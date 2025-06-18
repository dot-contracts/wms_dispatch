from dataclasses import dataclass
from typing import Optional
from datetime import datetime

@dataclass
class Branch:
    """Data class representing a branch/destination zone"""
    name: str
    description: Optional[str] = None
    created_at: Optional[datetime] = None
    updated_at: Optional[datetime] = None
    
    def __str__(self):
        return self.name

@dataclass
class UserProfile:
    """Data class representing user profile information"""
    username: str
    email: Optional[str] = None
    first_name: Optional[str] = None
    last_name: Optional[str] = None
    branch_name: Optional[str] = None
    is_branch_manager: bool = False
    role: Optional[str] = None
    created_at: Optional[datetime] = None
    updated_at: Optional[datetime] = None
    
    def __str__(self):
        branch_name = self.branch_name if self.branch_name else "No Branch"
        role = "Branch Manager" if self.is_branch_manager else self.role or "Staff"
        return f"{self.username} - {branch_name} ({role})"
    
    def get_full_name(self):
        return f"{self.first_name} {self.last_name}".strip() if self.first_name or self.last_name else self.username
