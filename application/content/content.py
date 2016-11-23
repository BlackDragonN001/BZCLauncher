"""
    content.py
    
    This software is licensed under the MIT license. Refer to LICENSE.txt for more
    information.
"""

class Content(object):
    """
        Base type representing a GUI interface.
    """
    _content = None
    _mousable_content = None
    _clickable_content = None
    
    _background = None
    
    def __init__(self, resource_manager):  
        self._content = [ ]
        self._mousable_content = [ ]
        self._clickable_content = [ ]
        
    def add(self, element):
        if (element not in self._content):
            self._content.append(element)
            
            if (element.clickable is True):
                self._clickable_content.append(element)
            if (element.mousable is True):
                self._mousable_content.append(element)
            
    def remove(self, element):
        self.remove(element)
        
    def draw(self, window, resource_manager, cr):
        """
            Draws the content to the window.
            
            Parameters:
                window - The PyGTK window we are using.
                resource_manager - The resource manager object in use by the
                rest of the program.
        """
        cr.set_source_surface(self._background, 0, 0)
        cr.paint()
        
        # Roll through and draw the sub-elements atop
        for element in self._content:
            if (element.visible):
                element.draw(cr, window, resource_manager)
            
    def on_mouse_release(self, window, resource_manager, location):
        for element in self._clickable_content:
            element.on_mouse_release(window, resource_manager, location)
            
    def on_mouse_click(self, window, resource_manager, location):
        for element in self._clickable_content:
            element.on_mouse_click(window, resource_manager, location)
        
    def on_mouse_move(self, window, resource_manager, location):
        for element in self._mousable_content:
            element.on_mouse_move(window, resource_manager, location)
        