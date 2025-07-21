from django import template
from django.utils.safestring import mark_safe
import qrcode
import base64
from io import BytesIO

register = template.Library()

@register.simple_tag
def qrcode_img(data, size=100):
    """
    Generate a QR code image from the given data and return as base64 encoded img tag.
    
    Usage: {% qrcode_img "some data" 150 %}
    """
    if not data:
        return mark_safe('<span class="text-muted">No data</span>')
    
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
    
    # Return img tag
    return mark_safe(f'<img src="data:image/png;base64,{img_str}" alt="QR Code for {data}" style="width: {size}px; height: {size}px;">')

@register.simple_tag
def qrcode_svg(data, size=100):
    """
    Generate a QR code SVG from the given data.
    
    Usage: {% qrcode_svg "some data" 150 %}
    """
    if not data:
        return mark_safe('<span class="text-muted">No data</span>')
    
    # Create QR code
    qr = qrcode.QRCode(
        version=1,
        error_correction=qrcode.constants.ERROR_CORRECT_L,
        box_size=10,
        border=4,
    )
    qr.add_data(str(data))
    qr.make(fit=True)
    
    # Create SVG
    svg = qr.make_svg(fill_color="black", back_color="white")
    
    # Set size if specified
    if size and size != 100:
        svg = svg.replace('<svg', f'<svg width="{size}" height="{size}"')
    
    return mark_safe(svg) 