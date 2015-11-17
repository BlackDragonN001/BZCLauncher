"""
        Basic config loader that provides easy to use functionality to load from simple
        configuration files that have take the following form on every line:

        * Option=Yes
        * Number=20
        * String=Whatever

        This software is licensed under the MIT license. Please refer to LICENSE.txt for more information.
"""

import string

class Config:
        """ The config loader class provides simple functionality to load from simple configuration files. """
        _settings_entries = None
        _yes = ["1", "true", "y", "yes", "enable", "toggle", "enabled"]
    
        def __init__(self, target_file = None):
            """ Initializes an instance of the Config loader. """
            self._settings_entries = { }
            
            if (target_file is not None):
                self.load(target_file)
            
        def load(self, target_file):
            """ Loads a configuration file from the hard disk. """
            file_handle = open(target_file, "r")
                
            for line_data in file_handle:
                preference_data = string.split(line_data, "=")
                line_data = line_data.lstrip()

                if (len(preference_data) == 2):
                    data = preference_data[1]
                    entry_data = data[:len(data)].replace("\n","")
                    entry_data = entry_data.replace("\r", "")
                    self._settings_entries[preference_data[0]] = entry_data
                    # TODO: Make this actually do some work to make post-fix comments work ...
                elif(line_data.find("#") and line_data != ""):
                    continue

            file_handle.close()
            
        def get_indices(self):
            """ Returns all known indices. This is a list of the indices you would use in :func:`get_index`. """
            return self._settings_entries.keys()

        def set_index(self, index, value):
            self._settings_entries[index] = value
            
        def export(self, output_file):
            with open(output_file, "w") as handle:
                for key in self._settings_entries.keys():
                    handle.write("%s=%s\n" % (key, self._settings_entries[key]))
            
        def get_index(self, index=None, datatype=None):
            """ Returns a loaded configuration setting from the Settings loader.

            Keyword arguments: 
                * index -- The name of the setting that is to be loaded from the file.
                * datatype -- The datatype that is supposed to be used to represent this setting in the return value.

            """
            if(index in self._settings_entries):
                entries = self._settings_entries
                if (datatype is bool):
                    if (string.lower(self._settings_entries[index]) in self._yes):
                        return True
                    else:
                        return False
                else:
                    return datatype(entries[index])
            else:
                return None
