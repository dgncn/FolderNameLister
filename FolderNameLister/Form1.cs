using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderNameLister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Clear();
                string path = textBox1.Text;
                if (string.IsNullOrEmpty(path) || string.IsNullOrWhiteSpace(path))
                {
                    MessageBox.Show("Hatalı Dizin Adresi / Directory Path should be checked.");
                }
                else
                {
                    path.Trim();
                    DirectoryInfo d = new DirectoryInfo(path);
                    IEnumerable<DirectoryInfo> fi = d.EnumerateDirectories();
                    textBox1.ScrollBars = ScrollBars.Vertical;
                    foreach (var directory in fi)
                    {
                        textBox2.Text += directory.Name + "\r\n";
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

       
    }
}
