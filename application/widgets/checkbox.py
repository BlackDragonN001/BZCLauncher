 
import cairo

import vector
import rectangle
from .widget import Widget

class CheckBox(Widget):
    _on_image = None
    _off_image = None
    _clicked_image = None
    _disabled_image = None
    _clicked = False
    _moused = False
    
    clickable = True
    mousable = True
    text = None
    toggled_responder = None
    
    is_toggled = None
    is_disabled = None
    
    def __init__(self, resource_manager, text, toggled):
        Widget.__init__(self, resource_manager)
        
        self._on_image = resource_manager.load_image("res/bzcoptionbuttonon.png")
        self.image_resolution = vector.Resolution(self._on_image.get_width(), self._on_image.get_height())
        
        self._off_image = resource_manager.load_image("res/bzcoptionbuttonoff.png")
        self._clicked_image = resource_manager.load_image("res/bzcoptionbuttonclk.png")
        self._disabled_image = resource_manager.load_image("res/bzcoptionbuttondis.png")
        self.text = text
        
        self.toggled_responder = toggled
        self.is_toggled = False
        self.is_disabled = False
    
    def get_dimensions(self):
        return vector.Vector(self._off_image.get_width(), self._off_image.get_height())
    
    def get_rectangle(self):
        return rectangle.Rectangle(self.position, self.get_dimensions())
    
    def draw(self, cr, window, resource_manager):
        image = self._off_image
        if (not self.is_disabled and self._moused is True):
            image = self._on_image
        if (self.is_toggled is True):
            image = self._clicked_image
        
        cr.save()
        cr.set_source_surface(self._disabled_image, self.position.x, self.position.y)
        cr.paint()
            
        # Draw the image first
        if (not self.is_disabled):
            cr.set_source_surface(image, self.position.x + 12, self.position.y)
            cr.paint()
        
        cr.set_source_rgb(0, 1, 0)
        
        # Draw the text
        cr.select_font_face("Arial", cairo.FONT_SLANT_NORMAL, cairo.FONT_WEIGHT_NORMAL)
        cr.set_font_size(13)
        
        (x, y, width, height, dx, dy) = cr.text_extents(self.text)
        cr.move_to(self.position.x + self.image_resolution.x + 25, self.position.y + (self.image_resolution.y / 2) + (height/ 2))    
        cr.show_text(self.text)
        cr.restore()
    
    def on_mouse_click(self, window, resource_manager, location):
        rect = self.get_rectangle()
        if (not self.is_disabled and rect.contains_point(location)):
            self._clicked = True
    
    def on_mouse_release(self, window, resource_manager, location):
        rect = self.get_rectangle()
        if (not self.is_disabled and rect.contains_point(location)): 
            self._clicked = False
            self.is_toggled = not self.is_toggled
            
            if (self.toggled_responder is not None):
                self.toggled_responder(self, window, resource_manager, self.is_toggled)

    def on_mouse_move(self, window, resource_manager, location):
        rect = self.get_rectangle()
        
        if (rect.contains_point(location)):
            self._moused = True
            return
        
        self._moused = False
