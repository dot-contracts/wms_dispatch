from django import template
from django.utils.safestring import mark_safe
import qrcode
import base64
from io import BytesIO
import logging

logger = logging.getLogger(__name__)

register = template.Library()

@register.simple_tag
def qrcode_img(data, size=100):
    """
    Generate a QR code image from the given data and return as base64 encoded data URL.
    
    Usage: {% qrcode_img "some data" 150 %}
    """
    if not data:
        return ""
    
    try:
        # Create QR code
        qr = qrcode.QRCode(
            version=1,
            error_correction=qrcode.constants.ERROR_CORRECT_L,
            box_size=10,
            border=4,
        )
        qr.add_data(str(data))
        qr.make(fit=True)
        
        # Create image
        img = qr.make_image(fill_color="black", back_color="white")
        
        # Resize image if size is specified
        if size and size != 100:
            img = img.resize((size, size))
        
        # Convert to base64
        buffer = BytesIO()
        img.save(buffer, format='PNG')
        img_str = base64.b64encode(buffer.getvalue()).decode()
        
        # Return data URL
        return f'data:image/png;base64,{img_str}'
    
    except Exception as e:
        logger.error(f"Error generating QR code for data '{data}': {str(e)}")
        return ""

@register.simple_tag
def qrcode_img_tag(data, size=100):
    """
    Generate a QR code image from the given data and return as complete img tag.
    
    Usage: {% qrcode_img_tag "some data" 150 %}
    """
    if not data:
        logger.warning("QR code generation attempted with empty data")
        return mark_safe('<span class="text-muted">No data</span>')
    
    try:
        # Log the data being processed
        logger.debug(f"Generating QR code for data: '{data}' with size: {size}")
        
        # Create QR code
        qr = qrcode.QRCode(
            version=1,
            error_correction=qrcode.constants.ERROR_CORRECT_L,
            box_size=10,
            border=4,
        )
        qr.add_data(str(data))
        qr.make(fit=True)
        
        # Create image
        img = qr.make_image(fill_color="black", back_color="white")
        
        # Resize image if size is specified
        if size and size != 100:
            img = img.resize((size, size))
        
        # Convert to base64
        buffer = BytesIO()
        img.save(buffer, format='PNG')
        img_str = base64.b64encode(buffer.getvalue()).decode()
        
        # Return complete img tag
        return mark_safe(f'<img src="data:image/png;base64,{img_str}" alt="QR Code for {data}" style="width: {size}px; height: {size}px;">')
    
    except Exception as e:
        logger.error(f"Error generating QR code for data '{data}': {str(e)}")
        return mark_safe(f'<span class="text-danger">QR Code Error: {str(e)}</span>')

@register.simple_tag
def qrcode_svg(data, size=100):
    """
    Generate a QR code SVG from the given data using qrcode library.
    
    Usage: {% qrcode_svg "some data" 150 %}
    """
    if not data:
        return mark_safe('<span class="text-muted">No data</span>')
    
    try:
        # Create QR code
        qr = qrcode.QRCode(
            version=1,
            error_correction=qrcode.constants.ERROR_CORRECT_L,
            box_size=10,
            border=4,
        )
        qr.add_data(str(data))
        qr.make(fit=True)
        
        # Create image and convert to SVG-like format
        # Since qrcode doesn't have built-in SVG, we'll create a simple SVG representation
        img = qr.make_image(fill_color="black", back_color="white")
        
        # Convert to base64 for embedding
        buffer = BytesIO()
        img.save(buffer, format='PNG')
        img_str = base64.b64encode(buffer.getvalue()).decode()
        
        # Create SVG wrapper around the base64 image
        svg_content = f'''<svg width="{size}" height="{size}" xmlns="http://www.w3.org/2000/svg">
            <image href="data:image/png;base64,{img_str}" width="{size}" height="{size}"/>
        </svg>'''
        
        return mark_safe(svg_content)
    
    except Exception as e:
        logger.error(f"Error generating QR SVG for data '{data}': {str(e)}")
        return mark_safe(f'<span class="text-danger">QR SVG Error: {str(e)}</span>') 