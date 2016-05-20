using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DaroKhane.DataAccess;

namespace DaroKhane
{
    public class Drug
    {
        /// <summary>
        /// دیتا مدل
        /// </summary>
        private DaroKhaneEntities db = new DaroKhaneEntities();
        public DaroKhaneEntities DB { get { return db; } }

        /// <summary>
        /// کد دارو
        /// </summary>
        public int DrugCode { get; set; }

        /// <summary>
        /// نام دارو
        /// </summary>
        public string DrugName { get; set; }

        /// <summary>
        /// نام شرکت سازنده
        /// </summary>
        public string SherkatTolid { get; set; }

        /// <summary>
        /// تاریخ تولید
        /// </summary>
        public string TarikhTolid { get; set; }

        /// <summary>
        /// تاریخ انقضا
        /// </summary>
        public string TarikhEngza { get; set; }

        /// <summary>
        /// تعداد موجود
        /// </summary>
        public int TedadMojod { get; set; }

        /// <summary>
        /// قیمت
        /// </summary>
        public string Cost { get; set; }

 
        /// <summary>
        /// اطلاعات دارو جدید
        /// </summary>
        /// <param name="name">نام دارو</param>
        /// <param name="sherkat">شرکت سازنده دارو</param>
        /// <param name="tolid">تاریخ تولید</param>
        /// <param name="engza">تاریخ انقضا</param>
        /// <param name="value">تعداد موجود</param>
        /// <param name="cost">هزینه</param>
        public Drug ( string name , string sherkat , string tolid , string engza  , 
            int value  , string cost)
        {

            db.AddToDaroo(new Daroo
            {
                name_daroo = name,
                sherkatTolid_daroo = sherkat,
                tarikhTolid_daroo = tolid ,
                tarikhEngeza_daroo = engza ,
                tedadMojod_daroo = value ,
                gheymat_daroo = cost
            });

            db.SaveChanges();
        }

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Drug()
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
                Daroo myDrug = db.Daroo.First(
                         item => item.code_daroo == code
                         );

                db.Daroo.DeleteObject(myDrug);
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
        /// <param name="code">کد دارو</param>
        /// <returns>اگر کد دارو در جدول بود اطلاعات دارو داخل فیلدهای کلاس ذخیره میشود</returns>
        public bool Search(int code)
        {
            try
            {
                Daroo myDrug = db.Daroo.First(item => item.code_daroo== code);

                DrugCode = myDrug.code_daroo;
                DrugName = myDrug.name_daroo;
                SherkatTolid = myDrug.sherkatTolid_daroo;
                TarikhTolid = myDrug.tarikhTolid_daroo;
                TarikhEngza = myDrug.tarikhEngeza_daroo;
                TedadMojod =Convert.ToInt16( myDrug.tedadMojod_daroo);
                 Cost = myDrug.gheymat_daroo;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// ویرایش اطلاعات دارو
        /// </summary>
        /// <param name="code">کد دارو</param>
        /// <param name="name">نام دارو</param>
        /// <param name="sherkat">نام شرکت سازنده</param>
        /// <param name="tolid">تاریخ تولید</param>
        /// <param name="engza">تاریخ انقضا</param>
        /// <param name="value">تعداد موجود</param>
        /// <param name="cost">هزینه</param>
        /// <returns></returns>
        public bool Edit(int code, string name, string sherkat, string tolid, 
            string engza,int value, string cost)
        {
             Daroo myDrug = db.Daroo.First(item => item.code_daroo == code);

             try
             {
                 myDrug.name_daroo = name ;
                 myDrug.sherkatTolid_daroo =sherkat ;
                 myDrug.tarikhTolid_daroo = tolid ;
                 myDrug.tarikhEngeza_daroo = engza;
                 myDrug.tedadMojod_daroo = value ;
                 myDrug.gheymat_daroo = cost;

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
