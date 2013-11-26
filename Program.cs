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

//ReadAllBytes //Convert.ToBase64String(bytes)

//"<Payload>"
//                     // Payload of document instance comes here
//                   + "<pwns:document_instance xmlns:pwns=\"http://schemas.pw.vg.com/pwns\" dx_etyp=\"string\" uid=\"ui2\">"
//                   + "<pwns:textarea dx_etyp=\"string\" uid=\"ui4\">Dit is de tekst zoals je die te zien krijgt.</pwns:textarea>"
//                   //+ "<pwns:attachments dx_etyp=\"attachment\">
//                   //+ "     <attachment0 dx_atmt=\"true\" filename=\"testfile.txt\" isfilecontent=\"true\" xmlns=\"http://schemas.pw.vg.com/pwns\">
//                   ////         <!-- Base 64 encoded content of attachment0 goes here -->
//                   //+ "     </attachment0>"
//                   //+ "</pwns:attachments1>"
//                   + "</pwns:document_instance>"
//                + "</Payload>"