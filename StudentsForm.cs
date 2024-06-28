using System;
using System.Data;
using System.Windows.Forms;

namespace Приложение_для_деканата_v1
{
    internal partial class StudentsForm : Form
    {
        private readonly PGSQL pGSQL;
        private StudentsClass students;

        private short numsem { get; set; }
        private static string DefailtGroup = "Неизвестно";

        private readonly GeneralClass generalClass;

        public StudentsForm(PGSQL pGSQL, GeneralClass generalClass)
        {
            InitializeComponent();
            this.pGSQL = pGSQL;
            this.generalClass = generalClass;
            students = new StudentsClass();
            buttonAmendment_Click(null, null);
            buttonUpdateTable_Click(null, null);
        }
        public StudentsForm(PGSQL pGSQL, int idStudent, string fullname, string groupStudent, GeneralClass generalClass)
        {
            InitializeComponent();
            this.pGSQL = pGSQL;
            var data = pGSQL.SelectDB($"select gender, birthday from students where id_student={idStudent}");
            students = new StudentsClass(idStudent, fullname, (bool)data.Rows[0][0], (DateTime)data.Rows[0][1],groupStudent);
            this.generalClass = generalClass;
            data.Dispose();
            LoadKnownProfile();
        }
        private void LoadKnownProfile()
        {
            textBoxFullname.Text=students.Fullname;
            //if (generalClass.SelectGroup)
            //{
                //DataRow data = pGSQL.SelectDB($"select num_of_semester, current_semester from \"group\" where id_group = \'{students.IdGroup}\';").Rows[0];
                //numsem = (short)data[1];
                //for (short i = 1; i < numsem + 1; i++) choice_semester.Items.Add(i);
                //labelAllsemester.Text = $"из {data[0]}";
                //if (numsem != 0) choice_semester.SelectedIndex = 0;
                //else buttonUpdateTable_Click(null, null);
                LoadGroupData();
            //}
            //else MessageBox.Show("Внимание: у вас недостаточно прав, чтобы получить информацию о группе студента!");
            comboBoxGender.SelectedIndex = students.Gender ? 0 : 1;
            dateTimePickerBirthday.Value = students.Birthday;
            buttonAmendment.Enabled = generalClass.UpdateStudents;
        }
        private void LoadGroupData()
        {
            DataRow data = pGSQL.SelectDB($"select num_of_semester, current_semester from \"group\" where id_group = \'{students.IdGroup}\';").Rows[0];
            numsem = (short)data[1];
            for (short i = 1; i < numsem + 1; i++) choice_semester.Items.Add(i);
            labelAllsemester.Text = $"из {data[0]}";
            if (numsem != 0) choice_semester.SelectedIndex = 0;
            else buttonUpdateTable_Click(null, null);
        }
        private void choice_semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonUpdateTable_Click(null, null);
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            dataGridViewEstimation.AutoGenerateColumns = false;
            dataGridViewEstimation.AllowUserToAddRows = false;
            dataGridViewEstimation.RowHeadersVisible = false;

            choice_semester.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;

            //buttonAmendment.Enabled = generalClass.UpdateStudents;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxFullname.Text == "")
            {
                MessageBox.Show("Поле ФИО не заполнено!"); return;
            }
            if (textBoxFullname.Text.Split(' ').Length < 2)
            {
                MessageBox.Show("Неправильный формат ввода ФИО!\nДолжно быть: Фамилия Имя Отчество(если есть)");
                return;
            }
            if (comboBoxGender.SelectedItem == null)
            {
                MessageBox.Show("Выберите пол!");
                return;
            }
            LoadDataOnSQL();
        }
        private void LoadDataOnSQL()
        {
            students.Fullname = textBoxFullname.Text.Trim();
            students.Gender = comboBoxGender.SelectedItem.ToString() == "Мужской";
            students.IdGroup = comboBoxGroup.SelectedItem?.ToString();
            students.Birthday = dateTimePickerBirthday.Value;
            buttonAmendment_Click(null, null);
            if (students.Id == -1)
            {

                students.Id = Convert.ToInt32(pGSQL.SelectDB($"insert into students (gender,birthday,fullname,id_group) values ({students.Gender},\'{students.Birthday.ToString("dd.MM.yyyy")}\',\'{students.Fullname}\',\'{students.IdGroup}\') returning id_student;").Rows[0][0]);
                //students.Id = Convert.ToInt32(pGSQL.SelectDB($"insert into students (gender,birthday,fullname) values ({students.Gender},\'{students.Birthday.ToString("dd.MM.yyyy")}\',\'{students.Fullname}\') returning id_student;").Rows[0][0]);
                //if (generalClass.UpdateGroup)
                //{
                //    pGSQL.InsertUpdateDeleteDB($"update students set id_group = \'{students.IdGroup}\' where id_student = {students.Id};");
                //    pGSQL.InsertUpdateDeleteDB($"update \"group\" set subjects_ids =subjects_ids where id_group=\'{students.IdGroup}\'");
                //}
                //else MessageBox.Show("У вас недостаточно прав, чтобы назначить студента в группу!\nОн будет автомотически переназначен в группу \"Неизвестно\"!");

                //LoadKnownProfile();
                LoadGroupData();

                MessageBox.Show("Студент загружен в базу данных!");
                return;
            }
            pGSQL.InsertUpdateDeleteDB($"update students set fullname = \'{students.Fullname}\', gender = {students.Gender}, birthday = \'{dateTimePickerBirthday.Value.ToString("dd.MM.yyyy")}\', id_group = \'{students.IdGroup}\' where id_student = {students.Id}");
            if (generalClass.UpdateEvaluations)
            {
                int value;
                foreach (DataGridViewRow row in dataGridViewEstimation.Rows)
                {
                    if (row.Cells[2].Value != null)
                    {
                        value = row.Cells[2].Value.ToString() == "Зачёт" ? 0 : row.Cells[2].Value.ToString() == "Незачёт" ? -1 : Convert.ToInt32(row.Cells[2].Value);
                        pGSQL.InsertUpdateDeleteDB($"UPDATE evaluations SET estimation = {value} WHERE id_student = {students.Id} AND id_subject = (SELECT id_subject FROM subjects WHERE name = \'{row.Cells[1].Value}\') AND semester = {choice_semester.SelectedItem};");
                    }
                    if (row.Cells[3].Value != null) pGSQL.InsertUpdateDeleteDB($"UPDATE evaluations SET id_examiner = (SELECT id_examiner FROM examiners WHERE fullname = \'{row.Cells[3].Value}\') WHERE id_student = {students.Id} AND id_subject = (SELECT id_subject FROM subjects WHERE name = \'{row.Cells[1].Value}\') AND semester = {choice_semester.SelectedItem};");
                }
            }
            buttonUpdateTable_Click(null, null);
        }

        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            DataTable database;
            //if (generalClass.SelectGroup)
            //{
                comboBoxGroup.Items.Clear();
                database = pGSQL.SelectDB($"Select id_group from \"group\";");
                foreach (DataRow row in database.Rows) comboBoxGroup.Items.Add(row[0]);
                comboBoxGroup.SelectedItem = students.IdGroup == null ? DefailtGroup : students.IdGroup;
            //}
            //if (generalClass.SelectExaminers)
            //{
                id_examiner.Items.Clear();
                database = pGSQL.SelectDB($"SELECT fullname FROM examiners;");
                foreach (DataRow row in database.Rows) id_examiner.Items.Add(row[0]);
            //}


            if (choice_semester.SelectedItem == null /*|| !generalClass.SelectEvaluations*/) return;
            dataGridViewEstimation.Rows.Clear();
            database = pGSQL.SelectDB($"SELECT sub.name, e.estimation, ex.fullname FROM evaluations e LEFT JOIN students s ON e.id_student = s.id_student LEFT JOIN subjects sub ON e.id_subject = sub.id_subject LEFT JOIN examiners ex ON e.id_examiner = ex.id_examiner where s.id_student = {students.Id} and semester = {choice_semester.SelectedItem};");
            bool stipendium=true;
            bool nullcell = false;
            int index;
            DataGridViewComboBoxCell comboBox;
            foreach (DataRow row in database.Rows)
            {
                index=dataGridViewEstimation.Rows.Add(row);
                dataGridViewEstimation.Rows[index].Cells[0].Value = false;
                dataGridViewEstimation.Rows[index].Cells[1].Value = row[0];

                comboBox= dataGridViewEstimation.Rows[index].Cells[2] as DataGridViewComboBoxCell;
                if (comboBox != null && comboBox.Items.Contains(row[1].ToString()))
                { comboBox.Value = row[1].ToString(); if (row[1].ToString() != "4" && row[1].ToString() != "5") stipendium = false; }
                else if (row[1].ToString() == "-1") { comboBox.Value = "Незачёт"; stipendium = false; }
                else if (row[1].ToString() == "0") comboBox.Value = "Зачёт";
                else nullcell=true;

                comboBox=dataGridViewEstimation.Rows[index].Cells[3] as DataGridViewComboBoxCell;
                if(comboBox != null && comboBox.Items.Contains(row[2].ToString())) comboBox.Value = row[2].ToString();
            }
            if (!nullcell && database.Rows.Count != 0) labelStipendium.Text = stipendium ? "Стипендия: есть" : "Стипендия: нету";
            else labelStipendium.Text = "Стипендия: неизвстно";
        }

        private void buttonAmendment_Click(object sender, EventArgs e)
        {
            /*if(generalClass.UpdateStudents)*/buttonAmendment.Enabled = !buttonAmendment.Enabled;
            buttonSave.Enabled = !buttonSave.Enabled;
            if (generalClass.DeleteEvaluations) buttonDeleteInfoOnTable.Enabled = !buttonDeleteInfoOnTable.Enabled;
            if (generalClass.InsertEvaluations) buttonInsertOnTable.Enabled = !buttonInsertOnTable.Enabled;
            comboBoxGender.Enabled = !comboBoxGender.Enabled;
            comboBoxGroup.Enabled = !comboBoxGroup.Enabled;
            dateTimePickerBirthday.Enabled = !dateTimePickerBirthday.Enabled;
            textBoxFullname.Enabled = !textBoxFullname.Enabled;
            if (generalClass.UpdateEvaluations) dataGridViewEstimation.Columns[0].Visible = !dataGridViewEstimation.Columns[0].Visible;
            if (generalClass.UpdateEvaluations) dataGridViewEstimation.Columns[2].ReadOnly = !dataGridViewEstimation.Columns[2].ReadOnly;
            if (generalClass.UpdateEvaluations) dataGridViewEstimation.Columns[3].ReadOnly = !dataGridViewEstimation.Columns[3].ReadOnly;
        }

        private void buttonDeleteInfoOnTable_Click(object sender, EventArgs e)
        {
            //int i = 0;
            //foreach (DataGridViewRow item in dataGridViewEstimation.Rows)
            //{
            //    if ((bool)item.Cells["checkbox"].Value == true)
            //    {
            //        pGSQL.InsertUpdateDeleteDB($"DELETE FROM evaluations WHERE id_student = {students.Id} AND id_subject = (SELECT id_subject FROM subjects s WHERE s.name = \'{item.Cells["id_subject"].Value}\') AND semester = {choice_semester.SelectedItem};");
            //        dataGridViewEstimation.Rows.RemoveAt(i);
            //    }
            //    i++;
            //}
            int count = dataGridViewEstimation.Rows.Count;
            for (int x = 0; x < count; x++)
            {
                if ((bool)dataGridViewEstimation.Rows[x].Cells["checkbox"].Value == true)
                {
                    pGSQL.InsertUpdateDeleteDB($"DELETE FROM evaluations WHERE id_student = {students.Id} AND id_subject = (SELECT id_subject FROM subjects s WHERE s.name = \'{dataGridViewEstimation.Rows[x].Cells["id_subject"].Value}\') AND semester = {choice_semester.SelectedItem};");
                    dataGridViewEstimation.Rows.RemoveAt(x);
                    x--;
                    count--;
                }
            }
        }

        private void buttonInsertOnTable_Click(object sender, EventArgs e)
        {
            if (students.Id==-1)
            {
                MessageBox.Show("Студент ещё не сохранён в базе данных!"); return;
            }
            new AddEvaluations(pGSQL,students.Id,numsem).Show();
        }
    }
}
