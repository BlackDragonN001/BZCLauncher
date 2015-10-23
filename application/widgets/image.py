import cairo

import vector
from .widget import Widget

class Image(Widget):
    clickable = False
    mousable = False
    
    image_resolution = None
    
    _image = None
    
    def __init__(self, resource_manager, image):
        Widget.__init__(self, resource_manager)

        self._image = resource_manager.load_image(image)
        self.image_resolution = vector.Resolution(self._image.get_width(), self._image.get_height())
        
    def draw(self, cr, window, resource_manager):
        cr.set_source_surface(self._image, self.position.x, self.position.y)
        cr.paint()