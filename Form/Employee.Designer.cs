namespace EmpManagement
{
    partial class Employee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveOrUpdateEmp = new MaterialSkin.Controls.MaterialButton();
            this.idEmp = new System.Windows.Forms.Button();
            this.reloadDataGirdViews = new System.Windows.Forms.PictureBox();
            this.empDataGridViews = new System.Windows.Forms.DataGridView();
            this.btnGoToHome = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteEmp = new MaterialSkin.Controls.MaterialButton();
            this.cbbEmpGender = new MaterialSkin.Controls.MaterialComboBox();
            this.cbbEmpPosition = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.empDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtEmpEducation = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtEmpPhone = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtEmpAddress = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtEmpName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtEmpCode = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reloadDataGirdViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataGridViews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Manager";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.saveOrUpdateEmp);
            this.panel1.Controls.Add(this.idEmp);
            this.panel1.Controls.Add(this.reloadDataGirdViews);
            this.panel1.Controls.Add(this.empDataGridViews);
            this.panel1.Controls.Add(this.btnGoToHome);
            this.panel1.Controls.Add(this.btnDeleteEmp);
            this.panel1.Controls.Add(this.cbbEmpGender);
            this.panel1.Controls.Add(this.cbbEmpPosition);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.empDateOfBirth);
            this.panel1.Controls.Add(this.txtEmpEducation);
            this.panel1.Controls.Add(this.txtEmpPhone);
            this.panel1.Controls.Add(this.txtEmpAddress);
            this.panel1.Controls.Add(this.txtEmpName);
            this.panel1.Controls.Add(this.txtEmpCode);
            this.panel1.Location = new System.Drawing.Point(1, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 553);
            this.panel1.TabIndex = 3;
            // 
            // saveOrUpdateEmp
            // 
            this.saveOrUpdateEmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveOrUpdateEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveOrUpdateEmp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveOrUpdateEmp.Depth = 0;
            this.saveOrUpdateEmp.HighEmphasis = true;
            this.saveOrUpdateEmp.Icon = null;
            this.saveOrUpdateEmp.Location = new System.Drawing.Point(35, 494);
            this.saveOrUpdateEmp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveOrUpdateEmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveOrUpdateEmp.Name = "saveOrUpdateEmp";
            this.saveOrUpdateEmp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveOrUpdateEmp.Size = new System.Drawing.Size(64, 36);
            this.saveOrUpdateEmp.TabIndex = 26;
            this.saveOrUpdateEmp.Text = "SAVE";
            this.saveOrUpdateEmp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveOrUpdateEmp.UseAccentColor = false;
            this.saveOrUpdateEmp.UseVisualStyleBackColor = true;
            this.saveOrUpdateEmp.Click += new System.EventHandler(this.saveOrUpdateEmp_Click);
            // 
            // idEmp
            // 
            this.idEmp.BackColor = System.Drawing.Color.Black;
            this.idEmp.Cursor = System.Windows.Forms.Cursors.No;
            this.idEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idEmp.ForeColor = System.Drawing.Color.White;
            this.idEmp.Location = new System.Drawing.Point(502, 10);
            this.idEmp.Name = "idEmp";
            this.idEmp.Size = new System.Drawing.Size(45, 28);
            this.idEmp.TabIndex = 25;
            this.idEmp.Text = "ID";
            this.idEmp.UseVisualStyleBackColor = false;
            // 
            // reloadDataGirdViews
            // 
            this.reloadDataGirdViews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadDataGirdViews.Image = ((System.Drawing.Image)(resources.GetObject("reloadDataGirdViews.Image")));
            this.reloadDataGirdViews.Location = new System.Drawing.Point(919, 3);
            this.reloadDataGirdViews.Name = "reloadDataGirdViews";
            this.reloadDataGirdViews.Size = new System.Drawing.Size(33, 33);
            this.reloadDataGirdViews.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reloadDataGirdViews.TabIndex = 23;
            this.reloadDataGirdViews.TabStop = false;
            this.reloadDataGirdViews.Click += new System.EventHandler(this.reloadDataGirdViews_Click);
            // 
            // empDataGridViews
            // 
            this.empDataGridViews.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.empDataGridViews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDataGridViews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empDataGridViews.Location = new System.Drawing.Point(594, 39);
            this.empDataGridViews.Name = "empDataGridViews";
            this.empDataGridViews.Size = new System.Drawing.Size(649, 491);
            this.empDataGridViews.TabIndex = 22;
            this.empDataGridViews.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empDataGridViews_CellContentClick);
            // 
            // btnGoToHome
            // 
            this.btnGoToHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGoToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToHome.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGoToHome.Depth = 0;
            this.btnGoToHome.HighEmphasis = true;
            this.btnGoToHome.Icon = null;
            this.btnGoToHome.Location = new System.Drawing.Point(212, 494);
            this.btnGoToHome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGoToHome.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGoToHome.Name = "btnGoToHome";
            this.btnGoToHome.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGoToHome.Size = new System.Drawing.Size(64, 36);
            this.btnGoToHome.TabIndex = 21;
            this.btnGoToHome.Text = "HOME";
            this.btnGoToHome.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGoToHome.UseAccentColor = false;
            this.btnGoToHome.UseVisualStyleBackColor = true;
            this.btnGoToHome.Click += new System.EventHandler(this.btnGoToHome_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEmp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteEmp.Depth = 0;
            this.btnDeleteEmp.HighEmphasis = true;
            this.btnDeleteEmp.Icon = null;
            this.btnDeleteEmp.Location = new System.Drawing.Point(118, 494);
            this.btnDeleteEmp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteEmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteEmp.Size = new System.Drawing.Size(73, 36);
            this.btnDeleteEmp.TabIndex = 19;
            this.btnDeleteEmp.Text = "DELETE";
            this.btnDeleteEmp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteEmp.UseAccentColor = false;
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // cbbEmpGender
            // 
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
            "Male",
            "Female"});
            this.cbbEmpGender.Location = new System.Drawing.Point(35, 147);
            this.cbbEmpGender.MaxDropDownItems = 4;
            this.cbbEmpGender.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbEmpGender.Name = "cbbEmpGender";
            this.cbbEmpGender.Size = new System.Drawing.Size(512, 49);
            this.cbbEmpGender.StartIndex = 0;
            this.cbbEmpGender.TabIndex = 17;
            // 
            // cbbEmpPosition
            // 
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
            "Manager",
            "Internal",
            "Fresher Developer",
            "Senior Developer",
            "Junior Developer",
            "Tester",
            "BA"});
            this.cbbEmpPosition.Location = new System.Drawing.Point(35, 202);
            this.cbbEmpPosition.MaxDropDownItems = 4;
            this.cbbEmpPosition.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbEmpPosition.Name = "cbbEmpPosition";
            this.cbbEmpPosition.Size = new System.Drawing.Size(512, 49);
            this.cbbEmpPosition.StartIndex = 0;
            this.cbbEmpPosition.TabIndex = 16;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(50, 268);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(92, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Date Of Birth";
            // 
            // empDateOfBirth
            // 
            this.empDateOfBirth.Location = new System.Drawing.Point(157, 268);
            this.empDateOfBirth.Name = "empDateOfBirth";
            this.empDateOfBirth.Size = new System.Drawing.Size(390, 20);
            this.empDateOfBirth.TabIndex = 13;
            this.empDateOfBirth.ValueChanged += new System.EventHandler(this.empDateOfBirth_ValueChanged);
            // 
            // txtEmpEducation
            // 
            this.txtEmpEducation.AllowPromptAsInput = true;
            this.txtEmpEducation.AnimateReadOnly = false;
            this.txtEmpEducation.AsciiOnly = false;
            this.txtEmpEducation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmpEducation.BeepOnError = false;
            this.txtEmpEducation.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmpEducation.Depth = 0;
            this.txtEmpEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmpEducation.HidePromptOnLeave = false;
            this.txtEmpEducation.HideSelection = true;
            this.txtEmpEducation.Hint = "Education";
            this.txtEmpEducation.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtEmpEducation.LeadingIcon = null;
            this.txtEmpEducation.Location = new System.Drawing.Point(35, 363);
            this.txtEmpEducation.Mask = "";
            this.txtEmpEducation.MaxLength = 32767;
            this.txtEmpEducation.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmpEducation.Name = "txtEmpEducation";
            this.txtEmpEducation.PasswordChar = '\0';
            this.txtEmpEducation.PrefixSuffixText = null;
            this.txtEmpEducation.PromptChar = '_';
            this.txtEmpEducation.ReadOnly = false;
            this.txtEmpEducation.RejectInputOnFirstFailure = false;
            this.txtEmpEducation.ResetOnPrompt = true;
            this.txtEmpEducation.ResetOnSpace = true;
            this.txtEmpEducation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmpEducation.SelectedText = "";
            this.txtEmpEducation.SelectionLength = 0;
            this.txtEmpEducation.SelectionStart = 0;
            this.txtEmpEducation.ShortcutsEnabled = true;
            this.txtEmpEducation.Size = new System.Drawing.Size(512, 48);
            this.txtEmpEducation.SkipLiterals = true;
            this.txtEmpEducation.TabIndex = 12;
            this.txtEmpEducation.TabStop = false;
            this.txtEmpEducation.Text = " ";
            this.txtEmpEducation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmpEducation.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmpEducation.TrailingIcon = null;
            this.txtEmpEducation.UseSystemPasswordChar = false;
            this.txtEmpEducation.ValidatingType = null;
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.AllowPromptAsInput = true;
            this.txtEmpPhone.AnimateReadOnly = false;
            this.txtEmpPhone.AsciiOnly = false;
            this.txtEmpPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmpPhone.BeepOnError = false;
            this.txtEmpPhone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmpPhone.Depth = 0;
            this.txtEmpPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmpPhone.HidePromptOnLeave = false;
            this.txtEmpPhone.HideSelection = true;
            this.txtEmpPhone.Hint = "Phone";
            this.txtEmpPhone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtEmpPhone.LeadingIcon = null;
            this.txtEmpPhone.Location = new System.Drawing.Point(35, 309);
            this.txtEmpPhone.Mask = "";
            this.txtEmpPhone.MaxLength = 32767;
            this.txtEmpPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.PasswordChar = '\0';
            this.txtEmpPhone.PrefixSuffixText = null;
            this.txtEmpPhone.PromptChar = '_';
            this.txtEmpPhone.ReadOnly = false;
            this.txtEmpPhone.RejectInputOnFirstFailure = false;
            this.txtEmpPhone.ResetOnPrompt = true;
            this.txtEmpPhone.ResetOnSpace = true;
            this.txtEmpPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmpPhone.SelectedText = "";
            this.txtEmpPhone.SelectionLength = 0;
            this.txtEmpPhone.SelectionStart = 0;
            this.txtEmpPhone.ShortcutsEnabled = true;
            this.txtEmpPhone.Size = new System.Drawing.Size(512, 48);
            this.txtEmpPhone.SkipLiterals = true;
            this.txtEmpPhone.TabIndex = 11;
            this.txtEmpPhone.TabStop = false;
            this.txtEmpPhone.Text = " ";
            this.txtEmpPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmpPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmpPhone.TrailingIcon = null;
            this.txtEmpPhone.UseSystemPasswordChar = false;
            this.txtEmpPhone.ValidatingType = null;
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.AllowPromptAsInput = true;
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
            this.txtEmpAddress.Location = new System.Drawing.Point(35, 417);
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
            this.txtEmpAddress.Size = new System.Drawing.Size(512, 48);
            this.txtEmpAddress.SkipLiterals = true;
            this.txtEmpAddress.TabIndex = 8;
            this.txtEmpAddress.TabStop = false;
            this.txtEmpAddress.Text = " ";
            this.txtEmpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmpAddress.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmpAddress.TrailingIcon = null;
            this.txtEmpAddress.UseSystemPasswordChar = false;
            this.txtEmpAddress.ValidatingType = null;
            // 
            // txtEmpName
            // 
            this.txtEmpName.AllowPromptAsInput = true;
            this.txtEmpName.AnimateReadOnly = false;
            this.txtEmpName.AsciiOnly = false;
            this.txtEmpName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmpName.BeepOnError = false;
            this.txtEmpName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmpName.Depth = 0;
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmpName.HidePromptOnLeave = false;
            this.txtEmpName.HideSelection = true;
            this.txtEmpName.Hint = "Full Name";
            this.txtEmpName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtEmpName.LeadingIcon = null;
            this.txtEmpName.Location = new System.Drawing.Point(35, 93);
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
            this.txtEmpName.Size = new System.Drawing.Size(512, 48);
            this.txtEmpName.SkipLiterals = true;
            this.txtEmpName.TabIndex = 7;
            this.txtEmpName.TabStop = false;
            this.txtEmpName.Text = " ";
            this.txtEmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmpName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmpName.TrailingIcon = null;
            this.txtEmpName.UseSystemPasswordChar = false;
            this.txtEmpName.ValidatingType = null;
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.AllowPromptAsInput = true;
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
            this.txtEmpCode.Location = new System.Drawing.Point(35, 39);
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
            this.txtEmpCode.Size = new System.Drawing.Size(512, 48);
            this.txtEmpCode.SkipLiterals = true;
            this.txtEmpCode.TabIndex = 6;
            this.txtEmpCode.TabStop = false;
            this.txtEmpCode.Text = " ";
            this.txtEmpCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmpCode.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmpCode.TrailingIcon = null;
            this.txtEmpCode.UseSystemPasswordChar = false;
            this.txtEmpCode.ValidatingType = null;
            this.txtEmpCode.Click += new System.EventHandler(this.txtEmpCode_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1268, 694);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Manager";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reloadDataGirdViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDataGridViews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEmpEducation;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEmpPhone;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEmpAddress;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEmpName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEmpCode;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker empDateOfBirth;
        private MaterialSkin.Controls.MaterialComboBox cbbEmpPosition;
        private MaterialSkin.Controls.MaterialComboBox cbbEmpGender;
        private MaterialSkin.Controls.MaterialButton btnGoToHome;
        private MaterialSkin.Controls.MaterialButton btnDeleteEmp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView empDataGridViews;
        private System.Windows.Forms.PictureBox reloadDataGirdViews;
        private System.Windows.Forms.Button idEmp;
        private MaterialSkin.Controls.MaterialButton saveOrUpdateEmp;
    }
}