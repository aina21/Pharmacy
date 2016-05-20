using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DaroKhane.DataAccess;

namespace DaroKhane
{
    public class Sick
    {
        /// <summary>
        /// دیتا مدل
        /// </summary>
        private DaroKhaneEntities db = new DaroKhaneEntities();
        public DaroKhaneEntities DB { get { return db; } }

        /// <summary>
        /// کد بیمار
        /// </summary>
        public int CodeSick { get; set; }

        /// <summary>
        /// نام بیمار
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// کد ملی بیمار
        /// </summary>
        public string MelliCode { get; set; }

        /// <summary>
        /// اطلاعات بیمار جدید
        /// </summary>
        /// <param name="name">نام بیمار</param>
        /// <param name="codeMelli">کد ملی</param>
        public Sick(string name,string codeMelli)
        {
            //ایجاد حساب جدید
            db.AddToBimar(new Bimar()
            {
                name_bimar = name,
                mellicode_bimar =codeMelli 
            });

            db.SaveChanges();
        }

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Sick()
        { }

        /// <summary>
        /// حذف دارو
        /// </summary>
        /// <param name="code">کد دارو</param>
        /// <returns>اگه عملیات موفق امیز باشد مقدار صحیح برمیگرداند</returns>
        public bool Delete(int code)
        {
            try
            {
                Bimar mySick = db.Bimar.First(
                         item => item.code_bimar == code
                         );

                db.Bimar.DeleteObject(mySick);
                db.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// جستجو بر اساس کد بیمار
        /// </summary>
        /// <param name="code">کد بیمار</param>
        /// <returns>اگر کد بیمار در جدول بود اطلاعات بیمار داخل فیلدهای کلاس ذخیره میشود</returns>
        public bool Search(int code)
        {
            try
            {
                Bimar mySick = db.Bimar.First(item => item.code_bimar == code);

                CodeSick = mySick.code_bimar;
                Name = mySick.name_bimar;
                MelliCode = mySick.mellicode_bimar;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// ویرایش اطلاعات بیمار
        /// </summary>
        /// <param name="code">کد بیمار</param>
        /// <param name="name">نام بیمار</param>
        /// <param name="melliCode">ملی کد</param>
        /// <returns>اگر عملیات موفق امیز باشه مقدار صحیح برمیگردوند</returns>
        public bool Edit(int code , string name, string melliCode)
        {
             Bimar mySick = db.Bimar.First(item => item.code_bimar == code);

             try
             {
                 mySick.name_bimar = name ;
                 mySick.mellicode_bimar = melliCode;

                 db.SaveChanges();
                 return true;

             }
             catch (Exception)
             {
                 return false;
             }
        }
    }
}
