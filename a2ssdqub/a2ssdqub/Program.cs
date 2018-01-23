using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a2ssdqub
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Override data directory to use root database.mdf.
            var dataDir = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Environment.CurrentDirectory));
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);

            Application.Run(mainForm: new Home());
        }
    }
}
