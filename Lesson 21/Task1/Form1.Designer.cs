namespace Task1
{
    partial class frmStudentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentManagement));
            this.dgwStudents = new System.Windows.Forms.DataGridView();
            this.groupBoxAddStudent = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbxAdress = new System.Windows.Forms.TextBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.tbxNationality = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.groupBoxUpdateStudent = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.numericUpDownIdUpdate = new System.Windows.Forms.NumericUpDown();
            this.lblIdUpdate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxAdressUpdate = new System.Windows.Forms.TextBox();
            this.radioButtonFemaleUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonMaleUpdate = new System.Windows.Forms.RadioButton();
            this.tbxNationalityUpdate = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirthUpdate = new System.Windows.Forms.DateTimePicker();
            this.tbxSurnameUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblAdressUpdate = new System.Windows.Forms.Label();
            this.lblGenderUpdate = new System.Windows.Forms.Label();
            this.lblNationalityUpdate = new System.Windows.Forms.Label();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.lblDateOfBirthUpdate = new System.Windows.Forms.Label();
            this.lblSurnameUpdate = new System.Windows.Forms.Label();
            this.groupBoxDeleteStudent = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBoxClearForm = new System.Windows.Forms.GroupBox();
            this.lblİnfo1 = new System.Windows.Forms.Label();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.lblSearchInfo = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
            this.groupBoxAddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            this.groupBoxUpdateStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdUpdate)).BeginInit();
            this.groupBoxDeleteStudent.SuspendLayout();
            this.groupBoxClearForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwStudents
            // 
            this.dgwStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStudents.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudents.Location = new System.Drawing.Point(10, 53);
            this.dgwStudents.Margin = new System.Windows.Forms.Padding(1);
            this.dgwStudents.Name = "dgwStudents";
            this.dgwStudents.RowTemplate.Height = 25;
            this.dgwStudents.Size = new System.Drawing.Size(1264, 353);
            this.dgwStudents.TabIndex = 0;
            this.dgwStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStudents_CellClick);
            // 
            // groupBoxAddStudent
            // 
            this.groupBoxAddStudent.BackColor = System.Drawing.Color.Aqua;
            this.groupBoxAddStudent.Controls.Add(this.label2);
            this.groupBoxAddStudent.Controls.Add(this.numericUpDownId);
            this.groupBoxAddStudent.Controls.Add(this.lblId);
            this.groupBoxAddStudent.Controls.Add(this.btnCreate);
            this.groupBoxAddStudent.Controls.Add(this.tbxAdress);
            this.groupBoxAddStudent.Controls.Add(this.radioButtonFemale);
            this.groupBoxAddStudent.Controls.Add(this.radioButtonMale);
            this.groupBoxAddStudent.Controls.Add(this.tbxNationality);
            this.groupBoxAddStudent.Controls.Add(this.dtpDateOfBirth);
            this.groupBoxAddStudent.Controls.Add(this.tbxSurname);
            this.groupBoxAddStudent.Controls.Add(this.tbxName);
            this.groupBoxAddStudent.Controls.Add(this.lblAdress);
            this.groupBoxAddStudent.Controls.Add(this.lblGender);
            this.groupBoxAddStudent.Controls.Add(this.lblNationality);
            this.groupBoxAddStudent.Controls.Add(this.lblName);
            this.groupBoxAddStudent.Controls.Add(this.lblDateOfBirth);
            this.groupBoxAddStudent.Controls.Add(this.lblSurname);
            this.groupBoxAddStudent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAddStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxAddStudent.Location = new System.Drawing.Point(10, 411);
            this.groupBoxAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAddStudent.Name = "groupBoxAddStudent";
            this.groupBoxAddStudent.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAddStudent.Size = new System.Drawing.Size(559, 337);
            this.groupBoxAddStudent.TabIndex = 1;
            this.groupBoxAddStudent.TabStop = false;
            this.groupBoxAddStudent.Text = "Add new student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Profile image :";
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(125, 27);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(427, 27);
            this.numericUpDownId.TabIndex = 19;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(8, 29);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 20);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "Id :";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Lime;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(324, 300);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 30);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbxAdress
            // 
            this.tbxAdress.Location = new System.Drawing.Point(125, 222);
            this.tbxAdress.Name = "tbxAdress";
            this.tbxAdress.Size = new System.Drawing.Size(427, 27);
            this.tbxAdress.TabIndex = 16;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonFemale.Location = new System.Drawing.Point(191, 192);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(77, 24);
            this.radioButtonFemale.TabIndex = 15;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonMale.Location = new System.Drawing.Point(125, 192);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(61, 24);
            this.radioButtonMale.TabIndex = 14;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // tbxNationality
            // 
            this.tbxNationality.Location = new System.Drawing.Point(125, 159);
            this.tbxNationality.Name = "tbxNationality";
            this.tbxNationality.Size = new System.Drawing.Size(427, 27);
            this.tbxNationality.TabIndex = 13;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(125, 126);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(427, 27);
            this.dtpDateOfBirth.TabIndex = 12;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(125, 93);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(427, 27);
            this.tbxSurname.TabIndex = 11;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(125, 60);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(427, 27);
            this.tbxName.TabIndex = 10;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdress.Location = new System.Drawing.Point(8, 225);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(65, 20);
            this.lblAdress.TabIndex = 8;
            this.lblAdress.Text = "Adress :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(8, 194);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(68, 20);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender :";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNationality.Location = new System.Drawing.Point(8, 162);
            this.lblNationality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(95, 20);
            this.lblNationality.TabIndex = 6;
            this.lblNationality.Text = "Nationality :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(8, 63);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name :";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfBirth.Location = new System.Drawing.Point(8, 131);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(107, 20);
            this.lblDateOfBirth.TabIndex = 5;
            this.lblDateOfBirth.Text = "Date of birth :";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(8, 96);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(79, 20);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname :";
            // 
            // groupBoxUpdateStudent
            // 
            this.groupBoxUpdateStudent.BackColor = System.Drawing.Color.Aqua;
            this.groupBoxUpdateStudent.Controls.Add(this.numericUpDownIdUpdate);
            this.groupBoxUpdateStudent.Controls.Add(this.lblIdUpdate);
            this.groupBoxUpdateStudent.Controls.Add(this.btnUpdate);
            this.groupBoxUpdateStudent.Controls.Add(this.tbxAdressUpdate);
            this.groupBoxUpdateStudent.Controls.Add(this.radioButtonFemaleUpdate);
            this.groupBoxUpdateStudent.Controls.Add(this.radioButtonMaleUpdate);
            this.groupBoxUpdateStudent.Controls.Add(this.tbxNationalityUpdate);
            this.groupBoxUpdateStudent.Controls.Add(this.dtpDateOfBirthUpdate);
            this.groupBoxUpdateStudent.Controls.Add(this.tbxSurnameUpdate);
            this.groupBoxUpdateStudent.Controls.Add(this.tbxNameUpdate);
            this.groupBoxUpdateStudent.Controls.Add(this.lblAdressUpdate);
            this.groupBoxUpdateStudent.Controls.Add(this.lblGenderUpdate);
            this.groupBoxUpdateStudent.Controls.Add(this.lblNationalityUpdate);
            this.groupBoxUpdateStudent.Controls.Add(this.lblNameUpdate);
            this.groupBoxUpdateStudent.Controls.Add(this.lblDateOfBirthUpdate);
            this.groupBoxUpdateStudent.Controls.Add(this.lblSurnameUpdate);
            this.groupBoxUpdateStudent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxUpdateStudent.Location = new System.Drawing.Point(577, 411);
            this.groupBoxUpdateStudent.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxUpdateStudent.Name = "groupBoxUpdateStudent";
            this.groupBoxUpdateStudent.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxUpdateStudent.Size = new System.Drawing.Size(559, 337);
            this.groupBoxUpdateStudent.TabIndex = 2;
            this.groupBoxUpdateStudent.TabStop = false;
            this.groupBoxUpdateStudent.Text = "Update student";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(1278, 53);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(341, 353);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 22;
            this.pictureBox.TabStop = false;
            // 
            // numericUpDownIdUpdate
            // 
            this.numericUpDownIdUpdate.Location = new System.Drawing.Point(125, 27);
            this.numericUpDownIdUpdate.Name = "numericUpDownIdUpdate";
            this.numericUpDownIdUpdate.Size = new System.Drawing.Size(427, 27);
            this.numericUpDownIdUpdate.TabIndex = 21;
            // 
            // lblIdUpdate
            // 
            this.lblIdUpdate.AutoSize = true;
            this.lblIdUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdUpdate.Location = new System.Drawing.Point(8, 29);
            this.lblIdUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdUpdate.Name = "lblIdUpdate";
            this.lblIdUpdate.Size = new System.Drawing.Size(31, 20);
            this.lblIdUpdate.TabIndex = 20;
            this.lblIdUpdate.Text = "Id :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Khaki;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(324, 300);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxAdressUpdate
            // 
            this.tbxAdressUpdate.Location = new System.Drawing.Point(125, 222);
            this.tbxAdressUpdate.Name = "tbxAdressUpdate";
            this.tbxAdressUpdate.Size = new System.Drawing.Size(427, 27);
            this.tbxAdressUpdate.TabIndex = 16;
            // 
            // radioButtonFemaleUpdate
            // 
            this.radioButtonFemaleUpdate.AutoSize = true;
            this.radioButtonFemaleUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonFemaleUpdate.Location = new System.Drawing.Point(191, 192);
            this.radioButtonFemaleUpdate.Name = "radioButtonFemaleUpdate";
            this.radioButtonFemaleUpdate.Size = new System.Drawing.Size(77, 24);
            this.radioButtonFemaleUpdate.TabIndex = 15;
            this.radioButtonFemaleUpdate.TabStop = true;
            this.radioButtonFemaleUpdate.Text = "Female";
            this.radioButtonFemaleUpdate.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaleUpdate
            // 
            this.radioButtonMaleUpdate.AutoSize = true;
            this.radioButtonMaleUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonMaleUpdate.Location = new System.Drawing.Point(125, 192);
            this.radioButtonMaleUpdate.Name = "radioButtonMaleUpdate";
            this.radioButtonMaleUpdate.Size = new System.Drawing.Size(61, 24);
            this.radioButtonMaleUpdate.TabIndex = 14;
            this.radioButtonMaleUpdate.TabStop = true;
            this.radioButtonMaleUpdate.Text = "Male";
            this.radioButtonMaleUpdate.UseVisualStyleBackColor = true;
            // 
            // tbxNationalityUpdate
            // 
            this.tbxNationalityUpdate.Location = new System.Drawing.Point(125, 159);
            this.tbxNationalityUpdate.Name = "tbxNationalityUpdate";
            this.tbxNationalityUpdate.Size = new System.Drawing.Size(427, 27);
            this.tbxNationalityUpdate.TabIndex = 13;
            // 
            // dtpDateOfBirthUpdate
            // 
            this.dtpDateOfBirthUpdate.Location = new System.Drawing.Point(125, 126);
            this.dtpDateOfBirthUpdate.Name = "dtpDateOfBirthUpdate";
            this.dtpDateOfBirthUpdate.Size = new System.Drawing.Size(427, 27);
            this.dtpDateOfBirthUpdate.TabIndex = 12;
            // 
            // tbxSurnameUpdate
            // 
            this.tbxSurnameUpdate.Location = new System.Drawing.Point(125, 93);
            this.tbxSurnameUpdate.Name = "tbxSurnameUpdate";
            this.tbxSurnameUpdate.Size = new System.Drawing.Size(427, 27);
            this.tbxSurnameUpdate.TabIndex = 11;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(125, 60);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(427, 27);
            this.tbxNameUpdate.TabIndex = 10;
            // 
            // lblAdressUpdate
            // 
            this.lblAdressUpdate.AutoSize = true;
            this.lblAdressUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdressUpdate.Location = new System.Drawing.Point(8, 225);
            this.lblAdressUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdressUpdate.Name = "lblAdressUpdate";
            this.lblAdressUpdate.Size = new System.Drawing.Size(65, 20);
            this.lblAdressUpdate.TabIndex = 8;
            this.lblAdressUpdate.Text = "Adress :";
            // 
            // lblGenderUpdate
            // 
            this.lblGenderUpdate.AutoSize = true;
            this.lblGenderUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenderUpdate.Location = new System.Drawing.Point(8, 194);
            this.lblGenderUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenderUpdate.Name = "lblGenderUpdate";
            this.lblGenderUpdate.Size = new System.Drawing.Size(68, 20);
            this.lblGenderUpdate.TabIndex = 7;
            this.lblGenderUpdate.Text = "Gender :";
            // 
            // lblNationalityUpdate
            // 
            this.lblNationalityUpdate.AutoSize = true;
            this.lblNationalityUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNationalityUpdate.Location = new System.Drawing.Point(8, 162);
            this.lblNationalityUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNationalityUpdate.Name = "lblNationalityUpdate";
            this.lblNationalityUpdate.Size = new System.Drawing.Size(95, 20);
            this.lblNationalityUpdate.TabIndex = 6;
            this.lblNationalityUpdate.Text = "Nationality :";
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameUpdate.Location = new System.Drawing.Point(8, 63);
            this.lblNameUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(59, 20);
            this.lblNameUpdate.TabIndex = 3;
            this.lblNameUpdate.Text = "Name :";
            // 
            // lblDateOfBirthUpdate
            // 
            this.lblDateOfBirthUpdate.AutoSize = true;
            this.lblDateOfBirthUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfBirthUpdate.Location = new System.Drawing.Point(8, 131);
            this.lblDateOfBirthUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfBirthUpdate.Name = "lblDateOfBirthUpdate";
            this.lblDateOfBirthUpdate.Size = new System.Drawing.Size(107, 20);
            this.lblDateOfBirthUpdate.TabIndex = 5;
            this.lblDateOfBirthUpdate.Text = "Date of birth :";
            // 
            // lblSurnameUpdate
            // 
            this.lblSurnameUpdate.AutoSize = true;
            this.lblSurnameUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSurnameUpdate.Location = new System.Drawing.Point(8, 94);
            this.lblSurnameUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurnameUpdate.Name = "lblSurnameUpdate";
            this.lblSurnameUpdate.Size = new System.Drawing.Size(79, 20);
            this.lblSurnameUpdate.TabIndex = 4;
            this.lblSurnameUpdate.Text = "Surname :";
            // 
            // groupBoxDeleteStudent
            // 
            this.groupBoxDeleteStudent.BackColor = System.Drawing.Color.Aqua;
            this.groupBoxDeleteStudent.Controls.Add(this.label1);
            this.groupBoxDeleteStudent.Controls.Add(this.btnDelete);
            this.groupBoxDeleteStudent.Location = new System.Drawing.Point(1143, 410);
            this.groupBoxDeleteStudent.Name = "groupBoxDeleteStudent";
            this.groupBoxDeleteStudent.Size = new System.Drawing.Size(476, 164);
            this.groupBoxDeleteStudent.TabIndex = 3;
            this.groupBoxDeleteStudent.TabStop = false;
            this.groupBoxDeleteStudent.Text = "Delete student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "If you want to delete a student from the system, click on the \r\nstudent and click" +
    " the \"Delete\" button";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(370, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBoxClearForm
            // 
            this.groupBoxClearForm.BackColor = System.Drawing.Color.Aqua;
            this.groupBoxClearForm.Controls.Add(this.lblİnfo1);
            this.groupBoxClearForm.Controls.Add(this.btnClearForm);
            this.groupBoxClearForm.Location = new System.Drawing.Point(1143, 580);
            this.groupBoxClearForm.Name = "groupBoxClearForm";
            this.groupBoxClearForm.Size = new System.Drawing.Size(476, 164);
            this.groupBoxClearForm.TabIndex = 4;
            this.groupBoxClearForm.TabStop = false;
            this.groupBoxClearForm.Text = "Clear Form";
            // 
            // lblİnfo1
            // 
            this.lblİnfo1.AutoSize = true;
            this.lblİnfo1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblİnfo1.Location = new System.Drawing.Point(6, 23);
            this.lblİnfo1.Name = "lblİnfo1";
            this.lblİnfo1.Size = new System.Drawing.Size(444, 40);
            this.lblİnfo1.TabIndex = 1;
            this.lblİnfo1.Text = "If you click the \"Clear form\" button, all elements in the form \r\nwill be cleared." +
    "";
            // 
            // btnClearForm
            // 
            this.btnClearForm.BackColor = System.Drawing.Color.Yellow;
            this.btnClearForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearForm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearForm.Location = new System.Drawing.Point(369, 128);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(100, 30);
            this.btnClearForm.TabIndex = 0;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = false;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // lblSearchInfo
            // 
            this.lblSearchInfo.AutoSize = true;
            this.lblSearchInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchInfo.Location = new System.Drawing.Point(1036, 15);
            this.lblSearchInfo.Name = "lblSearchInfo";
            this.lblSearchInfo.Size = new System.Drawing.Size(192, 20);
            this.lblSearchInfo.TabIndex = 5;
            this.lblSearchInfo.Text = "Search students by name :";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(1234, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(385, 27);
            this.tbxSearch.TabIndex = 6;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // frmStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1624, 761);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearchInfo);
            this.Controls.Add(this.groupBoxClearForm);
            this.Controls.Add(this.groupBoxDeleteStudent);
            this.Controls.Add(this.groupBoxUpdateStudent);
            this.Controls.Add(this.groupBoxAddStudent);
            this.Controls.Add(this.dgwStudents);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmStudentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
            this.groupBoxAddStudent.ResumeLayout(false);
            this.groupBoxAddStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            this.groupBoxUpdateStudent.ResumeLayout(false);
            this.groupBoxUpdateStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdUpdate)).EndInit();
            this.groupBoxDeleteStudent.ResumeLayout(false);
            this.groupBoxDeleteStudent.PerformLayout();
            this.groupBoxClearForm.ResumeLayout(false);
            this.groupBoxClearForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwStudents;
        private System.Windows.Forms.GroupBox groupBoxAddStudent;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbxAdress;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.TextBox tbxNationality;
        private System.Windows.Forms.GroupBox groupBoxUpdateStudent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxAdressUpdate;
        private System.Windows.Forms.RadioButton radioButtonFemaleUpdate;
        private System.Windows.Forms.RadioButton radioButtonMaleUpdate;
        private System.Windows.Forms.TextBox tbxNationalityUpdate;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirthUpdate;
        private System.Windows.Forms.TextBox tbxSurnameUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblAdressUpdate;
        private System.Windows.Forms.Label lblGenderUpdate;
        private System.Windows.Forms.Label lblNationalityUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Label lblDateOfBirthUpdate;
        private System.Windows.Forms.Label lblSurnameUpdate;
        private System.Windows.Forms.GroupBox groupBoxDeleteStudent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBoxClearForm;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.NumericUpDown numericUpDownId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.NumericUpDown numericUpDownIdUpdate;
        private System.Windows.Forms.Label lblIdUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblİnfo1;
        private System.Windows.Forms.Label lblSearchInfo;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
