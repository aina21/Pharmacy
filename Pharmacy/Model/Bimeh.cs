using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DaroKhane.DataAccess;

namespace DaroKhane
{
    public class BimehClass
    {
        /// <summary>
        /// دیتا مدل
        /// </summary>
        private DaroKhaneEntities db = new DaroKhaneEntities();

        public DaroKhaneEntities DB { get { return db; } }

        /// <summary>
        /// کد بیمه
        /// </summary>
        public int BimehCode { get; set; }

        /// <summary>
        /// نام سازمان
        /// </summary>
        public string NameSazman { get; set; }

        /// <summary>
        /// درصد بیمه
        /// </summary>
        public string DarsadBimeh { get; set; }

        /// <summary>
        /// تاریخ اعتبار
        /// </summary>
        public string TarikhEtebar { get; set; }

        /// <summary>
        /// سازنده برای ایجاد بیمه جدید
        /// </summary>
        /// <param name="name">نام سازمان بیمه</param>
        /// <param name="darsad">درصد بیمه</param>
        /// <param name="etebar">اعتبار</param>
         public BimehClass(string name,string darsad , string etebar)
        {

            db.AddToBimeh(new Bimeh
            {
                nameSazman_bimeh = name,
                darsad_bimeh = darsad ,
                tarikheEtebar_bimeh = etebar ,
            });

            db.SaveChanges();
        }

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public BimehClass ()
        {}

        /// <summary>
        /// حذف بیمه
        /// </summary>
        /// <param name="code">کد بیمه</param>
        /// <returns>اگه عملیات موفق امیز باشد مقدار صحیح برمیگرداند</returns>
        public bool Delete(int code)
        {
            try
            {
                Bimeh myBimeh = db.Bimeh.First(
                         item => item.code_bimeh == code
                         );

                db.Bimeh.DeleteObject(myBimeh);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
          /// <summary>
        /// جستجو بر اساس کد بیمه
        /// </summary>
        /// <param name="code">کد بیمه</param>
        /// <returns>اگر کد بیمه در جدول بود اطلاعات دارو داخل فیلدهای کلاس ذخیره میشود</returns>
        public bool Search(int code)
        {
            try
            {
                Bimeh myBimeh = db.Bimeh.First(item => item.code_bimeh== code);

                BimehCode = myBimeh.code_bimeh;
                NameSazman = myBimeh.nameSazman_bimeh;
                TarikhEtebar = myBimeh.tarikheEtebar_bimeh;
                DarsadBimeh = myBimeh.darsad_bimeh;
   
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// ویرایش اطلاعات بیمه
        /// </summary>
        /// <param name="code">کد بیمه</param>
        /// <param name="name">نام سازمان بیمه</param>
        /// <param name="darsad">درصد بیمه</param>
        /// <param name="etebar">اعتبار</param>
        /// <returns>اگر عملیات موفقیت امیز باشد مقدار صحیح برمیگرداند</returns>
        public bool Edit(int code ,string name, string darsad, string etebar)
        {
            Bimeh myBimeh = db.Bimeh.First(item => item.code_bimeh == code);

            try
            {
                myBimeh.nameSazman_bimeh = name;
                myBimeh.tarikheEtebar_bimeh = etebar;
                myBimeh.darsad_bimeh = darsad;

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
