namespace EmpManagement
{
    partial class FilterEmployee
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
            this.searchEmp = new MaterialSkin.Controls.MaterialButton();
            this.txtEmpCode = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtEmpName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtEmpAddress = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.dataGridViewEmps = new System.Windows.Forms.DataGridView();
            this.cbbEmpPosition = new MaterialSkin.Controls.MaterialComboBox();
            this.cbbEmpGender = new MaterialSkin.Controls.MaterialComboBox();
            this.btnGoToHome = new MaterialSkin.Controls.MaterialButton();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmps)).BeginInit();
            this.SuspendLayout();
            // 
            // searchEmp
            // 
            this.searchEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchEmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchEmp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchEmp.Depth = 0;
            this.searchEmp.HighEmphasis = true;
            this.searchEmp.Icon = null;
            this.searchEmp.Location = new System.Drawing.Point(73, 365);
            this.searchEmp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchEmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchEmp.Name = "searchEmp";
            this.searchEmp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchEmp.Size = new System.Drawing.Size(78, 36);
            this.searchEmp.TabIndex = 0;
            this.searchEmp.Text = "Search";
            this.searchEmp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchEmp.UseAccentColor = false;
            this.searchEmp.UseVisualStyleBackColor = true;
            this.searchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.AllowPromptAsInput = true;
            this.txtEmpCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmpCode.AnimateReadOnly = false;
            this.txtEmpCode.AsciiOnly = false;
            this.txtEmpCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmpCode.BeepOnError = false;
            this.txtEmpCode.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmpCode.Depth = 0;
            this.txtEmpCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmpCode.HidePromptOnLeave = false;
            this.txtEmpCode.HideSelection = true;
            this.txtEmpCode.Hint = "Code";
            this.txtEmpCode.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtEmpCode.LeadingIcon = null;
            this.txtEmpCode.Location = new System.Drawing.Point(42, 37);
            this.txtEmpCode.Mask = "";
            this.txtEmpCode.MaxLength = 32767;
            this.txtEmpCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.PasswordChar = '\0';
            this.txtEmpCode.PrefixSuffixText = null;
            this.txtEmpCode.PromptChar = '_';
            this.txtEmpCode.ReadOnly = false;
            this.txtEmpCode.RejectInputOnFirstFailure = false;
            this.txtEmpCode.ResetOnPrompt = true;
            this.txtEmpCode.ResetOnSpace = true;
            this.txtEmpCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmpCode.SelectedText = "";
            this.txtEmpCode.SelectionLength = 0;
            this.txtEmpCode.SelectionStart = 0;
            this.txtEmpCode.ShortcutsEnabled = true;
            this.txtEmpCode.Size = new System.Drawing.Size(250, 48);
            this.txtEmpCode.SkipLiterals = true;
            this.txtEmpCode.TabIndex = 1;
            this.txtEmpCode.TabStop = false;
            this.txtEmpCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmpCode.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmpCode.TrailingIcon = null;
            this.txtEmpCode.UseSystemPasswordChar = false;
            this.txtEmpCode.ValidatingType = null;
            // 
            // txtEmpName
            // 
            this.txtEmpName.AllowPromptAsInput = true;
            this.txtEmpName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmpName.AnimateReadOnly = false;
            this.txtEmpName.AsciiOnly = false;
            this.txtEmpName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmpName.BeepOnError = false;
            this.txtEmpName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmpName.Depth = 0;
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmpName.HidePromptOnLeave = false;
            this.txtEmpName.HideSelection = true;
            this.txtEmpName.Hint = "Name";
            this.txtEmpName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtEmpName.LeadingIcon = null;
            this.txtEmpName.Location = new System.Drawing.Point(42, 91);
            this.txtEmpName.Mask = "";
            this.txtEmpName.MaxLength = 32767;
            this.txtEmpName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.PasswordChar = '\0';
            this.txtEmpName.PrefixSuffixText = null;
            this.txtEmpName.PromptChar = '_';
            this.txtEmpName.ReadOnly = false;
            this.txtEmpName.RejectInputOnFirstFailure = false;
            this.txtEmpName.ResetOnPrompt = true;
            this.txtEmpName.ResetOnSpace = true;
            this.txtEmpName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmpName.SelectedText = "";
            this.txtEmpName.SelectionLength = 0;
            this.txtEmpName.SelectionStart = 0;
            this.txtEmpName.ShortcutsEnabled = true;
            this.txtEmpName.Size = new System.Drawing.Size(250, 48);
            this.txtEmpName.SkipLiterals = true;
            this.txtEmpName.TabIndex = 2;
            this.txtEmpName.TabStop = false;
            this.txtEmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmpName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmpName.TrailingIcon = null;
            this.txtEmpName.UseSystemPasswordChar = false;
            this.txtEmpName.ValidatingType = null;
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.AllowPromptAsInput = true;
            this.txtEmpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmpAddress.AnimateReadOnly = false;
            this.txtEmpAddress.AsciiOnly = false;
            this.txtEmpAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmpAddress.BeepOnError = false;
            this.txtEmpAddress.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmpAddress.Depth = 0;
            this.txtEmpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmpAddress.HidePromptOnLeave = false;
            this.txtEmpAddress.HideSelection = true;
            this.txtEmpAddress.Hint = "Address";
            this.txtEmpAddress.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtEmpAddress.LeadingIcon = null;
            this.txtEmpAddress.Location = new System.Drawing.Point(42, 145);
            this.txtEmpAddress.Mask = "";
            this.txtEmpAddress.MaxLength = 32767;
            this.txtEmpAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.PasswordChar = '\0';
            this.txtEmpAddress.PrefixSuffixText = null;
            this.txtEmpAddress.PromptChar = '_';
            this.txtEmpAddress.ReadOnly = false;
            this.txtEmpAddress.RejectInputOnFirstFailure = false;
            this.txtEmpAddress.ResetOnPrompt = true;
            this.txtEmpAddress.ResetOnSpace = true;
            this.txtEmpAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmpAddress.SelectedText = "";
            this.txtEmpAddress.SelectionLength = 0;
            this.txtEmpAddress.SelectionStart = 0;
            this.txtEmpAddress.ShortcutsEnabled = true;
            this.txtEmpAddress.Size = new System.Drawing.Size(250, 48);
            this.txtEmpAddress.SkipLiterals = true;
            this.txtEmpAddress.TabIndex = 5;
            this.txtEmpAddress.TabStop = false;
            this.txtEmpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmpAddress.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmpAddress.TrailingIcon = null;
            this.txtEmpAddress.UseSystemPasswordChar = false;
            this.txtEmpAddress.ValidatingType = null;
            // 
            // dataGridViewEmps
            // 
            this.dataGridViewEmps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridViewEmps.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewEmps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmps.Location = new System.Drawing.Point(366, 37);
            this.dataGridViewEmps.Name = "dataGridViewEmps";
            this.dataGridViewEmps.Size = new System.Drawing.Size(873, 442);
            this.dataGridViewEmps.TabIndex = 6;
            this.dataGridViewEmps.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmps_CellContentClick);
            // 
            // cbbEmpPosition
            // 
            this.cbbEmpPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbbEmpPosition.AutoResize = false;
            this.cbbEmpPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbEmpPosition.Depth = 0;
            this.cbbEmpPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbEmpPosition.DropDownHeight = 174;
            this.cbbEmpPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEmpPosition.DropDownWidth = 121;
            this.cbbEmpPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbEmpPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbEmpPosition.FormattingEnabled = true;
            this.cbbEmpPosition.Hint = "Position";
            this.cbbEmpPosition.IntegralHeight = false;
            this.cbbEmpPosition.ItemHeight = 43;
            this.cbbEmpPosition.Items.AddRange(new object[] {
            "",
            "Manager",
            "Internal",
            "Fresher Developer",
            "Senior Developer",
            "Junior Developer",
            "Tester",
            "BA"});
            this.cbbEmpPosition.Location = new System.Drawing.Point(42, 199);
            this.cbbEmpPosition.MaxDropDownItems = 4;
            this.cbbEmpPosition.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbEmpPosition.Name = "cbbEmpPosition";
            this.cbbEmpPosition.Size = new System.Drawing.Size(250, 49);
            this.cbbEmpPosition.StartIndex = 0;
            this.cbbEmpPosition.TabIndex = 7;
            // 
            // cbbEmpGender
            // 
            this.cbbEmpGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbbEmpGender.AutoResize = false;
            this.cbbEmpGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbEmpGender.Depth = 0;
            this.cbbEmpGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbEmpGender.DropDownHeight = 174;
            this.cbbEmpGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEmpGender.DropDownWidth = 121;
            this.cbbEmpGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbEmpGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbEmpGender.FormattingEnabled = true;
            this.cbbEmpGender.Hint = "Gender";
            this.cbbEmpGender.IntegralHeight = false;
            this.cbbEmpGender.ItemHeight = 43;
            this.cbbEmpGender.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.cbbEmpGender.Location = new System.Drawing.Point(42, 254);
            this.cbbEmpGender.MaxDropDownItems = 4;
            this.cbbEmpGender.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbEmpGender.Name = "cbbEmpGender";
            this.cbbEmpGender.Size = new System.Drawing.Size(250, 49);
            this.cbbEmpGender.StartIndex = 0;
            this.cbbEmpGender.TabIndex = 8;
            // 
            // btnGoToHome
            // 
            this.btnGoToHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnGoToHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGoToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToHome.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGoToHome.Depth = 0;
            this.btnGoToHome.HighEmphasis = true;
            this.btnGoToHome.Icon = null;
            this.btnGoToHome.Location = new System.Drawing.Point(175, 365);
            this.btnGoToHome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGoToHome.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGoToHome.Name = "btnGoToHome";
            this.btnGoToHome.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGoToHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGoToHome.Size = new System.Drawing.Size(64, 36);
            this.btnGoToHome.TabIndex = 9;
            this.btnGoToHome.Text = "HOME";
            this.btnGoToHome.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGoToHome.UseAccentColor = false;
            this.btnGoToHome.UseVisualStyleBackColor = true;
            this.btnGoToHome.Click += new System.EventHandler(this.btnGoToHome_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.White;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close.Location = new System.Drawing.Point(1260, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.TabIndex = 10;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // FilterEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 532);
            this.Controls.Add(this.close);
            this.Controls.Add(this.btnGoToHome);
            this.Controls.Add(this.cbbEmpGender);
            this.Controls.Add(this.cbbEmpPosition);
            this.Controls.Add(this.dataGridViewEmps);
            this.Controls.Add(this.txtEmpAddress);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpCode);
            this.Controls.Add(this.searchEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilterEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter Employee";
            this.Load += new System.EventHandler(this.FilterEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton searchEmp;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEmpCode;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEmpName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEmpAddress;
        private System.Windows.Forms.DataGridView dataGridViewEmps;
        private MaterialSkin.Controls.MaterialComboBox cbbEmpPosition;
        private MaterialSkin.Controls.MaterialComboBox cbbEmpGender;
        private MaterialSkin.Controls.MaterialButton btnGoToHome;
        private System.Windows.Forms.Button close;
    }
}