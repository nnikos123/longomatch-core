
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui
{
	public partial class PlayerCapturerBin
	{
		private global::Gtk.HBox hbox4;
		
		private global::Gtk.VBox playerbox;
		
		private global::Gtk.HBox replayhbox;
		
		private global::Gtk.Image replayimage;
		
		private global::Gtk.Label replaylabel;
		
		private global::Gtk.VBox capturerbox;
		
		private global::Gtk.HBox livebox;
		
		private global::Gtk.Image liveimage;
		
		private global::Gtk.Label livelabel;
		
		private global::LongoMatch.Gui.CapturerBin capturerbin;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.PlayerCapturerBin
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.PlayerCapturerBin";
			// Container child LongoMatch.Gui.PlayerCapturerBin.Gtk.Container+ContainerChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Homogeneous = true;
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.playerbox = new global::Gtk.VBox ();
			this.playerbox.Name = "playerbox";
			this.playerbox.Spacing = 6;
			// Container child playerbox.Gtk.Box+BoxChild
			this.replayhbox = new global::Gtk.HBox ();
			this.replayhbox.Name = "replayhbox";
			this.replayhbox.Spacing = 6;
			// Container child replayhbox.Gtk.Box+BoxChild
			this.replayimage = new global::Gtk.Image ();
			this.replayimage.Name = "replayimage";
			this.replayhbox.Add (this.replayimage);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.replayhbox [this.replayimage]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child replayhbox.Gtk.Box+BoxChild
			this.replaylabel = new global::Gtk.Label ();
			this.replaylabel.Name = "replaylabel";
			this.replaylabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Replay");
			this.replayhbox.Add (this.replaylabel);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.replayhbox [this.replaylabel]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.playerbox.Add (this.replayhbox);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.playerbox [this.replayhbox]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			this.hbox4.Add (this.playerbox);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.playerbox]));
			w4.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.capturerbox = new global::Gtk.VBox ();
			this.capturerbox.Name = "capturerbox";
			this.capturerbox.Spacing = 6;
			// Container child capturerbox.Gtk.Box+BoxChild
			this.livebox = new global::Gtk.HBox ();
			this.livebox.Name = "livebox";
			this.livebox.Spacing = 6;
			// Container child livebox.Gtk.Box+BoxChild
			this.liveimage = new global::Gtk.Image ();
			this.liveimage.Name = "liveimage";
			this.livebox.Add (this.liveimage);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.livebox [this.liveimage]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child livebox.Gtk.Box+BoxChild
			this.livelabel = new global::Gtk.Label ();
			this.livelabel.Name = "livelabel";
			this.livelabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Live");
			this.livebox.Add (this.livelabel);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.livebox [this.livelabel]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.capturerbox.Add (this.livebox);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.capturerbox [this.livebox]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child capturerbox.Gtk.Box+BoxChild
			this.capturerbin = new global::LongoMatch.Gui.CapturerBin ();
			this.capturerbin.Events = ((global::Gdk.EventMask)(256));
			this.capturerbin.Name = "capturerbin";
			this.capturerbin.Capturing = false;
			this.capturerbox.Add (this.capturerbin);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.capturerbox [this.capturerbin]));
			w8.Position = 1;
			this.hbox4.Add (this.capturerbox);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.capturerbox]));
			w9.Position = 1;
			this.Add (this.hbox4);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.replayhbox.Hide ();
			this.livebox.Hide ();
			this.Hide ();
		}
	}
}
