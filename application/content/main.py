import os
import platform

import cairo
import gtk

import widgets
from .content import Content
from .settings import Settings
import vector

class Main(Content):
    def __init__(self, resource_manager):
        Content.__init__(self, resource_manager)
        
        # Add the BZC Tag
        tag = widgets.Image(resource_manager, "res/bzctag.png")
        tag.position.x = 250
        self.add(tag)
        
        # Create the exit button
        exitButton = widgets.Button(resource_manager, "EXIT", "res/TLbtnoff.png", "res/TLbtnon.png", "res/TLbtnclk.png")
        exitButton.responder = gtk.main_quit
        exitButton.text_offset = vector.Vector(80, 20)
        self.add(exitButton)
        
         # Create the launch button
        launchButton = widgets.Button(resource_manager, "LAUNCH", "res/TRbtnoff.png", "res/TRbtnon.png", "res/TRbtnclk.png")
        launchButton.position.x = 489
        launchButton.responder = self.launch_pressed
        launchButton.text_offset = vector.Vector(40, 20)
        self.add(launchButton)
        
        # Create the settings button
        settingsButton = widgets.Button(resource_manager, "SETTINGS", "res/BLbtnoff.png", "res/BLbtnon.png", "res/BLbtnclk.png")
        settingsButton.position.y = 445
        settingsButton.text_offset = vector.Vector(60, 23)
        settingsButton.responder = self.settings_pressed
        self.add(settingsButton)
        
        # Create the news window
        newsWindow = widgets.Window(resource_manager)
        newsWindow.position.y = 50
        newsWindow.position.x = 40
        newsWindow.scale = vector.Scale(1.5,1)
        self.add(newsWindow)
        
        # Create the title for the news text
        newsText = widgets.Text(resource_manager, "News")
        #newsWindow.relative_reposition(newsText)
        newsText.position = vector.Position(255, 16)
        newsWindow.relative_reposition(newsText)
        self.add(newsText)
                  
        # Create the text block for the news
        self.newsBlock = widgets.TextBlock(resource_manager, "There is currently no news information to display at this time.\nSorry for the inconvenience!")
        self.newsBlock.position = vector.Position(27, 40)
        self.newsBlock.maximum_lines = 20
        self.newsBlock.maximum_width = 674
        newsWindow.relative_reposition(self.newsBlock)
        self.add(self.newsBlock)
        
        # Load a test image
        self._background = resource_manager.load_image("res/bzclbackground.png")
    
    def settings_pressed(self, window, resource_manager):
        window.set_interface("settings")
        
    def launch_pressed(self, window, resource_manager):
        # Make our launcher window invisible for the launch period
        window.set_visible(False)
        
        if ("Linux" in platform.system()):
            (stdin, stdout) = os.popen2("wine bzone.exe", "rw", 100)
        else:
            (stdin, stdout) = os.popen2("bzone.exe", "rw", 100)
            
        