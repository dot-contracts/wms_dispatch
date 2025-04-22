import qrcode
import base64
import io
from django import template

register = template.Library()

@register.simple_tag
def qrcode_img(text, size=100):
    """
    Generate a QR code as a data URI
    
    Usage: {% qrcode_img parcel.qr_code 100 %}
    """
    if not text:
        return ''
        
    # Generate QR code
    qr = qrcode.QRCode(
        version=1,
        error_correction=qrcode.constants.ERROR_CORRECT_M,
        box_size=6,
        border=2,
    )
    qr.add_data(text)
    qr.make(fit=True)
    
    # Create an image from the QR code
    img = qr.make_image(fill_color="black", back_color="white")
    
    # Save the image to a bytes buffer
    buffer = io.BytesIO()
    img.save(buffer, format="PNG")
    img_str = base64.b64encode(buffer.getvalue()).decode()
    
    # Return as a data URI
    return f"data:image/png;base64,{img_str}" 