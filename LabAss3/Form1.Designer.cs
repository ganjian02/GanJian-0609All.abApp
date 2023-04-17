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
            this.txtName = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.lblGender.SuspendLayout();
            this.lblStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(72, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(111, 15);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Customer Name";
            // 
            // cmbCountry
            // 
            this.cmbCountry.AutoSize = true;
            this.cmbCountry.Location = new System.Drawing.Point(75, 87);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(63, 15);
            this.cmbCountry.TabIndex = 1;
            this.cmbCountry.Text = "Country";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 25);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(209, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 25);
            this.textBox2.TabIndex = 3;
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
            this.btnPreview.Location = new System.Drawing.Point(133, 388);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(181, 23);
            this.btnPreview.TabIndex = 11;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkPainting);
            this.Controls.Add(this.chkReading);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Customer Data Entry Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.lblGender.ResumeLayout(false);
            this.lblGender.PerformLayout();
            this.lblStatus.ResumeLayout(false);
            this.lblStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label cmbCountry;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
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
    }
}

