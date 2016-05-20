namespace DaroKhane
{
    partial class frmBimeh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBimeh));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSick = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDrug = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBimeh = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnNoskhe = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEtebar = new System.Windows.Forms.TextBox();
            this.txtDarsad = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbCode = new System.Windows.Forms.ComboBox();
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
            this.toolStripBtnBimeh,
            this.toolStripBtnNoskhe,
            this.toolStripBtnUser,
            this.toolStripButton1});
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
            this.toolStripBtnDrug.Click += new System.EventHandler(this.toolStripBtnDrug_Click);
            // 
            // toolStripBtnBimeh
            // 
            this.toolStripBtnBimeh.AutoSize = false;
            this.toolStripBtnBimeh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnBimeh.Enabled = false;
            this.toolStripBtnBimeh.Image = global::DaroKhane.Properties.Resources.Bimeh;
            this.toolStripBtnBimeh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnBimeh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBimeh.Name = "toolStripBtnBimeh";
            this.toolStripBtnBimeh.Size = new System.Drawing.Size(64, 64);
            this.toolStripBtnBimeh.ToolTipText = "اطلاعات بیمه";
            this.toolStripBtnBimeh.Click += new System.EventHandler(this.toolStripBtnBimeh_Click);
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
            this.toolStripBtnNoskhe.Click += new System.EventHandler(this.toolStripBtnNoskhe_Click);
            // 
            // toolStripBtnUser
            // 
            this.toolStripBtnUser.AutoSize = false;
            this.toolStripBtnUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnUser.Image = global::DaroKhane.Properties.Resources.Users;
            this.toolStripBtnUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnUser.Name = "toolStripBtnUser";
            this.toolStripBtnUser.Size = new System.Drawing.Size(64, 64);
            this.toolStripBtnUser.Click += new System.EventHandler(this.toolStripBtnUser_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::DaroKhane.Properties.Resources.Close;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "خروج از برنامه";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(20, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "کد بیمه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(5, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام سازمان";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(5, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "درصد بیمه";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(5, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "تاریخ اعتبار";
            // 
            // txtEtebar
            // 
            this.txtEtebar.Location = new System.Drawing.Point(81, 200);
            this.txtEtebar.Name = "txtEtebar";
            this.txtEtebar.Size = new System.Drawing.Size(580, 31);
            this.txtEtebar.TabIndex = 4;
            // 
            // txtDarsad
            // 
            this.txtDarsad.Location = new System.Drawing.Point(79, 163);
            this.txtDarsad.Name = "txtDarsad";
            this.txtDarsad.Size = new System.Drawing.Size(580, 31);
            this.txtDarsad.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 126);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(580, 31);
            this.txtName.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(585, 89);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(34, 31);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Image = global::DaroKhane.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(545, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 31);
            this.btnAdd.TabIndex = 5;
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
            this.btnDelete.Location = new System.Drawing.Point(625, 89);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(34, 31);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Image = global::DaroKhane.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(264, 89);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 31);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbCode
            // 
            this.cmbCode.FormattingEnabled = true;
            this.cmbCode.Location = new System.Drawing.Point(80, 88);
            this.cmbCode.Name = "cmbCode";
            this.cmbCode.Size = new System.Drawing.Size(179, 32);
            this.cmbCode.TabIndex = 9;
            // 
            // frmBimeh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 321);
            this.Controls.Add(this.cmbCode);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDarsad);
            this.Controls.Add(this.txtEtebar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "frmBimeh";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات بیمه";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNoskhe_FormClosed);
            this.Load += new System.EventHandler(this.frmBimeh_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEtebar;
        private System.Windows.Forms.TextBox txtDarsad;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripButton toolStripBtnBimeh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ComboBox cmbCode;
    }
}