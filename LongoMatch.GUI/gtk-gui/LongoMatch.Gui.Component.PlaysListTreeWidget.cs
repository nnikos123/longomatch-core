
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class PlaysListTreeWidget
	{
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::LongoMatch.Gui.Component.PlaysTreeView treeview;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.PlaysListTreeWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.PlaysListTreeWidget";
			// Container child LongoMatch.Gui.Component.PlaysListTreeWidget.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeview = new global::LongoMatch.Gui.Component.PlaysTreeView ();
			this.treeview.CanFocus = true;
			this.treeview.Name = "treeview";
			this.treeview.Colors = false;
			this.GtkScrolledWindow.Add (this.treeview);
			this.Add (this.GtkScrolledWindow);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
		}
	}
}
