using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SCMSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine();
            skin.SkinFile = System.Environment.CurrentDirectory + "\\skins\\" + "MSN.ssk";
            skin.Active = true;
            Application.Run(new SCMSystem());
            
        }
    }
}
