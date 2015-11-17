"""
    vector.py
    
    Python file implementing vector operations and aliases for various 2D vector types.
    
    This software is licensed under the MIT license. Refer to LICENSE.txt for more
    information.
"""

import math

class Vector(object):
    """
        Basic 2D vector type. 
        
        Attributes:
            x - The x component of the vector.
            y - The y component of the vector.
    """
    
    x = 0
    y = 0
    
    def __init__(self, x = 0, y = 0):
        """
            Initializes a new vector given the x and y coordinates.
            
            Parameters:
            x - The x component of the new vector.
            y - The y component of the new vector.
        """
        self.x = x
        self.y = y
        
    def __add__(self, rhs):
        """
            Operator overload for addition.
            
            Param rhs:
                
        """
        if (type(rhs) is Vector): 
            return Vector(self.x + rhs.x, self.y + rhs.y)
        raise TypeError("Cannot add non-Vector types to vectors!")
    
    def __sub__(self, rhs):
        if (type(rhs) is Vector):
            return Vector(self.x - rhs.x, self.y - rhs.y)
        raise TypeError("Cannot subtract non-Vector types from vectors!")
    
    def __mul__(self, rhs):
        if (type(rhs) is Vector):
            return Vector(self.x * rhs.x, self.y * rhs.y)
        raise TypeError("Cannot multiply non-Vector types against Vectors!")
    
    def __div__(self, rhs):
        if (type(rhs) is Vector):
            return Vector(self.x / rhs.x, self.y / rhs.y)
        raise TypeError("Cannot divide Vectors by non-Vector types!")
    
    def __lt__(self, other):
        if (type(rhs) is Vector):
            return self.x < rhs.x and self.y < rhs.y
        raise TypeError("Cannot compare Vector types against non-Vector types!")
    
    def __le__(self, rhs):
        if (type(rhs) is Vector):
            return self.x <= rhs.x and self.y <= rhs.y
        raise TypeError("Cannot compare Vector types against non-Vector types!")
    
    def __eq__(self, rhs):
        if (type(rhs) is Vector):
            return self.x == rhs.x and self.y == rhs.y
        raise TypeError("Cannot compare Vector types against non-Vector types!")
    
    def __ne__(self, rhs):
        if (type(rhs) is Vector):
            return not self.__eq__(rhs)
        raise TypeError("Cannot compare Vector types against non-Vector types!")
    
    def __gt__(self, rhs):
        if (type(rhs) is Vector):
            return self.x > rhs.x and self.y > rhs.y
        raise TypeError("Cannot compare Vector types against non-Vector types!")
    
    def __ge__(self, rhs):
        if (type(rhs) is Vector):
            return self.x >= rhs.x and self.y >= rhs.y 
        raise TypeError("Cannot compare Vector types against non-Vector types!")
    
    def magnitude(self):
        return math.sqrt(pow(self.x, 2) + pow(self.y, 2))
    
    def __nonzero__(self):
        return self.x != 0 and self.y != 0
    
    length = magnitude

Position = Vector
Scale = Vector
Resolution = Vector
Size = Vector