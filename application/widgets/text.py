 
import cairo

import vector
from .widget import Widget

class Text(Widget):
    clickable = False
    mousable = False

    text = None
    
    def __init__(self, resource_manager, text):
        Widget.__init__(self, resource_manager)

        self.text = text
        
    def draw(self, cr, window, resource_manager):
        cr.save()
        cr.select_font_face("Arial", cairo.FONT_SLANT_NORMAL, cairo.FONT_WEIGHT_NORMAL)
        cr.set_font_size(13)
        cr.set_source_rgb(0, 1, 0)
        
        (x, y, width, height, dx, dy) = cr.text_extents(self.text)
        cr.move_to(self.position.x, self.position.y)    
        cr.show_text(self.text)
        cr.restore()