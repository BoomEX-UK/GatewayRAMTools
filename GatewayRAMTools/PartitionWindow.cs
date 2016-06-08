using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using Gtk;

namespace GatewayRAMTools
{
	public partial class PartitionWindow : Gtk.Window
	{
		public GWFileHeader binfile = new GWFileHeader ();

		public PartitionWindow () :
		base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
			initPartitionTable (this);
		}

		public void initPartitionTable(PartitionWindow sender){

			// Build columns and types for the Partition TreeView
			Gtk.TreeViewColumn rfrom = new Gtk.TreeViewColumn();
			Gtk.TreeViewColumn rto = new Gtk.TreeViewColumn();
			Gtk.TreeViewColumn fpos = new Gtk.TreeViewColumn();
			Gtk.TreeViewColumn dsize = new Gtk.TreeViewColumn();

			// Column Titles
			rfrom.Title = "RAM From";
			rto.Title = "RAM To";
			fpos.Title = "File Position";
			dsize.Title = "Dump Size";

			// Cell Typres / Renderers
			Gtk.CellRendererText rfrom_t = new Gtk.CellRendererText();
			Gtk.CellRendererText rto_t = new Gtk.CellRendererText();
			Gtk.CellRendererText fpos_t = new Gtk.CellRendererText();
			Gtk.CellRendererText dsize_t = new Gtk.CellRendererText();

			// Pack Into Table, Left - Expand
			rfrom.PackStart (rfrom_t, true);
			rto.PackStart (rto_t,true);
			fpos.PackStart (fpos_t,true);
			dsize.PackStart (dsize_t,true);

			// Display Type & Column #
			rfrom.AddAttribute(rfrom_t, "text", 0);
			rto.AddAttribute (rto_t, "text", 1);
			fpos.AddAttribute (fpos_t, "text", 2);
			dsize.AddAttribute (dsize_t, "text", 3);

			// Build Data Store
			Gtk.ListStore lstfiles = new Gtk.ListStore (typeof(string), typeof(string), typeof(string), typeof(string));

			// Keep the Empty Layout Tidy
			int colsize = 90;
			rfrom.MinWidth = colsize;
			rto.MinWidth = colsize;
			fpos.MinWidth = colsize;
			dsize.MinWidth = colsize;

			// Append Into TreeView
			sender.treePartition.AppendColumn (rfrom); 
			sender.treePartition.AppendColumn (rto);
			sender.treePartition.AppendColumn (fpos);
			sender.treePartition.AppendColumn (dsize);

			// Attach The Data Model
			sender.treePartition.Model = lstfiles;
		}

		public void generateHeaderTable(object sender){
			lblFName.Text = binfile.fileName;
			this.Title = "Partition Table - " + lblFName.Text;
			// Dump memRegions To Table;
			Gtk.ListStore ls = (Gtk.ListStore)treePartition.Model;
			Gtk.TreeIter ti = new Gtk.TreeIter ();
			for(int i = 0; i < binfile.memRegionCount; i++ ){
				ti = ls.Append ();
				ls.SetValue (ti, 0, binfile.memRegions[i][0].ToString("X8"));
				ls.SetValue (ti, 1, binfile.memRegions[i][1].ToString("X8"));
				ls.SetValue (ti, 2, binfile.memRegions[i][2].ToString("X8"));
				ls.SetValue (ti, 3, binfile.memRegions[i][3].ToString("X8"));
			}
		}

		public bool validHex(string test)
		{
			return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");
		}

		// Close Window Button
		protected void OnBtnPartCloseClicked (object sender, EventArgs e)
		{
			this.Destroy ();
		}

		// PoC - TBC
		protected void OnTxtRAMChanged (object sender, EventArgs e)
		{
			txtRAM.Text = txtRAM.Text.ToUpper();
			int ramval = 0;
			int conv = 0;
			if (validHex (txtRAM.Text)) {
				ramval = int.Parse(txtRAM.Text, System.Globalization.NumberStyles.HexNumber);
				TreeIter ti;
				ListStore pl = (ListStore)treePartition.Model;
				if( pl.GetIterFirst(out ti) ) do {
						int rfrom = int.Parse((string)pl.GetValue(ti, 0), System.Globalization.NumberStyles.HexNumber);
						int rto = int.Parse((string)pl.GetValue(ti, 1), System.Globalization.NumberStyles.HexNumber);
						int fo = int.Parse((string)pl.GetValue(ti, 2), System.Globalization.NumberStyles.HexNumber);
						if( (ramval >= rfrom) && (ramval <= rto)){
							conv = (ramval-rfrom) + fo;
						}
					} while (pl.IterNext(ref ti));
				txtFile.Changed -= OnTxtFileChanged;
				txtFile.Text = conv.ToString("X8");
				txtFile.Changed += OnTxtFileChanged;
			} else txtFile.Text = "00000000";
		}

		protected void OnBtnExportClicked (object sender, EventArgs e)
		{
			string xml_out_s = "";
			XmlSerializer xsSubmit = new XmlSerializer(typeof(GWFileHeader));
			using(StringWriter xml_out_w = new StringWriter())
			using(XmlWriter writer = XmlWriter.Create(xml_out_w))
			{
				xsSubmit.Serialize(writer, binfile);
				xml_out_s = xml_out_w.ToString(); // Your XML
			}
			Gtk.FileChooserDialog fcw = new Gtk.FileChooserDialog(
				"Please Select A RAM Dump",
				this,
				FileChooserAction.Save,
				"Cancel", ResponseType.Cancel,
				"Save", ResponseType.Accept
			);
			fcw.DefaultResponse = ResponseType.Cancel;
			fcw.DoOverwriteConfirmation = true;
			fcw.CurrentName = binfile.fileName + ".xml";

			Gtk.FileFilter fcw_filter_bin = new Gtk.FileFilter ();
			fcw_filter_bin.Name = "XML File (*.xml)";
			fcw_filter_bin.AddPattern ("*.xml");

			Gtk.FileFilter fcw_filter_all = new Gtk.FileFilter ();
			fcw_filter_all.Name = "All Files (*.*)";
			fcw_filter_all.AddPattern ("*");

			fcw.AddFilter (fcw_filter_bin);
			fcw.AddFilter (fcw_filter_all);

			if (fcw.Run () == (int)ResponseType.Accept) {
				System.IO.File.WriteAllText (fcw.Filename, xml_out_s);
			}
			fcw.Destroy ();
		}

		protected void OnTreePartitionRowActivated (object o, RowActivatedArgs args)
		{
			TreeIter ti;
			if( !treePartition.Model.GetIter(out ti, args.Path) ) return;
			txtRAM.Text = (string)treePartition.Model.GetValue (ti, 0);
		}

		protected void OnTxtFileChanged (object sender, EventArgs e)
		{
			txtFile.Text = txtFile.Text.ToUpper();
			int ramval = 0;
			int conv = 0;
			if (validHex (txtFile.Text)) {
				ramval = int.Parse(txtFile.Text, System.Globalization.NumberStyles.HexNumber);
				TreeIter ti;
				ListStore pl = (ListStore)treePartition.Model;
				if( pl.GetIterFirst(out ti) ) do {
						int rfrom = int.Parse((string)pl.GetValue(ti, 2), System.Globalization.NumberStyles.HexNumber);
						int rto = int.Parse((string)pl.GetValue(ti, 3), System.Globalization.NumberStyles.HexNumber);
						int fo = int.Parse((string)pl.GetValue(ti, 0), System.Globalization.NumberStyles.HexNumber);
						if( (ramval >= rfrom) && (ramval <= (rto+rfrom))){
							conv = (ramval-rfrom) + fo;
						}
					} while (pl.IterNext(ref ti));
				txtRAM.Changed -= OnTxtRAMChanged;
				txtRAM.Text = conv.ToString("X8");
				txtRAM.Changed += OnTxtRAMChanged;
			} else txtRAM.Text = "00000000";
		}
	}
}

