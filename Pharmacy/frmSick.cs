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
    public partial class frmSick : Form
    {
        public frmSick()
        {
            InitializeComponent();
        }

        //فرم دارو
        private void toolStripBtnDrug_Click(object sender, EventArgs e)
        {
            frmDrug drugForm = new frmDrug();
            drugForm.Show();
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

        private void frmSick_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void toolStripBtnSick_Click(object sender, EventArgs e)
        {

        }

        //اضاف کردن بیمار 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //اگر کاربر نام بیمار را وارد نکند
            if (txtName.Text == "")
            {
                MessageBox.Show(null,
                    "نام بیمار را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                //اگر کاربر کد ملی بیمار را وارد نکند
            else if (txtMelliCod.Text == "")
            {
                MessageBox.Show(null,
                    "کد ملی بیمار را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //ایجاد بیمار جدید
            Sick newSick = new Sick(txtName.Text,txtMelliCod.Text);

            MessageBox.Show(null,
                    "عملیات موفق آمیز بود", ""
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmSick_Load(sender, e);
        }

        //حذف بیمار
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Sick mySick = new Sick();
            //اگر کاربر کد بیمار را وارد نکند
            if (cmbCode.Text == "")
            {
                MessageBox.Show(null,
                    "کد بیمار را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //اگر عمل حذف موفق امیز بود
            if (mySick.Delete(Convert.ToInt16(cmbCode.Text)))
            {
                MessageBox.Show(null,
                         "اطلاعات بیمار با موفقیت حذف شد", ""
                         , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else//اگر موفق امیز نبود
            {
                MessageBox.Show(null,
                         "کد بیمار اشتباه است ", "خطا"
                         , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmSick_Load(sender, e);
        }

        //جستجو
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Sick mySick = new Sick();

            //اگر کاربر کد بیمار را وارد نکند
            if (cmbCode.Text == "")
            {
                MessageBox.Show(null,
                    "کد بیمار را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //اگر جستجو موفقیت امیز بود
            if (mySick.Search(Convert.ToInt16(cmbCode.Text)))
            {
                txtMelliCod.Text = mySick.MelliCode;
                txtName.Text = mySick.Name;
            }
            else//اگر موفقیت امیز نبود
            {
                MessageBox.Show(null,
                         "کد بیمار اشتباه است ", "خطا"
                         , MessageBoxButtons.OK, MessageBoxIcon.Error);

                cmbCode.Text = "";
                txtName.Text = "";
                txtMelliCod.Text = "";

            }
        }

        //ویرایش اطلاعات بیمار
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Sick mySick = new Sick();

            //اگر کاربر کد بیمار را وارد نکند
            if (cmbCode.Text == "")
            {
                MessageBox.Show(null,
                    "کد بیمار را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //اگر ویرایش اطلاعات با موفقیت انجام شد
            if (mySick.Edit(Convert.ToInt16(cmbCode.Text), txtName.Text, txtMelliCod.Text))
            {
                MessageBox.Show(null,
                         " اطلاعات بیمار با موفقیت ویرایش شد ", ""
                         , MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else//اگر موفقیت امیز نبود
            {
                MessageBox.Show(null,
                         "کد بیمار اشتباه است ", "خطا"
                         , MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmSick_Load(sender, e);
            }

        }

        //فرم بیمه
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmBimeh userForm = new frmBimeh();
            userForm.Show();
            this.Dispose();
        }

        //خروج از برنامه
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ServiceManager.Exit();
        }

        //لود شدن فرم
        private void frmSick_Load(object sender, EventArgs e)
        {
            //ایجاد شی جدید از کلاس بیمار
            Sick sick = new Sick();
            cmbCode.DataSource = sick.DB.Bimar.ToList();

            cmbCode.DisplayMember = "code_bimar";
            cmbCode.ValueMember = "code_bimar";

            cmbCode.Text = "";
            txtMelliCod.Text = "";
            txtName.Text = "";
        }
    }
}
