"""
    main.py
    
    Main source file for the BattleZone: Classic launcher.
    
    This software is licensed under the MIT license. Refer to LICENSE.txt for more
    information.
"""

import sys
from math import pi

import pygtk
pygtk.require('2.0')
import gtk, cairo

import gobject
import pango
from gtk import gdk

import widgets
import content
import vector
import resourcemanager
        
class Application(gtk.Window):
    """
        Main class of the BattleZone: Classic launcher. This class is what creates
        the main window and sets up all window events with PyGTK.
    """
    _content = None
    _cr = None
    background = None
    
    _interfaces = None
    
    area = None
    
    resource_manager = None
    
    def __init__(self):
        super(gtk.Window, self).__init__()
        
        self.set_resizable(False)
        # Ensure that we can draw into the window directly
        self.set_app_paintable(True)
        # Ensure that our window will be of the correct resolution
        self.set_size_request(640, 480)
        self.set_title("BattleZone: Classic Launcher")
        
        # Bind all relevant events
        self.connect("delete-event", gtk.main_quit)
        self.connect("expose-event", Application.do_expose_event)
        self.connect("button-press-event", Application.do_button_press)
        self.connect("button-release-event", Application.do_button_release)
        self.connect("motion-notify-event", Application.do_motion_event)
        
        # Notify GTK that we want to listen for these mouse events
        self.set_events(gtk.gdk.BUTTON_PRESS_MASK | gtk.gdk.BUTTON_RELEASE_MASK | gtk.gdk.POINTER_MOTION_MASK)
        
        # Attempt to set an RGBA color map
        rgba = self.get_screen().get_rgba_colormap()        
        if (rgba is not None):
            self.set_colormap(rgba)
        else:
            print("Warning: Unable to acquire an RGBA color map for the window. Graphical output may be incorrect.")
            
        # And finally instantiate our resource manager
        self.resource_manager = resourcemanager.ResourceManager()
        self._interfaces = { }
    
    def set_interface(self, name):
        name = name.lower()
        
        if (name not in self._interfaces.keys()):
            print("Warning: Unknown interface '%s'!" % name)
            return
        
        self._content = self._interfaces[name]
        # Force a redraw
        self.queue_draw()
        
    def register_interface(self, interface, name):
        name = name.lower()
        
        if (name in self._interfaces.keys()):
            print("Warning: Rewrote interface '%s'!" % name)
            
        self._interfaces[name] = interface
            
    def main(self):
        """
            This main method is called after the Application class has been wholly constructed.
        """
        
        # Register the interface types with the window
        main = content.Main(self.resource_manager)
        self.register_interface(main, "main")
        settings = content.Settings(self.resource_manager)
        self.register_interface(settings, "settings")
        
        self._content = main
        self.show_all()
        gtk.main()
        
    #def set_content(self, content):        
    #    self._content = content
    
    def do_expose_event(self, event):
        if (self._content is not None):
            self._content.draw(self, self.resource_manager, self.window.cairo_create())
    
    def do_button_release(self, event):
        self.queue_draw()
        self._content.on_mouse_release(self, self.resource_manager, vector.Position(event.x, event.y))
        
    def do_button_press(self, event):
        self.queue_draw()
        self._content.on_mouse_click(self, self.resource_manager, vector.Position(event.x, event.y))
        
    def do_motion_event(self, event):
        self.queue_draw()
        self._content.on_mouse_move(self, self.resource_manager, vector.Position(event.x, event.y))

if __name__ == '__main__':
    Application().main()
