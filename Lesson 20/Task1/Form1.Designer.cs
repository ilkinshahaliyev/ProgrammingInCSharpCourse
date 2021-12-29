namespace Task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBoxRegistration = new System.Windows.Forms.GroupBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtIdDelete = new System.Windows.Forms.TextBox();
            this.lblIdDelete = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            this.groupBoxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(135, 168);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(205, 23);
            this.comboBoxGender.TabIndex = 19;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(17, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(53, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Enter Id :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter name :";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(17, 84);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(89, 15);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Enter surname :";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(17, 113);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(108, 15);
            this.lblDateOfBirth.TabIndex = 3;
            this.lblDateOfBirth.Text = "Enter date of birth :";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(17, 142);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(99, 15);
            this.lblNationality.TabIndex = 4;
            this.lblNationality.Text = "Enter nationality :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(17, 171);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(80, 15);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Enter gender :";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(17, 200);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(76, 15);
            this.lblAdress.TabIndex = 6;
            this.lblAdress.Text = "Enter adress :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 23);
            this.txtName.TabIndex = 8;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(135, 80);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(205, 23);
            this.txtSurname.TabIndex = 9;
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(135, 139);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(205, 23);
            this.txtNationality.TabIndex = 11;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(135, 197);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(205, 23);
            this.txtAdress.TabIndex = 13;
            // 
            // btnCreate
            // 
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Location = new System.Drawing.Point(17, 238);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBoxRegistration
            // 
            this.groupBoxRegistration.Controls.Add(this.comboBoxGender);
            this.groupBoxRegistration.Controls.Add(this.dtpDateOfBirth);
            this.groupBoxRegistration.Controls.Add(this.numericUpDownId);
            this.groupBoxRegistration.Controls.Add(this.btnRead);
            this.groupBoxRegistration.Controls.Add(this.btnUpdate);
            this.groupBoxRegistration.Controls.Add(this.btnCreate);
            this.groupBoxRegistration.Controls.Add(this.lblId);
            this.groupBoxRegistration.Controls.Add(this.txtAdress);
            this.groupBoxRegistration.Controls.Add(this.lblName);
            this.groupBoxRegistration.Controls.Add(this.lblSurname);
            this.groupBoxRegistration.Controls.Add(this.txtNationality);
            this.groupBoxRegistration.Controls.Add(this.lblDateOfBirth);
            this.groupBoxRegistration.Controls.Add(this.lblNationality);
            this.groupBoxRegistration.Controls.Add(this.txtSurname);
            this.groupBoxRegistration.Controls.Add(this.lblGender);
            this.groupBoxRegistration.Controls.Add(this.txtName);
            this.groupBoxRegistration.Controls.Add(this.lblAdress);
            this.groupBoxRegistration.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRegistration.Name = "groupBoxRegistration";
            this.groupBoxRegistration.Size = new System.Drawing.Size(502, 284);
            this.groupBoxRegistration.TabIndex = 15;
            this.groupBoxRegistration.TabStop = false;
            this.groupBoxRegistration.Text = "User registiration";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(135, 109);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(205, 23);
            this.dtpDateOfBirth.TabIndex = 18;
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(135, 22);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(205, 23);
            this.numericUpDownId.TabIndex = 17;
            // 
            // btnRead
            // 
            this.btnRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRead.Location = new System.Drawing.Point(265, 238);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 16;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(135, 238);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(897, 531);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.btnDelete);
            this.groupBoxDelete.Controls.Add(this.txtIdDelete);
            this.groupBoxDelete.Controls.Add(this.lblIdDelete);
            this.groupBoxDelete.Location = new System.Drawing.Point(532, 12);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(440, 128);
            this.groupBoxDelete.TabIndex = 17;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Delete Student by Id";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(91, 76);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtIdDelete
            // 
            this.txtIdDelete.Location = new System.Drawing.Point(91, 23);
            this.txtIdDelete.Name = "txtIdDelete";
            this.txtIdDelete.Size = new System.Drawing.Size(162, 23);
            this.txtIdDelete.TabIndex = 8;
            // 
            // lblIdDelete
            // 
            this.lblIdDelete.AutoSize = true;
            this.lblIdDelete.Location = new System.Drawing.Point(20, 26);
            this.lblIdDelete.Name = "lblIdDelete";
            this.lblIdDelete.Size = new System.Drawing.Size(53, 15);
            this.lblIdDelete.TabIndex = 0;
            this.lblIdDelete.Text = "Enter Id :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 302);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(960, 214);
            this.listBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 566);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBoxRegistration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxRegistration.ResumeLayout(false);
            this.groupBoxRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            this.groupBoxDelete.ResumeLayout(false);
            this.groupBoxDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBoxRegistration;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtIdDelete;
        private System.Windows.Forms.Label lblIdDelete;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.NumericUpDown numericUpDownId;
    }
}
