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

namespace CopyMate_V._01
{
    public partial class Form1 : Form
    {

        string srcPath = string.Empty;
        string desPath = string.Empty;
        string oldFile = string.Empty;
        string newFile = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void runPause_button_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(srcPath))
            {
                string[] files = System.IO.Directory.GetFiles(srcPath);

                foreach (string s in files)
                {
                    oldFile = System.IO.Path.GetFileName(s);
                    newFile = System.IO.Path.Combine(desPath, oldFile);
                    System.IO.File.Copy(s, newFile, true);
                }
            }
            else
            {
                Console.WriteLine("Source Path does not exist!");
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {

        }

        private void src_button_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog flBroswer = new FolderBrowserDialog();
            if (flBroswer.ShowDialog() == DialogResult.OK)
            {
                srcPath = flBroswer.SelectedPath;
                srcTextBox.Text = srcPath; 
            }
        }

        private void des_button_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog flBroswer = new FolderBrowserDialog();
            if (flBroswer.ShowDialog() == DialogResult.OK)
            {
                desPath = flBroswer.SelectedPath;
                desTextBox.Text = desPath;
            }
        }

        private void srcTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void desTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

    }
}
