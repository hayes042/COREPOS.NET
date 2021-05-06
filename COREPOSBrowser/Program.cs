using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COREPOSBrowser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WebBrowserHelper.FixBrowserVersion();
            WebBrowserHelper.FixBrowserVersion("COREPOSBrowser.exe");
            WebBrowserHelper.FixBrowserVersion("COREPOSBrowser.exe", 11001);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new COREPOS());
        }
        
    }
}
