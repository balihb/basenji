// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

#if GNOME
namespace Gnome {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class DesktopThumbnailFactory : GLib.Object {

		public DesktopThumbnailFactory(IntPtr raw) : base(raw) {}

		[DllImport("gnome-desktop-2")]
		static extern IntPtr gnome_desktop_thumbnail_factory_new(int size);

		public DesktopThumbnailFactory (Gnome.DesktopThumbnailSize size) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (DesktopThumbnailFactory)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			Raw = gnome_desktop_thumbnail_factory_new((int) size);
		}

		[DllImport("gnome-desktop-2")]
		static extern bool gnome_desktop_thumbnail_factory_has_valid_failed_thumbnail(IntPtr raw, IntPtr uri, IntPtr mtime);

		public bool HasValidFailedThumbnail(string uri, System.DateTime mtime) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			bool raw_ret = gnome_desktop_thumbnail_factory_has_valid_failed_thumbnail(Handle, native_uri, GLib.Marshaller.DateTimeTotime_t (mtime));
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			return ret;
		}

		[DllImport("gnome-desktop-2")]
		static extern void gnome_desktop_thumbnail_factory_save_thumbnail(IntPtr raw, IntPtr thumbnail, IntPtr uri, IntPtr original_mtime);

		public void SaveThumbnail(Gdk.Pixbuf thumbnail, string uri, System.DateTime original_mtime) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			gnome_desktop_thumbnail_factory_save_thumbnail(Handle, thumbnail == null ? IntPtr.Zero : thumbnail.Handle, native_uri, GLib.Marshaller.DateTimeTotime_t (original_mtime));
			GLib.Marshaller.Free (native_uri);
		}

		[DllImport("gnome-desktop-2")]
		static extern IntPtr gnome_desktop_thumbnail_factory_generate_thumbnail(IntPtr raw, IntPtr uri, IntPtr mime_type);

		public Gdk.Pixbuf GenerateThumbnail(string uri, string mime_type) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr native_mime_type = GLib.Marshaller.StringToPtrGStrdup (mime_type);
			IntPtr raw_ret = gnome_desktop_thumbnail_factory_generate_thumbnail(Handle, native_uri, native_mime_type);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
			GLib.Marshaller.Free (native_uri);
			GLib.Marshaller.Free (native_mime_type);
			return ret;
		}

		[DllImport("gnome-desktop-2")]
		static extern IntPtr gnome_desktop_thumbnail_factory_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gnome_desktop_thumbnail_factory_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gnome-desktop-2")]
		static extern bool gnome_desktop_thumbnail_factory_can_thumbnail(IntPtr raw, IntPtr uri, IntPtr mime_type, IntPtr mtime);

		public bool CanThumbnail(string uri, string mime_type, System.DateTime mtime) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr native_mime_type = GLib.Marshaller.StringToPtrGStrdup (mime_type);
			bool raw_ret = gnome_desktop_thumbnail_factory_can_thumbnail(Handle, native_uri, native_mime_type, GLib.Marshaller.DateTimeTotime_t (mtime));
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			GLib.Marshaller.Free (native_mime_type);
			return ret;
		}

		[DllImport("gnome-desktop-2")]
		static extern void gnome_desktop_thumbnail_factory_create_failed_thumbnail(IntPtr raw, IntPtr uri, IntPtr mtime);

		public void CreateFailedThumbnail(string uri, System.DateTime mtime) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			gnome_desktop_thumbnail_factory_create_failed_thumbnail(Handle, native_uri, GLib.Marshaller.DateTimeTotime_t (mtime));
			GLib.Marshaller.Free (native_uri);
		}

		[DllImport("gnome-desktop-2")]
		static extern IntPtr gnome_desktop_thumbnail_factory_lookup(IntPtr raw, IntPtr uri, IntPtr mtime);

		public string Lookup(string uri, System.DateTime mtime) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr raw_ret = gnome_desktop_thumbnail_factory_lookup(Handle, native_uri, GLib.Marshaller.DateTimeTotime_t (mtime));
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_uri);
			return ret;
		}

#endregion
	}
}
#endif