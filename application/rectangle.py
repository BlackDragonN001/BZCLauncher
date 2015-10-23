"""
    rectangle.py
    
    Python file implementing a rectangle type for representing bounds.
    
    This software is licensed under the MIT license. Refer to LICENSE.txt for more
    information.
"""

import vector

class Rectangle(object):
    """
        A rectangle represents a given rectangular area specified by a pair of coordinates labeled
        upper (left corner) and lower (right corner) respectively.
    """
    
    upper = None
    lower = None
    size = None
    
    def __init__(self, upper = vector.Position(), size = vector.Size()):
        self.upper = upper
        self.size = size
        self.lower = self.upper + self.size
    
    def contains_point(self, other):
        return other >= self.upper and other <= self.lower
    
    def intersects(self, other):
        return self.contains_point(other.upper) or self.contains_point(other.lower)