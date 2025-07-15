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
    Example: MBS-20250715-DS5TX8
    """
    # Get destination initials (first 3 letters, uppercase)
    dest_code = destination[:3].upper() if destination else "N/A"
    
    # Get current date in EAT
    eat_time = get_eat_time()
    date_str = eat_time.strftime('%Y%m%d')
    
    # Generate random 5-character alphanumeric string
    random_chars = ''.join(random.choices(string.ascii_uppercase + string.digits, k=5))
    
    return f"{dest_code}-{date_str}-DS{random_chars}" 