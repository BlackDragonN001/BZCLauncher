import vector

class Element(object):
    position = None
    scale = None
    
    clickable = False
    mousable = False
    
    def __init__(self, resource_manager):
        self.position = vector.Position()
        self.scale = vector.Scale(1, 1)