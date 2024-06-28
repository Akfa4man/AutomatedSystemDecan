using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приложение_для_деканата_v1._2
{
    public partial class SubjectsForm : Form
    {
        private readonly PGSQL pGSQL;
        private bool IsExists;
        public SubjectsForm(PGSQL pGSQL)
        {
            InitializeComponent();
            this.pGSQL = pGSQL;
            IsExists = true;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (IsExists)
            {
                MessageBox.Show("Предмет уже существует или вы ничего не вписали в поле ввода!");
                return;
            }
            pGSQL.InsertUpdateDeleteDB($"insert into subjects (\"name\") values (\'{textBoxSubjectsName.Text}\');");
            MessageBox.Show("Предмет добавлен в базу данных!");
        }

        private void textBoxSubjectsName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSubjectsName.Text.Trim() == "" || textBoxSubjectsName.Text==null)
            {
                labelStatus.Text = "неизвестно";
                IsExists = true;
            }
            else if ((bool)pGSQL.SelectDB($"SELECT EXISTS (SELECT 1 FROM subjects WHERE \"name\" = \'{textBoxSubjectsName.Text}\');").Rows[0][0])
            {
                labelStatus.Text = "существует";
                IsExists = true;
            }
            else 
            {
                labelStatus.Text = "не существует";
                IsExists = false;
            }
            //labelStatus.Text = (bool)pGSQL.SelectDB($"SELECT EXISTS (SELECT 1 FROM subjects WHERE \"name\" = \'{textBoxSubjectsName.Text}\');").Rows[0][0] ? "существует" : "не существует";
        }
    }
}
