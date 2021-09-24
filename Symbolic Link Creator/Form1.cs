using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symbolic_Link_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetSourceName();
            info_Lab.Text = string.Empty;
        }

        private void toBeSelect_BT_Click(object sender, EventArgs e)
        {
            info_Lab.Text = string.Empty;
            toBeSelect_TB.Text = Helper.SetTextBoxText();
            SetSourceName();
        }

        private void newFol_BT_Click(object sender, EventArgs e)
        {
            info_Lab.Text = string.Empty;
            newFol_TB.Text = Helper.SetTextBoxText();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            info_Lab.Text = string.Empty;
            SetSourceName();
        }

        /// <summary>
        /// If checkbox is checked gets the name of source folder using LastIndexOf and fills TextBox.
        /// </summary>
        private void SetSourceName()
        {
            if (source_CB.Checked == true)
            {
                sourceName_TB.Enabled = false;
                if (!string.IsNullOrEmpty(toBeSelect_TB.Text))
                {
                    sourceName_TB.Text = toBeSelect_TB.Text.Substring(toBeSelect_TB.Text.LastIndexOf("\\") + 1);
                }
            }
            else
            {
                sourceName_TB.Enabled = true;
            }
        }

        private void create_BT_Click(object sender, EventArgs e)
        {
            //check for selected RadioButton
            string radio = "/J";
            if (dir_RB.Checked == true)
                radio = "/D";
            else if (hard_RB.Checked == true)
                radio = "/H";
            else
                radio = "/J";
            //create command
            string strCmd = string.Format("/C mklink {0} \"{2}\\{3}\" \"{1}\"", radio, toBeSelect_TB.Text, newFol_TB.Text, sourceName_TB.Text);
            //execute command
            System.Diagnostics.Process.Start("CMD.exe", strCmd);
            //display label to let user know something happend
            info_Lab.Text = "Symbolic link created.";
        }

        private void toBeSelect_TB_TextChanged(object sender, EventArgs e)
        {
            if (source_CB.Checked == true && toBeSelect_TB.Text.LastIndexOf("\\") != -1)
                sourceName_TB.Text = toBeSelect_TB.Text.Substring(toBeSelect_TB.Text.LastIndexOf("\\") + 1);
        }
    }

    public static class Helper
    {
        /// <summary>
        /// Opens FolderBrowserDialog and returns selected path of selected folder.
        /// </summary>
        /// <returns>String FolderBrowserDialog.SelectedPath</returns>
        public static string SetTextBoxText()
        {
            string tbtext = string.Empty;
            FolderBrowserDialog fbd;
            try
            {
                using (fbd = new FolderBrowserDialog())
                {
                    //open FolderBrowserDialog
                    DialogResult result = fbd.ShowDialog();
                                                    //check if there is folder selected
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        return fbd.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException("Source: " + ex.Source + "\nError: " + ex.Message + "\nInnerEx: " + ((ex.InnerException == null) ? "null" : ex.InnerException.Message));
            }
            return tbtext;
        }
    }
}
