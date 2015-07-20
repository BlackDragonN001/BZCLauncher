"""
    rectangle.py
    
    Python file implementing a rectangle type for representing bounds.
    
    This software is licensed under the MIT license. Refer to LICENSE.txt for more
    information.
"""

import vector

class Rectangle(object):
    upper = None
    lower = None
    size = None
    
    def __init__(self, upper = vector.Position(), size = vector.Size())
        self.upper = upper
        self.size = size
        self.lower = self.upper + self.size