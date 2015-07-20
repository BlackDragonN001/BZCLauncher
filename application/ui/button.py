import cairo

import vector
from .element import Element

class Button(Element):
    _on_image = None
    _off_image = None
    _clicked_image = None
    
    _clicked = False
    _moused = False
    
    clickable = True
    mousable = True
    text = None
    responder = None
    
    text_offset = None
    
    def __init__(self, resource_manager, text, off, on, clicked):
        Element.__init__(self, resource_manager)
        
        self._on_image = resource_manager.load_image(on)
        self.image_resolution = vector.Resolution(self._on_image.get_width(), self._on_image.get_height())
        
        self._off_image = resource_manager.load_image(off)
        self._clicked_image = resource_manager.load_image(clicked)
        self.text = text
        self.text_offset = vector.Vector(0, 0)
    
    def location_in_bounds(self, location):
        if (location.x >= self.position.x and location.y >= self.position.y and location.x <= self.position.x + self.image_resolution.x and location.y <= self.position.y + self.image_resolution.y):
            return True
        return False
    
    def draw(self, cr, window, resource_manager):
        image = self._off_image
        if (self._moused is True):
            image = self._on_image
        if (self._clicked is True):
            image = self._clicked_image
        
        # Draw the image first
        cr.set_source_surface(image, self.position.x, self.position.y)
        cr.paint()
        
        cr.set_source_rgb(0, 1, 0)
        
        # Draw the text
        cr.select_font_face("Arial", cairo.FONT_SLANT_NORMAL, cairo.FONT_WEIGHT_NORMAL)
        cr.set_font_size(13)
        
        (x, y, width, height, dx, dy) = cr.text_extents(self.text)

        cr.move_to(self.position.x + self.text_offset.x, self.position.y + self.text_offset.y)   
        cr.show_text(self.text)
        
    def on_mouse_click(self, window, resource_manager, location):
        if (self.location_in_bounds(location)):
            self._clicked = True
    
    def on_mouse_release(self, window, resource_manager, location):
        self._clicked = False
        
        if (self.location_in_bounds(location) and self.responder is not None):
            self.responder(window, resource_manager)

    def on_mouse_move(self, window, resource_manager, location):
        if (self.location_in_bounds(location)):
            self._moused = True
            return
        
        self._moused = False
    
    # Called when mouse down and mouse up occur atop the button
    def on_clicked(self, window, resource_manager):
        pass 
