
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Dialog
{
	public partial class SplashScreen
	{
		private global::Gtk.Fixed fixed1;
		
		private global::Gtk.ProgressBar progressbar1;
		
		private global::Gtk.Image splashimage;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Dialog.SplashScreen
			this.Name = "LongoMatch.Gui.Dialog.SplashScreen";
			this.Title = global::Mono.Unix.Catalog.GetString ("SplashScreen");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child LongoMatch.Gui.Dialog.SplashScreen.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.WidthRequest = 640;
			this.fixed1.HeightRequest = 480;
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.progressbar1 = new global::Gtk.ProgressBar ();
			this.progressbar1.WidthRequest = 384;
			this.progressbar1.Name = "progressbar1";
			this.fixed1.Add (this.progressbar1);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.progressbar1]));
			w1.X = 96;
			w1.Y = 430;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.splashimage = new global::Gtk.Image ();
			this.splashimage.WidthRequest = 640;
			this.splashimage.HeightRequest = 480;
			this.splashimage.Name = "splashimage";
			this.fixed1.Add (this.splashimage);
			this.Add (this.fixed1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 640;
			this.DefaultHeight = 480;
			this.Show ();
		}
	}
}
