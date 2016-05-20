using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DaroKhane.DataAccess;
using System.Windows.Forms;

namespace DaroKhane
{
    public class ListNoskhe
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
        /// کد دارو
        /// </summary>
        public int CodeDaroo { get; set; }

        /// <summary>
        /// تعداد
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// سازنده لیست اقلام
        /// </summary>
        /// <param name="code">کد نسخه</param>
        /// <param name="daroo">کد دارو</param>
        /// <param name="value">تعداد</param>
        public ListNoskhe(int code,int daroo , int value)
        {
            bool isCorrect = db.AghlameNoskhe.Any(item => item.code_noskhe == code
                &&
                item.code_daroo == daroo);

            if (isCorrect)
            {
                MessageBox.Show(null,
                    "این دارو در لیست وجود دارد", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.AddToAghlameNoskhe(new AghlameNoskhe
            {
                code_noskhe = code,
                code_daroo = daroo,
                tedad = value ,
            });

            db.SaveChanges();


            MessageBox.Show(null,
                    "عملیات موفق آمیز بود", ""
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public ListNoskhe()
        {}

        /// <summary>
        /// حذف اقلام نسخه
        /// </summary>
        /// <param name="noskhe">کد نسخه</param>
        /// <param name="daroo">کد دارو</param>
        /// <returns>اگر عملیات صحیح باشد </returns>
        public bool Delete(int noskhe , int daroo)
        {
            try
            {
                AghlameNoskhe myNoskhe= db.AghlameNoskhe.First(
                         item => item.code_noskhe == noskhe 
                             && item.code_daroo == daroo
                         );

                db.AghlameNoskhe.DeleteObject(myNoskhe);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// جستجو 
        /// </summary>
        /// <param name="noskhe">کد نسخه</param>
        /// <param name="daroo">کد دارو</param>
        /// <returns>مقدار صحیح اگر عملیات درست انجام شود</returns>
        public bool Search(int noskhe , int daroo)
        {
            try
            {
                AghlameNoskhe myNoskhe = db.AghlameNoskhe.First(
                         item => item.code_noskhe == noskhe
                             && item.code_daroo == daroo
                         );

                CodeNoskhe = myNoskhe.code_noskhe;
                CodeDaroo = myNoskhe.code_daroo;
                Value = Convert.ToInt32(myNoskhe.tedad);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// ویرایش
        /// </summary>
        /// <param name="noskhe">کد نسخه</param>
        /// <param name="daroo">کد دارو</param>
        /// <param name="value">تعداد</param>
        /// <returns>اگر عملیات موفق امیز بود</returns>
        public bool Edit(int noskhe, int daroo, int value)
        {
            AghlameNoskhe myNoskhe = db.AghlameNoskhe.First(
                         item => item.code_noskhe == noskhe
                             && item.code_daroo == daroo
                         );

            try
            {
                myNoskhe.code_noskhe = noskhe;
                myNoskhe.code_daroo= daroo;
                myNoskhe.tedad = value;

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
