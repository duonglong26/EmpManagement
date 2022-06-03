namespace EmpManagement
{
    partial class FormChangePassword
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
            this.close = new System.Windows.Forms.Button();
            this.txtOldPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtNewPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtConfirmPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnSavePassword = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoToHome = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.White;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close.Location = new System.Drawing.Point(544, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.TabIndex = 11;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.AllowPromptAsInput = true;
            this.txtOldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldPassword.AnimateReadOnly = false;
            this.txtOldPassword.AsciiOnly = false;
            this.txtOldPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtOldPassword.BeepOnError = false;
            this.txtOldPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtOldPassword.Depth = 0;
            this.txtOldPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOldPassword.HidePromptOnLeave = false;
            this.txtOldPassword.HideSelection = true;
            this.txtOldPassword.Hint = "Old Password";
            this.txtOldPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtOldPassword.LeadingIcon = null;
            this.txtOldPassword.Location = new System.Drawing.Point(123, 61);
            this.txtOldPassword.Mask = "";
            this.txtOldPassword.MaxLength = 32767;
            this.txtOldPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.PrefixSuffixText = null;
            this.txtOldPassword.PromptChar = '_';
            this.txtOldPassword.ReadOnly = false;
            this.txtOldPassword.RejectInputOnFirstFailure = false;
            this.txtOldPassword.ResetOnPrompt = true;
            this.txtOldPassword.ResetOnSpace = true;
            this.txtOldPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOldPassword.SelectedText = "";
            this.txtOldPassword.SelectionLength = 0;
            this.txtOldPassword.SelectionStart = 0;
            this.txtOldPassword.ShortcutsEnabled = true;
            this.txtOldPassword.Size = new System.Drawing.Size(315, 48);
            this.txtOldPassword.SkipLiterals = true;
            this.txtOldPassword.TabIndex = 12;
            this.txtOldPassword.TabStop = false;
            this.txtOldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOldPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtOldPassword.TrailingIcon = null;
            this.txtOldPassword.UseSystemPasswordChar = false;
            this.txtOldPassword.ValidatingType = null;
            this.txtOldPassword.Click += new System.EventHandler(this.txtOldPassword_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.AllowPromptAsInput = true;
            this.txtNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPassword.AnimateReadOnly = false;
            this.txtNewPassword.AsciiOnly = false;
            this.txtNewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNewPassword.BeepOnError = false;
            this.txtNewPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNewPassword.Depth = 0;
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNewPassword.HidePromptOnLeave = false;
            this.txtNewPassword.HideSelection = true;
            this.txtNewPassword.Hint = "New Password";
            this.txtNewPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtNewPassword.LeadingIcon = null;
            this.txtNewPassword.Location = new System.Drawing.Point(123, 129);
            this.txtNewPassword.Mask = "";
            this.txtNewPassword.MaxLength = 32767;
            this.txtNewPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.PrefixSuffixText = null;
            this.txtNewPassword.PromptChar = '_';
            this.txtNewPassword.ReadOnly = false;
            this.txtNewPassword.RejectInputOnFirstFailure = false;
            this.txtNewPassword.ResetOnPrompt = true;
            this.txtNewPassword.ResetOnSpace = true;
            this.txtNewPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.SelectionLength = 0;
            this.txtNewPassword.SelectionStart = 0;
            this.txtNewPassword.ShortcutsEnabled = true;
            this.txtNewPassword.Size = new System.Drawing.Size(315, 48);
            this.txtNewPassword.SkipLiterals = true;
            this.txtNewPassword.TabIndex = 13;
            this.txtNewPassword.TabStop = false;
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNewPassword.TrailingIcon = null;
            this.txtNewPassword.UseSystemPasswordChar = false;
            this.txtNewPassword.ValidatingType = null;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.AllowPromptAsInput = true;
            this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPassword.AnimateReadOnly = false;
            this.txtConfirmPassword.AsciiOnly = false;
            this.txtConfirmPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtConfirmPassword.BeepOnError = false;
            this.txtConfirmPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtConfirmPassword.Depth = 0;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConfirmPassword.HidePromptOnLeave = false;
            this.txtConfirmPassword.HideSelection = true;
            this.txtConfirmPassword.Hint = "Confirm New Password";
            this.txtConfirmPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtConfirmPassword.LeadingIcon = null;
            this.txtConfirmPassword.Location = new System.Drawing.Point(123, 192);
            this.txtConfirmPassword.Mask = "";
            this.txtConfirmPassword.MaxLength = 32767;
            this.txtConfirmPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.PrefixSuffixText = null;
            this.txtConfirmPassword.PromptChar = '_';
            this.txtConfirmPassword.ReadOnly = false;
            this.txtConfirmPassword.RejectInputOnFirstFailure = false;
            this.txtConfirmPassword.ResetOnPrompt = true;
            this.txtConfirmPassword.ResetOnSpace = true;
            this.txtConfirmPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.SelectionLength = 0;
            this.txtConfirmPassword.SelectionStart = 0;
            this.txtConfirmPassword.ShortcutsEnabled = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(315, 48);
            this.txtConfirmPassword.SkipLiterals = true;
            this.txtConfirmPassword.TabIndex = 14;
            this.txtConfirmPassword.TabStop = false;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtConfirmPassword.TrailingIcon = null;
            this.txtConfirmPassword.UseSystemPasswordChar = false;
            this.txtConfirmPassword.ValidatingType = null;
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSavePassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSavePassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSavePassword.Depth = 0;
            this.btnSavePassword.HighEmphasis = true;
            this.btnSavePassword.Icon = null;
            this.btnSavePassword.Location = new System.Drawing.Point(228, 262);
            this.btnSavePassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSavePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSavePassword.Size = new System.Drawing.Size(64, 36);
            this.btnSavePassword.TabIndex = 15;
            this.btnSavePassword.Text = "SAVE";
            this.btnSavePassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSavePassword.UseAccentColor = false;
            this.btnSavePassword.UseVisualStyleBackColor = true;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Change Password";
            // 
            // btnGoToHome
            // 
            this.btnGoToHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGoToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToHome.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGoToHome.Depth = 0;
            this.btnGoToHome.HighEmphasis = true;
            this.btnGoToHome.Icon = null;
            this.btnGoToHome.Location = new System.Drawing.Point(1, 1);
            this.btnGoToHome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGoToHome.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGoToHome.Name = "btnGoToHome";
            this.btnGoToHome.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGoToHome.Size = new System.Drawing.Size(64, 36);
            this.btnGoToHome.TabIndex = 22;
            this.btnGoToHome.Text = "HOME";
            this.btnGoToHome.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGoToHome.UseAccentColor = false;
            this.btnGoToHome.UseVisualStyleBackColor = true;
            this.btnGoToHome.Click += new System.EventHandler(this.btnGoToHome_Click);
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 348);
            this.Controls.Add(this.btnGoToHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSavePassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtOldPassword;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtNewPassword;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtConfirmPassword;
        private MaterialSkin.Controls.MaterialButton btnSavePassword;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnGoToHome;
    }
}