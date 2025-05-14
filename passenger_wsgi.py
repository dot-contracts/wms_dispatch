import os
import sys

# Set the project path
# Assumes this passenger_wsgi.py is in the project root (e.g., /home/user/wms/)
# and your Django project directory (containing settings.py) is ficma_dispatch
project_path = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, project_path)

# Set the DJANGO_SETTINGS_MODULE environment variable
# Replace 'ficma_dispatch.settings' with your actual settings file path
os.environ['DJANGO_SETTINGS_MODULE'] = 'ficma_dispatch.settings'

# Import the WSGI application from your Django project
# This should match your "Application Entry point" but as an import
from ficma_dispatch.wsgi import application

# If you are serving static files through a different mechanism in production (e.g. Apache/Nginx directly)
# and your wsgi.py already handles Cling for development, you might not need Cling here.
# However, some setups benefit from explicitly using WhiteNoise for static files in production via passenger_wsgi.py
# To use WhiteNoise (ensure it's in your requirements.txt):
# from whitenoise import WhiteNoise
# application = WhiteNoise(application) 