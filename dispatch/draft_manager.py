"""
Shared Draft Manager for Multi-User Dispatch Drafts
Uses cache backend (Redis/Memcached) for shared state
"""
from django.core.cache import cache
from django.utils import timezone
from django.conf import settings
import json
import logging

logger = logging.getLogger(__name__)

class SharedDraftManager:
    """
    Manages shared dispatch drafts using Django's cache framework
    Supports multiple users accessing the same drafts
    """
    
    CACHE_PREFIX = "dispatch_draft"
    DEFAULT_TIMEOUT = 60 * 60 * 24  # 24 hours
    
    def __init__(self, branch_name=None):
        self.branch_name = branch_name
        
    def _get_cache_key(self, destination):
        """Generate cache key for a destination draft"""
        if self.branch_name:
            return f"{self.CACHE_PREFIX}:{self.branch_name}:{destination}"
        return f"{self.CACHE_PREFIX}:global:{destination}"
    
    def _get_lock_key(self, destination):
        """Generate lock key to prevent concurrent modifications"""
        return f"{self._get_cache_key(destination)}:lock"
    
    def get_all_drafts(self):
        """Get all active drafts for the current branch"""
        try:
            if self.branch_name:
                pattern = f"{self.CACHE_PREFIX}:{self.branch_name}:*"
            else:
                pattern = f"{self.CACHE_PREFIX}:global:*"
            
            # Note: This requires Redis backend for pattern matching
            # For other cache backends, we'd need to maintain a draft index
            drafts = {}
            
            # Get drafts index (fallback for non-Redis backends)
            index_key = f"{self.CACHE_PREFIX}:index:{self.branch_name or 'global'}"
            draft_destinations = cache.get(index_key, [])
            
            for destination in draft_destinations:
                draft_data = self.get_draft(destination)
                if draft_data:
                    drafts[destination] = draft_data
                    
            return drafts
        except Exception as e:
            logger.error(f"Error getting all drafts: {e}")
            return {}
    
    def get_draft(self, destination):
        """Get a specific draft by destination"""
        try:
            cache_key = self._get_cache_key(destination)
            draft_data = cache.get(cache_key)
            return draft_data
        except Exception as e:
            logger.error(f"Error getting draft for {destination}: {e}")
            return None
    
    def save_draft(self, destination, parcel_ids, vehicle_registration=None, 
                   driver_name=None, user=None):
        """Save or update a draft"""
        try:
            # Get lock to prevent race conditions
            lock_key = self._get_lock_key(destination)
            if cache.get(lock_key):
                return False, "Draft is being modified by another user. Please try again."
            
            # Set lock
            cache.set(lock_key, True, timeout=30)  # 30 second lock
            
            try:
                existing_draft = self.get_draft(destination)
                
                draft_data = {
                    'destination': destination,
                    'parcel_ids': list(set(parcel_ids)),  # Remove duplicates
                    'vehicle_registration': vehicle_registration,
                    'driver_name': driver_name,
                    'created_at': existing_draft.get('created_at') if existing_draft else timezone.now().isoformat(),
                    'created_by': existing_draft.get('created_by') if existing_draft else (user.username if user else 'unknown'),
                    'updated_at': timezone.now().isoformat(),
                    'updated_by': user.username if user else 'unknown',
                    'contributors': list(set((existing_draft.get('contributors', []) + [user.username]) if user else existing_draft.get('contributors', []))),
                }
                
                # Save draft
                cache_key = self._get_cache_key(destination)
                cache.set(cache_key, draft_data, timeout=self.DEFAULT_TIMEOUT)
                
                # Update drafts index
                self._update_drafts_index(destination, add=True)
                
                return True, f"Draft saved successfully. {len(draft_data['parcel_ids'])} parcels."
                
            finally:
                # Release lock
                cache.delete(lock_key)
                
        except Exception as e:
            logger.error(f"Error saving draft for {destination}: {e}")
            return False, f"Error saving draft: {e}"
    
    def clear_draft(self, destination, user=None):
        """Clear a specific draft"""
        try:
            cache_key = self._get_cache_key(destination)
            cache.delete(cache_key)
            
            # Update drafts index
            self._update_drafts_index(destination, add=False)
            
            return True, f"Draft for {destination} cleared successfully."
        except Exception as e:
            logger.error(f"Error clearing draft for {destination}: {e}")
            return False, f"Error clearing draft: {e}"
    
    def clear_all_drafts(self, user=None):
        """Clear all drafts for the current branch"""
        try:
            drafts = self.get_all_drafts()
            for destination in drafts.keys():
                self.clear_draft(destination, user)
            return True, f"All {len(drafts)} drafts cleared successfully."
        except Exception as e:
            logger.error(f"Error clearing all drafts: {e}")
            return False, f"Error clearing all drafts: {e}"
    
    def _update_drafts_index(self, destination, add=True):
        """Maintain an index of active drafts"""
        try:
            index_key = f"{self.CACHE_PREFIX}:index:{self.branch_name or 'global'}"
            destinations = cache.get(index_key, [])
            
            if add and destination not in destinations:
                destinations.append(destination)
            elif not add and destination in destinations:
                destinations.remove(destination)
            
            cache.set(index_key, destinations, timeout=self.DEFAULT_TIMEOUT)
        except Exception as e:
            logger.error(f"Error updating drafts index: {e}")
    
    def get_parcel_draft_info(self, parcel_ids):
        """Get which drafts contain specific parcels"""
        parcel_info = {}
        drafts = self.get_all_drafts()
        
        for parcel_id in parcel_ids:
            parcel_info[parcel_id] = {
                'is_in_draft': False,
                'draft_destination': None,
                'draft_contributors': []
            }
            
            for destination, draft_data in drafts.items():
                if parcel_id in draft_data.get('parcel_ids', []):
                    parcel_info[parcel_id] = {
                        'is_in_draft': True,
                        'draft_destination': destination,
                        'draft_contributors': draft_data.get('contributors', [])
                    }
                    break
        
        return parcel_info

# Utility function to get draft manager instance
def get_draft_manager(user=None):
    """Get a draft manager instance for the user's branch"""
    branch_name = None
    if user and hasattr(user, 'branch') and user.branch:
        branch_name = user.branch.get('name')
    return SharedDraftManager(branch_name=branch_name) 