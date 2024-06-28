namespace Приложение_для_деканата_v1
{
    partial class GeneralForm
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
            this.studentsPage = new System.Windows.Forms.TabPage();
            this.UpdateStudents = new System.Windows.Forms.Button();
            this.DeleteStudents = new System.Windows.Forms.Button();
            this.InsertStudents = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.checkboxStudents = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewLinkColumn();
            this.IdGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPage = new System.Windows.Forms.TabPage();
            this.InsertGroup = new System.Windows.Forms.Button();
            this.DeleteGroup = new System.Windows.Forms.Button();
            this.UpdateGroup = new System.Windows.Forms.Button();
            this.dataGridViewGroup = new System.Windows.Forms.DataGridView();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_group = new System.Windows.Forms.DataGridViewLinkColumn();
            this.num_of_semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_of_students_ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_of_subjects_ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current_semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.examinersPage = new System.Windows.Forms.TabPage();
            this.DeleteExaminers = new System.Windows.Forms.Button();
            this.InsertExaminers = new System.Windows.Forms.Button();
            this.UpdateExaminers = new System.Windows.Forms.Button();
            this.dataGridViewExaminers = new System.Windows.Forms.DataGridView();
            this.checkboxExaminers = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_examiner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examinersName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.subjectsPage = new System.Windows.Forms.TabPage();
            this.dataGridViewSubjects = new System.Windows.Forms.DataGridView();
            this.checkboxSubjects = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameSubjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateSubjets = new System.Windows.Forms.Button();
            this.InsertSubjects = new System.Windows.Forms.Button();
            this.DeleteSubjects = new System.Windows.Forms.Button();
            this.studentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.groupPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroup)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.examinersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExaminers)).BeginInit();
            this.subjectsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsPage
            // 
            this.studentsPage.Controls.Add(this.UpdateStudents);
            this.studentsPage.Controls.Add(this.DeleteStudents);
            this.studentsPage.Controls.Add(this.InsertStudents);
            this.studentsPage.Controls.Add(this.dataGridViewStudents);
            this.studentsPage.Location = new System.Drawing.Point(4, 25);
            this.studentsPage.Name = "studentsPage";
            this.studentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentsPage.Size = new System.Drawing.Size(925, 398);
            this.studentsPage.TabIndex = 1;
            this.studentsPage.Text = "Студенты";
            this.studentsPage.UseVisualStyleBackColor = true;
            // 
            // UpdateStudents
            // 
            this.UpdateStudents.Location = new System.Drawing.Point(32, 333);
            this.UpdateStudents.Name = "UpdateStudents";
            this.UpdateStudents.Size = new System.Drawing.Size(200, 30);
            this.UpdateStudents.TabIndex = 3;
            this.UpdateStudents.Text = "Обновить таблицу";
            this.UpdateStudents.UseVisualStyleBackColor = true;
            this.UpdateStudents.Click += new System.EventHandler(this.UpdateStudents_Click);
            // 
            // DeleteStudents
            // 
            this.DeleteStudents.Location = new System.Drawing.Point(790, 338);
            this.DeleteStudents.Name = "DeleteStudents";
            this.DeleteStudents.Size = new System.Drawing.Size(100, 25);
            this.DeleteStudents.TabIndex = 2;
            this.DeleteStudents.Text = "Удалить";
            this.DeleteStudents.UseVisualStyleBackColor = true;
            this.DeleteStudents.Click += new System.EventHandler(this.DeleteStudents_Click);
            // 
            // InsertStudents
            // 
            this.InsertStudents.Location = new System.Drawing.Point(684, 338);
            this.InsertStudents.Name = "InsertStudents";
            this.InsertStudents.Size = new System.Drawing.Size(100, 25);
            this.InsertStudents.TabIndex = 1;
            this.InsertStudents.Text = "Добавить";
            this.InsertStudents.UseVisualStyleBackColor = true;
            this.InsertStudents.Click += new System.EventHandler(this.InsertStudents_Click);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkboxStudents,
            this.id_student,
            this.fullname,
            this.IdGroup});
            this.dataGridViewStudents.Location = new System.Drawing.Point(32, 53);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(858, 219);
            this.dataGridViewStudents.TabIndex = 0;
            this.dataGridViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellContentClick);
            // 
            // checkboxStudents
            // 
            this.checkboxStudents.HeaderText = "";
            this.checkboxStudents.MinimumWidth = 6;
            this.checkboxStudents.Name = "checkboxStudents";
            // 
            // id_student
            // 
            this.id_student.HeaderText = "ID-код";
            this.id_student.MinimumWidth = 6;
            this.id_student.Name = "id_student";
            this.id_student.ReadOnly = true;
            this.id_student.Visible = false;
            // 
            // fullname
            // 
            this.fullname.HeaderText = "ФИО";
            this.fullname.MinimumWidth = 6;
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            this.fullname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fullname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IdGroup
            // 
            this.IdGroup.HeaderText = "Группа";
            this.IdGroup.MinimumWidth = 6;
            this.IdGroup.Name = "IdGroup";
            this.IdGroup.ReadOnly = true;
            // 
            // groupPage
            // 
            this.groupPage.Controls.Add(this.InsertGroup);
            this.groupPage.Controls.Add(this.DeleteGroup);
            this.groupPage.Controls.Add(this.UpdateGroup);
            this.groupPage.Controls.Add(this.dataGridViewGroup);
            this.groupPage.Location = new System.Drawing.Point(4, 25);
            this.groupPage.Name = "groupPage";
            this.groupPage.Padding = new System.Windows.Forms.Padding(3);
            this.groupPage.Size = new System.Drawing.Size(925, 398);
            this.groupPage.TabIndex = 0;
            this.groupPage.Text = "Группы";
            this.groupPage.UseVisualStyleBackColor = true;
            this.groupPage.Click += new System.EventHandler(this.groupPage_Click);
            // 
            // InsertGroup
            // 
            this.InsertGroup.Location = new System.Drawing.Point(696, 342);
            this.InsertGroup.Name = "InsertGroup";
            this.InsertGroup.Size = new System.Drawing.Size(100, 25);
            this.InsertGroup.TabIndex = 4;
            this.InsertGroup.Text = "Добавить";
            this.InsertGroup.UseVisualStyleBackColor = true;
            this.InsertGroup.Click += new System.EventHandler(this.InsertGroup_Click);
            // 
            // DeleteGroup
            // 
            this.DeleteGroup.Location = new System.Drawing.Point(802, 342);
            this.DeleteGroup.Name = "DeleteGroup";
            this.DeleteGroup.Size = new System.Drawing.Size(100, 25);
            this.DeleteGroup.TabIndex = 3;
            this.DeleteGroup.Text = "Удалить";
            this.DeleteGroup.UseVisualStyleBackColor = true;
            this.DeleteGroup.Click += new System.EventHandler(this.DeleteGroup_Click);
            // 
            // UpdateGroup
            // 
            this.UpdateGroup.Location = new System.Drawing.Point(28, 337);
            this.UpdateGroup.Name = "UpdateGroup";
            this.UpdateGroup.Size = new System.Drawing.Size(200, 30);
            this.UpdateGroup.TabIndex = 2;
            this.UpdateGroup.Text = "Обновить таблицу";
            this.UpdateGroup.UseVisualStyleBackColor = true;
            this.UpdateGroup.Click += new System.EventHandler(this.UpdateGroup_Click);
            // 
            // dataGridViewGroup
            // 
            this.dataGridViewGroup.AllowUserToOrderColumns = true;
            this.dataGridViewGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox,
            this.id_group,
            this.num_of_semester,
            this.num_of_students_ids,
            this.num_of_subjects_ids,
            this.current_semester});
            this.dataGridViewGroup.Location = new System.Drawing.Point(28, 20);
            this.dataGridViewGroup.Name = "dataGridViewGroup";
            this.dataGridViewGroup.RowHeadersWidth = 51;
            this.dataGridViewGroup.RowTemplate.Height = 24;
            this.dataGridViewGroup.Size = new System.Drawing.Size(874, 277);
            this.dataGridViewGroup.TabIndex = 1;
            this.dataGridViewGroup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroup_CellContentClick);
            // 
            // checkbox
            // 
            this.checkbox.HeaderText = "";
            this.checkbox.MinimumWidth = 6;
            this.checkbox.Name = "checkbox";
            // 
            // id_group
            // 
            this.id_group.HeaderText = "Название группы";
            this.id_group.MinimumWidth = 6;
            this.id_group.Name = "id_group";
            this.id_group.ReadOnly = true;
            this.id_group.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_group.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // num_of_semester
            // 
            this.num_of_semester.HeaderText = "Количество семестров";
            this.num_of_semester.MinimumWidth = 6;
            this.num_of_semester.Name = "num_of_semester";
            this.num_of_semester.ReadOnly = true;
            // 
            // num_of_students_ids
            // 
            this.num_of_students_ids.HeaderText = "Количество студентов";
            this.num_of_students_ids.MinimumWidth = 6;
            this.num_of_students_ids.Name = "num_of_students_ids";
            this.num_of_students_ids.ReadOnly = true;
            // 
            // num_of_subjects_ids
            // 
            this.num_of_subjects_ids.HeaderText = "Количество предметов";
            this.num_of_subjects_ids.MinimumWidth = 6;
            this.num_of_subjects_ids.Name = "num_of_subjects_ids";
            this.num_of_subjects_ids.ReadOnly = true;
            // 
            // current_semester
            // 
            this.current_semester.HeaderText = "Текущий семестр";
            this.current_semester.MinimumWidth = 6;
            this.current_semester.Name = "current_semester";
            this.current_semester.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.groupPage);
            this.tabControl1.Controls.Add(this.studentsPage);
            this.tabControl1.Controls.Add(this.examinersPage);
            this.tabControl1.Controls.Add(this.subjectsPage);
            this.tabControl1.Location = new System.Drawing.Point(-1, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(933, 427);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
            // 
            // examinersPage
            // 
            this.examinersPage.Controls.Add(this.DeleteExaminers);
            this.examinersPage.Controls.Add(this.InsertExaminers);
            this.examinersPage.Controls.Add(this.UpdateExaminers);
            this.examinersPage.Controls.Add(this.dataGridViewExaminers);
            this.examinersPage.Location = new System.Drawing.Point(4, 25);
            this.examinersPage.Name = "examinersPage";
            this.examinersPage.Padding = new System.Windows.Forms.Padding(3);
            this.examinersPage.Size = new System.Drawing.Size(925, 398);
            this.examinersPage.TabIndex = 2;
            this.examinersPage.Text = "Преподаватели";
            this.examinersPage.UseVisualStyleBackColor = true;
            // 
            // DeleteExaminers
            // 
            this.DeleteExaminers.Location = new System.Drawing.Point(783, 319);
            this.DeleteExaminers.Name = "DeleteExaminers";
            this.DeleteExaminers.Size = new System.Drawing.Size(100, 25);
            this.DeleteExaminers.TabIndex = 3;
            this.DeleteExaminers.Text = "Удалить";
            this.DeleteExaminers.UseVisualStyleBackColor = true;
            this.DeleteExaminers.Click += new System.EventHandler(this.DeleteExaminers_Click);
            // 
            // InsertExaminers
            // 
            this.InsertExaminers.Location = new System.Drawing.Point(677, 319);
            this.InsertExaminers.Name = "InsertExaminers";
            this.InsertExaminers.Size = new System.Drawing.Size(100, 25);
            this.InsertExaminers.TabIndex = 2;
            this.InsertExaminers.Text = "Добавить";
            this.InsertExaminers.UseVisualStyleBackColor = true;
            this.InsertExaminers.Click += new System.EventHandler(this.InsertExaminers_Click);
            // 
            // UpdateExaminers
            // 
            this.UpdateExaminers.Location = new System.Drawing.Point(37, 314);
            this.UpdateExaminers.Name = "UpdateExaminers";
            this.UpdateExaminers.Size = new System.Drawing.Size(200, 30);
            this.UpdateExaminers.TabIndex = 1;
            this.UpdateExaminers.Text = "Обновить таблицу";
            this.UpdateExaminers.UseVisualStyleBackColor = true;
            this.UpdateExaminers.Click += new System.EventHandler(this.UpdateExaminers_Click);
            // 
            // dataGridViewExaminers
            // 
            this.dataGridViewExaminers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExaminers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExaminers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkboxExaminers,
            this.id_examiner,
            this.examinersName});
            this.dataGridViewExaminers.Location = new System.Drawing.Point(37, 42);
            this.dataGridViewExaminers.Name = "dataGridViewExaminers";
            this.dataGridViewExaminers.RowHeadersWidth = 51;
            this.dataGridViewExaminers.RowTemplate.Height = 24;
            this.dataGridViewExaminers.Size = new System.Drawing.Size(846, 247);
            this.dataGridViewExaminers.TabIndex = 0;
            this.dataGridViewExaminers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExaminers_CellContentClick);
            // 
            // checkboxExaminers
            // 
            this.checkboxExaminers.HeaderText = "";
            this.checkboxExaminers.MinimumWidth = 6;
            this.checkboxExaminers.Name = "checkboxExaminers";
            // 
            // id_examiner
            // 
            this.id_examiner.HeaderText = "ID";
            this.id_examiner.MinimumWidth = 6;
            this.id_examiner.Name = "id_examiner";
            this.id_examiner.ReadOnly = true;
            this.id_examiner.Visible = false;
            // 
            // examinersName
            // 
            this.examinersName.HeaderText = "ФИО";
            this.examinersName.MinimumWidth = 6;
            this.examinersName.Name = "examinersName";
            this.examinersName.ReadOnly = true;
            this.examinersName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // subjectsPage
            // 
            this.subjectsPage.Controls.Add(this.DeleteSubjects);
            this.subjectsPage.Controls.Add(this.InsertSubjects);
            this.subjectsPage.Controls.Add(this.UpdateSubjets);
            this.subjectsPage.Controls.Add(this.dataGridViewSubjects);
            this.subjectsPage.Location = new System.Drawing.Point(4, 25);
            this.subjectsPage.Name = "subjectsPage";
            this.subjectsPage.Padding = new System.Windows.Forms.Padding(3);
            this.subjectsPage.Size = new System.Drawing.Size(925, 398);
            this.subjectsPage.TabIndex = 3;
            this.subjectsPage.Text = "Предметы изучения";
            this.subjectsPage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubjects
            // 
            this.dataGridViewSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkboxSubjects,
            this.nameSubjects});
            this.dataGridViewSubjects.Location = new System.Drawing.Point(38, 24);
            this.dataGridViewSubjects.Name = "dataGridViewSubjects";
            this.dataGridViewSubjects.RowHeadersWidth = 51;
            this.dataGridViewSubjects.RowTemplate.Height = 24;
            this.dataGridViewSubjects.Size = new System.Drawing.Size(846, 247);
            this.dataGridViewSubjects.TabIndex = 0;
            // 
            // checkboxSubjects
            // 
            this.checkboxSubjects.HeaderText = "";
            this.checkboxSubjects.MinimumWidth = 6;
            this.checkboxSubjects.Name = "checkboxSubjects";
            // 
            // nameSubjects
            // 
            this.nameSubjects.HeaderText = "Название предмета";
            this.nameSubjects.MinimumWidth = 6;
            this.nameSubjects.Name = "nameSubjects";
            this.nameSubjects.ReadOnly = true;
            // 
            // UpdateSubjets
            // 
            this.UpdateSubjets.Location = new System.Drawing.Point(38, 309);
            this.UpdateSubjets.Name = "UpdateSubjets";
            this.UpdateSubjets.Size = new System.Drawing.Size(200, 30);
            this.UpdateSubjets.TabIndex = 1;
            this.UpdateSubjets.Text = "Обновить таблицу";
            this.UpdateSubjets.UseVisualStyleBackColor = true;
            this.UpdateSubjets.Click += new System.EventHandler(this.UpdateSubjets_Click);
            // 
            // InsertSubjects
            // 
            this.InsertSubjects.Location = new System.Drawing.Point(664, 314);
            this.InsertSubjects.Name = "InsertSubjects";
            this.InsertSubjects.Size = new System.Drawing.Size(100, 25);
            this.InsertSubjects.TabIndex = 2;
            this.InsertSubjects.Text = "Добавить";
            this.InsertSubjects.UseVisualStyleBackColor = true;
            this.InsertSubjects.Click += new System.EventHandler(this.InsertSubjects_Click);
            // 
            // DeleteSubjects
            // 
            this.DeleteSubjects.Location = new System.Drawing.Point(784, 314);
            this.DeleteSubjects.Name = "DeleteSubjects";
            this.DeleteSubjects.Size = new System.Drawing.Size(100, 25);
            this.DeleteSubjects.TabIndex = 3;
            this.DeleteSubjects.Text = "Удалить";
            this.DeleteSubjects.UseVisualStyleBackColor = true;
            this.DeleteSubjects.Click += new System.EventHandler(this.DeleteSubjects_Click);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 444);
            this.Controls.Add(this.tabControl1);
            this.Name = "GeneralForm";
            this.Text = "GeneralForm";
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.studentsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.groupPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroup)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.examinersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExaminers)).EndInit();
            this.subjectsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage studentsPage;
        private System.Windows.Forms.Button UpdateStudents;
        private System.Windows.Forms.Button DeleteStudents;
        private System.Windows.Forms.Button InsertStudents;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.TabPage groupPage;
        private System.Windows.Forms.Button InsertGroup;
        private System.Windows.Forms.Button DeleteGroup;
        private System.Windows.Forms.Button UpdateGroup;
        private System.Windows.Forms.DataGridView dataGridViewGroup;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewLinkColumn id_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_of_semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_of_students_ids;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_of_subjects_ids;
        private System.Windows.Forms.DataGridViewTextBoxColumn current_semester;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkboxStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_student;
        private System.Windows.Forms.DataGridViewLinkColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGroup;
        private System.Windows.Forms.TabPage examinersPage;
        private System.Windows.Forms.TabPage subjectsPage;
        private System.Windows.Forms.DataGridView dataGridViewExaminers;
        private System.Windows.Forms.Button DeleteExaminers;
        private System.Windows.Forms.Button InsertExaminers;
        private System.Windows.Forms.Button UpdateExaminers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkboxExaminers;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_examiner;
        private System.Windows.Forms.DataGridViewLinkColumn examinersName;
        private System.Windows.Forms.DataGridView dataGridViewSubjects;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkboxSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSubjects;
        private System.Windows.Forms.Button DeleteSubjects;
        private System.Windows.Forms.Button InsertSubjects;
        private System.Windows.Forms.Button UpdateSubjets;
    }
}