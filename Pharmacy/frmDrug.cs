using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DaroKhane
{
    public partial class frmDrug : Form
    {
        public frmDrug()
        {
            InitializeComponent();
        }

        //فرم بیمار
        private void toolStripBtnSick_Click(object sender, EventArgs e)
        {
            frmSick sickForm = new frmSick();
            sickForm.Show();
            this.Dispose();
        }

        //فرم نسخه
        private void toolStripBtnNoskhe_Click(object sender, EventArgs e)
        {
            frmNoskhe noskheForm = new frmNoskhe();
            noskheForm.Show();
            this.Dispose();
        }

        //فرم کاربر
        private void toolStripBtnUser_Click(object sender, EventArgs e)
        {
            frmUser userForm = new frmUser();
            userForm.Show();
            this.Dispose();
        }

        //خروج از برنامه
        private void frmDrug_FormClosed(object sender, FormClosedEventArgs e)
        {
            ServiceManager.Exit();
        }

        //لود شدن فرم
        private void frmDrug_Load(object sender, EventArgs e)
        {
            Drug newDrug = new Drug();
            cmbCode.DataSource = newDrug.DB.Daroo.ToList();

            cmbCode.DisplayMember = "code_daroo";
            cmbCode.ValueMember = "code_daroo";

            cmbCode.Text = "";
            txtCost.Text = "";
            txtEngeza.Text = "";
            txtName.Text = "";
            txtSazande.Text = "";
            txtTolid.Text = "";
            txtValue.Text = "";
        }

        //اضافه کردن دارو جدید
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // اگر نام سازمان را وارد نکرد
            if (txtSazande.Text == "")
            {
                MessageBox.Show(null,
                    "نام شرکت سازنده را وارد نمایید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                // اگر نام دارو را وارد نکرد
            else if (txtName.Text == "")
            {
                MessageBox.Show(null,
                    "نام دارو  را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                //اگر تاریخ تولید را وارد نکرد
            else if (txtTolid.Text == "")
            {
                MessageBox.Show(null,
                    "تاریخ تولید  را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                //اگر تاریخ انقضا را وارد نکرد
            else if (txtEngeza.Text == "")
            {
                MessageBox.Show(null,
                    "تاریخ انقضا  را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                //اگر تعداد را وارد نکرد
            else if (txtValue.Text == "")
            {
                MessageBox.Show(null,
                    "تعداد دارو موجود را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                //اگر هزینه را وارد نکرد
            else if (txtCost.Text == "")
            {
                MessageBox.Show(null,
                    "قیمت دارو  را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //ایجاد دارو جدید
            Drug newDrug = new Drug(txtName.Text, txtSazande.Text, txtTolid.Text, 
                txtEngeza.Text, Convert.ToInt32(txtValue.Text), txtCost.Text);

            MessageBox.Show(null,
                    "عملیات موفق آمیز بود", ""
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmDrug_Load(sender, e);
               
        }

        //ویرایش اطلاعات دارو
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Drug myDrug = new Drug();

            //اگر کد دارو را انتخاب نکرد
            if ( cmbCode.Text == "" )
            {
                MessageBox.Show(null,
                    "کد دارو را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //اگر عمل ویرایش موفقیت امیز بود
            if (myDrug.Edit(Convert.ToInt16( cmbCode.Text), txtName.Text, txtSazande.Text, 
                txtTolid.Text,txtEngeza.Text, Convert.ToInt32(txtValue.Text), txtCost.Text))
            {
                MessageBox.Show(null,
                         " اطلاعات دارو با موفقیت ویرایش شد ", ""
                         , MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else//اگر عمل ویرایش ناموفق بود
            {
                MessageBox.Show(null,
                         "کد دارو اشتباه است ", "خطا"
                         , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmDrug_Load(sender, e);
        }

        //جستجو
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Drug myDrug = new Drug();

            //اگر کاربر کد دارو را وارد نکرد
            if ( cmbCode.Text == "")
            {
                MessageBox.Show(null,
                    "کد دارو را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //اگر عمل جستجو موفقیت امیز بود
            if (myDrug.Search(Convert.ToInt16( cmbCode.Text)))
            {
                txtCost.Text = myDrug.Cost;
                txtEngeza.Text = myDrug.TarikhEngza;
                txtName.Text = myDrug.DrugName;
                txtSazande.Text = myDrug.SherkatTolid;
                txtTolid.Text = myDrug.TarikhTolid;
                txtValue.Text = myDrug.TedadMojod.ToString();
            }
            else//اگر ناموفق بود
            {
                MessageBox.Show(null,
                          "کد دارو اشتباه است ", "خطا"
                          , MessageBoxButtons.OK, MessageBoxIcon.Error);

                frmDrug_Load(sender, e);

            }
        }

        //حذف دارو
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Drug myDrug = new Drug();

            //اگر کاربر کد دارو را وارد نکند
            if ( cmbCode.Text == "")
            {
                MessageBox.Show(null,
                    "کد دارو را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //اگر عمل حذف موفقیت امیز بود
            if (myDrug.Delete(Convert.ToInt16( cmbCode.Text)))
            {
                MessageBox.Show(null,
                         "اطلاعات دارو با موفقیت حذف شد", ""
                         , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else//اگر ناموفق بود
            {
                MessageBox.Show(null,
                         "کد دارو اشتباه است ", "خطا"
                         , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmDrug_Load(sender, e);
        }

        //فرم بیمه
        private void toolStripBtnBimeh_Click(object sender, EventArgs e)
        {
            frmBimeh noskheForm = new frmBimeh();
            noskheForm.Show();
            this.Dispose();
        }

        //خروج از برنامه
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ServiceManager.Exit();
        }

    }
}
