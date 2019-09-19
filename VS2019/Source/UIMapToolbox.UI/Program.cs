using System;
using System.Windows.Forms;

namespace UIMapToolbox.UI
{
    static class Program
    {
        public const string ApplicationName = "UIMap Toolbox";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += Application_ThreadException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string msg =
                $"An error occured. Please report to https://github.com/n-fowler/CodedUIMapToolbox with information on how to reproduce issue.\n\n{e.Exception.Message}\n\nStack trace:\n{e.Exception.StackTrace}";

            MessageBox.Show(msg, ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
