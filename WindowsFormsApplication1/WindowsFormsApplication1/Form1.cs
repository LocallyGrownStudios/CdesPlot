using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK); // Test result.
            Console.WriteLine(result); // <-- For debugging use.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OpenFileDialog myFileDlog = new OpenFileDialog();
            textBox1.Text = myFileDlog.FileName;
        }
   }
}
