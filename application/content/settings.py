import os
import platform

import cairo
import gtk

import vector
import ui
from .content import Content

class Settings(Content):
    def __init__(self, resource_manager):
        Content.__init__(self, resource_manager)
        
        # Add the BZC Tag
        tag = ui.Image(resource_manager, "res/bzctag.png")
        tag.position.x = 250
        self.add(tag)
        
        # Back Button
        back_button = ui.Button(resource_manager, "BACK", "res/BLbtnoff.png", "res/BLbtnon.png", "res/BLbtnclk.png")
        back_button.position.y = 445
        back_button.text_offset = vector.Vector(75, 23)
        back_button.responder = self.back_button_pressed
        self.add(back_button)
        
        # Create the exit button
        exit_button = ui.Button(resource_manager, "EXIT", "res/TLbtnoff.png", "res/TLbtnon.png", "res/TLbtnclk.png")
        exit_button.responder = gtk.main_quit
        exit_button.text_offset = vector.Vector(80, 20)
        self.add(exit_button)
        
         # Create the launch button
        launch_button = ui.Button(resource_manager, "LAUNCH", "res/TRbtnoff.png", "res/TRbtnon.png", "res/TRbtnclk.png")
        launch_button.position.x = 489
        launch_button.responder = self.launch_pressed
        launch_button.text_offset = vector.Vector(40, 20)
        self.add(launch_button)
        
        # Create the config window 
        config_window = ui.Window(resource_manager)
        config_window.position.y = 50
        config_window.position.x = 40
        config_window.scale = vector.Scale(1.5,1)
        self.add(config_window)
        
        # Create the title for the news text
        config_text = ui.Text(resource_manager, "Config")
        config_text.position = vector.Position(255, 16)
        config_window.relative_reposition(config_text)
        self.add(config_text)
        
        # Create directory text
        directory_text = ui.TextBlock(resource_manager, "BattleZone II directory, this must point to an install of BattleZone II v1.3 Public Beta 6.5\nor Higher.")
        directory_text.position = vector.Position(30, 40)
        config_window.relative_reposition(directory_text)
        self.add(directory_text)
        
        # Command Line Options Text
        options_text = ui.TextBlock(resource_manager, "There are several command line options. You may type any command line arguments\ninto the field, and/or simply select the ones you want to use.\nCmnd line args:")
        options_text.maximum_lines = 3
        options_text.position = vector.Position(30, 120)
        config_window.relative_reposition(options_text)
        self.add(options_text)
        
        # Editor Check
        self.editor_check = ui.CheckBox(resource_manager,"Editor (Multiplayer Disabled)", self.editor_toggled)
        self.editor_check.position = vector.Position(300, 150)
        config_window.relative_reposition(self.editor_check)
        self.add(self.editor_check)
        
        # Windowed Mode
        self.windowed_check = ui.CheckBox(resource_manager, "Windowed Mode", self.windowed_mode_toggled)
        self.windowed_check.position = vector.Position(30, 175)
        config_window.relative_reposition(self.windowed_check)
        self.add(self.windowed_check)
        
        # Nobody Home
        self.nobody_home_check = ui.CheckBox(resource_manager, "Nobody Home (Blank BZN)", self.nobody_home_toggled)
        self.nobody_home_check.position = vector.Position(300, 175)
        config_window.relative_reposition(self.nobody_home_check)
        self.add(self.nobody_home_check)
        
        # Skip Intro
        self.skip_intro_check = ui.CheckBox(resource_manager, "Skip Intro Movie", self.skip_intro_toggled)
        self.skip_intro_check.position = vector.Position(30, 200)
        config_window.relative_reposition(self.skip_intro_check)
        self.add(self.skip_intro_check)
        
        # No Script
        self.no_script_check = ui.CheckBox(resource_manager, "No Script", self.no_script_toggled)
        self.no_script_check.position = vector.Position(300, 200)
        config_window.relative_reposition(self.no_script_check)
        self.add(self.no_script_check)
        
        # Power User Mode
        self.power_user_check = ui.CheckBox(resource_manager, "Power User Mode", self.power_user_toggled)
        self.power_user_check.position = vector.Position(30, 225)
        config_window.relative_reposition(self.power_user_check)
        self.add(self.power_user_check)
        
        # Shell map
        self.shell_map_check = ui.CheckBox(resource_manager, "Shell Map", self.shell_map_toggled)
        self.shell_map_check.position = vector.Position(300, 225)
        config_window.relative_reposition(self.shell_map_check)
        self.add(self.shell_map_check)
        
        # Safe mode
        self.safe_mode_check = ui.CheckBox(resource_manager, "Safe Mode (Reset Graphics)", self.safe_mode_toggled)
        self.safe_mode_check.position = vector.Position(30, 250)
        config_window.relative_reposition(self.safe_mode_check)
        self.add(self.safe_mode_check)
        
        # Snap Scrap
        self.snap_scrap_check = ui.CheckBox(resource_manager, "Snap Scrap", self.snap_scrap_toggled)
        self.snap_scrap_check.position = vector.Position(300, 250)
        config_window.relative_reposition(self.snap_scrap_check)
        self.add(self.snap_scrap_check)
        
        # No Vista
        self.no_vista_check = ui.CheckBox(resource_manager, "No Vista (Don't use MyDocs)", self.no_vista_toggled)
        self.no_vista_check.position = vector.Position(30, 275)
        config_window.relative_reposition(self.no_vista_check)
        self.add(self.no_vista_check)
        
        # Delete AOI's on Load
        self.delete_aoi_check = ui.CheckBox(resource_manager, "Delete AOI's on Load", self.aoi_mode_toggled)
        self.delete_aoi_check.position = vector.Position(300, 275)
        config_window.relative_reposition(self.delete_aoi_check)
        self.add(self.delete_aoi_check)
        
        # Load the background
        self._background = resource_manager.load_image("res/bzclbackground.png")
   
    def launch_pressed(self, window, resource_manager):
        pass
    
    def power_user_toggled(self, window, resource_manager, state):
        pass
    
    def editor_toggled(self, window, resource_manager, state):
        pass
    
    def skip_intro_toggled(self, window, resource_manager, state):
        pass
    
    def no_script_toggled(self, window, resource_manager, state):
        pass
    
    def shell_map_toggled(self, window, resource_manager, state):
        pass
    
    def safe_mode_toggled(self, window, resource_manager, state):
        pass
    
    def snap_scrap_toggled(self, window, resource_manager, state):
        pass
    
    def no_vista_toggled(self, window, resource_manager, state):
        pass
    
    def windowed_mode_toggled(self, window, resource_manager, state):
        pass
    
    def aoi_mode_toggled(self, window, resource_manager, state):
        pass
    
    def nobody_home_toggled(self, window, resource_manager, state):
        pass
    
    def back_button_pressed(self, window, resource_manager):
        window.set_interface("main")
        