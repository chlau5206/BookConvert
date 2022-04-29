/// <summary>
/// Program:  ConvtEPub2
/// Date:     5/1/2022
/// Author:   Charles Lau
/// Platform: Windows form.  .Net Framework 4.8
/// Purpose:  Convert GBK(CN) ePub file to Big5(TW).  
/// 
/// What's next: (1) add abort method.
/// </summary>using System;
using System.IO;
using System.Windows.Forms;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookConvert {
    public partial class ConvtEPub2 : Form {
        public ConvtEPub2() {
            InitializeComponent();
            this.listBox1.AllowDrop = true;
            this.listBox1.DragDrop += new
                System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new
                System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);

        }
        private void listBox1_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string fileName in files) {
                if (!listBox1.Items.Contains(fileName)  // no duplicated file
                    && Path.GetExtension(fileName).ToLower() == ".epub") {   // only epub file
                    listBox1.Items.Add(fileName);
                    button1.Enabled = true;
                    button1.Text = "Start";
                }
            }
        }

        private void button1_Click(object sender, System.EventArgs e) {
            if (listBox1.Items.Count > 0) {
                button1.Text = "Process";
                foreach (string filePath in listBox1.Items) {
                    ePubBig5Converter.convertEPub(filePath);
                }
                listBox1.Items.Clear();
            }
            button1.Enabled = false;
            button1.Text = "Convert";
        }

    }
}
