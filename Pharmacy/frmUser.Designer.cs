namespace DaroKhane
{
    partial class frmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSick = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDrug = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnNoskhe = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSick,
            this.toolStripBtnDrug,
            this.toolStripButton1,
            this.toolStripBtnNoskhe,
            this.toolStripBtnUser,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(673, 75);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnSick
            // 
            this.toolStripBtnSick.AutoSize = false;
            this.toolStripBtnSick.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSick.Image = global::DaroKhane.Properties.Resources.bandage;
            this.toolStripBtnSick.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSick.Name = "toolStripBtnSick";
            this.toolStripBtnSick.Size = new System.Drawing.Size(64, 64);
            this.toolStripBtnSick.Text = "toolStripButton1";
            this.toolStripBtnSick.ToolTipText = "اطلاعات بیمار";
            this.toolStripBtnSick.Click += new System.EventHandler(this.toolStripBtnSick_Click);
            // 
            // toolStripBtnDrug
            // 
            this.toolStripBtnDrug.AutoSize = false;
            this.toolStripBtnDrug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnDrug.Image = global::DaroKhane.Properties.Resources.Pill;
            this.toolStripBtnDrug.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnDrug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDrug.Name = "toolStripBtnDrug";
            this.toolStripBtnDrug.Size = new System.Drawing.Size(64, 64);
            this.toolStripBtnDrug.Text = "toolStripButton1";
            this.toolStripBtnDrug.ToolTipText = "اطلاعات دارو";
            this.toolStripBtnDrug.Click += new System.EventHandler(this.toolStripBtnDrug_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::DaroKhane.Properties.Resources.Bimeh;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "اطلاعات بیمه";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripBtnNoskhe
            // 
            this.toolStripBtnNoskhe.AutoSize = false;
            this.toolStripBtnNoskhe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnNoskhe.Image = global::DaroKhane.Properties.Resources.Wipes;
            this.toolStripBtnNoskhe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnNoskhe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNoskhe.Name = "toolStripBtnNoskhe";
            this.toolStripBtnNoskhe.Size = new System.Drawing.Size(64, 64);
            this.toolStripBtnNoskhe.Text = "toolStripButton2";
            this.toolStripBtnNoskhe.ToolTipText = "اطلاعات نسخه";
            this.toolStripBtnNoskhe.Click += new System.EventHandler(this.toolStripBtnNoskhe_Click);
            // 
            // toolStripBtnUser
            // 
            this.toolStripBtnUser.AutoSize = false;
            this.toolStripBtnUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnUser.Enabled = false;
            this.toolStripBtnUser.Image = global::DaroKhane.Properties.Resources.Users;
            this.toolStripBtnUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnUser.Name = "toolStripBtnUser";
            this.toolStripBtnUser.Size = new System.Drawing.Size(64, 64);
            this.toolStripBtnUser.Text = "toolStripButton3";
            this.toolStripBtnUser.ToolTipText = "اطلاعات کاربری";
            this.toolStripBtnUser.Click += new System.EventHandler(this.toolStripBtnUser_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::DaroKhane.Properties.Resources.Close;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton2.Text = "toolStripButton1";
            this.toolStripButton2.ToolTipText = "خروج از برنامه";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام کاربر";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(11, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "رمز ورود";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(8, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "تکرار رمز";
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(80, 163);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.PasswordChar = '*';
            this.txtRePass.Size = new System.Drawing.Size(577, 31);
            this.txtRePass.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(80, 126);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(577, 31);
            this.txtPass.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 31);
            this.txtName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Image = global::DaroKhane.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(583, 86);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Image = global::DaroKhane.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(623, 86);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(34, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 321);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtRePass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "frmUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات بیمار";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnSick;
        private System.Windows.Forms.ToolStripButton toolStripBtnDrug;
        private System.Windows.Forms.ToolStripButton toolStripBtnNoskhe;
        private System.Windows.Forms.ToolStripButton toolStripBtnUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}