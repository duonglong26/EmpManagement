namespace EmpManagement
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFormSearchEmp = new System.Windows.Forms.Label();
            this.labelOpenEmployee = new System.Windows.Forms.Label();
            this.pictureOpenFormSearchEmp = new System.Windows.Forms.PictureBox();
            this.pictureOpenEmployee = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFormLogin = new MaterialSkin.Controls.MaterialButton();
            this.close = new System.Windows.Forms.Button();
            this.pictureChangePassword = new System.Windows.Forms.PictureBox();
            this.lbChangePassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenFormSearchEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChangePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbChangePassword);
            this.panel1.Controls.Add(this.pictureChangePassword);
            this.panel1.Controls.Add(this.openFormSearchEmp);
            this.panel1.Controls.Add(this.labelOpenEmployee);
            this.panel1.Controls.Add(this.pictureOpenFormSearchEmp);
            this.panel1.Controls.Add(this.pictureOpenEmployee);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 265);
            this.panel1.TabIndex = 3;
            // 
            // openFormSearchEmp
            // 
            this.openFormSearchEmp.AutoSize = true;
            this.openFormSearchEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFormSearchEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFormSearchEmp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.openFormSearchEmp.Location = new System.Drawing.Point(356, 193);
            this.openFormSearchEmp.Name = "openFormSearchEmp";
            this.openFormSearchEmp.Size = new System.Drawing.Size(70, 24);
            this.openFormSearchEmp.TabIndex = 10;
            this.openFormSearchEmp.Text = "Search";
            this.openFormSearchEmp.Click += new System.EventHandler(this.openFormSearchEmp_Click);
            // 
            // labelOpenEmployee
            // 
            this.labelOpenEmployee.AutoSize = true;
            this.labelOpenEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelOpenEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenEmployee.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelOpenEmployee.Location = new System.Drawing.Point(180, 193);
            this.labelOpenEmployee.Name = "labelOpenEmployee";
            this.labelOpenEmployee.Size = new System.Drawing.Size(96, 24);
            this.labelOpenEmployee.TabIndex = 9;
            this.labelOpenEmployee.Text = "Employee";
            this.labelOpenEmployee.Click += new System.EventHandler(this.labelOpenEmployee_Click);
            // 
            // pictureOpenFormSearchEmp
            // 
            this.pictureOpenFormSearchEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureOpenFormSearchEmp.Image = ((System.Drawing.Image)(resources.GetObject("pictureOpenFormSearchEmp.Image")));
            this.pictureOpenFormSearchEmp.Location = new System.Drawing.Point(340, 66);
            this.pictureOpenFormSearchEmp.Name = "pictureOpenFormSearchEmp";
            this.pictureOpenFormSearchEmp.Size = new System.Drawing.Size(99, 124);
            this.pictureOpenFormSearchEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureOpenFormSearchEmp.TabIndex = 7;
            this.pictureOpenFormSearchEmp.TabStop = false;
            this.pictureOpenFormSearchEmp.Click += new System.EventHandler(this.pictureOpenFormSearchEmp_Click);
            // 
            // pictureOpenEmployee
            // 
            this.pictureOpenEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureOpenEmployee.Image = ((System.Drawing.Image)(resources.GetObject("pictureOpenEmployee.Image")));
            this.pictureOpenEmployee.Location = new System.Drawing.Point(177, 66);
            this.pictureOpenEmployee.Name = "pictureOpenEmployee";
            this.pictureOpenEmployee.Size = new System.Drawing.Size(99, 124);
            this.pictureOpenEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureOpenEmployee.TabIndex = 6;
            this.pictureOpenEmployee.TabStop = false;
            this.pictureOpenEmployee.Click += new System.EventHandler(this.pictureOpenEmployee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(355, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "EmpiSoft";
            // 
            // openFormLogin
            // 
            this.openFormLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openFormLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFormLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.openFormLogin.Depth = 0;
            this.openFormLogin.HighEmphasis = true;
            this.openFormLogin.Icon = null;
            this.openFormLogin.Location = new System.Drawing.Point(709, 384);
            this.openFormLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openFormLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.openFormLogin.Name = "openFormLogin";
            this.openFormLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.openFormLogin.Size = new System.Drawing.Size(78, 36);
            this.openFormLogin.TabIndex = 4;
            this.openFormLogin.Text = "Logout";
            this.openFormLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.openFormLogin.UseAccentColor = false;
            this.openFormLogin.UseVisualStyleBackColor = true;
            this.openFormLogin.Click += new System.EventHandler(this.openFormLogin_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.White;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close.Location = new System.Drawing.Point(770, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.TabIndex = 5;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureChangePassword
            // 
            this.pictureChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureChangePassword.Image")));
            this.pictureChangePassword.Location = new System.Drawing.Point(531, 66);
            this.pictureChangePassword.Name = "pictureChangePassword";
            this.pictureChangePassword.Size = new System.Drawing.Size(99, 124);
            this.pictureChangePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureChangePassword.TabIndex = 11;
            this.pictureChangePassword.TabStop = false;
            this.pictureChangePassword.Click += new System.EventHandler(this.pictureChangePassword_Click);
            // 
            // lbChangePassword
            // 
            this.lbChangePassword.AutoSize = true;
            this.lbChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChangePassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbChangePassword.Location = new System.Drawing.Point(494, 193);
            this.lbChangePassword.Name = "lbChangePassword";
            this.lbChangePassword.Size = new System.Drawing.Size(164, 24);
            this.lbChangePassword.TabIndex = 12;
            this.lbChangePassword.Text = "Change Password";
            this.lbChangePassword.Click += new System.EventHandler(this.lbChangePassword_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.close);
            this.Controls.Add(this.openFormLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenFormSearchEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpenEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChangePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton openFormLogin;
        private System.Windows.Forms.PictureBox pictureOpenFormSearchEmp;
        private System.Windows.Forms.PictureBox pictureOpenEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label openFormSearchEmp;
        private System.Windows.Forms.Label labelOpenEmployee;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label lbChangePassword;
        private System.Windows.Forms.PictureBox pictureChangePassword;
    }
}