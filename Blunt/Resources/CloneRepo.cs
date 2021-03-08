using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Blunt.Resources
{
    class CloneRepo
    {
        public void Clone(string path, string cmdText)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            // values that are set when start a process
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

            // hides the window when we start the local process
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/C cd {path} && git clone {cmdText}";

            process.StartInfo = startInfo;
            process.Start();
        }

        public void Copy(string sourceFileName, string destFileName)
        {
            File.Copy(sourceFileName, destFileName, true);
        }
    }
}
