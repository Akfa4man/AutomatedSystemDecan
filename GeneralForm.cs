using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Приложение_для_деканата_v1._2;

namespace Приложение_для_деканата_v1
{
    public partial class GeneralForm : Form
    {
        private GeneralClass generalClass { get; set; }
        private PGSQL pGSQL;
        public GeneralForm()
        {
            InitializeComponent();
        }

        private void groupPage_Click(object sender, EventArgs e)
        {

        }
        private enum PrivilegeType
        {
            SELECT,
            INSERT,
            UPDATE,
            DELETE
        }
        private void GeneralForm_Load(object sender, EventArgs e)
        {
            using (EntranceWindow entranceWindow = new EntranceWindow())
            {
                if (entranceWindow.ShowDialog() == DialogResult.OK) pGSQL = entranceWindow.pGSQL;
                else
                {
                    this.Close();
                    return;
                }
            }
            DataTable rulesdata = pGSQL.SelectDB("SELECT * FROM information_schema.table_privileges WHERE grantee = CURRENT_USER;");
            generalClass = new GeneralClass(
                CheckPrivilege(rulesdata, "students", PrivilegeType.UPDATE),
                CheckPrivilege(rulesdata, "students", PrivilegeType.SELECT),
                CheckPrivilege(rulesdata, "group", PrivilegeType.UPDATE),
                CheckPrivilege(rulesdata, "group", PrivilegeType.SELECT),
                CheckPrivilege(rulesdata, "subjects", PrivilegeType.SELECT),
                CheckPrivilege(rulesdata, "examiners", PrivilegeType.SELECT),
                CheckPrivilege(rulesdata, "evaluations", PrivilegeType.SELECT),
                CheckPrivilege(rulesdata, "evaluations", PrivilegeType.INSERT),
                CheckPrivilege(rulesdata, "evaluations", PrivilegeType.DELETE),
                CheckPrivilege(rulesdata, "evaluations", PrivilegeType.UPDATE),
                CheckPrivilege(rulesdata, "examiners", PrivilegeType.UPDATE));

            if (generalClass.SelectGroup)
            {
                InsertGroup.Enabled = CheckPrivilege(rulesdata, "group", PrivilegeType.INSERT) && generalClass.SelectGroup && generalClass.SelectStudents && generalClass.SelectSubjects && generalClass.UpdateGroup && generalClass.UpdateStudents;
                DeleteGroup.Enabled = CheckPrivilege(rulesdata, "group", PrivilegeType.DELETE) && generalClass.UpdateStudents && generalClass.SelectStudents;

                dataGridViewGroup.AutoGenerateColumns = false;
                dataGridViewGroup.AllowUserToAddRows = false;
                dataGridViewGroup.RowHeadersVisible = false;

                UpdateGroup_Click(null, null);
            }
            else groupPage.Dispose();

            if (generalClass.SelectStudents)
            {
                InsertStudents.Enabled = CheckPrivilege(rulesdata, "students", PrivilegeType.INSERT) && generalClass.SelectStudents && generalClass.SelectGroup && generalClass.SelectEvaluations && generalClass.SelectExaminers && generalClass.SelectSubjects && generalClass.UpdateGroup && generalClass.UpdateStudents;
                DeleteStudents.Enabled = CheckPrivilege(rulesdata, "students", PrivilegeType.DELETE) && generalClass.UpdateGroup && generalClass.SelectGroup;

                dataGridViewStudents.AutoGenerateColumns = false;
                dataGridViewStudents.AllowUserToAddRows = false;
                dataGridViewStudents.RowHeadersVisible = false;

                UpdateStudents_Click(null, null);
            }
            else studentsPage.Dispose();

            if (generalClass.SelectExaminers)
            {
                InsertExaminers.Enabled = CheckPrivilege(rulesdata, "examiners", PrivilegeType.INSERT);
                DeleteExaminers.Enabled = CheckPrivilege(rulesdata, "examiners", PrivilegeType.DELETE);

                dataGridViewExaminers.AutoGenerateColumns = false;
                dataGridViewExaminers.AllowUserToAddRows = false;
                dataGridViewExaminers.RowHeadersVisible = false;

                UpdateExaminers_Click(null, null);
            }
            else examinersPage.Dispose();

            if (generalClass.SelectSubjects)
            {
                InsertSubjects.Enabled = CheckPrivilege(rulesdata, "subjects", PrivilegeType.INSERT);
                DeleteSubjects.Enabled = CheckPrivilege(rulesdata, "subjects", PrivilegeType.DELETE);

                dataGridViewSubjects.AutoGenerateColumns = false;
                dataGridViewSubjects.AllowUserToAddRows = false;
                dataGridViewSubjects.RowHeadersVisible = false;

                UpdateSubjets_Click(null, null);
            }
            else subjectsPage.Dispose();

            rulesdata.Dispose();
        }
        private bool CheckPrivilege(DataTable dataTable, string tableName, PrivilegeType privilegeType)
        {
            return dataTable.AsEnumerable().Any(row =>
                row.Field<string>("table_name") == tableName &&
                row.Field<string>("privilege_type") == privilegeType.ToString());
        }

        private void DeleteGroup_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow item in dataGridViewGroup.Rows)
            {
                if ((bool)item.Cells["checkbox"].Value)
                {
                    pGSQL.InsertUpdateDeleteDB($"delete from \"group\" where id_group = \'{item.Cells["id_group"].Value}\';");
                    dataGridViewGroup.Rows.RemoveAt(i);
                }
                i++;
            }
        }

        private void UpdateGroup_Click(object sender, EventArgs e)
        {
            if(!generalClass.UpdateGroup) return;
            dataGridViewGroup.Rows.Clear();
            DataTable groupdata = pGSQL.SelectDB("SELECT id_group, num_of_semester, cardinality(students_ids) AS num_of_students_ids, cardinality(subjects_ids) AS num_of_subjects_ids, current_semester FROM  \"group\" where id_group not like \'%Неизвестно%\';");
            //int index;
            //foreach (DataRow item in exdata1.Rows)
            //{
            //    index = dataGridViewGroup.Rows.Add();
            //    dataGridViewGroup.Rows[index].Cells[0].Value = false;
            //    dataGridViewGroup.Rows[index].Cells[1].Value = item[0];
            //    dataGridViewGroup.Rows[index].Cells[2].Value = item[1];
            //    dataGridViewGroup.Rows[index].Cells[3].Value = item[2];
            //    dataGridViewGroup.Rows[index].Cells[4].Value = item[3];
            //    dataGridViewGroup.Rows[index].Cells[5].Value = item[4];
            //}
            foreach(DataRow item in groupdata.Rows) dataGridViewGroup.Rows.Add(false, item[0], item[1], item[2], item[3], item[4]);
            groupdata.Dispose();
        }

        private void InsertGroup_Click(object sender, EventArgs e)
        {
            new GroupForm(pGSQL, generalClass).Show();
        }

        private void dataGridViewGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 1) return;
            if (!(generalClass.SelectGroup && generalClass.SelectStudents && generalClass.SelectSubjects))
            {
                MessageBox.Show("У вас недостаточно прав для более детального просмотра информации о группе!"); return;
            }
            string id = (string)dataGridViewGroup.Rows[e.RowIndex].Cells["id_group"].Value;
            int num_of_semester = Convert.ToInt16(dataGridViewGroup.Rows[e.RowIndex].Cells["num_of_semester"].Value);
            int current_semester = Convert.ToInt16(dataGridViewGroup.Rows[e.RowIndex].Cells["current_semester"].Value);
            new GroupForm(pGSQL,id, num_of_semester, current_semester,generalClass).Show();
        }

        private void InsertStudents_Click(object sender, EventArgs e)
        {
            new StudentsForm(pGSQL, generalClass).Show();
        }

        private void DeleteStudents_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow item in dataGridViewStudents.Rows)
            {
                if ((bool)item.Cells["checkboxStudents"].Value)
                {
                    pGSQL.InsertUpdateDeleteDB($"delete from students where id_student = {item.Cells["id_student"].Value};");
                    dataGridViewStudents.Rows.RemoveAt(i);
                }
                i++;
            }
        }

        private void UpdateStudents_Click(object sender, EventArgs e)
        {
            if(!generalClass.UpdateStudents) return;
            dataGridViewStudents.Rows.Clear();
            DataTable studentsdata = pGSQL.SelectDB("select id_student, fullname, id_group from students;");
            foreach (DataRow item in studentsdata.Rows) dataGridViewStudents.Rows.Add(false, item[0], item[1], item[2]);
            studentsdata.Dispose();
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2) return;
            if (!(generalClass.SelectStudents && generalClass.SelectGroup && generalClass.SelectEvaluations && generalClass.SelectExaminers && generalClass.SelectSubjects))
            {
                MessageBox.Show("У вас недостаточно прав для более детального просмотра информации о студенте!"); return;
            }
            int id = Convert.ToInt32(dataGridViewStudents.Rows[e.RowIndex].Cells["id_student"].Value);
            string fullname = (string)dataGridViewStudents.Rows[e.RowIndex].Cells["fullname"].Value;
            string groupStudent=(string)dataGridViewStudents.Rows[e.RowIndex].Cells["IdGroup"].Value;
            new StudentsForm(pGSQL, id, fullname, groupStudent, generalClass).Show();
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //if (tabControl1.SelectedIndex == 0) UpdateGroup_Click(sender, e);
            //else UpdateStudents_Click(sender, e);
            switch (tabControl1.SelectedTab.Name)
            {
                case "groupPage":
                    UpdateGroup_Click(sender, e); 
                    break;
                case "studentsPage":
                    UpdateStudents_Click(sender, e);
                    break;
                case "examinersPage":
                    UpdateExaminers_Click(sender, e);
                    break;
                case "subjectsPage":
                    UpdateSubjets_Click(sender, e);
                    break;
                default: throw new ArgumentOutOfRangeException("Такой вкладки не существует или не должно быть!");
            }
        }

        private void dataGridViewExaminers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex!=2) return;
            if (!generalClass.SelectExaminers)
            {
                MessageBox.Show("У вас недостаточно прав для более детального просмотра информации о преподавателе!"); 
                return;
            }
            int id = Convert.ToInt32(dataGridViewExaminers.Rows[e.RowIndex].Cells["id_examiner"].Value);
            string fullname = (string)dataGridViewExaminers.Rows[e.RowIndex].Cells["examinersName"].Value;
            new ExaminersForm(pGSQL, id, fullname, generalClass.UpdateExaminers).Show();
        }

        private void UpdateExaminers_Click(object sender, EventArgs e)
        {
            if(!generalClass.SelectExaminers) return;
            dataGridViewExaminers.Rows.Clear();
            DataTable examinersdata = pGSQL.SelectDB("select id_examiner, fullname from examiners;");
            foreach (DataRow item in examinersdata.Rows) dataGridViewExaminers.Rows.Add(false, item[0], item[1]);
            examinersdata.Dispose();

        }

        private void InsertExaminers_Click(object sender, EventArgs e)
        {
            new ExaminersForm(pGSQL).Show();
        }

        private void DeleteExaminers_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow item in dataGridViewExaminers.Rows)
            {
                if ((bool)item.Cells["checkboxExaminers"].Value)
                {
                    pGSQL.InsertUpdateDeleteDB($"delete from examiners where id_examiner = {item.Cells["id_examiner"].Value};");
                    dataGridViewExaminers.Rows.RemoveAt(i);
                }
                i++;
            }
        }

        private void UpdateSubjets_Click(object sender, EventArgs e)
        {
            if (!generalClass.SelectSubjects) return;
            dataGridViewSubjects.Rows.Clear();
            DataTable subjectsdata = pGSQL.SelectDB("select \"name\" from subjects;");
            foreach (DataRow item in subjectsdata.Rows) dataGridViewSubjects.Rows.Add(false, item[0]);
            subjectsdata.Dispose();
        }

        private void InsertSubjects_Click(object sender, EventArgs e)
        {
            new SubjectsForm(pGSQL).Show();
        }

        private void DeleteSubjects_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow item in dataGridViewSubjects.Rows)
            {
                if ((bool)item.Cells["checkboxSubjects"].Value)
                {
                    pGSQL.InsertUpdateDeleteDB($"delete from subjects where \"name\" = \'{item.Cells["nameSubjects"].Value}\';");
                    dataGridViewSubjects.Rows.RemoveAt(i);
                }
                i++;
            }
        }
    }
}