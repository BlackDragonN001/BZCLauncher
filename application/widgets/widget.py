import vector
import rectangle
import exceptions

class Widget(object):
    """
        Every item rendered on screen is a widget and therefore must derive from this class for the
        most basic of GUI functionality.
        
        Attributes:
            tag - A generic value that can be anything whose primary purpose is unique identification
            of GUI elements.
    """
    position = None
    scale = None
    
    clickable = False
    mousable = False
    visible = True
    
    tag = None
    
    def __init__(self, resource_manager):
        self.position = vector.Position()
        self.scale = vector.Scale(1, 1)
        
    def get_dimensions(self):
        raise exceptions.NotImplementedException("Not implememented.")
    
    def get_rectangle(self):
        raise exceptions.NotImplementedException("Not implememented.")