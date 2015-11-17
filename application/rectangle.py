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
        
        Attributes:
            upper - The top left hand corner of this rectangle object.
            lower - The bottom right hand corner of this rectangle object.
            size - The total size of this rectangle object.
    """
    
    upper = None
    lower = None
    size = None
    
    def __init__(self, upper = vector.Position(), size = vector.Size()):
        """
            Initializes a new Rectangle object given the upper left hand corner and the size of it.
            
            Parameters:
                upper - A vector representing the top left hand corner of the rectangle.
                size - A vector representing the total size of the rectangle.
        """
        self.upper = upper
        self.size = size
        self.lower = self.upper + self.size
    
    def contains_point(self, other):
        """
            Returns whether or not this rectangle contains the given point.
            
            Parameters:
                other - The point to test.
                
            Return:
                A boolean representing whether or not the given point appears to be
                contained within this rectangle object.
        """
        return other >= self.upper and other <= self.lower
    
    def intersects(self, other):
        """
            Returns whether or not this rectangle intersects with the given rectangle.
            
            Parameters:
                other - The rectangle to test.
                
            Return:
                A boolean representing whether or not the given rectangle appears to intersects
                this rectangle object.
        """
        return self.contains_point(other.upper) or self.contains_point(other.lower)