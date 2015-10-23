import cairo

import vector
import math
from .widget import Widget

class TextBlock(Widget):
    clickable = False
    mousable = False

    text = None
    maximum_lines = None
    maximum_width = None
    
    _text_data = None
    
    def __init__(self, resource_manager, text):
        Widget.__init__(self, resource_manager)

        self.text = text
        self.maximum_lines = 2
        self.maximum_width = 800
        self._text_data = [ ]

        for split in text.split("\n"):
            self._text_data.append(split)
        
    def draw(self, cr, window, resource_manager):
        cr.save()
        cr.select_font_face("Arial", cairo.FONT_SLANT_NORMAL, cairo.FONT_WEIGHT_NORMAL)
        cr.set_font_size(13)
        cr.set_source_rgb(0, 1, 0)
        
        for line_number in range(self.maximum_lines):
            if line_number < len(self._text_data):
                line = self._text_data[line_number]
                (x, y, width, height, dx, dy) = cr.text_extents(self.text)
                cr.move_to(self.position.x, self.position.y + (line_number * (height + 7)))    
                cr.show_text(line)

        cr.restore()