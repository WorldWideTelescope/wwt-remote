using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WWTRemoteControl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            if (args.Length > 0)
            {
                if (args[0].ToLower() == "master")
                {
                    Properties.Settings.Default.Master = true;
                    MainForm.ShowConfig = true;

                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
