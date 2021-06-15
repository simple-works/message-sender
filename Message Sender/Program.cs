using System;
using System.Windows.Forms;

namespace MessageSender
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Splash());
        }
    }
}
