using System;
using System.Collections.Generic;
using System.Text;

namespace Blunt.Resources
{
    class CloneRepo
    {
        public void Clone(string cmdText)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            // values that are set when start a process
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

            // hides the window when we start the local process
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/C {cmdText}";

            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
