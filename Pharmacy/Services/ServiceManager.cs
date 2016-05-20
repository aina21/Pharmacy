using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DaroKhane.DataAccess;

namespace DaroKhane
{
    public class ServiceManager
    {
        /// <summary>
        /// اجرای فرم لاگین
        /// </summary>
        public ServiceManager()
        {
            frmLogin a = new frmLogin();
            a.Show();
        }

        /// <summary>
        /// خروج از برنامه
        /// </summary>
        public static void Exit()
        {
            Application.Exit();
        }
       
    }
}
