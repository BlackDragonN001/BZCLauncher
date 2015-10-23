"""
    vector.py
    
    Python file implementing vector operations and aliases for various 2D vector types.
    
    This software is licensed under the MIT license. Refer to LICENSE.txt for more
    information.
"""

import math

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
    
    def __mul__(self, rhs):
        return Vector(self.x * rhs.x, self.y * rhs.y)
    
    def __div__(self, rhs):
        return Vector(self.x / rhs.x, self.y / rhs.y)
    
    def __lt__(self, other):
        return self.x < other.x and self.y < other.y
    
    def __le__(self, other):
        return self.x <= other.x and self.y <= other.y
    
    def __eq__(self, other):
        return self.x == other.x and self.y == other.y
    
    def __ne__(self, other):
        return not self.__eq__(other)
    
    def __gt__(self, other):
        return self.x > other.x and self.y > other.y
    
    def __ge__(self, other):
        return self.x >= other.x and self.y >= other.y 
    
    def magnitude(self):
        return math.sqrt(pow(self.x, 2) + pow(self.y, 2))
    
    def __nonzero__(self):
        return self.x != 0 and self.y != 0
    
    length = magnitude

Position = Vector
Scale = Vector
Resolution = Vector
Size = Vector