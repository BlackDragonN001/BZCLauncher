 
import cairo

import vector
from .element import Element

class Text(Element):
    clickable = False
    mousable = False

    text = None
    
    def __init__(self, resource_manager, text):
        Element.__init__(self, resource_manager)

        self.text = text
        
    def draw(self, cr, window, resource_manager):
        # Draw the text
        cr.save()
        cr.select_font_face("Arial", cairo.FONT_SLANT_NORMAL, cairo.FONT_WEIGHT_NORMAL)
        cr.set_font_size(13)
        cr.set_source_rgb(0, 1, 0)
        
        (x, y, width, height, dx, dy) = cr.text_extents(self.text)
        cr.move_to(self.position.x, self.position.y)    
        cr.show_text(self.text)
        cr.restore()