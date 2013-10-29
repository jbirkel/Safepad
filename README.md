Safepad
=======

Windows Notepad clone with optional file encryption.

Requires: jhblib


Build Instructions
------------------

This is a C# program.  The project files are for Visual Studio 8.  After cloning Safelib to your local disk:
- clone jhblib (github.com/jbirkel/jhblib)
- open Safepad.sln in VS8
- add existing project jhblib/cslibW32/jhblib-cslibW32.csproj to the solution (from wherever you cloned it to)
- in the Safepad project, add a reference to jhblib-cslibW32 (it will be the only item in the Projects tab of the 'Add Reference' window
- build and run it
