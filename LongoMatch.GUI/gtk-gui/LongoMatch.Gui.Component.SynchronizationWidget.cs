
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class SynchronizationWidget
	{
		private global::Gtk.EventBox headereventbox;

		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox videoplayerbox;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Alignment labels_alignment;

		private global::Gtk.VBox labels_vbox;

		private global::Gtk.DrawingArea labelsarea;

		private global::Gtk.HBox zoomhbox;

		private global::VAS.UI.Helpers.ImageView zoomoutimage;

		private global::Gtk.HScale zoomscale;

		private global::VAS.UI.Helpers.ImageView zoominimage;

		private global::Gtk.VBox vbox9;

		private global::Gtk.DrawingArea timerulearea;

		private global::Gtk.ScrolledWindow scrolledwindow2;

		private global::Gtk.DrawingArea timelinearea;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget LongoMatch.Gui.Component.SynchronizationWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "LongoMatch.Gui.Component.SynchronizationWidget";
			// Container child LongoMatch.Gui.Component.SynchronizationWidget.Gtk.Container+ContainerChild
			this.headereventbox = new global::Gtk.EventBox();
			this.headereventbox.Name = "headereventbox";
			// Container child headereventbox.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.videoplayerbox = new global::Gtk.HBox();
			this.videoplayerbox.Name = "videoplayerbox";
			this.videoplayerbox.Spacing = 6;
			this.vbox1.Add(this.videoplayerbox);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.videoplayerbox]));
			w1.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			// Container child hbox5.Gtk.Box+BoxChild
			this.labels_alignment = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.labels_alignment.Name = "labels_alignment";
			// Container child labels_alignment.Gtk.Container+ContainerChild
			this.labels_vbox = new global::Gtk.VBox();
			this.labels_vbox.Name = "labels_vbox";
			// Container child labels_vbox.Gtk.Box+BoxChild
			this.labelsarea = new global::Gtk.DrawingArea();
			this.labelsarea.Name = "labelsarea";
			this.labels_vbox.Add(this.labelsarea);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.labels_vbox[this.labelsarea]));
			w2.Position = 0;
			// Container child labels_vbox.Gtk.Box+BoxChild
			this.zoomhbox = new global::Gtk.HBox();
			this.zoomhbox.Name = "zoomhbox";
			this.zoomhbox.Spacing = 6;
			// Container child zoomhbox.Gtk.Box+BoxChild
			this.zoomoutimage = new global::VAS.UI.Helpers.ImageView();
			this.zoomoutimage.WidthRequest = 14;
			this.zoomoutimage.HeightRequest = 8;
			this.zoomoutimage.Name = "zoomoutimage";
			this.zoomhbox.Add(this.zoomoutimage);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.zoomhbox[this.zoomoutimage]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child zoomhbox.Gtk.Box+BoxChild
			this.zoomscale = new global::Gtk.HScale(null);
			this.zoomscale.CanFocus = true;
			this.zoomscale.Name = "zoomscale";
			this.zoomscale.Adjustment.Upper = 100;
			this.zoomscale.Adjustment.PageIncrement = 10;
			this.zoomscale.Adjustment.StepIncrement = 1;
			this.zoomscale.DrawValue = false;
			this.zoomscale.Digits = 0;
			this.zoomscale.ValuePos = ((global::Gtk.PositionType)(2));
			this.zoomhbox.Add(this.zoomscale);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.zoomhbox[this.zoomscale]));
			w4.Position = 1;
			// Container child zoomhbox.Gtk.Box+BoxChild
			this.zoominimage = new global::VAS.UI.Helpers.ImageView();
			this.zoominimage.WidthRequest = 14;
			this.zoominimage.HeightRequest = 8;
			this.zoominimage.Name = "zoominimage";
			this.zoomhbox.Add(this.zoominimage);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.zoomhbox[this.zoominimage]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			this.labels_vbox.Add(this.zoomhbox);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.labels_vbox[this.zoomhbox]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.labels_alignment.Add(this.labels_vbox);
			this.hbox5.Add(this.labels_alignment);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.labels_alignment]));
			w8.Position = 0;
			w8.Expand = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vbox9 = new global::Gtk.VBox();
			this.vbox9.Name = "vbox9";
			// Container child vbox9.Gtk.Box+BoxChild
			this.timerulearea = new global::Gtk.DrawingArea();
			this.timerulearea.Name = "timerulearea";
			this.vbox9.Add(this.timerulearea);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.timerulearea]));
			w9.Position = 0;
			w9.Expand = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow2.HeightRequest = 50;
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.VscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.scrolledwindow2.HscrollbarPolicy = ((global::Gtk.PolicyType)(0));
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			global::Gtk.Viewport w10 = new global::Gtk.Viewport();
			w10.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.timelinearea = new global::Gtk.DrawingArea();
			this.timelinearea.Name = "timelinearea";
			w10.Add(this.timelinearea);
			this.scrolledwindow2.Add(w10);
			this.vbox9.Add(this.scrolledwindow2);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.scrolledwindow2]));
			w13.Position = 1;
			this.hbox5.Add(this.vbox9);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vbox9]));
			w14.Position = 1;
			this.vbox1.Add(this.hbox5);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox5]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			this.headereventbox.Add(this.vbox1);
			this.Add(this.headereventbox);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
