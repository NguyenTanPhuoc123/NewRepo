using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLogin
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
<<<<<<< HEAD
            Application.Run(new frmProductManagement());
=======
            Application.Run(new frmAccountManagement());
>>>>>>> 4664ef7e63a8f68702e5a77d9f61e56fbddb1d5d
        }
    }
}
