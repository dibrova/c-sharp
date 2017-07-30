using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    static class Program
    {
        static public Form1 Frm1;
        static public Form2 Frm2;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Form1 
                Frm1 = new Form1();
            //Form2 
                Frm2 = new Form2();
            
            Frm2.Show();
            Application.Run(Frm1);
            
        }
    }
}
