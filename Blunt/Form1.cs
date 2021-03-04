using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Blunt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resourcePanel.Hide();
        }

        private void chooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                label1.Text = FBD.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newResource_Click(object sender, EventArgs e)
        {
            resourcePanel.Show();
        }
    }
}
