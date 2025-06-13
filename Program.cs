using Kutuphane_TakipSistemi_Form;
using System;
using System.Windows.Forms;


namespace Kutuphane_Takip_Sistemi
{
    class Program
    {
        

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // FORM1'İ ÇALIŞTIR
        }
    }
}


