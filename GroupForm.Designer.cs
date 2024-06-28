namespace Приложение_для_деканата_v1
{
    partial class GroupForm
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
            this.UpdateTables = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewSubjects = new System.Windows.Forms.DataGridView();
            this.checkboxsubj = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.subjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectsubjects = new System.Windows.Forms.Label();
            this.textBoxCurrent_semester = new System.Windows.Forms.TextBox();
            this.current_semester = new System.Windows.Forms.Label();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.checkboxstud = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.students = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectstudents = new System.Windows.Forms.Label();
            this.textBoxNum_of_semester = new System.Windows.Forms.TextBox();
            this.num_of_semester = new System.Windows.Forms.Label();
            this.labelgroupisexists = new System.Windows.Forms.Label();
            this.textBoxNameGroup = new System.Windows.Forms.TextBox();
            this.labelgroup = new System.Windows.Forms.Label();
            this.buttonAmendment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateTables
            // 
            this.UpdateTables.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateTables.Location = new System.Drawing.Point(135, 486);
            this.UpdateTables.Name = "UpdateTables";
            this.UpdateTables.Size = new System.Drawing.Size(149, 23);
            this.UpdateTables.TabIndex = 25;
            this.UpdateTables.Text = "Обновить таблицы";
            this.UpdateTables.UseVisualStyleBackColor = true;
            this.UpdateTables.Click += new System.EventHandler(this.UpdateTables_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(33, 486);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 23);
            this.buttonSave.TabIndex = 24;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewSubjects
            // 
            this.dataGridViewSubjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkboxsubj,
            this.subjects});
            this.dataGridViewSubjects.Location = new System.Drawing.Point(33, 325);
            this.dataGridViewSubjects.Name = "dataGridViewSubjects";
            this.dataGridViewSubjects.RowHeadersWidth = 51;
            this.dataGridViewSubjects.RowTemplate.Height = 24;
            this.dataGridViewSubjects.Size = new System.Drawing.Size(381, 150);
            this.dataGridViewSubjects.TabIndex = 23;
            this.dataGridViewSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubjects_CellContentClick);
            // 
            // checkboxsubj
            // 
            this.checkboxsubj.HeaderText = "";
            this.checkboxsubj.MinimumWidth = 6;
            this.checkboxsubj.Name = "checkboxsubj";
            this.checkboxsubj.Visible = false;
            this.checkboxsubj.Width = 125;
            // 
            // subjects
            // 
            this.subjects.HeaderText = "Предметы";
            this.subjects.MinimumWidth = 6;
            this.subjects.Name = "subjects";
            this.subjects.ReadOnly = true;
            this.subjects.Width = 125;
            // 
            // selectsubjects
            // 
            this.selectsubjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectsubjects.AutoSize = true;
            this.selectsubjects.Location = new System.Drawing.Point(30, 306);
            this.selectsubjects.Name = "selectsubjects";
            this.selectsubjects.Size = new System.Drawing.Size(140, 16);
            this.selectsubjects.TabIndex = 22;
            this.selectsubjects.Text = "Выберите предметы";
            // 
            // textBoxCurrent_semester
            // 
            this.textBoxCurrent_semester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCurrent_semester.Enabled = false;
            this.textBoxCurrent_semester.Location = new System.Drawing.Point(436, 71);
            this.textBoxCurrent_semester.Name = "textBoxCurrent_semester";
            this.textBoxCurrent_semester.Size = new System.Drawing.Size(62, 22);
            this.textBoxCurrent_semester.TabIndex = 21;
            // 
            // current_semester
            // 
            this.current_semester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.current_semester.AutoSize = true;
            this.current_semester.Location = new System.Drawing.Point(309, 77);
            this.current_semester.Name = "current_semester";
            this.current_semester.Size = new System.Drawing.Size(121, 16);
            this.current_semester.TabIndex = 20;
            this.current_semester.Text = "Текущий семестр";
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkboxstud,
            this.students});
            this.dataGridViewStudents.Location = new System.Drawing.Point(33, 126);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(381, 150);
            this.dataGridViewStudents.TabIndex = 19;
            this.dataGridViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellContentClick);
            // 
            // checkboxstud
            // 
            this.checkboxstud.HeaderText = "";
            this.checkboxstud.MinimumWidth = 6;
            this.checkboxstud.Name = "checkboxstud";
            this.checkboxstud.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkboxstud.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkboxstud.Visible = false;
            this.checkboxstud.Width = 125;
            // 
            // students
            // 
            this.students.HeaderText = "Студенты";
            this.students.MinimumWidth = 6;
            this.students.Name = "students";
            this.students.ReadOnly = true;
            this.students.Width = 125;
            // 
            // selectstudents
            // 
            this.selectstudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectstudents.AutoSize = true;
            this.selectstudents.Location = new System.Drawing.Point(30, 107);
            this.selectstudents.Name = "selectstudents";
            this.selectstudents.Size = new System.Drawing.Size(144, 16);
            this.selectstudents.TabIndex = 18;
            this.selectstudents.Text = "Выберите студентов";
            // 
            // textBoxNum_of_semester
            // 
            this.textBoxNum_of_semester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNum_of_semester.Enabled = false;
            this.textBoxNum_of_semester.Location = new System.Drawing.Point(194, 74);
            this.textBoxNum_of_semester.Name = "textBoxNum_of_semester";
            this.textBoxNum_of_semester.Size = new System.Drawing.Size(51, 22);
            this.textBoxNum_of_semester.TabIndex = 17;
            // 
            // num_of_semester
            // 
            this.num_of_semester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_of_semester.AutoSize = true;
            this.num_of_semester.Location = new System.Drawing.Point(30, 77);
            this.num_of_semester.Name = "num_of_semester";
            this.num_of_semester.Size = new System.Drawing.Size(158, 16);
            this.num_of_semester.TabIndex = 16;
            this.num_of_semester.Text = "Количество семестров";
            // 
            // labelgroupisexists
            // 
            this.labelgroupisexists.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelgroupisexists.AutoSize = true;
            this.labelgroupisexists.Location = new System.Drawing.Point(309, 41);
            this.labelgroupisexists.Name = "labelgroupisexists";
            this.labelgroupisexists.Size = new System.Drawing.Size(0, 16);
            this.labelgroupisexists.TabIndex = 15;
            this.labelgroupisexists.Visible = false;
            // 
            // textBoxNameGroup
            // 
            this.textBoxNameGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNameGroup.Enabled = false;
            this.textBoxNameGroup.Location = new System.Drawing.Point(159, 38);
            this.textBoxNameGroup.Name = "textBoxNameGroup";
            this.textBoxNameGroup.Size = new System.Drawing.Size(141, 22);
            this.textBoxNameGroup.TabIndex = 14;
            this.textBoxNameGroup.TextChanged += new System.EventHandler(this.textBoxNameGroup_TextChanged);
            // 
            // labelgroup
            // 
            this.labelgroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelgroup.AutoSize = true;
            this.labelgroup.Location = new System.Drawing.Point(30, 44);
            this.labelgroup.Name = "labelgroup";
            this.labelgroup.Size = new System.Drawing.Size(123, 16);
            this.labelgroup.TabIndex = 13;
            this.labelgroup.Text = "Название группы";
            // 
            // buttonAmendment
            // 
            this.buttonAmendment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAmendment.Location = new System.Drawing.Point(297, 486);
            this.buttonAmendment.Name = "buttonAmendment";
            this.buttonAmendment.Size = new System.Drawing.Size(152, 23);
            this.buttonAmendment.TabIndex = 26;
            this.buttonAmendment.Text = "Внести изменения";
            this.buttonAmendment.UseVisualStyleBackColor = true;
            this.buttonAmendment.Click += new System.EventHandler(this.buttonAmendment_Click);
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.buttonAmendment);
            this.Controls.Add(this.UpdateTables);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewSubjects);
            this.Controls.Add(this.selectsubjects);
            this.Controls.Add(this.textBoxCurrent_semester);
            this.Controls.Add(this.current_semester);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.selectstudents);
            this.Controls.Add(this.textBoxNum_of_semester);
            this.Controls.Add(this.num_of_semester);
            this.Controls.Add(this.labelgroupisexists);
            this.Controls.Add(this.textBoxNameGroup);
            this.Controls.Add(this.labelgroup);
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            this.Load += new System.EventHandler(this.GroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateTables;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewSubjects;
        private System.Windows.Forms.Label selectsubjects;
        private System.Windows.Forms.TextBox textBoxCurrent_semester;
        private System.Windows.Forms.Label current_semester;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Label selectstudents;
        private System.Windows.Forms.TextBox textBoxNum_of_semester;
        private System.Windows.Forms.Label num_of_semester;
        private System.Windows.Forms.Label labelgroupisexists;
        private System.Windows.Forms.TextBox textBoxNameGroup;
        private System.Windows.Forms.Label labelgroup;
        private System.Windows.Forms.Button buttonAmendment;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkboxsubj;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjects;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkboxstud;
        private System.Windows.Forms.DataGridViewTextBoxColumn students;
    }
}