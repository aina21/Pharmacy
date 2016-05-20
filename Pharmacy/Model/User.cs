using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DaroKhane.DataAccess;
using System.Windows.Forms;

namespace DaroKhane
{
    public class User
    {
        /// <summary>
        /// دیتا مدل
        /// </summary>
        private DaroKhaneEntities db = new DaroKhaneEntities();

        /// <summary>
        /// کد کاربر
        /// </summary>
        public int CodeUser { get; set; }

        /// <summary>
        /// نام کاربری
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// پسورد
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// تکرار پسوردد
        /// </summary>
        public string RePassword { get; set; }

        /// <summary>
        /// سازنده برای ایجاد حساب
        /// </summary>
        public User(string name ,  string pass)
        {
            //جلوگیری از وجود نام تکراری
            bool isExistUserName = db.Karbar.Any(item => item.name_karbar == name);
            if (isExistUserName )
            {
                MessageBox.Show(null,
                    "نام کاربری وجود دارد", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //ایجاد حساب جدید
            db.AddToKarbar(new Karbar()
            {
            name_karbar = name,
            rmazeVorood_karbar = pass
            });

            db.SaveChanges();

            MessageBox.Show(null,
                "عملیات موفق آمیز بود", ""
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public User()
        { }

        /// <summary>
        /// چک میکنه کاربر اجازه ورود دارد یا نه
        /// </summary>
        /// <param name="userName">نام کاربری</param>
        /// <param name="pass">پسورد</param>
        /// <returns>اگر اطلاعات کاربر صحیح باشد مقدار true
        /// باز میگرداند</returns>
        public bool CheckLogin(string userName,string pass)
        {
            bool isUserCorrected = db.Karbar.Any(item =>
                item.name_karbar.ToLower() == userName.ToLower()
                &&
                item.rmazeVorood_karbar.ToLower() == pass.ToLower());

            return isUserCorrected;
        }

        /// <summary>
        /// حذف کاربر
        /// </summary>
        /// <param name="name">نام کاربر</param>
        /// <param name="pass">پسورد</param>
        /// <returns>اگر عملیات موفق امیز بود True</returns>
        public bool Delete(string name, string pass)
        {
            bool isUserCorrected = db.Karbar.Any(item =>
                item.name_karbar.ToLower() == name.ToLower()
                &&
                item.rmazeVorood_karbar.ToLower() == pass.ToLower());

            if (isUserCorrected)
            {
                Karbar myKarbar = db.Karbar.First(
                    item => item.name_karbar == name
                    );
                db.Karbar.DeleteObject(myKarbar);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
