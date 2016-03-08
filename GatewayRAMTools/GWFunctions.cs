using System;
using System.IO;

// Ram Tools Class for Gateway File Functions - To be extended in the future

namespace GatewayRAMTools
{
	// File Header Class
	public class GWFileHeader {
		public string filePath; // full file path
		public string fileName; // file name only
		public string leadIn;
		public bool isGateway; // rough validation (needs improving)
		public string error;
		public long fileSize; // file size (Bytes)
		public long rawsize;
		public int headerSize; // Size of Header (Bytes)
		public int memRegionCount; // # of Header Blocks
		public int[][] memRegions; // Header Blocks
		public int magicBit; // Validation Int - Now Used
		public string magicBit0x;
	}

	// Functions
	public class GWFunctions
	{
		// Entry
		public GWFunctions () {}

		// Quick Function For Checking If File Is Gateway Dump
		public bool isGatewayDump( string fname ){
			GWFileHeader gwf = new GWFileHeader();
			gwf = buildFromDump(fname);
			return gwf.isGateway;
		}

		// Build Gateway RAM Partition Table (And Validate)
		public GWFileHeader buildFromDump(string fpath){
			GWFileHeader tmpres = new GWFileHeader ();
			long pAddr = 0;
			// Set File Path
			tmpres.error = "none";
			tmpres.filePath = fpath;
			// Set File Name
			tmpres.fileName = System.IO.Path.GetFileName (fpath);
			// Set File Size
			tmpres.fileSize = new System.IO.FileInfo (fpath).Length;
			// tmpres.isGateway = isGatewayDump (fpath);
			using (FileStream fs = new FileStream (fpath, FileMode.Open, FileAccess.Read))
			using (var reader = new BinaryReader (fs)) {
				// Set memRegions
				System.UInt32 regions = reader.ReadUInt32 ();
				tmpres.leadIn = regions.ToString ("X8");
				tmpres.isGateway = (regions < 100); // max 99 memRegions
				if (!tmpres.isGateway) {
					tmpres.error = "Header Too Big";
				} else { 
					// Count Memory Regions
					tmpres.memRegionCount = (int)regions;
					tmpres.memRegions = new int[regions][];
					tmpres.headerSize = (int)(8 + (regions * 12));
					pAddr = tmpres.headerSize;
					for (int i = 0; i < regions; i++) {
						int[] newline = new int[4];
						int dsize = (int)reader.ReadUInt32 ();
						// File Pointer
						pAddr = pAddr + dsize;
						newline [2] = (int)pAddr;
						if (i > 0) {
							tmpres.memRegions [i - 1] [3] = dsize;
							tmpres.memRegions [i - 1] [1] = tmpres.memRegions [i - 1] [0] + dsize;
						}
						// Virtual Address
						newline [0] = (int)reader.ReadUInt32 ();
						// Scrambled Eggs
						newline [1] = (int)reader.ReadUInt32 ();
						// Virtual Size (See You In The Next Loop)
						if (i + 1 == regions) {
							newline [3] = (int)(tmpres.fileSize - pAddr);
							newline [1] = newline [0] + newline [3];
						} else
							newline [3] = 0;
						tmpres.memRegions [i] = newline;
					}
					tmpres.rawsize = tmpres.memRegions [tmpres.memRegionCount - 1] [1];
					tmpres.magicBit = (int)reader.ReadUInt32 (); // Validation Int
					tmpres.magicBit0x = tmpres.magicBit.ToString("X8"); // Validation Hex
					tmpres.isGateway = (tmpres.magicBit == tmpres.memRegions [tmpres.memRegionCount - 1] [3]); // Final Check Against Validation Bit
					if( !tmpres.isGateway ) tmpres.error = "Validation Failed";
				}

				if( !tmpres.isGateway ){
					tmpres.memRegions = new int[1][];
					tmpres.memRegionCount = 1;
					int[] newline = new int[4];
					newline [0] = 0;
					newline [1] = (int)tmpres.fileSize;
					newline [2] = 0;
					newline [3] = (int)tmpres.fileSize;
					tmpres.memRegions[0] = newline;
				}
			}
			return tmpres;
		}

	}
}

