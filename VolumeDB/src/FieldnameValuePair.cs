// FieldnameValuePair.cs
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

namespace VolumeDB
{
	internal struct FieldnameValuePair
	{
		private string fieldName;
		private object value;

		public FieldnameValuePair(string fieldName, object value) {
			this.fieldName	= fieldName;
			this.value		= value;
		}

		public string Fieldname {
			get { return fieldName; }
		}

		public object Value {
			get { return value; }
		}
	}
}
