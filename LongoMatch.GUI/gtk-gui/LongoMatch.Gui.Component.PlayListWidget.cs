
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class PlayListWidget
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.ScrolledWindow scrolledwindow1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Button newbutton;

		private global::VAS.UI.Helpers.ImageView newimage;

		private global::Gtk.Button newvideobutton;

		private global::VAS.UI.Helpers.ImageView recimage;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget LongoMatch.Gui.Component.PlayListWidget
			global::Stetic.BinContainer.Attach(this);
			this.WidthRequest = 100;
			this.Name = "LongoMatch.Gui.Component.PlayListWidget";
			// Container child LongoMatch.Gui.Component.PlayListWidget.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			this.vbox2.Add(this.scrolledwindow1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.scrolledwindow1]));
			w1.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Homogeneous = true;
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.newbutton = new global::Gtk.Button();
			this.newbutton.TooltipMarkup = "Create a new playlist";
			this.newbutton.CanFocus = true;
			this.newbutton.Name = "newbutton";
			this.newbutton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child newbutton.Gtk.Container+ContainerChild
			this.newimage = new global::VAS.UI.Helpers.ImageView();
			this.newimage.Name = "newimage";
			this.newbutton.Add(this.newimage);
			this.hbox2.Add(this.newbutton);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.newbutton]));
			w3.Position = 0;
			w3.Padding = ((uint)(5));
			// Container child hbox2.Gtk.Box+BoxChild
			this.newvideobutton = new global::Gtk.Button();
			this.newvideobutton.TooltipMarkup = "Export the playlist to new video file";
			this.newvideobutton.CanFocus = true;
			this.newvideobutton.Name = "newvideobutton";
			this.newvideobutton.Relief = ((global::Gtk.ReliefStyle)(2));
			// Container child newvideobutton.Gtk.Container+ContainerChild
			this.recimage = new global::VAS.UI.Helpers.ImageView();
			this.recimage.Name = "recimage";
			this.newvideobutton.Add(this.recimage);
			this.hbox2.Add(this.newvideobutton);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.newvideobutton]));
			w5.Position = 1;
			w5.Padding = ((uint)(5));
			this.vbox2.Add(this.hbox2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Show();
		}
	}
}
