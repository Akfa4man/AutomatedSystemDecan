using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Приложение_для_деканата_v1
{
    internal partial class AddEvaluations : Form
    {
        private readonly PGSQL pGSQL;
        private readonly int idStudent;
        private readonly int num_of_semester;
        public AddEvaluations(PGSQL pGSQL, int idStudent, int num_of_semester)
        {
            InitializeComponent();
            this.pGSQL = pGSQL;
            this.idStudent = idStudent;
            this.num_of_semester = num_of_semester;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxSubjects.SelectedItem == null || comboBoxSemester.SelectedItem == null)
            {
                MessageBox.Show("Не все обязательные поля заполнены!");
                return;
            }
            labelWork.Text = "Выполняется...";
            short id_subject=Convert.ToInt16(pGSQL.SelectDB($"select id_subject from subjects s where s.name=\'{comboBoxSubjects.SelectedItem}\';").Rows[0][0]);
            int estmition;
            StringBuilder sb = new StringBuilder("insert into evaluations (id_student,id_subject,semester");
            if (comboBoxEstmition.SelectedItem == null && comboBoxExaminers.SelectedItem == null)
            {
                sb.Append($") values ({idStudent}, {id_subject}, {comboBoxSemester.SelectedItem});");
            }
            else if (comboBoxEstmition.SelectedItem != null && comboBoxExaminers.SelectedItem == null)
            {
                estmition = comboBoxEstmition.SelectedItem == "Зачёт" ? 0 :
                      comboBoxEstmition.SelectedItem == "Незачёт" ? -1 : int.TryParse(comboBoxEstmition.SelectedItem.ToString(), out int numericValue) ? numericValue :
                      throw new InvalidOperationException("Неожиданное значение в comboBoxEstmition.SelectedItem");
                sb.Append($",estimation) values ({idStudent}, {id_subject}, {comboBoxSemester.SelectedItem},{estmition});");
            }
            else if (comboBoxEstmition.SelectedItem == null && comboBoxExaminers.SelectedItem != null)
            {
                sb.Append($",id_examiner) values ({idStudent}, {id_subject}, {comboBoxSemester.SelectedItem},");
                id_subject = Convert.ToInt16(pGSQL.SelectDB($"select id_examiner from examiners where fullname=\'{comboBoxExaminers.SelectedItem}\';").Rows[0][0]);
                sb.Append($"{id_subject});");
            }
            else 
            {
                estmition = comboBoxEstmition.SelectedItem == "Зачёт" ? 0 :
                      comboBoxEstmition.SelectedItem == "Незачёт" ? -1 : int.TryParse(comboBoxEstmition.SelectedItem.ToString(), out int numericValue) ? numericValue :
                      throw new InvalidOperationException("Неожиданное значение в comboBoxEstmition.SelectedItem");
                sb.Append($",estimation,id_examiner) values ({idStudent}, {id_subject}, {comboBoxSemester.SelectedItem},{estmition},");
                id_subject = Convert.ToInt16(pGSQL.SelectDB($"select id_examiner from examiners where fullname=\'{comboBoxExaminers.SelectedItem}\';").Rows[0][0]);
                sb.Append($"{id_subject});");
            }
            pGSQL.InsertUpdateDeleteDB(sb.ToString());
            labelWork.Text = "Готов к работе!";
        }

        private void AddEvaluations_Load(object sender, EventArgs e)
        {
            DataTable dt = pGSQL.SelectDB("select s.name from subjects s;");
            foreach (DataRow row in dt.Rows) { comboBoxSubjects.Items.Add(row[0]); }

            dt=pGSQL.SelectDB("select e.fullname  from examiners e ;");
            foreach (DataRow row in dt.Rows) { comboBoxExaminers.Items.Add(row[0]); }

            for (int i = 1; i <= num_of_semester; i++) { comboBoxSemester.Items.Add(i); }
        }
    }
}