namespace EmpManagement
{
    partial class FormConfirmOTP
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
            this.txtOtp = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnConfirmOtp = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtOtp
            // 
            this.txtOtp.AllowPromptAsInput = true;
            this.txtOtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtOtp.AnimateReadOnly = false;
            this.txtOtp.AsciiOnly = false;
            this.txtOtp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtOtp.BeepOnError = false;
            this.txtOtp.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtOtp.Depth = 0;
            this.txtOtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOtp.HidePromptOnLeave = false;
            this.txtOtp.HideSelection = true;
            this.txtOtp.Hint = "Enter OTP";
            this.txtOtp.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtOtp.LeadingIcon = null;
            this.txtOtp.Location = new System.Drawing.Point(87, 21);
            this.txtOtp.Mask = "";
            this.txtOtp.MaxLength = 32767;
            this.txtOtp.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOtp.Name = "txtOtp";
            this.txtOtp.PasswordChar = '\0';
            this.txtOtp.PrefixSuffixText = null;
            this.txtOtp.PromptChar = '_';
            this.txtOtp.ReadOnly = false;
            this.txtOtp.RejectInputOnFirstFailure = false;
            this.txtOtp.ResetOnPrompt = true;
            this.txtOtp.ResetOnSpace = true;
            this.txtOtp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOtp.SelectedText = "";
            this.txtOtp.SelectionLength = 0;
            this.txtOtp.SelectionStart = 0;
            this.txtOtp.ShortcutsEnabled = true;
            this.txtOtp.Size = new System.Drawing.Size(266, 48);
            this.txtOtp.SkipLiterals = true;
            this.txtOtp.TabIndex = 0;
            this.txtOtp.TabStop = false;
            this.txtOtp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOtp.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtOtp.TrailingIcon = null;
            this.txtOtp.UseSystemPasswordChar = false;
            this.txtOtp.ValidatingType = null;
            // 
            // btnConfirmOtp
            // 
            this.btnConfirmOtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnConfirmOtp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmOtp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmOtp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirmOtp.Depth = 0;
            this.btnConfirmOtp.HighEmphasis = true;
            this.btnConfirmOtp.Icon = null;
            this.btnConfirmOtp.Location = new System.Drawing.Point(168, 78);
            this.btnConfirmOtp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirmOtp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmOtp.Name = "btnConfirmOtp";
            this.btnConfirmOtp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirmOtp.Size = new System.Drawing.Size(86, 36);
            this.btnConfirmOtp.TabIndex = 1;
            this.btnConfirmOtp.Text = "CONFIRM";
            this.btnConfirmOtp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirmOtp.UseAccentColor = false;
            this.btnConfirmOtp.UseVisualStyleBackColor = true;
            this.btnConfirmOtp.Click += new System.EventHandler(this.btnConfirmOtp_Click);
            // 
            // FormConfirmOTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 141);
            this.Controls.Add(this.btnConfirmOtp);
            this.Controls.Add(this.txtOtp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormConfirmOTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter OTP To Access";
            this.Load += new System.EventHandler(this.ConfirmOTP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox txtOtp;
        private MaterialSkin.Controls.MaterialButton btnConfirmOtp;
    }
}