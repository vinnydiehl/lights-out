# Lights Out Change Log

All changes to this application, both in the source and in the application, will be logged in this file with each release, whether or not they are noticable to the end-user. Goals for the next release will also be mentioned when applicable.

## 1.0a1

Initial prototype, included only one window with a working tile interface.

### Goals for Next Release
 + Implement a counter for the number of clicks
 + Add a way to reset the game without exiting the application

## 1.0a2

This is another prototype, I expanded the window and added some buttons and functions into there, still want more options for the user though.

### New Features
 + Added a click counter
 + Added a new game button that resets the tiles and counter

### Goals for Next Release
 + Add settings with better user customization
 + Add an about window
 + A tutorial some time in the future

## 1.0a3

My goal here is to make this a pre-beta, this release will be much closer to a
completed application. I will begin packaging the application on this release.

### Source Cleaning
 + Got rid of the try-catch hell in activate(), much cleaner when all of the edges are controlled by if statements
 + Organized the Graphics folder a bit more
 + Made a blank form to use as a template for making new forms with the style of this application
 + Added a Classes folder to hold all of the classes

### Major Source Changes
 + Added Global.cs, containing classes with global variables
    + Moved the DLL const's and functions that handle dragging application windows to the Sys class
    + WindowControl class implemented to regulate child windows to one instance each
 + Settings class added to support settings

### New Features
 + Settings window with some customization options added
    + Load New Game on Startup
    + Load New Game on Completion
    + Reset Clicks on New Game
    + Customize both lit and unlit colors for tiles
 + About window with information pertaining to the application
 + Added an icon

## 1.0b1

A lot has been added for the beta, and this is looking stable enough to let people use. The game looks and feels a lot more complete than it did before, but there may be a few bugs that I didn't catch, so the ultimate goal is to work them all out by the next release.

### Bug Fixes
 + Disabled ability to maximize any of the windows.
 + All UI elements are now transparent; overlapping problems were noticed on some systems due to font dependencies.

### Source Cleaning
 + Removed a lot of unnecessary references

### Source Tweaks
 + Moved the loadSettings() in frmMain's constructor to after the tiles list is generated to prevent any future regressions, I want that tiles list to be available as soon as possible.
 + Oops, testing >0 in the first if statement of activate() was completely unnecessary. Removed.
 + Requiring checkLights() to have a sender (and as a result requiring the this pointer to be passed with each call) wasn't necessary to call it from frmSettings; only needed an overload. The need to call it at all is now gone, but refer to newGame() to see the overload

### New Features
 + Status indicator in the lower right portion of the window.
 + Added a lights on mode, customizable in the settings.
 + Added tooltips to the settings window.
 + Settings window now has OK/Cancel/Apply buttons.
 + Implemented a game mode that gives a limited number of clicks.

### Goals for Next Release
 + Implement more game modes, difficulty settings, etc.
 + Fix any reported bugs from this release

## 1.0

After a lot of work and testing, I am calling this the first stable release of
Lights Out. It is now licensed under the GNU GPL, all of the bugs that were
found in the beta were fixed, and some important new Features were added.

### Licensing
 + Licensed under the GNU General Public License
 + Added a GNU GPL documentation comment at the beginning of each source file

### Bug Fixes
 + Fixed the changing game modes being to eager to set the status label to "Game Mode Changed" and start a new game; e.g. toggling the radio buttons back and forth would trigger this behavior
 + Similarly, the entirity of the settings was too eager to set the label to "Settings Changed"- now, it will only show this if the settings have actually changed from when they opened the window.
 + Bundled the Gill Sans MT Bold font with the executable; the click counter should now show up properly

### Source Cleaning
 + Removed some unnecessary imports from Global.cs

### Source Tweaks
 + Added the constant APP_NAME to Global.cs for use with the AppData folder
 + Made the StreamWriter and StreamReader in Settings.cs private
 + Now using the /unsafe compiler option

### Major Source Changes
 + Moved GetMyAppDataDir to Global.cs, renamed GetAppDataDir

### Changes
 + Renamed settings.txt to LightsOutSettings.cfg

### New Features
 + Implemented mode that only allows lit tiles to be activated
 + Added a Restore Defaults button to the settings
 + Added the ability to save and load game saves in the settings
    + This required a rearranging of the settings window so that it didn't get too tall, this also made more room for the Restore Defaults button

### Goals for Next Release
 + Challenge mode is a bit hard right now- add difficulty settings.
