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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        //اضافه کردن کاربر جدید
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //اگر نام کاربری را وارد نکرد
            if (txtName.Text == "" )
            {
                MessageBox.Show(null,
                    "نام کاربر را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                //اگر پسورد را وارد نکرد
            else if(txtPass.Text == "")
            {
                MessageBox.Show(null,
                    "پسورد را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                //اگر تکرار پسورد را وارد نکرد
            else if (txtRePass.Text == "")
            {
                MessageBox.Show(null,
                    "پسورد را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //اگر تکرار پسورد با پسورد یکی نبود
            if (txtPass.Text != txtRePass.Text)
                MessageBox.Show(null,
                    "پسورد را مجددا وارد نمایید","اخطار" 
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            else// اگر بود
            {
                User newUser = new User(txtName.Text, txtPass.Text);

                frmUser_Load(sender, e);

            }
            
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

        //فرم بیمار
        private void toolStripBtnSick_Click(object sender, EventArgs e)
        {
            frmSick sickForm = new frmSick();
            sickForm.Show();
            this.Dispose();
        }

        //حذف کاربر
        private void btnDelete_Click(object sender, EventArgs e)
        {
            User myUser = new User();

            //اگر نام کاربر را وارد نکرد
             if (txtName.Text == "" )
            {
                MessageBox.Show(null,
                    "نام کاربر را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                 //اگر پسورد را وارد نکرد
            else if(txtPass.Text == "")
            {
                MessageBox.Show(null,
                    "پسورد را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                 //اگر تکرار پسورد را وارد نکرد
            else if (txtRePass.Text == "")
            {
                MessageBox.Show(null,
                    "پسورد را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //اگر تکرار پسورد با پسورد یکی نبود
             if (txtPass.Text != txtRePass.Text)
                 MessageBox.Show(null,
                     "پسورد را مجددا وارد نمایید", "اخطار"
                     , MessageBoxButtons.OK, MessageBoxIcon.Error);
             else//اگر بود
             {
                 if (myUser.Delete(txtName.Text, txtPass.Text))
                 {
                     MessageBox.Show(null,
                         "کاربر با موفقیت حذف شد", ""
                         , MessageBoxButtons.OK, MessageBoxIcon.Information);

                     frmUser_Load(sender, e);
                 }
             }
        }

        //لود فرم
        private void frmUser_Load(object sender, EventArgs e)
        {
            txtRePass.Text = "";
            txtName.Text = "";
            txtPass.Text = "";
        }

        //فرم بیمه
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmBimeh noskheForm = new frmBimeh();
            noskheForm.Show();
            this.Dispose(); 
        }

        //خروج از برنامه
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ServiceManager.Exit();
        }

        private void toolStripBtnUser_Click(object sender, EventArgs e)
        {

        }
    }
}
