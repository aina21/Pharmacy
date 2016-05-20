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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //وقتی پسورد را وارد میکند
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //اگر دکمه enter را زد
            if (e.KeyChar == 13)
            {
                //از کلاس کاربر یک شی جدید بگیرد
                User myUser = new User();

                //اگر اطلاعات صحیح بود
                if (myUser.CheckLogin(txtUserName.Text, txtPassword.Text))
                {
                    frmSick newForm = new frmSick();
                    newForm.Show();
                    this.Dispose();
                }
                else//اگر اشتباه بود
                {
                    MessageBox.Show(null,
                        "نام کاربری یا پسورد اشتباه است", "اخطار"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ServiceManager.Exit();
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
