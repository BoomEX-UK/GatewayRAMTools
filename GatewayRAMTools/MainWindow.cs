using System;
using System.Collections.Generic;
using Gtk;

namespace GatewayRAMTools {
	public partial class MainWindow: Gtk.Window
	{
		public MainWindow () : base (Gtk.WindowType.Toplevel)
		{
			Build ();
			initFileList (this);
		}

		// Simple Count If Ticked Function
		public int countSelected(){
			TreeIter iter = new TreeIter ();
			int tmpresult = 0;
			if (treeFiles.Model.GetIterFirst (out iter)) {
				do {
					if( (bool)treeFiles.Model.GetValue(iter,0) ) tmpresult++;
				} while( treeFiles.Model.IterNext(ref iter) );
			}
			return tmpresult;
		}

		// Check if file already listed
		public bool fileListed(string fname){
			TreeIter iter = new TreeIter ();
			bool tmpresult = false;
			if (treeFiles.Model.GetIterFirst (out iter)) {
				do {
					if( (string)treeFiles.Model.GetValue(iter,4) == fname ) tmpresult = true;
				} while(treeFiles.Model.IterNext (ref iter) && !tmpresult);
			}
			return tmpresult;
		}

		// Info Popup (Mainly For Debugging)
		public void MsgBoxInfo(string msg){
			MessageDialog MsgBox = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, msg);
			MsgBox.Run ();
			MsgBox.Destroy ();
		}

		// Convert Bytes To Next Readable Format (Simple)
		public string filesizestring(double len){
			string[] sizes = { "B", "KB", "MB", "GB", "TB" };
			int order = 0;
			while (len >= 1024 && order + 1 < sizes.Length) {
				order++;
				len = len / 1024;
			}
			return String.Format ("{0:0.##} {1}", len, sizes [order]);
		}

		// Initialise File List
		// - Set up columns and cell types,
		// - Create OnToggle events for check boxes
		public void initFileList(MainWindow sender){

			// Build columns and types for the main TreeView
			Gtk.TreeViewColumn fcheck = new Gtk.TreeViewColumn();
			Gtk.TreeViewColumn fname = new Gtk.TreeViewColumn();
			Gtk.TreeViewColumn fsize = new Gtk.TreeViewColumn();
			Gtk.TreeViewColumn ftype = new Gtk.TreeViewColumn();
			Gtk.TreeViewColumn fpath = new Gtk.TreeViewColumn();

			// Column Titles
			fcheck.Title = "";
			fname.Title = "Filename";
			fsize.Title = "Size";
			ftype.Title = "Type";
			fpath.Title = "Filepath";

			// Cell Typres / Renderers
			Gtk.CellRendererToggle fcheck_c = new Gtk.CellRendererToggle();
			Gtk.CellRendererText fname_t = new Gtk.CellRendererText();
			Gtk.CellRendererText fsize_t = new Gtk.CellRendererText();
			Gtk.CellRendererText ftype_t = new Gtk.CellRendererText();
			Gtk.CellRendererText fpath_t = new Gtk.CellRendererText();

			// Pack Into Table, Left - Expand
			fcheck.PackStart (fcheck_c, true);
			fname.PackStart (fname_t,true);
			fsize.PackStart (fsize_t,true);
			ftype.PackStart (ftype_t,true);
			fpath.PackStart (fpath_t,true);

			// Display Type & Column #
			fcheck.AddAttribute(fcheck_c, "active", 0);
			fname.AddAttribute (fname_t, "text", 1);
			fsize.AddAttribute (fsize_t, "text", 2);
			ftype.AddAttribute (ftype_t, "text", 3);
			fpath.AddAttribute (fpath_t, "text", 4);

			// Build Data Store
			Gtk.ListStore lstfiles = new Gtk.ListStore (typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string));

			// OnToggle for Checkboxes
			fcheck_c.Toggled += delegate( object o, ToggledArgs args) {
				Gtk.TreeIter iter = new TreeIter();
				if( lstfiles.GetIter(out iter, new TreePath(args.Path))){
					lstfiles.SetValue(iter, 0, !fcheck_c.Active);
				}
			};

			// Keep the Empty Layout Tidy
			fcheck.MinWidth = 20;
			fname.MinWidth = 120;
			fsize.MinWidth = 70;
			ftype.MinWidth = 70;

			// Append Into TreeView
			sender.treeFiles.AppendColumn (fcheck); 
			sender.treeFiles.AppendColumn (fname);
			sender.treeFiles.AppendColumn (fsize);
			sender.treeFiles.AppendColumn (ftype);
			// Decided Not To Show Full Path But Use The Data In Functions
			// sender.treeFiles.AppendColumn (fpath);
			sender.treeFiles.Model = lstfiles;
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}

		// Add Files To The File List
		protected void OnBtnAddFilesClicked (object sender, EventArgs e)
		{
			GWFunctions gwf = new GWFunctions ();
			// Open Dialog
			Gtk.FileChooserDialog fcw = new Gtk.FileChooserDialog(
				"Please Select A RAM Dump",
				this,
				FileChooserAction.Open,
				"Cancel", ResponseType.Cancel,
				"Open", ResponseType.Accept
			);
			fcw.DefaultResponse = ResponseType.Cancel;
			fcw.SelectMultiple = true;

			Gtk.FileFilter fcw_filter_bin = new Gtk.FileFilter ();
			fcw_filter_bin.Name = "RAM Dump (*.bin)";
			fcw_filter_bin.AddPattern ("*.bin");

			Gtk.FileFilter fcw_filter_all = new Gtk.FileFilter ();
			fcw_filter_all.Name = "All Files (*.*)";
			fcw_filter_all.AddPattern ("*");

			fcw.AddFilter (fcw_filter_bin);
			fcw.AddFilter (fcw_filter_all);

			// Get Ready For Files
			Gtk.ListStore ls = (Gtk.ListStore)treeFiles.Model;
			Gtk.TreeIter ti = new Gtk.TreeIter();
			if (fcw.Run () == (int)ResponseType.Accept) {
				// Add them all (unless they already exist)
				for (int i = 0; i < fcw.Filenames.Length; i++) {
					if (!fileListed(fcw.Filenames [i])) {
						ti = ls.Append ();
						ls.SetValue (ti, 0, false);
						ls.SetValue (ti, 1, System.IO.Path.GetFileName (fcw.Filenames [i]));
						long len = new System.IO.FileInfo (fcw.Filenames [i]).Length;
						ls.SetValue (ti, 2, filesizestring (len));
						ls.SetValue (ti, 3, "RAW");
						// Check For Gateway RAM Dump Header
						if (gwf.isGatewayDump(fcw.Filenames [i])) {
							ls.SetValue (ti, 3, "Gateway");
						}
						ls.SetValue (ti, 4, fcw.Filenames [i]);
					}
				}
			}

			// Make Sure The Dialog Closes (duh!)
			fcw.Destroy ();
		}

		protected void OnTreeFilesCursorChanged (object sender, EventArgs e)
		{
			// Remove Button Enabled (if ticked>0)
			btnRemove.Sensitive = (countSelected () > 0);
			// View Partition Enabled (if selected>0)
			ViewSelectedPartitionAction.Sensitive = (treeFiles.Selection.CountSelectedRows()>0);
		}

		protected void OnAddFilesActionActivated (object sender, EventArgs e)
		{
			OnBtnAddFilesClicked(btnAddFiles, null);
		}

		protected void OnExitActionActivated (object sender, EventArgs e)
		{
			Application.Quit ();
		}

		protected void OnBtnRemoveClicked (object sender, EventArgs e)
		{
			TreeIter iter = new TreeIter ();
			if (treeFiles.Model.GetIterFirst (out iter)) {
				do {
					if( (bool)treeFiles.Model.GetValue(iter,0) ){
						do {
							(treeFiles.Model as ListStore).Remove(ref iter);
							treeFiles.Model.GetIterFirst (out iter);
						} while ((bool)treeFiles.Model.GetValue(iter,0));
					}
				} while(treeFiles.Model.IterNext (ref iter));
			}
			OnTreeFilesCursorChanged (treeFiles,null);
		}

		protected void OnAllActionActivated (object sender, EventArgs e)
		{
			TreeIter iter = new TreeIter ();
			if (treeFiles.Model.GetIterFirst (out iter)) {
				do {
					treeFiles.Model.SetValue(iter,0,true);
				} while(treeFiles.Model.IterNext (ref iter));
			}
			OnTreeFilesCursorChanged (treeFiles,null);
		}

		protected void OnNoneActionActivated (object sender, EventArgs e)
		{
			TreeIter iter = new TreeIter ();
			if (treeFiles.Model.GetIterFirst (out iter)) {
				do {
					treeFiles.Model.SetValue(iter,0,false);
				} while(treeFiles.Model.IterNext (ref iter));
			}
			OnTreeFilesCursorChanged (treeFiles,null);
		}

		protected void OnAllRAWActionActivated (object sender, EventArgs e)
		{
			TreeIter iter = new TreeIter ();
			if (treeFiles.Model.GetIterFirst (out iter)) {
				do {
					treeFiles.Model.SetValue(iter,0,( (string)treeFiles.Model.GetValue(iter,3) == "RAW" ));
				} while(treeFiles.Model.IterNext (ref iter));
			}
			OnTreeFilesCursorChanged (treeFiles,null);
		}

		protected void OnAllGatewayActionActivated (object sender, EventArgs e)
		{
			TreeIter iter = new TreeIter ();
			if (treeFiles.Model.GetIterFirst (out iter)) {
				do {
					treeFiles.Model.SetValue(iter,0,( (string)treeFiles.Model.GetValue(iter,3) == "Gateway" ));
				} while(treeFiles.Model.IterNext (ref iter));
			}
			OnTreeFilesCursorChanged (treeFiles,null);
		}

		protected void OnViewPartitionTableActionActivated (object sender, EventArgs e)
		{
			OnTreeFilesRowActivated (this, null);
		}

		protected void OnAboutActionActivated (object sender, EventArgs e)
		{
			MsgBoxInfo ("Created By: xJam.es\r\nProject Started: 20th Jan 2016\r\n--------\r\nThanks To:\r\n* The Gateway Team\r\n* Maxconsole.com Forums\r\n* msparky76\r\n* makikatze\r\n* storm75x (Fort42)");
		}

		protected void OnSupportActionActivated (object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.maxconsole.com/maxcon_forums/threads/293146-Finding-Pointer-Codes-With-Gateway-RAM-Dump");
		}

		protected void OnExportRAWDumpActionActivated (object sender, EventArgs e)
		{
			List<GWFileHeader> heads = new List<GWFileHeader> ();
			GWFunctions gwf = new GWFunctions ();
			TreeIter iter = new TreeIter ();
			long tfsize = 0;

			if (treeFiles.Model.GetIterFirst (out iter)) {
				do {
					if( (bool)treeFiles.Model.GetValue(iter,0) && ((string)treeFiles.Model.GetValue(iter,3) == "Gateway") ) {
						heads.Add(gwf.buildFromDump((string)treeFiles.Model.GetValue(iter,4)));
						tfsize += heads[heads.Count-1].rawsize;
					}
				} while( treeFiles.Model.IterNext(ref iter) );
			}

			if (heads.Count > 0) {
				MessageDialog MsgBox = new MessageDialog (this, DialogFlags.Modal, MessageType.Question, ButtonsType.YesNo, string.Format ("This will export {0} RAM dump(s) totalling {1}.\r\rThey will each be saved in the same folder as the original file and labelled -raw.\r\rContinue?", heads.Count, filesizestring (tfsize)));
				var re = MsgBox.Run ();
				MsgBox.Destroy ();
				if (re == (int)ResponseType.Yes) {
					MsgBoxInfo ("OK");
				}
			} else {
				MsgBoxInfo ("No Gateway RAM Dumps have been ticked.");
			}
		}

		protected void OnTreeFilesRowActivated (object o, RowActivatedArgs args)
		{
			TreeIter iter = new TreeIter ();
			GWFunctions gwf = new GWFunctions ();
			treeFiles.Selection.GetSelected (out iter);
			PartitionWindow prt = new PartitionWindow ();
			prt.binfile = gwf.buildFromDump ((string)treeFiles.Model.GetValue (iter, 4));
			prt.generateHeaderTable (this);
			prt.ShowAll ();
		}
	}
}