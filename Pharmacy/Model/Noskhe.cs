using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DaroKhane.DataAccess;

namespace DaroKhane
{
    public class NoskheClass
    {
        /// <summary>
        /// دیتا مدل
        /// </summary>
        private DaroKhaneEntities db = new DaroKhaneEntities();
        public DaroKhaneEntities DB { get { return db; } }

        /// <summary>
        /// کد نسخه
        /// </summary>
        public int CodeNoskhe { get; set; }

        /// <summary>
        /// کد بیمه
        /// </summary>
        public int CodeBimeh { get; set; }

        /// <summary>
        /// کد بیمار
        /// </summary>
        public int CodeSick { get; set; }

        /// <summary>
        /// سازنده برای ایجاد نسخه
        /// </summary>
        /// <param name="bimeh">کد بیمه</param>
        /// <param name="sick">کد بیمار</param>
        public NoskheClass(int bimeh, int sick)
        {

            db.AddToNoskhe(new Noskhe
            {
                code_bimeh = bimeh,
                code_bimar = sick,
            });

            db.SaveChanges();
        }

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public NoskheClass()
        { }

        /// <summary>
        /// حذف نسخه
        /// </summary>
        /// <param name="code">کد بیمه</param>
        /// <returns>اگه عملیات موفق امیز باشد مقدار صحیح برمیگرداند</returns>
        public bool Delete(int code)
        {
            try
            {
                Noskhe myNoskhe = db.Noskhe.First(
                         item => item.code_noskhe == code
                         );

                db.Noskhe.DeleteObject(myNoskhe);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// جستجو بر اساس کد نسخه
        /// </summary>
        /// <param name="code">کد نسخه</param>
        /// <returns>اگر کد نسخه در جدول بود اطلاعات دارو داخل فیلدهای کلاس ذخیره میشود</returns>
        public bool Search(int code)
        {
            try
            {
                Noskhe myNoskhe = db.Noskhe.First(item => item.code_noskhe == code);

                CodeBimeh = myNoskhe.code_bimeh;
                CodeSick = myNoskhe.code_bimar;
                CodeNoskhe = myNoskhe.code_noskhe;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// ویرایش نسخه
        /// </summary>
        /// <param name="code">کد نسخه</param>
        /// <param name="bimeh">کد بیمه</param>
        /// <param name="sick">کد بیمار</param>
        /// <returns>اگه عملیا ت موفق امیز بود</returns>
        public bool Edit(int code, int bimeh, int sick)
        {
            Noskhe myNoskhe = db.Noskhe.First(item => item.code_noskhe == code);

            try
            {
                myNoskhe.code_bimar = CodeSick;
                myNoskhe.code_bimeh = CodeBimeh;

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
