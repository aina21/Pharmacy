using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DaroKhane.DataAccess;

namespace DaroKhane
{
    public partial class frmNoskhe : Form
    {

        public frmNoskhe()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //اضافه کردن نسخه جدید
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //اگر کد نسخه را کاربر وارد نکرد
             if (cmbBimar.Text == "")
            {
                MessageBox.Show(null,
                    "کد بیمار را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                 //اگر کد بیمه را کاربر وارد نکرد
            else if (cmbBimeh.Text == "")
            {
                MessageBox.Show(null,
                    "کد بیمه را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            //اطلاعات کامل وارد شده یک رکورد جدید ایجاد کند
           NoskheClass newNoskhe = new NoskheClass(Convert.ToInt32( cmbBimeh.SelectedValue),Convert.ToInt32( cmbBimar.SelectedValue));

            MessageBox.Show(null,
                    "عملیات موفق آمیز بود", ""
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

            //فرم مجدد لود شود
            frmNoskhe_Load(sender, e);

        }

        private void frmNoskhe_Load(object sender, EventArgs e)
        {
            //کد بیمار 
            Sick bimar = new Sick();
            cmbBimar.DataSource = bimar.DB.Bimar.ToList();
            cmbBimar.DisplayMember = "name_bimar";
            cmbBimar.ValueMember = "code_bimar";

            //کد دارو
            Drug daroo = new Drug();
            cmbDaroo.DataSource = daroo.DB.Daroo.ToList();
            cmbDaroo.DisplayMember = "name_daroo";
            cmbDaroo.ValueMember = "code_daroo";

            //کد بیمه
            BimehClass bime = new BimehClass();
            cmbBimeh.DataSource = bime.DB.Bimeh.ToList();
            cmbBimeh.DisplayMember = "nameSazman_bimeh";
            cmbBimeh.ValueMember = "code_bimeh";

            // کد نسخه
            NoskheClass noskhe = new NoskheClass();
            cmbCode.DataSource = noskhe.DB.Noskhe.ToList();
            cmbCode.DisplayMember = "code_noskhe";
            cmbCode.ValueMember = "code_noskhe";

            //
            cmbBimar.Text = "";
            cmbBimeh.Text = "";
            cmbCode.Text = "";
            cmbDaroo.Text = "";
            txtValue.Text = "";


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

        //فرم بیمه
        private void toolStripBtnBimeh_Click(object sender, EventArgs e)
        {
            frmBimeh bimehForm = new frmBimeh();
            bimehForm.Show();
            this.Dispose();
        }

        //فرم کاربر
        private void toolStripBtnUser_Click(object sender, EventArgs e)
        {
            frmUser userForm = new frmUser();
            userForm.Show();
            this.Dispose();
        }

        //جستجو 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //ایجاد یک شی از کلاس نسخه
            NoskheClass myNoskhe = new NoskheClass();

            //اگرکاربر کد نسخه را وارد نکرد
            if (cmbCode.Text == "")
            {
                MessageBox.Show(null,
                    "کد نسخه را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // اگر عمل جستجو موفقیت امیز بود
            if (myNoskhe.Search(Convert.ToInt16(cmbCode.Text)))
            {
                cmbBimar.Text = myNoskhe.CodeSick.ToString();
                cmbBimeh.Text = myNoskhe.CodeBimeh.ToString();

            }
            else//اگر جستجو ناموفق بود
            {
                MessageBox.Show(null,
                         "کد نسخه اشتباه است ", "خطا"
                         , MessageBoxButtons.OK, MessageBoxIcon.Error);

                frmNoskhe_Load(sender, e);
            }
        }

        //ویرایش
        private void btnEdit_Click(object sender, EventArgs e)
        {
            NoskheClass myNoskhe = new NoskheClass();

            //اگر کاربر کد را وارد نکند
            if (cmbCode.Text == "")
            {
                MessageBox.Show(null,
                    "کد نسخه را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //اگر عمل ویرایش موفقیت امیز بود
            if (myNoskhe.Edit(Convert.ToInt16(cmbCode.Text),
                Convert.ToInt32( cmbBimeh.SelectedValue),
                Convert.ToInt32( cmbBimar.SelectedValue)))
            {
                MessageBox.Show(null,
                         " اطلاعات نسخه با موفقیت ویرایش شد ", ""
                         , MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else// اگر ناموفق بود
            {
                MessageBox.Show(null,
                         "کد نسخه اشتباه است ", "خطا"
                         , MessageBoxButtons.OK, MessageBoxIcon.Error);

                frmNoskhe_Load(sender, e);
            }
        }

        //حذف 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            NoskheClass myNoskhe = new NoskheClass();

            //اگر کاربر کد نسخه را وارد نکند
            if (cmbCode.Text == "")
            {
                MessageBox.Show(null,
                    "کد نسخه را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //اگر عمل حذف موفقیت امیز بود
            if (myNoskhe.Delete(Convert.ToInt16(cmbCode.Text)))
            {
                MessageBox.Show(null,
                         "اطلاعات نسخه با موفقیت حذف شد", ""
                         , MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else//اگر عمل حذف ناموفق بود
            {
                MessageBox.Show(null,
                         "کد نسخه اشتباه است ", "خطا"
                         , MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmNoskhe_Load(sender, e);
            }
        }

        //اضافه کردن اقلام نسخه
        private void btnAddList_Click(object sender, EventArgs e)
        {
            //اگر کاربر کد دارو را وارد نکرد
            if (cmbDaroo.Text == "")
            {
                MessageBox.Show(null,
                    "دارو را انتخاب کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                //اگر مقدار را وارد نکرد
            else if (txtValue.Text == "")
            {
                MessageBox.Show(null,
                    "تعداد را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                //اگر کد نسخه را مشخص نکرد
            else if (cmbCode.Text == "")
            {
                MessageBox.Show(null,
                    "کد نسخه را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //ایجاد رکورد جدید
            ListNoskhe newNoskhe = new ListNoskhe(Convert.ToInt32(cmbCode.Text), Convert.ToInt32(cmbDaroo.SelectedValue), Convert.ToInt32(txtValue.Text));

            frmNoskhe_Load(sender, e);
        }

        //ویرایش اقلام نسخه
        private void btnEditList_Click(object sender, EventArgs e)
        {
            ListNoskhe myNoskhe = new ListNoskhe();
            //اگر کاربر کد را وارد نکرد
            if (cmbCode.Text == "")
            {
                MessageBox.Show(null,
                    "کد نسخه را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                // اگر کاربر دارو را مشخص نکرد
            else if(cmbDaroo.Text == "")
             {
                MessageBox.Show(null,
                    "دارو را انتخاب کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //اگر ویرایش موفقیت امیز بود
            if (myNoskhe.Edit(Convert.ToInt16(cmbCode.Text),
                Convert.ToInt32(cmbDaroo.SelectedValue),
                Convert.ToInt32(txtValue.Text)))
            {
                MessageBox.Show(null,
                         " اطلاعات نسخه با موفقیت ویرایش شد ", ""
                         , MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else//اگر ویرایش ناموفق بود
            {
                MessageBox.Show(null,
                         "اشتباه است ", "خطا"
                         , MessageBoxButtons.OK, MessageBoxIcon.Error);

                frmNoskhe_Load(sender, e);
            }
        }

        //حذف اقلام نسخه
        private void btnDeleteList_Click(object sender, EventArgs e)
        {
            ListNoskhe myNoskhe = new ListNoskhe();
            //اگر کاربر کد نسخه را وارد نکرد
            if (cmbCode.Text == "")
            {
                MessageBox.Show(null,
                    "کد نسخه را وارد کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                //اگر کاربر کد دارو را وارد نکرد
            else if (cmbDaroo.Text == "")
            {
                MessageBox.Show(null,
                    "دارو را انتخاب کنید", "اخطار"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //اگر عمل حذف با موفقیت انجام شود
            if (myNoskhe.Delete(Convert.ToInt16(cmbCode.Text),
                Convert.ToInt32(cmbDaroo.SelectedValue)))
            {
                MessageBox.Show(null,
                         " اطلاعات نسخه با موفقیت ویرایش شد ", ""
                         , MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                frmNoskhe_Load(sender, e);
            }
            else//اگر عمل حذف با موفقیت انجام نشود
            {
                MessageBox.Show(null,
                         "اشتباه است ", "خطا"
                         , MessageBoxButtons.OK, MessageBoxIcon.Error);

                frmNoskhe_Load(sender, e);
            }
        }

        //خروج از برنامه
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ServiceManager.Exit();
        }
    }
}
