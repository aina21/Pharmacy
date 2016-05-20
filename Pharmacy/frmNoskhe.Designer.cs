namespace DaroKhane
{
    partial class frmNoskhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNoskhe));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSick = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnDrug = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBimeh = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnNoskhe = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBimeh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBimar = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditList = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDaroo = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbCode = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.toolStripBtnDrug.ToolTipText = "اطلاعات دارو";
            this.toolStripBtnDrug.Click += new System.EventHandler(this.toolStripBtnDrug_Click);
            // 
            // toolStripBtnBimeh
            // 
            this.toolStripBtnBimeh.AutoSize = false;
            this.toolStripBtnBimeh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.toolStripBtnNoskhe.Enabled = false;
            this.toolStripBtnNoskhe.Image = global::DaroKhane.Properties.Resources.Wipes;
            this.toolStripBtnNoskhe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnNoskhe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNoskhe.Name = "toolStripBtnNoskhe";
            this.toolStripBtnNoskhe.Size = new System.Drawing.Size(64, 64);
            this.toolStripBtnNoskhe.ToolTipText = "اطلاعات نسخه";
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
            this.toolStripBtnUser.ToolTipText = "اطلاعات کاربر";
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
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "کد نسخه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "کد بیمار";
            // 
            // cmbBimeh
            // 
            this.cmbBimeh.FormattingEnabled = true;
            this.cmbBimeh.Location = new System.Drawing.Point(434, 134);
            this.cmbBimeh.Name = "cmbBimeh";
            this.cmbBimeh.Size = new System.Drawing.Size(214, 32);
            this.cmbBimeh.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(372, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "کد بیمه";
            // 
            // cmbBimar
            // 
            this.cmbBimar.FormattingEnabled = true;
            this.cmbBimar.Location = new System.Drawing.Point(80, 136);
            this.cmbBimar.Name = "cmbBimar";
            this.cmbBimar.Size = new System.Drawing.Size(214, 32);
            this.cmbBimar.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditList);
            this.groupBox2.Controls.Add(this.btnAddList);
            this.groupBox2.Controls.Add(this.txtValue);
            this.groupBox2.Controls.Add(this.btnDeleteList);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbDaroo);
            this.groupBox2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(80, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 107);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اقلام نسخه";
            // 
            // btnEditList
            // 
            this.btnEditList.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditList.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditList.Image = ((System.Drawing.Image)(resources.GetObject("btnEditList.Image")));
            this.btnEditList.Location = new System.Drawing.Point(40, 19);
            this.btnEditList.Name = "btnEditList";
            this.btnEditList.Size = new System.Drawing.Size(34, 31);
            this.btnEditList.TabIndex = 3;
            this.btnEditList.UseVisualStyleBackColor = false;
            this.btnEditList.Click += new System.EventHandler(this.btnEditList_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddList.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddList.Image = global::DaroKhane.Properties.Resources.Add;
            this.btnAddList.Location = new System.Drawing.Point(80, 19);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(34, 31);
            this.btnAddList.TabIndex = 2;
            this.btnAddList.UseVisualStyleBackColor = false;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtValue.Location = new System.Drawing.Point(263, 64);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(174, 31);
            this.txtValue.TabIndex = 1;
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteList.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteList.Image = global::DaroKhane.Properties.Resources.Delete;
            this.btnDeleteList.Location = new System.Drawing.Point(4, 19);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(34, 31);
            this.btnDeleteList.TabIndex = 4;
            this.btnDeleteList.UseVisualStyleBackColor = false;
            this.btnDeleteList.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(443, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "تعداد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(443, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "کد دارو";
            // 
            // cmbDaroo
            // 
            this.cmbDaroo.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbDaroo.FormattingEnabled = true;
            this.cmbDaroo.Location = new System.Drawing.Point(263, 24);
            this.cmbDaroo.Name = "cmbDaroo";
            this.cmbDaroo.Size = new System.Drawing.Size(174, 32);
            this.cmbDaroo.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(574, 79);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(34, 31);
            this.btnEdit.TabIndex = 5;
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
            this.btnAdd.Location = new System.Drawing.Point(538, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 31);
            this.btnAdd.TabIndex = 4;
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
            this.btnDelete.Location = new System.Drawing.Point(614, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(34, 31);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbCode
            // 
            this.cmbCode.FormattingEnabled = true;
            this.cmbCode.Location = new System.Drawing.Point(80, 91);
            this.cmbCode.Name = "cmbCode";
            this.cmbCode.Size = new System.Drawing.Size(214, 32);
            this.cmbCode.TabIndex = 19;
            // 
            // frmNoskhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 321);
            this.Controls.Add(this.cmbCode);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbBimar);
            this.Controls.Add(this.cmbBimeh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximizeBox = false;
            this.Name = "frmNoskhe";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات نسخه";
            this.Load += new System.EventHandler(this.frmNoskhe_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton toolStripBtnBimeh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBimeh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBimar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDaroo;
        private System.Windows.Forms.Button btnEditList;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ComboBox cmbCode;
    }
}