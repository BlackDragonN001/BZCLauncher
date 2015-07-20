"""
    vector.py
    
    Python file implementing vector operations and aliases for various 2D vector types.
    
    This software is licensed under the MIT license. Refer to LICENSE.txt for more
    information.
"""

class Vector(object):
    """
        Base 2D vector type. 
    """
    
    x = 0
    y = 0
    
    def __init__(self, x = 0, y = 0):
        self.x = x
        self.y = y
        
    def __add__(self, rhs):
        return Vector(self.x + rhs.x, self.y + rhs.y)
    
    def __sub__(self, rhs):
        return Vector(self.x - rhs.x, self.y - rhs.y)
    
    def __mult__(self, rhs):
        return Vector(self.x * rhs.x, self.y * rhs.y)
    
    def __div__(self, rhs):
        return Vector(self.x / rhs.x, self.y / rhs.y)

class Position(Vector):
    pass

class Scale(Vector):
    pass

class Resolution(Vector):
    pass

class Size(Vector):
    pass
