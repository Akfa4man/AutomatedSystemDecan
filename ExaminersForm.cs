using DataClass;
using System;
using System.Data;
using System.Windows.Forms;

namespace Приложение_для_деканата_v1._2
{
    public partial class ExaminersForm : Form
    {
        private readonly PGSQL pGSQL;
        private ExaminersClass examiners;
        public ExaminersForm(PGSQL pGSQL)
        {
            InitializeComponent();
            this.pGSQL = pGSQL;
            examiners = new ExaminersClass();
            buttonAmendment_Click(null, null);
        }

        public ExaminersForm(PGSQL pGSQL, int id, string fullname, bool amendment)
        {
            InitializeComponent();
            this.pGSQL = pGSQL;
            DataTable examdata = pGSQL.SelectDB($"select gender, birthday from examiners where id_examiner = {id};");
            examiners = new ExaminersClass(id, fullname, (bool)examdata.Rows[0][0], (DateTime)examdata.Rows[0][1]);
            examdata.Dispose();
            buttonAmendment.Enabled = amendment;
            LoadKnownProfile();
        }
        private void LoadKnownProfile()
        {
            textBoxFullname.Text=examiners.Fullname;
            comboBoxGender.SelectedIndex = examiners.Gender ? 0 : 1;
            dateTimePickerBirthday.Value = examiners.Birthday;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxFullname.Text == "")
            {
                MessageBox.Show("Поле ФИО не заполнено!");
                return;
            }
            if (textBoxFullname.Text.Split(' ').Length < 2)
            {
                MessageBox.Show("Неправильный формат ввода ФИО!\nДолжно быть: Фамилия Имя Отчество(если есть)");
                return;
            }
            if(comboBoxGender.SelectedItem == null)
            {
                MessageBox.Show("Выберите пол!");
                return;
            }
            LoadDataOnSQL();
        }

        private void LoadDataOnSQL()
        {
            examiners.Fullname = textBoxFullname.Text;
            examiners.Gender = comboBoxGender.SelectedItem.ToString() == "Мужской";
            examiners.Birthday=dateTimePickerBirthday.Value;
            if (examiners.ID == -1)
            {
                examiners.ID = Convert.ToInt32(pGSQL.SelectDB($"insert into examiners (fullname, gender, birthday) values (\'{examiners.Fullname}\', {examiners.Gender}, \'{examiners.Birthday.ToString("dd.MM.yyyy")}\') returning id_examiner;").Rows[0][0]);
                MessageBox.Show("Преподаватель загружен в базу данных!");
            }
            else 
            {
                pGSQL.InsertUpdateDeleteDB($"update examiners set fullname = \'{examiners.Fullname}\', gender = {examiners.Gender}, birthday =\'{examiners.Birthday.ToString("dd.MM.yyyy")}\' where id_examiner = {examiners.ID};");
            }
            buttonAmendment_Click(null, null);
        }

        private void buttonAmendment_Click(object sender, EventArgs e)
        {
            textBoxFullname.Enabled =! textBoxFullname.Enabled;
            comboBoxGender.Enabled = ! comboBoxGender.Enabled;
            dateTimePickerBirthday.Enabled = ! dateTimePickerBirthday.Enabled;
            buttonAmendment.Enabled=!buttonAmendment.Enabled;
            buttonSave.Enabled=!buttonSave.Enabled;
        }
    }
}