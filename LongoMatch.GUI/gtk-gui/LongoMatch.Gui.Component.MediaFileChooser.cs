
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class MediaFileChooser
	{
		private global::Gtk.EventBox fileentryeventbox;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Entry fileentry;
		private global::Gtk.Button addbutton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.MediaFileChooser
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.MediaFileChooser";
			// Container child LongoMatch.Gui.Component.MediaFileChooser.Gtk.Container+ContainerChild
			this.fileentryeventbox = new global::Gtk.EventBox ();
			this.fileentryeventbox.Name = "fileentryeventbox";
			// Container child fileentryeventbox.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.BorderWidth = ((uint)(2));
			// Container child hbox1.Gtk.Box+BoxChild
			this.fileentry = new global::Gtk.Entry ();
			this.fileentry.CanFocus = true;
			this.fileentry.Name = "fileentry";
			this.fileentry.IsEditable = false;
			this.fileentry.HasFrame = false;
			this.fileentry.InvisibleChar = '•';
			this.hbox1.Add (this.fileentry);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.fileentry]));
			w1.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.addbutton = new global::Gtk.Button ();
			this.addbutton.CanFocus = true;
			this.addbutton.Name = "addbutton";
			this.addbutton.UseUnderline = true;
			// Container child addbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w2 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w3 = new global::Gtk.HBox ();
			w3.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w4 = new global::Gtk.Image ();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "longomatch-browse", global::Gtk.IconSize.Button);
			w3.Add (w4);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w6 = new global::Gtk.Label ();
			w3.Add (w6);
			w2.Add (w3);
			this.addbutton.Add (w2);
			this.hbox1.Add (this.addbutton);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.addbutton]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.fileentryeventbox.Add (this.hbox1);
			this.Add (this.fileentryeventbox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
