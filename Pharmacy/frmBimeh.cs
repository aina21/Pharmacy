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
    public partial class frmBimeh : Form
    {
        public frmBimeh()
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

        //فرم دارو
        private void toolStripBtnDrug_Click(object sender, EventArgs e)
        {
            frmDrug drugForm = new frmDrug();
            drugForm.Show();
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
        private void frmNoskhe_FormClosed(object sender, FormClosedEventArgs e)
        {
            ServiceManager.Exit();
        }

        //فرم نسخه
        private void toolStripBtnNoskhe_Click(object sender, EventArgs e)
        {
            frmNoskhe noskheForm = new frmNoskhe();
            noskheForm.Show();
            this.Dispose();
        }

        //اضافه کردن بیمه 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //اگر نام بیمه را وارد نکند
            if (txtName.Text == "")
            {
                MessageBox.Show(null,
                    "نام سازمان بیمه را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                //اگر درصد بیمه را وارد نکند
            else if (txtDarsad.Text == "")
            {
                MessageBox.Show(null,
                    "درصد بیمه را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                //اگر تاریخ اعتبار را وارد نکند
            else if (txtEtebar.Text == "")
            {
                MessageBox.Show(null,
                    "اعتبار را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //اضافه کردن اطلاعات بیمه جدید
           BimehClass newBimeh = new BimehClass(txtName.Text, txtDarsad.Text,txtEtebar.Text);

            MessageBox.Show(null,
                    "عملیات موفق آمیز بود", ""
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmBimeh_Load(sender, e);
         
        }

        //حذف بیمه
        private void btnDelete_Click(object sender, EventArgs e)
        {
            BimehClass myBimeh = new BimehClass();

            //اگر کد بیمه را وارد نکند
            if (cmbCode.Text == "")
            {
                MessageBox.Show(null,
                    "کد بیمه را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //اگر عمل حذف موفقیت امیز بود
            if (myBimeh.Delete(Convert.ToInt16(cmbCode.Text)))
            {
                MessageBox.Show(null,
                         "اطلاعات بیمه با موفقیت حذف شد", ""
                         , MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(null,
                         "کد بیمه اشتباه است ", "خطا"
                         , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            frmBimeh_Load(sender, e);
        }

        //جستجو
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BimehClass myBimeh = new BimehClass();

            //کد بیمه را وارد نکرد
            if (cmbCode.Text == "")
            {
                MessageBox.Show(null,
                    "کد بیمه را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //اگز جستجو موفقیت امیز بود
            if (myBimeh.Search(Convert.ToInt16(cmbCode.Text)))
            {
                txtEtebar.Text = myBimeh.TarikhEtebar;
                txtName.Text = myBimeh.NameSazman;
                txtDarsad.Text = myBimeh.DarsadBimeh;
            }
            else//اگر ناموفق بود
            {
                MessageBox.Show(null,
                         "کد بیمه اشتباه است ", "خطا"
                         , MessageBoxButtons.OK, MessageBoxIcon.Error);

                frmBimeh_Load(sender, e);
            }
        }

        //ویرایش اطلاعات بیمه
        private void btnEdit_Click(object sender, EventArgs e)
        {
            BimehClass myBimeh = new BimehClass();

            //اگر کاربر کد بیمه را وراد نکند
            if (cmbCode.Text == "")
            {
                MessageBox.Show(null,
                    "کد بیمه را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //اگر ویرایش اطلاعات موفیت امیز بود
            if (myBimeh.Edit(Convert.ToInt16(cmbCode.Text),
                txtName.Text, txtDarsad.Text, txtEtebar.Text))
            {
                MessageBox.Show(null,
                         " اطلاعات بیمه با موفقیت ویرایش شد ", ""
                         , MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else//اگر ناموفق بود
            {
                MessageBox.Show(null,
                         "کد بیمه اشتباه است ", "خطا"
                         , MessageBoxButtons.OK, MessageBoxIcon.Error);

                frmBimeh_Load(sender, e);
            }
        }

        //خروج از برنامه
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ServiceManager.Exit();
        }

        private void toolStripBtnBimeh_Click(object sender, EventArgs e)
        {

        }

        //لود شدن فرم
        private void frmBimeh_Load(object sender, EventArgs e)
        {
            BimehClass bime = new BimehClass();
            cmbCode.DataSource = bime.DB.Bimeh.ToList();
            
            cmbCode.DisplayMember = "code_bimeh";
            cmbCode.ValueMember = "code_bimeh";

            cmbCode.Text = "";
            txtDarsad.Text = "";
            txtEtebar.Text = "";
            txtName.Text = "";
        }

    }
}
