import random
import string
from datetime import datetime
import pytz

def get_eat_time():
    """Returns the current time in EAT (UTC+3)."""
    return datetime.now(pytz.timezone('Africa/Nairobi'))

def generate_dispatch_code(destination):
    """
    Generates a dispatch code based on destination, date, and a random string.
    Format: [DEST_CODE]-[YYYYMMDD]-DS[5_ALPHANUM]
    Example: MBS-20250715-DS51TX8
    """
    # Mapping of destinations to their proper initials - only the destinations available in the system
    destination_initials = {
        'eldoret': 'ELD',
        'kakamega': 'KKG',
        'kapsabet': 'KPS',
        'kericho': 'KRC',
        'kisumu': 'KSM',
        'kitale': 'KTL',
        'mombasa': 'MBS',
        'nairobi': 'NBO',
        'nakuru': 'NKR'
    }
    
    # Get destination code from mapping, fallback to first 3 letters if not found
    dest_lower = destination.lower().strip() if destination else ""
    dest_code = destination_initials.get(dest_lower, destination[:3].upper() if destination else "UNK")
    
    # Get current date in EAT
    eat_time = get_eat_time()
    date_str = eat_time.strftime('%Y%m%d')
    
    # Generate random 5-character alphanumeric string (letters and numbers)
    random_chars = ''.join(random.choices(string.ascii_uppercase + string.digits, k=5))
    
    return f"{dest_code}-{date_str}-DS{random_chars}" 