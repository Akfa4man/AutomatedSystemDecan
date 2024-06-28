namespace Приложение_для_деканата_v1
{
    partial class StudentsForm
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
            this.choice_semester = new System.Windows.Forms.ComboBox();
            this.textBoxFullname = new System.Windows.Forms.TextBox();
            this.labelFullname = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelGroup = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.labelWhichSemester = new System.Windows.Forms.Label();
            this.dataGridViewEstimation = new System.Windows.Forms.DataGridView();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.id_examiner = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdateTable = new System.Windows.Forms.Button();
            this.buttonAmendment = new System.Windows.Forms.Button();
            this.buttonDeleteInfoOnTable = new System.Windows.Forms.Button();
            this.buttonInsertOnTable = new System.Windows.Forms.Button();
            this.labelAllsemester = new System.Windows.Forms.Label();
            this.labelStipendium = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstimation)).BeginInit();
            this.SuspendLayout();
            // 
            // choice_semester
            // 
            this.choice_semester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.choice_semester.FormattingEnabled = true;
            this.choice_semester.Location = new System.Drawing.Point(102, 194);
            this.choice_semester.Name = "choice_semester";
            this.choice_semester.Size = new System.Drawing.Size(54, 24);
            this.choice_semester.TabIndex = 0;
            this.choice_semester.SelectedIndexChanged += new System.EventHandler(this.choice_semester_SelectedIndexChanged);
            // 
            // textBoxFullname
            // 
            this.textBoxFullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFullname.Enabled = false;
            this.textBoxFullname.Location = new System.Drawing.Point(77, 31);
            this.textBoxFullname.Name = "textBoxFullname";
            this.textBoxFullname.Size = new System.Drawing.Size(318, 22);
            this.textBoxFullname.TabIndex = 1;
            // 
            // labelFullname
            // 
            this.labelFullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFullname.AutoSize = true;
            this.labelFullname.Location = new System.Drawing.Point(30, 34);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(41, 16);
            this.labelFullname.TabIndex = 2;
            this.labelFullname.Text = "ФИО:";
            // 
            // labelGender
            // 
            this.labelGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(30, 76);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(36, 16);
            this.labelGender.TabIndex = 3;
            this.labelGender.Text = "Пол:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxGender.Enabled = false;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(69, 73);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(146, 24);
            this.comboBoxGender.TabIndex = 4;
            // 
            // labelBirthday
            // 
            this.labelBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(30, 117);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(109, 16);
            this.labelBirthday.TabIndex = 5;
            this.labelBirthday.Text = "Дата рождения:";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerBirthday.Enabled = false;
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(145, 112);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBirthday.TabIndex = 6;
            // 
            // labelGroup
            // 
            this.labelGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(30, 149);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(57, 16);
            this.labelGroup.TabIndex = 7;
            this.labelGroup.Text = "Группа:";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxGroup.Enabled = false;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(94, 146);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGroup.TabIndex = 8;
            // 
            // labelWhichSemester
            // 
            this.labelWhichSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWhichSemester.AutoSize = true;
            this.labelWhichSemester.Location = new System.Drawing.Point(30, 197);
            this.labelWhichSemester.Name = "labelWhichSemester";
            this.labelWhichSemester.Size = new System.Drawing.Size(66, 16);
            this.labelWhichSemester.TabIndex = 9;
            this.labelWhichSemester.Text = "Семестр:";
            // 
            // dataGridViewEstimation
            // 
            this.dataGridViewEstimation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewEstimation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstimation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox,
            this.id_subject,
            this.estimation,
            this.id_examiner});
            this.dataGridViewEstimation.Location = new System.Drawing.Point(33, 224);
            this.dataGridViewEstimation.Name = "dataGridViewEstimation";
            this.dataGridViewEstimation.RowHeadersWidth = 51;
            this.dataGridViewEstimation.RowTemplate.Height = 24;
            this.dataGridViewEstimation.Size = new System.Drawing.Size(719, 150);
            this.dataGridViewEstimation.TabIndex = 10;
            // 
            // checkbox
            // 
            this.checkbox.HeaderText = "";
            this.checkbox.MinimumWidth = 6;
            this.checkbox.Name = "checkbox";
            this.checkbox.Visible = false;
            this.checkbox.Width = 125;
            // 
            // id_subject
            // 
            this.id_subject.HeaderText = "Предмет";
            this.id_subject.MinimumWidth = 6;
            this.id_subject.Name = "id_subject";
            this.id_subject.ReadOnly = true;
            this.id_subject.Width = 125;
            // 
            // estimation
            // 
            this.estimation.HeaderText = "Оценка";
            this.estimation.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1",
            "Незачёт",
            "Зачёт"});
            this.estimation.MinimumWidth = 6;
            this.estimation.Name = "estimation";
            this.estimation.ReadOnly = true;
            this.estimation.Width = 125;
            // 
            // id_examiner
            // 
            this.id_examiner.HeaderText = "Преподаватель";
            this.id_examiner.MinimumWidth = 6;
            this.id_examiner.Name = "id_examiner";
            this.id_examiner.ReadOnly = true;
            this.id_examiner.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_examiner.Width = 125;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(33, 396);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(97, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdateTable
            // 
            this.buttonUpdateTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateTable.Location = new System.Drawing.Point(136, 396);
            this.buttonUpdateTable.Name = "buttonUpdateTable";
            this.buttonUpdateTable.Size = new System.Drawing.Size(95, 23);
            this.buttonUpdateTable.TabIndex = 12;
            this.buttonUpdateTable.Text = "Обновить";
            this.buttonUpdateTable.UseVisualStyleBackColor = true;
            this.buttonUpdateTable.Click += new System.EventHandler(this.buttonUpdateTable_Click);
            // 
            // buttonAmendment
            // 
            this.buttonAmendment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAmendment.Location = new System.Drawing.Point(237, 396);
            this.buttonAmendment.Name = "buttonAmendment";
            this.buttonAmendment.Size = new System.Drawing.Size(158, 23);
            this.buttonAmendment.TabIndex = 13;
            this.buttonAmendment.Text = "Внести изменения";
            this.buttonAmendment.UseVisualStyleBackColor = true;
            this.buttonAmendment.Click += new System.EventHandler(this.buttonAmendment_Click);
            // 
            // buttonDeleteInfoOnTable
            // 
            this.buttonDeleteInfoOnTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteInfoOnTable.Enabled = false;
            this.buttonDeleteInfoOnTable.Location = new System.Drawing.Point(481, 386);
            this.buttonDeleteInfoOnTable.Name = "buttonDeleteInfoOnTable";
            this.buttonDeleteInfoOnTable.Size = new System.Drawing.Size(133, 42);
            this.buttonDeleteInfoOnTable.TabIndex = 14;
            this.buttonDeleteInfoOnTable.Text = "Удалить запись из таблицы";
            this.buttonDeleteInfoOnTable.UseVisualStyleBackColor = true;
            this.buttonDeleteInfoOnTable.Click += new System.EventHandler(this.buttonDeleteInfoOnTable_Click);
            // 
            // buttonInsertOnTable
            // 
            this.buttonInsertOnTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonInsertOnTable.Enabled = false;
            this.buttonInsertOnTable.Location = new System.Drawing.Point(620, 386);
            this.buttonInsertOnTable.Name = "buttonInsertOnTable";
            this.buttonInsertOnTable.Size = new System.Drawing.Size(132, 42);
            this.buttonInsertOnTable.TabIndex = 15;
            this.buttonInsertOnTable.Text = "Создать запись в таблице";
            this.buttonInsertOnTable.UseVisualStyleBackColor = true;
            this.buttonInsertOnTable.Click += new System.EventHandler(this.buttonInsertOnTable_Click);
            // 
            // labelAllsemester
            // 
            this.labelAllsemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAllsemester.AutoSize = true;
            this.labelAllsemester.Location = new System.Drawing.Point(162, 197);
            this.labelAllsemester.Name = "labelAllsemester";
            this.labelAllsemester.Size = new System.Drawing.Size(23, 16);
            this.labelAllsemester.TabIndex = 16;
            this.labelAllsemester.Text = "из";
            // 
            // labelStipendium
            // 
            this.labelStipendium.AutoSize = true;
            this.labelStipendium.Location = new System.Drawing.Point(598, 202);
            this.labelStipendium.Name = "labelStipendium";
            this.labelStipendium.Size = new System.Drawing.Size(154, 16);
            this.labelStipendium.TabIndex = 17;
            this.labelStipendium.Text = "Стипендия: неизвстно";
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStipendium);
            this.Controls.Add(this.labelAllsemester);
            this.Controls.Add(this.buttonInsertOnTable);
            this.Controls.Add(this.buttonDeleteInfoOnTable);
            this.Controls.Add(this.buttonAmendment);
            this.Controls.Add(this.buttonUpdateTable);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewEstimation);
            this.Controls.Add(this.labelWhichSemester);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelFullname);
            this.Controls.Add(this.textBoxFullname);
            this.Controls.Add(this.choice_semester);
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox choice_semester;
        private System.Windows.Forms.TextBox textBoxFullname;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label labelWhichSemester;
        private System.Windows.Forms.DataGridView dataGridViewEstimation;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdateTable;
        private System.Windows.Forms.Button buttonAmendment;
        private System.Windows.Forms.Button buttonDeleteInfoOnTable;
        private System.Windows.Forms.Button buttonInsertOnTable;
        private System.Windows.Forms.Label labelAllsemester;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_subject;
        private System.Windows.Forms.DataGridViewComboBoxColumn estimation;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_examiner;
        private System.Windows.Forms.Label labelStipendium;
    }
}