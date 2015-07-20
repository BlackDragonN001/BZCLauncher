"""
"""

import os
import os.path

import cairo

class ResourceManager(object):
    _loaded_resources = None
    
    def __init__(self):
        self._loaded_resources = { }
        
    def load_image(self, filepath):
        if (filepath not in self._loaded_resources.keys()):
            # Supported extension?
            #filename, extension = os.path.splitext(filepath)
            
            result = cairo.ImageSurface.create_from_png(filepath)
            
            print("ResourceManager: Loaded '%s' off disk." % filepath)
            #if (extension.lower() == ".png"):
            #    cairo.ImageSurface.create_from_png(filepath)
            #else:
                
            self._loaded_resources[filepath] = result
            return result
        
        return self._loaded_resources[filepath]
        