using System;
using System.Windows.Forms;

namespace Tracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //If a path to a trackerfile is passed to this program, open that file.

            /*TODO Check to make sure the extension is .track, just in case.
             * The logic for checking if the file at the specified path exists in the openFile method,
             * but I feel as if additonal checks should be called below.
             * This is purely a design choice. I will decide later.
             */
            if(args.Length == 1)
            {
                Application.Run(new TrackerForm(args[0]));
            }
            else
            {
                Application.Run(new TrackerForm());
            }
        }
    }
}
