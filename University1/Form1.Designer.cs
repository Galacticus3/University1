namespace University1
{
    partial class Form1
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
            this.btnShowAllGroups = new System.Windows.Forms.Button();
            this.btnShowAllSubjects = new System.Windows.Forms.Button();
            this.btnShowAllStudents = new System.Windows.Forms.Button();
            this.dtGridGroups = new System.Windows.Forms.DataGridView();
            this.dtGridSubjects = new System.Windows.Forms.DataGridView();
            this.dtGridStudents = new System.Windows.Forms.DataGridView();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtStudFName = new System.Windows.Forms.TextBox();
            this.txtStudLName = new System.Windows.Forms.TextBox();
            this.txtStudAge = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblStudId = new System.Windows.Forms.Label();
            this.lblStudFirstName = new System.Windows.Forms.Label();
            this.lblStudLastName = new System.Windows.Forms.Label();
            this.lblStudAge = new System.Windows.Forms.Label();
            this.lblStudGroup = new System.Windows.Forms.Label();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnAddNewStudent = new System.Windows.Forms.Button();
            this.btnDeleteCurrentGroup = new System.Windows.Forms.Button();
            this.btnUpdateGroup = new System.Windows.Forms.Button();
            this.btnUpdateSubject = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.cmbStudGroup = new System.Windows.Forms.ComboBox();
            this.btnUpdateCurStud = new System.Windows.Forms.Button();
            this.btnDelCurStud = new System.Windows.Forms.Button();
            this.lblGroupSunj = new System.Windows.Forms.Label();
            this.dtGridGroupStud = new System.Windows.Forms.DataGridView();
            this.cmbGrSbjGroup = new System.Windows.Forms.ComboBox();
            this.cmbGrSbjSubject = new System.Windows.Forms.ComboBox();
            this.lblGrSbjGroup = new System.Windows.Forms.Label();
            this.lblGrSbjSubject = new System.Windows.Forms.Label();
            this.btnShowAllGropSubj = new System.Windows.Forms.Button();
            this.btnAddGrSubj = new System.Windows.Forms.Button();
            this.btnDeleteGrSubj = new System.Windows.Forms.Button();
            this.dtGridGrOrSubj = new System.Windows.Forms.DataGridView();
            this.btnAllSubjetcsOfGroup = new System.Windows.Forms.Button();
            this.btnSubjectInGroups = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridGroupStud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridGrOrSubj)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAllGroups
            // 
            this.btnShowAllGroups.Location = new System.Drawing.Point(12, 12);
            this.btnShowAllGroups.Name = "btnShowAllGroups";
            this.btnShowAllGroups.Size = new System.Drawing.Size(149, 23);
            this.btnShowAllGroups.TabIndex = 0;
            this.btnShowAllGroups.Text = "All groups";
            this.btnShowAllGroups.UseVisualStyleBackColor = true;
            this.btnShowAllGroups.Click += new System.EventHandler(this.btnShowAllGroups_Click);
            // 
            // btnShowAllSubjects
            // 
            this.btnShowAllSubjects.Location = new System.Drawing.Point(265, 12);
            this.btnShowAllSubjects.Name = "btnShowAllSubjects";
            this.btnShowAllSubjects.Size = new System.Drawing.Size(149, 23);
            this.btnShowAllSubjects.TabIndex = 1;
            this.btnShowAllSubjects.Text = "All subjects";
            this.btnShowAllSubjects.UseVisualStyleBackColor = true;
            this.btnShowAllSubjects.Click += new System.EventHandler(this.btnShowAllSubjects_Click);
            // 
            // btnShowAllStudents
            // 
            this.btnShowAllStudents.Location = new System.Drawing.Point(905, 12);
            this.btnShowAllStudents.Name = "btnShowAllStudents";
            this.btnShowAllStudents.Size = new System.Drawing.Size(149, 23);
            this.btnShowAllStudents.TabIndex = 2;
            this.btnShowAllStudents.Text = "All students";
            this.btnShowAllStudents.UseVisualStyleBackColor = true;
            this.btnShowAllStudents.Click += new System.EventHandler(this.btnShowAllStudents_Click);
            // 
            // dtGridGroups
            // 
            this.dtGridGroups.AllowUserToAddRows = false;
            this.dtGridGroups.AllowUserToDeleteRows = false;
            this.dtGridGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridGroups.Location = new System.Drawing.Point(12, 51);
            this.dtGridGroups.Name = "dtGridGroups";
            this.dtGridGroups.ReadOnly = true;
            this.dtGridGroups.Size = new System.Drawing.Size(247, 198);
            this.dtGridGroups.TabIndex = 3;
            this.dtGridGroups.SelectionChanged += new System.EventHandler(this.dtGridGroups_SelectionChanged);
            // 
            // dtGridSubjects
            // 
            this.dtGridSubjects.AllowUserToAddRows = false;
            this.dtGridSubjects.AllowUserToDeleteRows = false;
            this.dtGridSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSubjects.Location = new System.Drawing.Point(265, 51);
            this.dtGridSubjects.Name = "dtGridSubjects";
            this.dtGridSubjects.ReadOnly = true;
            this.dtGridSubjects.Size = new System.Drawing.Size(260, 198);
            this.dtGridSubjects.TabIndex = 4;
            this.dtGridSubjects.SelectionChanged += new System.EventHandler(this.dtGridSubjects_SelectionChanged_1);
            // 
            // dtGridStudents
            // 
            this.dtGridStudents.AllowUserToAddRows = false;
            this.dtGridStudents.AllowUserToDeleteRows = false;
            this.dtGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridStudents.Location = new System.Drawing.Point(905, 51);
            this.dtGridStudents.Name = "dtGridStudents";
            this.dtGridStudents.ReadOnly = true;
            this.dtGridStudents.Size = new System.Drawing.Size(557, 198);
            this.dtGridStudents.TabIndex = 5;
            this.dtGridStudents.SelectionChanged += new System.EventHandler(this.dtGridStudents_SelectionChanged);
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(12, 285);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(118, 20);
            this.txtGroup.TabIndex = 6;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(265, 284);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(118, 20);
            this.txtSubject.TabIndex = 7;
            // 
            // txtStudFName
            // 
            this.txtStudFName.Location = new System.Drawing.Point(968, 285);
            this.txtStudFName.Name = "txtStudFName";
            this.txtStudFName.Size = new System.Drawing.Size(62, 20);
            this.txtStudFName.TabIndex = 9;
            // 
            // txtStudLName
            // 
            this.txtStudLName.Location = new System.Drawing.Point(1101, 285);
            this.txtStudLName.Name = "txtStudLName";
            this.txtStudLName.Size = new System.Drawing.Size(77, 20);
            this.txtStudLName.TabIndex = 10;
            // 
            // txtStudAge
            // 
            this.txtStudAge.Location = new System.Drawing.Point(1219, 285);
            this.txtStudAge.Name = "txtStudAge";
            this.txtStudAge.Size = new System.Drawing.Size(53, 20);
            this.txtStudAge.TabIndex = 11;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(9, 265);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(117, 13);
            this.lblGroup.TabIndex = 12;
            this.lblGroup.Text = "Enter new group name:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(262, 265);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(124, 13);
            this.lblSubject.TabIndex = 13;
            this.lblSubject.Text = "Enter new subject name:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(902, 265);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(143, 13);
            this.lblStudent.TabIndex = 14;
            this.lblStudent.Text = "Enter info about new student";
            // 
            // lblStudId
            // 
            this.lblStudId.AutoSize = true;
            this.lblStudId.Location = new System.Drawing.Point(904, 288);
            this.lblStudId.Name = "lblStudId";
            this.lblStudId.Size = new System.Drawing.Size(0, 13);
            this.lblStudId.TabIndex = 15;
            // 
            // lblStudFirstName
            // 
            this.lblStudFirstName.AutoSize = true;
            this.lblStudFirstName.Location = new System.Drawing.Point(904, 290);
            this.lblStudFirstName.Name = "lblStudFirstName";
            this.lblStudFirstName.Size = new System.Drawing.Size(58, 13);
            this.lblStudFirstName.TabIndex = 16;
            this.lblStudFirstName.Text = "First name:";
            // 
            // lblStudLastName
            // 
            this.lblStudLastName.AutoSize = true;
            this.lblStudLastName.Location = new System.Drawing.Point(1036, 290);
            this.lblStudLastName.Name = "lblStudLastName";
            this.lblStudLastName.Size = new System.Drawing.Size(59, 13);
            this.lblStudLastName.TabIndex = 17;
            this.lblStudLastName.Text = "Last name:";
            // 
            // lblStudAge
            // 
            this.lblStudAge.AutoSize = true;
            this.lblStudAge.Location = new System.Drawing.Point(1184, 289);
            this.lblStudAge.Name = "lblStudAge";
            this.lblStudAge.Size = new System.Drawing.Size(29, 13);
            this.lblStudAge.TabIndex = 18;
            this.lblStudAge.Text = "Age:";
            // 
            // lblStudGroup
            // 
            this.lblStudGroup.AutoSize = true;
            this.lblStudGroup.Location = new System.Drawing.Point(1278, 289);
            this.lblStudGroup.Name = "lblStudGroup";
            this.lblStudGroup.Size = new System.Drawing.Size(39, 13);
            this.lblStudGroup.TabIndex = 19;
            this.lblStudGroup.Text = "Group:";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(12, 320);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(149, 23);
            this.btnAddGroup.TabIndex = 20;
            this.btnAddGroup.Text = "Add group name";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(265, 320);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(149, 23);
            this.btnAddSubject.TabIndex = 21;
            this.btnAddSubject.Text = "Add subject name";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.Location = new System.Drawing.Point(907, 320);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.Size = new System.Drawing.Size(149, 23);
            this.btnAddNewStudent.TabIndex = 22;
            this.btnAddNewStudent.Text = "Add new student";
            this.btnAddNewStudent.UseVisualStyleBackColor = true;
            this.btnAddNewStudent.Click += new System.EventHandler(this.btnAddNewStudent_Click);
            // 
            // btnDeleteCurrentGroup
            // 
            this.btnDeleteCurrentGroup.Location = new System.Drawing.Point(12, 378);
            this.btnDeleteCurrentGroup.Name = "btnDeleteCurrentGroup";
            this.btnDeleteCurrentGroup.Size = new System.Drawing.Size(149, 23);
            this.btnDeleteCurrentGroup.TabIndex = 23;
            this.btnDeleteCurrentGroup.Text = "Delete current group";
            this.btnDeleteCurrentGroup.UseVisualStyleBackColor = true;
            this.btnDeleteCurrentGroup.Click += new System.EventHandler(this.btnDeleteCurrentGroup_Click);
            // 
            // btnUpdateGroup
            // 
            this.btnUpdateGroup.Location = new System.Drawing.Point(12, 349);
            this.btnUpdateGroup.Name = "btnUpdateGroup";
            this.btnUpdateGroup.Size = new System.Drawing.Size(149, 23);
            this.btnUpdateGroup.TabIndex = 24;
            this.btnUpdateGroup.Text = "Update current group ";
            this.btnUpdateGroup.UseVisualStyleBackColor = true;
            this.btnUpdateGroup.Click += new System.EventHandler(this.btnUpdateGroup_Click);
            // 
            // btnUpdateSubject
            // 
            this.btnUpdateSubject.Location = new System.Drawing.Point(265, 349);
            this.btnUpdateSubject.Name = "btnUpdateSubject";
            this.btnUpdateSubject.Size = new System.Drawing.Size(149, 23);
            this.btnUpdateSubject.TabIndex = 25;
            this.btnUpdateSubject.Text = "Update current subject";
            this.btnUpdateSubject.UseVisualStyleBackColor = true;
            this.btnUpdateSubject.Click += new System.EventHandler(this.btnUpdateSubject_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Location = new System.Drawing.Point(265, 378);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(149, 23);
            this.btnDeleteSubject.TabIndex = 26;
            this.btnDeleteSubject.Text = "Delete current subject";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // cmbStudGroup
            // 
            this.cmbStudGroup.FormattingEnabled = true;
            this.cmbStudGroup.Location = new System.Drawing.Point(1320, 284);
            this.cmbStudGroup.Name = "cmbStudGroup";
            this.cmbStudGroup.Size = new System.Drawing.Size(139, 21);
            this.cmbStudGroup.TabIndex = 27;
            // 
            // btnUpdateCurStud
            // 
            this.btnUpdateCurStud.Location = new System.Drawing.Point(905, 349);
            this.btnUpdateCurStud.Name = "btnUpdateCurStud";
            this.btnUpdateCurStud.Size = new System.Drawing.Size(149, 23);
            this.btnUpdateCurStud.TabIndex = 29;
            this.btnUpdateCurStud.Text = "Update current student";
            this.btnUpdateCurStud.UseVisualStyleBackColor = true;
            this.btnUpdateCurStud.Click += new System.EventHandler(this.btnUpdateCurStud_Click);
            // 
            // btnDelCurStud
            // 
            this.btnDelCurStud.Location = new System.Drawing.Point(907, 378);
            this.btnDelCurStud.Name = "btnDelCurStud";
            this.btnDelCurStud.Size = new System.Drawing.Size(149, 23);
            this.btnDelCurStud.TabIndex = 30;
            this.btnDelCurStud.Text = "Delete current student";
            this.btnDelCurStud.UseVisualStyleBackColor = true;
            this.btnDelCurStud.Click += new System.EventHandler(this.btnDelCurStud_Click);
            // 
            // lblGroupSunj
            // 
            this.lblGroupSunj.AutoSize = true;
            this.lblGroupSunj.Location = new System.Drawing.Point(528, 265);
            this.lblGroupSunj.Name = "lblGroupSunj";
            this.lblGroupSunj.Size = new System.Drawing.Size(111, 13);
            this.lblGroupSunj.TabIndex = 31;
            this.lblGroupSunj.Text = "Enter new connection";
            // 
            // dtGridGroupStud
            // 
            this.dtGridGroupStud.AllowUserToAddRows = false;
            this.dtGridGroupStud.AllowUserToDeleteRows = false;
            this.dtGridGroupStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridGroupStud.Location = new System.Drawing.Point(531, 51);
            this.dtGridGroupStud.Name = "dtGridGroupStud";
            this.dtGridGroupStud.ReadOnly = true;
            this.dtGridGroupStud.Size = new System.Drawing.Size(368, 198);
            this.dtGridGroupStud.TabIndex = 32;
            this.dtGridGroupStud.SelectionChanged += new System.EventHandler(this.dtGridGroupStud_SelectionChanged);
            // 
            // cmbGrSbjGroup
            // 
            this.cmbGrSbjGroup.FormattingEnabled = true;
            this.cmbGrSbjGroup.Location = new System.Drawing.Point(604, 284);
            this.cmbGrSbjGroup.Name = "cmbGrSbjGroup";
            this.cmbGrSbjGroup.Size = new System.Drawing.Size(81, 21);
            this.cmbGrSbjGroup.TabIndex = 33;
            // 
            // cmbGrSbjSubject
            // 
            this.cmbGrSbjSubject.FormattingEnabled = true;
            this.cmbGrSbjSubject.Location = new System.Drawing.Point(785, 284);
            this.cmbGrSbjSubject.Name = "cmbGrSbjSubject";
            this.cmbGrSbjSubject.Size = new System.Drawing.Size(103, 21);
            this.cmbGrSbjSubject.TabIndex = 34;
            // 
            // lblGrSbjGroup
            // 
            this.lblGrSbjGroup.AutoSize = true;
            this.lblGrSbjGroup.Location = new System.Drawing.Point(528, 288);
            this.lblGrSbjGroup.Name = "lblGrSbjGroup";
            this.lblGrSbjGroup.Size = new System.Drawing.Size(70, 13);
            this.lblGrSbjGroup.TabIndex = 35;
            this.lblGrSbjGroup.Text = "Select group:";
            // 
            // lblGrSbjSubject
            // 
            this.lblGrSbjSubject.AutoSize = true;
            this.lblGrSbjSubject.Location = new System.Drawing.Point(702, 287);
            this.lblGrSbjSubject.Name = "lblGrSbjSubject";
            this.lblGrSbjSubject.Size = new System.Drawing.Size(77, 13);
            this.lblGrSbjSubject.TabIndex = 36;
            this.lblGrSbjSubject.Text = "Select subject:";
            // 
            // btnShowAllGropSubj
            // 
            this.btnShowAllGropSubj.Location = new System.Drawing.Point(531, 12);
            this.btnShowAllGropSubj.Name = "btnShowAllGropSubj";
            this.btnShowAllGropSubj.Size = new System.Drawing.Size(149, 23);
            this.btnShowAllGropSubj.TabIndex = 37;
            this.btnShowAllGropSubj.Text = "All groups with subjects";
            this.btnShowAllGropSubj.UseVisualStyleBackColor = true;
            this.btnShowAllGropSubj.Click += new System.EventHandler(this.btnShowAllGropSubj_Click);
            // 
            // btnAddGrSubj
            // 
            this.btnAddGrSubj.Location = new System.Drawing.Point(531, 320);
            this.btnAddGrSubj.Name = "btnAddGrSubj";
            this.btnAddGrSubj.Size = new System.Drawing.Size(196, 23);
            this.btnAddGrSubj.TabIndex = 38;
            this.btnAddGrSubj.Text = "Add group - subject";
            this.btnAddGrSubj.UseVisualStyleBackColor = true;
            this.btnAddGrSubj.Click += new System.EventHandler(this.btnAddGrSubj_Click);
            // 
            // btnDeleteGrSubj
            // 
            this.btnDeleteGrSubj.Location = new System.Drawing.Point(531, 349);
            this.btnDeleteGrSubj.Name = "btnDeleteGrSubj";
            this.btnDeleteGrSubj.Size = new System.Drawing.Size(196, 23);
            this.btnDeleteGrSubj.TabIndex = 40;
            this.btnDeleteGrSubj.Text = "Delete current group - subject";
            this.btnDeleteGrSubj.UseVisualStyleBackColor = true;
            this.btnDeleteGrSubj.Click += new System.EventHandler(this.btnDeleteGrSubj_Click);
            // 
            // dtGridGrOrSubj
            // 
            this.dtGridGrOrSubj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridGrOrSubj.Location = new System.Drawing.Point(531, 407);
            this.dtGridGrOrSubj.Name = "dtGridGrOrSubj";
            this.dtGridGrOrSubj.Size = new System.Drawing.Size(368, 144);
            this.dtGridGrOrSubj.TabIndex = 41;
            // 
            // btnAllSubjetcsOfGroup
            // 
            this.btnAllSubjetcsOfGroup.Location = new System.Drawing.Point(531, 378);
            this.btnAllSubjetcsOfGroup.Name = "btnAllSubjetcsOfGroup";
            this.btnAllSubjetcsOfGroup.Size = new System.Drawing.Size(196, 23);
            this.btnAllSubjetcsOfGroup.TabIndex = 42;
            this.btnAllSubjetcsOfGroup.Text = "Sujects in current group";
            this.btnAllSubjetcsOfGroup.UseVisualStyleBackColor = true;
            this.btnAllSubjetcsOfGroup.Click += new System.EventHandler(this.btnAllSubjetcsOfGroup_Click);
            // 
            // btnSubjectInGroups
            // 
            this.btnSubjectInGroups.Location = new System.Drawing.Point(733, 378);
            this.btnSubjectInGroups.Name = "btnSubjectInGroups";
            this.btnSubjectInGroups.Size = new System.Drawing.Size(166, 23);
            this.btnSubjectInGroups.TabIndex = 43;
            this.btnSubjectInGroups.Text = "Groups wich have curr subject";
            this.btnSubjectInGroups.UseVisualStyleBackColor = true;
            this.btnSubjectInGroups.Click += new System.EventHandler(this.btnSubjectInGroups_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1467, 558);
            this.Controls.Add(this.btnSubjectInGroups);
            this.Controls.Add(this.btnAllSubjetcsOfGroup);
            this.Controls.Add(this.dtGridGrOrSubj);
            this.Controls.Add(this.btnDeleteGrSubj);
            this.Controls.Add(this.btnAddGrSubj);
            this.Controls.Add(this.btnShowAllGropSubj);
            this.Controls.Add(this.lblGrSbjSubject);
            this.Controls.Add(this.lblGrSbjGroup);
            this.Controls.Add(this.cmbGrSbjSubject);
            this.Controls.Add(this.cmbGrSbjGroup);
            this.Controls.Add(this.dtGridGroupStud);
            this.Controls.Add(this.lblGroupSunj);
            this.Controls.Add(this.btnDelCurStud);
            this.Controls.Add(this.btnUpdateCurStud);
            this.Controls.Add(this.cmbStudGroup);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnUpdateSubject);
            this.Controls.Add(this.btnUpdateGroup);
            this.Controls.Add(this.btnDeleteCurrentGroup);
            this.Controls.Add(this.btnAddNewStudent);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.lblStudGroup);
            this.Controls.Add(this.lblStudAge);
            this.Controls.Add(this.lblStudLastName);
            this.Controls.Add(this.lblStudFirstName);
            this.Controls.Add(this.lblStudId);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.txtStudAge);
            this.Controls.Add(this.txtStudLName);
            this.Controls.Add(this.txtStudFName);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.dtGridStudents);
            this.Controls.Add(this.dtGridSubjects);
            this.Controls.Add(this.dtGridGroups);
            this.Controls.Add(this.btnShowAllStudents);
            this.Controls.Add(this.btnShowAllSubjects);
            this.Controls.Add(this.btnShowAllGroups);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridGroupStud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridGrOrSubj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAllGroups;
        private System.Windows.Forms.Button btnShowAllSubjects;
        private System.Windows.Forms.Button btnShowAllStudents;
        private System.Windows.Forms.DataGridView dtGridGroups;
        private System.Windows.Forms.DataGridView dtGridSubjects;
        private System.Windows.Forms.DataGridView dtGridStudents;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtStudFName;
        private System.Windows.Forms.TextBox txtStudLName;
        private System.Windows.Forms.TextBox txtStudAge;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblStudId;
        private System.Windows.Forms.Label lblStudFirstName;
        private System.Windows.Forms.Label lblStudLastName;
        private System.Windows.Forms.Label lblStudAge;
        private System.Windows.Forms.Label lblStudGroup;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnAddNewStudent;
        private System.Windows.Forms.Button btnDeleteCurrentGroup;
        private System.Windows.Forms.Button btnUpdateGroup;
        private System.Windows.Forms.Button btnUpdateSubject;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.ComboBox cmbStudGroup;
        private System.Windows.Forms.Button btnUpdateCurStud;
        private System.Windows.Forms.Button btnDelCurStud;
        private System.Windows.Forms.Label lblGroupSunj;
        private System.Windows.Forms.DataGridView dtGridGroupStud;
        private System.Windows.Forms.ComboBox cmbGrSbjGroup;
        private System.Windows.Forms.ComboBox cmbGrSbjSubject;
        private System.Windows.Forms.Label lblGrSbjGroup;
        private System.Windows.Forms.Label lblGrSbjSubject;
        private System.Windows.Forms.Button btnShowAllGropSubj;
        private System.Windows.Forms.Button btnAddGrSubj;
        private System.Windows.Forms.Button btnDeleteGrSubj;
        private System.Windows.Forms.DataGridView dtGridGrOrSubj;
        private System.Windows.Forms.Button btnAllSubjetcsOfGroup;
        private System.Windows.Forms.Button btnSubjectInGroups;
    }
}

