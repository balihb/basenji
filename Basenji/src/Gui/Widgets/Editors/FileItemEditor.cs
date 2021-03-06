// FileSystemItemEditor.cs
// 
// Copyright (C) 2010, 2012 Patrick Ulbrich
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
using System.Collections.Generic;
using Gtk;
using Basenji.Gui.Base;
using VolumeDB;

namespace Basenji.Gui.Widgets.Editors
{
	public class FileItemEditor : FileSystemItemEditor
	{
		private Label lblSize;
		private Label lblHash;
		
		public FileItemEditor() : base(S._("File")) {}

		protected override void LoadFromObject(VolumeDB.VolumeItem item) {
			if (!(item is FileVolumeItem))
				throw new ArgumentException(string.Format("must be of type {0}",
				                                          typeof(FileVolumeItem)), "item");

			base.LoadFromObject(item);
			
			FileVolumeItem fvi = (FileVolumeItem)item;
			UpdateLabel(lblSize, Util.GetSizeStr(fvi.Size));
			UpdateLabel(lblHash, string.IsNullOrEmpty(fvi.Hash) ? "-" : fvi.Hash);
		}
		
		protected override void AddInfoLabels(List<InfoLabel> infoLabels) {
			base.AddInfoLabels(infoLabels);
			
			lblSize	= WindowBase.CreateLabel();
			lblHash	= WindowBase.CreateLabel();			
			
			infoLabels.AddRange( new InfoLabel[] { 
				new InfoLabel(S._("Size") + ":", lblSize),
				new InfoLabel(S._("Hash") + ":", lblHash)
			} );
		}
	}
}
