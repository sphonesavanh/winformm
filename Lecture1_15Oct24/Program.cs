using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture1_15Oct24
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Form2());
            //Application.Run(new Form3());
            Application.Run(new frmLogin());
            //Application.Run(new supplier());

            //Application.Run(new frmProducts());
            //Application.Run(new frmCustomer());
            //Application.Run(new frmOrders());
            //Application.Run(new frmMainMenu());
            //Application.Run(new frmSupplier());
        }
    }
}
