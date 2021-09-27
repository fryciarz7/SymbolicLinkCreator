using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symbolic_Link_Creator.Helpers
{
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