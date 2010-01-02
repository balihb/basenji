// About.cs
// 
// Copyright (C) 2008 Patrick Ulbrich
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using System.Text;
using Gtk;
using Gdk;

namespace Basenji.Gui
{
	public partial class About : AboutDialog
	{
		private static readonly string		subTitle			= S._("A portable volume indexing tool");
		private static readonly string		dbVersion			= string.Format(S._("Using VolumeDB v{0}."), Util.GetVolumeDBVersion());
		private static readonly string		comments			= string.Format("{0}\n{1}", subTitle, dbVersion);
		private static readonly string		copyright			= string.Format("{0}{1}", S._("Copyright (c) "), App.Copyright);
		private static readonly string[]	authors				= new string[] { "Patrick Ulbrich <zulu99@gmx.net>" };
		private static readonly string		translatorCredits	= 
@"Yaron, https://launchpad.net/~sh-yaron
nanker, https://launchpad.net/~nanker
Nicolás M. Zahlut, https://launchpad.net/~nzahlut
Patrick Ulbrich, https://launchpad.net/~pulb";
		
		public About() {
			// general window settings
			this.Modal = true;
			SkipTaskbarHint	= true;
			Icon = Basenji.Icons.Icon.Stock_About.Render(this, IconSize.Menu);
			
			// about dialog settings
			Logo				= new Pixbuf("data/basenji.svg", 200, 200);
			ProgramName			= App.Name;
			Version				= App.Version;
			Comments			= comments;
			Copyright			= copyright;
			Website				= "http://www.launchpad.net/basenji";
			//WebsiteLabel		= "Basenji Homepage";
			Authors				= authors;
			TranslatorCredits	= translatorCredits;
		}
	}	
}