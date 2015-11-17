"""
    resourcemanager.py
    
    Source file implementing a basic resource management system in which images
    are loaded off disk and then cached in memory for later use.
    
    This software is licensed under the MIT license. Refer to LICENSE.txt for more
    information.
"""

import os
import os.path

import cairo

class ResourceManager(object):
    """
        The resource manager is a type in which various resources are loaded and cached
        into memory for later use elsewhere in the program. Currently, files are just
        cached by their file path which can cause problems on case insensitive file systems.
    """
    
    _loaded_resources = None
    
    def __init__(self):
        """
            Initializes a new resource manager object by initializing a new loaded resource
            dictionary.
        """
        self._loaded_resources = { }
        
    def load_image(self, filepath):
        """
            Returns a Cairo ImageSurface associated with the given filepath. If the filepath
            is in the cache, then only a lookup for the cached version is performed and the
            result is returned. If not, then the resource manager performs a full load of the
            image into memory and caches it for later use.
            
            Parameters: 
                filepath - The path to the file to load. This is also used as the cache key for cache 
                lookups which can cause problems on case insensitive file systems.
                
            Return:
                A Cairo ImageSurface representing the loaded image returned from either the cache in
                memory or a freshly loaded version from disk.
        """
        if (filepath not in self._loaded_resources.keys()):
            # Supported extension?
            filename, extension = os.path.splitext(filepath)  
            
            if (extension.lower() == ".png"):
                result = cairo.ImageSurface.create_from_png(filepath)
            else:
                raise NotImplementedError("Cannot load image '%s', unknown file type '%s'." % (filepath, extension))
            
            print("ResourceManager: Loaded '%s' off disk." % filepath)
                
            self._loaded_resources[filepath] = result
            return result
        
        return self._loaded_resources[filepath]
        