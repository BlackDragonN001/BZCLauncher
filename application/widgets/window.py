 
import cairo

import vector
from .widget import Widget

class Window(Widget):
    clickable = False
    mousable = False
    scale = None
    image_resolution = None
    
    _image = None
    
    def __init__(self, resource_manager):
        Widget.__init__(self, resource_manager)

        self._image = resource_manager.load_image("res/bigwindow1.png")
        self.image_resolution = vector.Resolution(self._image.get_width(), self._image.get_height())
        
        self.scale = vector.Scale(1, 1)
        
    def draw(self, cr, window, resource_manager):
        # Draw the image
        cr.save()
        cr.scale(self.scale.x, self.scale.y)
        cr.set_source_surface(self._image, self.position.x, self.position.y)
        cr.paint()
        cr.restore()
        
    def relative_reposition(self, element):
        element.position = self.position + element.position