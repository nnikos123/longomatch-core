// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch {
    
    
    public partial class TimeAdjustWidget {
        
        private Gtk.Table table1;
        
        private Gtk.Label label1;
        
        private Gtk.Label label3;
        
        private Gtk.SpinButton spinbutton1;
        
        private Gtk.SpinButton spinbutton2;
        
        private Gtk.Label startlabel;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.TimeAdjustWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "LongoMatch.TimeAdjustWidget";
            // Container child LongoMatch.TimeAdjustWidget.Gtk.Container+ContainerChild
            this.table1 = new Gtk.Table(((uint)(1)), ((uint)(5)), false);
            this.table1.Name = "table1";
            // Container child table1.Gtk.Table+TableChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Start gap:");
            this.table1.Add(this.label1);
            Gtk.Table.TableChild w1 = ((Gtk.Table.TableChild)(this.table1[this.label1]));
            w1.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Stop gap:");
            this.table1.Add(this.label3);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.table1[this.label3]));
            w2.LeftAttach = ((uint)(3));
            w2.RightAttach = ((uint)(4));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.spinbutton1 = new Gtk.SpinButton(0, 100, 1);
            this.spinbutton1.CanFocus = true;
            this.spinbutton1.Name = "spinbutton1";
            this.spinbutton1.Adjustment.PageIncrement = 10;
            this.spinbutton1.ClimbRate = 1;
            this.spinbutton1.Numeric = true;
            this.table1.Add(this.spinbutton1);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table1[this.spinbutton1]));
            w3.LeftAttach = ((uint)(2));
            w3.RightAttach = ((uint)(3));
            w3.XOptions = ((Gtk.AttachOptions)(4));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.spinbutton2 = new Gtk.SpinButton(-100, 100, 1);
            this.spinbutton2.CanFocus = true;
            this.spinbutton2.Name = "spinbutton2";
            this.spinbutton2.Adjustment.PageIncrement = 10;
            this.spinbutton2.ClimbRate = 1;
            this.spinbutton2.Numeric = true;
            this.table1.Add(this.spinbutton2);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table1[this.spinbutton2]));
            w4.LeftAttach = ((uint)(4));
            w4.RightAttach = ((uint)(5));
            w4.XOptions = ((Gtk.AttachOptions)(4));
            w4.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.startlabel = new Gtk.Label();
            this.startlabel.Name = "startlabel";
            this.startlabel.LabelProp = "";
            this.table1.Add(this.startlabel);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table1[this.startlabel]));
            w5.LeftAttach = ((uint)(1));
            w5.RightAttach = ((uint)(2));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            this.Add(this.table1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}
