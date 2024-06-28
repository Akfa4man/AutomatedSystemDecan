using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Приложение_для_деканата_v1
{
    internal partial class GroupForm : Form
    {
        private readonly PGSQL pGSQL;
        private readonly GeneralClass generalClass;
        private bool Amendment;//Режим изменений
        private bool NameGroup;//Существует ли такая группа уже
        private GroupClass groupClass;
        public GroupForm(PGSQL pGSQL, GeneralClass generalClass)
        {
            InitializeComponent();
            groupClass = new GroupClass();
            this.pGSQL = pGSQL;
            this.generalClass = generalClass;
            buttonAmendment_Click(null, null);
            //InitializeComponent();
            NameGroup = false;
        }
        public GroupForm(PGSQL pGSQL, string id_group, int num_of_semester, int current_semester, GeneralClass generalClass)
        {
            InitializeComponent();
            groupClass = new GroupClass(id_group, num_of_semester, current_semester);
            this.pGSQL = pGSQL;
            this.generalClass = generalClass;
            //buttonAmendment.Enabled = generalClass.UpdateGroup;
            //buttonAmendment.Enabled = update;
            LoadKnownProfile();
        }
        private void LoadKnownProfile()
        {
            dataGridViewStudents.Columns[0].Visible = false;
            dataGridViewSubjects.Columns[0].Visible = false;
            buttonSave.Enabled = false;
            Amendment = false;
            textBoxNameGroup.Text = groupClass.IdGroup;
            textBoxNum_of_semester.Text = groupClass.num_of_semester.ToString();
            textBoxCurrent_semester.Text=groupClass.current_semester.ToString();
            labelgroupisexists.Visible = false;
            textBoxNameGroup.Enabled = false;
            textBoxNum_of_semester.Enabled = false;
            textBoxCurrent_semester.Enabled = false;
            NameGroup = true;
            buttonAmendment.Enabled = generalClass.UpdateGroup && generalClass.UpdateStudents;
        }
        private void GroupForm_Load(object sender, EventArgs e) 
        {
            dataGridViewStudents.AutoGenerateColumns = false;
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.RowHeadersVisible = false;

            dataGridViewSubjects.AutoGenerateColumns = false;
            dataGridViewSubjects.AllowUserToAddRows = false;
            dataGridViewSubjects.RowHeadersVisible = false;

            //buttonAmendment.Enabled = generalClass.UpdateGroup;

            UpdateTables_Click(null, null);
        }

        private void UpdateTables_Click(object sender, EventArgs e)
        {
            dataGridViewStudents.Rows.Clear();
            dataGridViewSubjects.Rows.Clear();
            if (groupClass.IdGroup!=null) 
            {
                AddDataGridView($"SELECT id_student,fullname, TRUE AS is_in_group FROM students WHERE id_group = \'{groupClass.IdGroup}\';", dataGridViewStudents);
                /*if (generalClass.SelectSubjects)*/ AddDataGridView($"SELECT s.id_subject, s.name, TRUE AS is_in_group FROM subjects s WHERE s.id_subject = ANY (SELECT unnest(g.subjects_ids) FROM \"group\" g WHERE g.id_group = \'{groupClass.IdGroup}\');", dataGridViewSubjects);
            }
            if (Amendment)
            {
                AddDataGridView($"SELECT id_student,fullname, false  AS is_in_group FROM students WHERE id_group = \'Неизвестно\';", dataGridViewStudents);
                /*if (generalClass.SelectSubjects)*/ AddDataGridView($"SELECT s.id_subject, s.name, FALSE AS is_not_in_group FROM subjects s WHERE s.id_subject NOT IN (SELECT unnest(g.subjects_ids) FROM \"group\" g WHERE g.id_group = \'{groupClass.IdGroup}\');", dataGridViewSubjects);
            }
        }
        private void AddDataGridView(string command, DataGridView dataGridView)
        {
            DataTable database = pGSQL.SelectDB(command);
            int index;
            foreach (DataRow row in database.Rows)
            {
                index= dataGridView.Rows.Add();
                dataGridView.Rows[index].Cells[0].Value = row[2];
                dataGridView.Rows[index].Cells[1].Value = row[1];
            }
        }

        private void buttonAmendment_Click(object sender, EventArgs e)
        {
            Amendment = !Amendment;
            /*if(generalClass.UpdateGroup && generalClass.UpdateStudents)*/ buttonAmendment.Enabled = !buttonAmendment.Enabled;
            buttonSave.Enabled = !buttonSave.Enabled;
            dataGridViewStudents.Columns[0].Visible = !dataGridViewStudents.Columns[0].Visible;
            dataGridViewSubjects.Columns[0].Visible = !dataGridViewSubjects.Columns[0].Visible;
            textBoxNameGroup.Enabled = !textBoxNameGroup.Enabled;
            textBoxNum_of_semester.Enabled = !textBoxNum_of_semester.Enabled;
            textBoxCurrent_semester.Enabled = !textBoxCurrent_semester.Enabled;
            labelgroupisexists.Visible = !labelgroupisexists.Visible;
            UpdateTables_Click(null, null);

        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = (string)dataGridViewStudents.Rows[e.RowIndex].Cells["students"].Value;
            bool check=(bool)dataGridViewStudents.Rows[e.RowIndex].Cells["checkboxstud"].Value;
            groupClass.RecordCommand(groupClass.actionsStudents, id, !check);
        }

        private void dataGridViewSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string id = (string)dataGridViewSubjects.Rows[e.RowIndex].Cells["subjects"].Value;
            //bool check = (bool)dataGridViewSubjects.Rows[e.RowIndex].Cells["checkboxsubj"].Value;
            //groupClass.RecordCommand(groupClass.actionsSubjects, id, !check);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxNameGroup.Text == "" || textBoxCurrent_semester.Text == "" || textBoxNum_of_semester.Text == "")
            {
                MessageBox.Show("Вы не заполнили одно (или несколько) обязательных полей: \"Название группы\", \"Количество семестров\", \"Текущий семестр\"!");
                return;
            }
            if (!textBoxCurrent_semester.Text.All(char.IsDigit) || !textBoxNum_of_semester.Text.All(char.IsDigit)) 
            {
                MessageBox.Show("В полях \"Количество семестров\" и/или \"Текущий семестр\" было вписано не числовое значение!");
                return;
            }
            if (NameGroup && groupClass.IdGroup!= textBoxNameGroup.Text.Trim())
            {
                MessageBox.Show($"Группа с названием {textBoxNameGroup.Text} уже существует!");
                return;
            }
            LoadDataOnSQL();
        }
        private void LoadDataOnSQL()
        {
            groupClass.current_semester = int.Parse(textBoxCurrent_semester.Text);
            groupClass.num_of_semester = int.Parse(textBoxNum_of_semester.Text);
            if (groupClass.IdGroup == null)
            {
                pGSQL.InsertUpdateDeleteDB($"INSERT INTO \"group\" (id_group, num_of_semester, current_semester) VALUES (\'{textBoxNameGroup.Text.Trim()}\', {groupClass.num_of_semester}, {groupClass.current_semester});");
            }
            //if (groupClass.IdGroup != null && groupClass.IdGroup != textBoxNameGroup.Text.Trim())
            //{
            //    pGSQL.InsertUpdateDeleteDB($"UPDATE \"group\" set id_group=\'{textBoxNameGroup.Text.Trim()}\' where id_group = \'{groupClass.IdGroup}\';");
            //    groupClass.IdGroup = textBoxNameGroup.Text.Trim();
            //}
            //if (groupClass.current_semester != cursem)
            //{
            //    pGSQL.InsertUpdateDeleteDB($"UPDATE \"group\" set current_semester=\'{cursem}\' where id_group = \'{groupClass.IdGroup}\';");
            //    groupClass.current_semester = cursem;
            //}
            //if (groupClass.num_of_semester != numsem)
            //{
            //    pGSQL.InsertUpdateDeleteDB($"UPDATE \"group\" set num_of_semester=\'{numsem}\' where id_group = \'{groupClass.IdGroup}\';");
            //    groupClass.num_of_semester = numsem;
            //}

            else pGSQL.InsertUpdateDeleteDB($"UPDATE \"group\" set id_group=\'{textBoxNameGroup.Text.Trim()}\',current_semester={groupClass.current_semester},num_of_semester={groupClass.num_of_semester} where id_group = \'{groupClass.IdGroup}\';");

            groupClass.IdGroup = textBoxNameGroup.Text.Trim();

            foreach (var e in groupClass.actionsStudents)
            {
                if (e.Value) pGSQL.InsertUpdateDeleteDB($"update students set id_group = \'{groupClass.IdGroup}\' where fullname  = \'{e.Key}\';");
                else pGSQL.InsertUpdateDeleteDB($"update students set id_group = \'Неизвестно\' where fullname  = \'{e.Key}\';");
            }
            bool redflag= false;
            StringBuilder sb = new StringBuilder();
            sb.Append("\'{");
            foreach (DataGridViewRow e in dataGridViewSubjects.Rows)
            {
                if (!(bool)e.Cells[0].Value) continue;
                short id = (short)pGSQL.SelectDB($"select id_subject from subjects where \"name\" = \'{e.Cells[1].Value}\';").Rows[0][0];
                sb.Append($"{id},");
                redflag = true;
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append("}\'");
            if(redflag) pGSQL.InsertUpdateDeleteDB($"update \"group\" set subjects_ids  = {sb} where id_group = \'{groupClass.IdGroup}\';");
            buttonAmendment_Click(null, null);
        }

        private void textBoxNameGroup_TextChanged(object sender, EventArgs e)
        {
            if (pGSQL.SelectDB($"SELECT * FROM \"group\" WHERE id_group = \'{textBoxNameGroup.Text?.Trim()}\';").Rows.Count == 0)
            {
                labelgroupisexists.Text = "не существует";
                NameGroup=false;
                return;
            }
            labelgroupisexists.Text = "существует";
            NameGroup=true;
        }
    }
}
