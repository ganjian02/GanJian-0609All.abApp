namespace LabAss3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.GroupBox();
            this.chkReading = new System.Windows.Forms.CheckBox();
            this.chkPainting = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.GroupBox();
            this.radioUnrried = new System.Windows.Forms.RadioButton();
            this.radioMarried = new System.Windows.Forms.RadioButton();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.customerDBDataSet = new LabAss3.CustomerDBDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new LabAss3.CustomerDBDataSetTableAdapters.CustomerTableAdapter();
            this.lblGender.SuspendLayout();
            this.lblStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(72, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Customer Name";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(75, 87);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(63, 15);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Country";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(209, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(175, 25);
            this.txtName.TabIndex = 2;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(6, 37);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(60, 19);
            this.radioMale.TabIndex = 4;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(108, 37);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(76, 19);
            this.radioFemale.TabIndex = 5;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.Controls.Add(this.radioMale);
            this.lblGender.Controls.Add(this.radioFemale);
            this.lblGender.Location = new System.Drawing.Point(75, 129);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(309, 62);
            this.lblGender.TabIndex = 6;
            this.lblGender.TabStop = false;
            this.lblGender.Text = "Gender";
            // 
            // chkReading
            // 
            this.chkReading.AutoSize = true;
            this.chkReading.Location = new System.Drawing.Point(183, 231);
            this.chkReading.Name = "chkReading";
            this.chkReading.Size = new System.Drawing.Size(85, 19);
            this.chkReading.TabIndex = 7;
            this.chkReading.Text = "Reading";
            this.chkReading.UseVisualStyleBackColor = true;
            // 
            // chkPainting
            // 
            this.chkPainting.AutoSize = true;
            this.chkPainting.Location = new System.Drawing.Point(291, 231);
            this.chkPainting.Name = "chkPainting";
            this.chkPainting.Size = new System.Drawing.Size(93, 19);
            this.chkPainting.TabIndex = 8;
            this.chkPainting.Text = "Painting";
            this.chkPainting.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hobbies";
            // 
            // lblStatus
            // 
            this.lblStatus.Controls.Add(this.radioUnrried);
            this.lblStatus.Controls.Add(this.radioMarried);
            this.lblStatus.Location = new System.Drawing.Point(75, 276);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(309, 76);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.TabStop = false;
            this.lblStatus.Text = "Status";
            // 
            // radioUnrried
            // 
            this.radioUnrried.AutoSize = true;
            this.radioUnrried.Location = new System.Drawing.Point(155, 34);
            this.radioUnrried.Name = "radioUnrried";
            this.radioUnrried.Size = new System.Drawing.Size(92, 19);
            this.radioUnrried.TabIndex = 1;
            this.radioUnrried.TabStop = true;
            this.radioUnrried.Text = "Unmrried";
            this.radioUnrried.UseVisualStyleBackColor = true;
            // 
            // radioMarried
            // 
            this.radioMarried.AutoSize = true;
            this.radioMarried.Location = new System.Drawing.Point(23, 34);
            this.radioMarried.Name = "radioMarried";
            this.radioMarried.Size = new System.Drawing.Size(84, 19);
            this.radioMarried.TabIndex = 0;
            this.radioMarried.TabStop = true;
            this.radioMarried.Text = "Married";
            this.radioMarried.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(75, 382);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(81, 23);
            this.btnPreview.TabIndex = 11;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "Bangladesh"});
            this.cmbCountry.Location = new System.Drawing.Point(209, 87);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(175, 23);
            this.cmbCountry.TabIndex = 12;
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Location = new System.Drawing.Point(414, 37);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.RowHeadersWidth = 51;
            this.dtgCustomer.RowTemplate.Height = 27;
            this.dtgCustomer.Size = new System.Drawing.Size(637, 315);
            this.dtgCustomer.TabIndex = 13;
            this.dtgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellClick);
            this.dtgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(75, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(14, 431);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 15);
            this.lblID.TabIndex = 17;
            this.lblID.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(230, 423);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // customerDBDataSet
            // 
            this.customerDBDataSet.DataSetName = "CustomerDBDataSet";
            this.customerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.customerDBDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgCustomer);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkPainting);
            this.Controls.Add(this.chkReading);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Customer Data Entry Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.lblGender.ResumeLayout(false);
            this.lblGender.PerformLayout();
            this.lblStatus.ResumeLayout(false);
            this.lblStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.GroupBox lblGender;
        private System.Windows.Forms.CheckBox chkReading;
        private System.Windows.Forms.CheckBox chkPainting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox lblStatus;
        private System.Windows.Forms.RadioButton radioUnrried;
        private System.Windows.Forms.RadioButton radioMarried;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button button3;
        private CustomerDBDataSet customerDBDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CustomerDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
    }
}

