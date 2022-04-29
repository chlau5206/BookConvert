/// <summary>
/// Project: ConvertEPub version 2.0
/// Project type: C# .NET Framework 4.8
/// Date: May 1, 2022
/// Purpose: To convert GB2312(Simplified Chinese) epub file to Big5 
/// Update #1: add Windows form UI
/// Update #2: Use Convertor.dll for main module.
/// Condiction: GB2312 ePub must be in UTF-8
/// </summary>

using System;
using System.Windows.Forms;

//using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;


namespace BookConvert {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConvtEPub2());
        }
    }
}
