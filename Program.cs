using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleForStudents
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //string surname = "";
            Application.Run(new Login());

            //Login_Form flogin = new Login_Form();
            //if(flogin.ShowDialog() == DialogResult.OK )
            //{
            //    Application.Run(new MDIParent());
            //} else
            //{
            //    Application.Exit();
            //}
        }
    }
}
