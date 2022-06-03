namespace EmpManagement
{
    partial class FormForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgotPassword));
            this.backToLogin = new System.Windows.Forms.PictureBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.close = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetCodeResetPw = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.backToLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // backToLogin
            // 
            this.backToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToLogin.Image = ((System.Drawing.Image)(resources.GetObject("backToLogin.Image")));
            this.backToLogin.Location = new System.Drawing.Point(0, -1);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(34, 39);
            this.backToLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backToLogin.TabIndex = 15;
            this.backToLogin.TabStop = false;
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.AllowPromptAsInput = true;
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.AsciiOnly = false;
            this.txtUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsername.BeepOnError = false;
            this.txtUsername.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.HidePromptOnLeave = false;
            this.txtUsername.HideSelection = true;
            this.txtUsername.Hint = "Username";
            this.txtUsername.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(164, 66);
            this.txtUsername.Mask = "";
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PrefixSuffixText = null;
            this.txtUsername.PromptChar = '_';
            this.txtUsername.ReadOnly = false;
            this.txtUsername.RejectInputOnFirstFailure = false;
            this.txtUsername.ResetOnPrompt = true;
            this.txtUsername.ResetOnSpace = true;
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(375, 48);
            this.txtUsername.SkipLiterals = true;
            this.txtUsername.TabIndex = 16;
            this.txtUsername.TabStop = false;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtUsername.TrailingIcon = null;
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.ValidatingType = null;
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.White;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close.Location = new System.Drawing.Point(694, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.TabIndex = 17;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 226);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(1, 0);
            this.materialLabel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "*Note: Fill your \"Username\" and click the button to get code reset password.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 20;
            // 
            // btnGetCodeResetPw
            // 
            this.btnGetCodeResetPw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnGetCodeResetPw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetCodeResetPw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetCodeResetPw.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGetCodeResetPw.Depth = 0;
            this.btnGetCodeResetPw.HighEmphasis = true;
            this.btnGetCodeResetPw.Icon = null;
            this.btnGetCodeResetPw.Location = new System.Drawing.Point(314, 147);
            this.btnGetCodeResetPw.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGetCodeResetPw.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGetCodeResetPw.Name = "btnGetCodeResetPw";
            this.btnGetCodeResetPw.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGetCodeResetPw.Size = new System.Drawing.Size(64, 36);
            this.btnGetCodeResetPw.TabIndex = 21;
            this.btnGetCodeResetPw.Text = "SEND";
            this.btnGetCodeResetPw.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGetCodeResetPw.UseAccentColor = false;
            this.btnGetCodeResetPw.UseVisualStyleBackColor = true;
            this.btnGetCodeResetPw.Click += new System.EventHandler(this.btnGetCodeResetPw_Click);
            // 
            // FormForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 253);
            this.Controls.Add(this.btnGetCodeResetPw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.backToLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormForgotPassword";
            ((System.ComponentModel.ISupportInitialize)(this.backToLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backToLogin;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtUsername;
        private System.Windows.Forms.Button close;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton btnGetCodeResetPw;
    }
}