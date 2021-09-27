using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbolic_Link_Creator.AppLogic
{
    public class CmdLogic
    {
        public CmdLogic()
        {
        }

        public string GenerateCMDCommand(string radio, string toBeSelect, string newFol, string sourceName)
        {
            //create command
            string strCmd = string.Format("/C mklink {0} \"{2}\\{3}\" \"{1}\"", radio, toBeSelect, newFol, sourceName);

            return string.Empty;
        }
    }
}