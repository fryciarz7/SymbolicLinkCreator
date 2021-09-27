using Symbolic_Link_Creator.AppLogic;
using Symbolic_Link_Creator.Helpers;
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
            string radio = GetRadioSelect();

            CmdLogic cl = new CmdLogic();
            //execute command
            System.Diagnostics.Process.Start("CMD.exe", cl.GenerateCMDCommand(radio, toBeSelect_TB.Text, newFol_TB.Text, sourceName_TB.Text));
            //display label to let user know something happend
            info_Lab.Text = "Symbolic link created.";
        }

        private void toBeSelect_TB_TextChanged(object sender, EventArgs e)
        {
            if (source_CB.Checked == true && toBeSelect_TB.Text.LastIndexOf("\\") != -1)
                sourceName_TB.Text = toBeSelect_TB.Text.Substring(toBeSelect_TB.Text.LastIndexOf("\\") + 1);
        }

        /// <summary>
        /// Function returns cmd value based on Radio button selected
        /// </summary>
        /// <returns></returns>
        private string GetRadioSelect()
        {
            if (dir_RB.Checked == true)
                return "/D";
            else if (hard_RB.Checked == true)
                return "/H";
            else
                return "/J";
        }
    }
}