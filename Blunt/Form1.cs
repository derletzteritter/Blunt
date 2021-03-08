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
using Blunt.Resources;

namespace Blunt
{
    public partial class Form1 : Form
    {
        string selectedPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void chooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                selectedPath = FBD.SelectedPath;

                label1.Text = selectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resourcePanel.Hide();
        }

        private void newResource_Click(object sender, EventArgs e)
        {
            resourcePanel.Show();
        }

        private void tsRes_Click(object sender, EventArgs e)
        {
            Console.WriteLine("NEW RESOURCE: " + resourceLabel.Text);

            // removes whitespace
            System.Threading.Thread.Sleep(3000);
            string input_info = resourceLabel.Text.Replace(" ", string.Empty);
            SendKeys.Send(input_info);

            // this will eventually clone a repo to the selected directory
            CloneRepo repo = new CloneRepo();
            repo.Clone(selectedPath ,"https://github.com/itschip/cfa-templates.git");
        }

        private void closeModal_Click(object sender, EventArgs e)
        {
            resourcePanel.Hide();
        }
    }
}
