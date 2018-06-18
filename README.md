# Basenji
A cross-platform media indexing/search tool.  

Basenji is an indexing and search tool designed for easy and fast indexing of media collections.  
Once indexed, removable media such as CDs and USB sticks can be browsed and searched  
for specific files very quickly, without actually being connected to the computer.  
Besides file hierarchies and audio track listings, Basenji also presents extracted metadata  
(image dimensions, mp3 tags etc.) and content previews of indexed media in a clean and  
straightforward user interface.  
  
Basenji has been developed with platform independency in mind right from the start and  
presently consists of a GTK+ GUI frontend and a reusable library backend (VolumeDB) that  
implements the actual indexing, searching and storage logic.  
  
[Key features](http://pulb.github.io/basenji/features.htm)  
[Releases](https://www.github.com/pulb/basenji/releases)  
[Ubuntu packages](https://launchpad.net/~pulb/+archive/ppa)  
[Arch packages](https://aur.archlinux.org/packages/basenji)  
[Development](https://www.github.com/pulb/basenji)  
[Translations](https://translations.launchpad.net/basenji)

## Screenshots
![Screenshot](http://pulb.github.io/basenji/screenshots/basenji-gnome.png "Basenji on GNOME 3.6")
![Screenshot](http://pulb.github.io/basenji/screenshots/basenji-win.png "Basenji on Windows 7")

[More screenshots...](http://pulb.github.io/basenji/screenshots-legacy/screenshots.htm)

## Building

### GNU/LINUX/GNOME:

###### Requirements

* mono (>= 2.4)
* libglib2.0-cil-dev (>= 2.12.9)
* libgtk2.0-cil-dev (>= 2.12.9)
* libgio-cil-dev (>= 2.22.2)
* libmono-cairo-cil (>= 2.4.2.3)
* libtaglib-cil-dev (>= 2.0.4.0)
* libgnome-desktop-3 (>= 3.8.4)
* libgdk-pixbuf2 (>= 2.30.7)

###### Compile

	./configure (non-gnome: ./configure --config=RELEASE)
	make
	make install

__NOTE:__  
If you get a "GLib.GException: Couldn't recognize the image file format for file 'data/basenji.svg'" runtime error,  
you most likely don't have SVG pixbuf loaders installed (package librsvg2-common in Ubuntu).  
	

### MS Windows

###### Requirements

* .NET 4.0 Framework or higher
* Gtk# for .NET (http://www.go-mono.com/mono-downloads/download.html)

The following instructions only apply for Gtk# 2.12.45 and may change in the future:
* Download the [gtk+-bundle](http://win32builder.gnome.org/gtk+-bundle_3.6.4-20130921_win32.zip) ([soruce](https://github.com/mono/gtk-sharp/blob/master/msi/unmanaged/downloads.win32))
* extract `lib/gdk-pixbuf-2.0` into `%ProgramFiles(x86)%\GtkSharp\2.12\lib` (check if you have this file after: `%ProgramFiles(x86)%\GtkSharp\2.12\lib\gdk-pixbuf-2.0\2.10.0\loaders\libpixbufloader-svg.dll`)
* in an admin console run the following command:
  * `"%ProgramFiles(x86)%\GtkSharp\2.12\bin\gdk-pixbuf-query-loaders.exe" > "%ProgramFiles(x86)%\GtkSharp\2.12\lib\gdk-pixbuf-2.0\2.10.0\loaders.cache"`

The latest NuGet package for taglib-sharp is broken, so it must be compiled from source:
* clone the latest [taglib-spharp](https://github.com/mono/taglib-sharp) source code into the same directory where you cloned Basenji (Basendji uses a relative link to the dll)
* open the solution in Visual Studio and do a Release build

###### Compile

Open Basenji_win32.sln in Visual Studio 2017.
