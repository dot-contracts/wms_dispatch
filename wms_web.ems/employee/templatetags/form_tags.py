from django import template
from django.utils.safestring import SafeString

register = template.Library()

@register.filter(name='add_class')
def add_class(value, css_class):
    """Add CSS class to a form field."""
    if hasattr(value, 'as_widget'):
        # This is a form field
        return value.as_widget(attrs={"class": css_class})
    elif isinstance(value, SafeString) or isinstance(value, str):
        # Already rendered HTML or string
        # We need to be careful not to break existing HTML
        return value
    return value 