using System;
using EConnectDocEx.Properties;
using System.Windows.Forms;
using EConnectApi;

namespace EConnectDocEx
{

    public class Program
    {
        // Opstarten van de applicatie
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    }
}
