namespace Asrfly.Gui.GuiHome
{
    partial class HomeUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddInput = new System.Windows.Forms.Button();
            this.buttonAddOutput = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonAddProject = new System.Windows.Forms.Button();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 177);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Image = global::Asrfly.Properties.Resources.icons8_smart_144;
            this.pictureBox2.Location = new System.Drawing.Point(462, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.buttonAddInput);
            this.groupBox1.Controls.Add(this.buttonAddOutput);
            this.groupBox1.Controls.Add(this.buttonAddUser);
            this.groupBox1.Controls.Add(this.buttonAddProject);
            this.groupBox1.Controls.Add(this.buttonAddSupplier);
            this.groupBox1.Controls.Add(this.buttonAddCustomer);
            this.groupBox1.Controls.Add(this.buttonAddCategory);
            this.groupBox1.Location = new System.Drawing.Point(148, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافة";
            // 
            // buttonAddInput
            // 
            this.buttonAddInput.Image = global::Asrfly.Properties.Resources.icons8_receive_cash_32px;
            this.buttonAddInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddInput.Location = new System.Drawing.Point(30, 26);
            this.buttonAddInput.Name = "buttonAddInput";
            this.buttonAddInput.Padding = new System.Windows.Forms.Padding(5);
            this.buttonAddInput.Size = new System.Drawing.Size(124, 48);
            this.buttonAddInput.TabIndex = 1;
            this.buttonAddInput.Text = "قبض";
            this.buttonAddInput.UseVisualStyleBackColor = true;
            // 
            // buttonAddOutput
            // 
            this.buttonAddOutput.Image = global::Asrfly.Properties.Resources.icons8_payroll_32px;
            this.buttonAddOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddOutput.Location = new System.Drawing.Point(160, 26);
            this.buttonAddOutput.Name = "buttonAddOutput";
            this.buttonAddOutput.Padding = new System.Windows.Forms.Padding(5);
            this.buttonAddOutput.Size = new System.Drawing.Size(124, 48);
            this.buttonAddOutput.TabIndex = 1;
            this.buttonAddOutput.Text = "صرف";
            this.buttonAddOutput.UseVisualStyleBackColor = true;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Image = global::Asrfly.Properties.Resources.icons8_team_32px_1;
            this.buttonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddUser.Location = new System.Drawing.Point(290, 26);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Padding = new System.Windows.Forms.Padding(5);
            this.buttonAddUser.Size = new System.Drawing.Size(124, 48);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "       مستخدم";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonAddProject
            // 
            this.buttonAddProject.Image = global::Asrfly.Properties.Resources.icons8_microsoft_project_32px_2;
            this.buttonAddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddProject.Location = new System.Drawing.Point(420, 26);
            this.buttonAddProject.Name = "buttonAddProject";
            this.buttonAddProject.Padding = new System.Windows.Forms.Padding(5);
            this.buttonAddProject.Size = new System.Drawing.Size(124, 48);
            this.buttonAddProject.TabIndex = 1;
            this.buttonAddProject.Text = "       مشروع";
            this.buttonAddProject.UseVisualStyleBackColor = true;
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.Image = global::Asrfly.Properties.Resources.icons8_people_32px_2;
            this.buttonAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddSupplier.Location = new System.Drawing.Point(550, 26);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Padding = new System.Windows.Forms.Padding(5);
            this.buttonAddSupplier.Size = new System.Drawing.Size(124, 48);
            this.buttonAddSupplier.TabIndex = 1;
            this.buttonAddSupplier.Text = "مورد";
            this.buttonAddSupplier.UseVisualStyleBackColor = true;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Image = global::Asrfly.Properties.Resources.icons8_people_32px_3;
            this.buttonAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddCustomer.Location = new System.Drawing.Point(680, 26);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Padding = new System.Windows.Forms.Padding(5);
            this.buttonAddCustomer.Size = new System.Drawing.Size(124, 48);
            this.buttonAddCustomer.TabIndex = 1;
            this.buttonAddCustomer.Text = "عميل";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Image = global::Asrfly.Properties.Resources.icons8_categorize_32px_1;
            this.buttonAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddCategory.Location = new System.Drawing.Point(810, 26);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Padding = new System.Windows.Forms.Padding(5);
            this.buttonAddCategory.Size = new System.Drawing.Size(124, 48);
            this.buttonAddCategory.TabIndex = 1;
            this.buttonAddCategory.Text = "صنف";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LBC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(561, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "الوصول السريع";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxLogo.Image = global::Asrfly.Properties.Resources.icons8_smart_144;
            this.pictureBoxLogo.Location = new System.Drawing.Point(304, 21);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 106);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBoxLogo);
            this.panel2.Controls.Add(this.labelCompanyName);
            this.panel2.Location = new System.Drawing.Point(798, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 134);
            this.panel2.TabIndex = 1;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("LBC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCompanyName.Location = new System.Drawing.Point(61, 53);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(191, 45);
            this.labelCompanyName.TabIndex = 0;
            this.labelCompanyName.Text = "قناة تكنو U";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("LBC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.Location = new System.Drawing.Point(59, 59);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(149, 54);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "مرحبا بك مجددا\r\n صفاء جاسم";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWelcome.Click += new System.EventHandler(this.label3_Click);
            // 
            // HomeUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeUserControl1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1264, 613);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonAddInput;
        private System.Windows.Forms.Button buttonAddOutput;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonAddProject;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
