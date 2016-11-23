"""
    exceptions.py
    
    Python source file defining launcher specific exception types.
    
    This software is licensed under the MIT license. Refer to LICENSE.txt for more
    information.
"""

class LauncherException(exception):
    """
        An exception type representing the most generic type of launcher exceptions.
    """
    pass

class NotImplementedException(LauncherException):
    """
        An exception type thrown when the user attempts to invoke some functionality that
        is currently not supported by the launcher software.
    """
    pass