using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Приложение_для_деканата_v1
{
    internal partial class EntranceWindow : Form, ConnectionInterface
    {
        public EntranceWindow()
        {
            InitializeComponent();
        }
        public PGSQL pGSQL { get; private set; }

        public string Server => "localhost";

        public int Port => 5432;

        public string DataBase => "NewDecan";

        public string UserName => username;
        private string username;
        public string Password => password;
        private string password;

        //private PGSQL

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "" || PasswordBox.Text == "")
            {
                MessageBox.Show("Незаполнено поле логина или пароля!");
                return;
            }
            username=LoginBox.Text;
            password=PasswordBox.Text;
            pGSQL = new PGSQL(this);
            if (!pGSQL.WorkCheck) return;
            //var data = pGSQL.SelectDB("SELECT * FROM information_schema.table_privileges WHERE grantee = CURRENT_USER;");
            //this.Hide();
            //new GeneralForm(pGSQL).ShowDialog();
            this.DialogResult = DialogResult.OK;
            this.Close();
            this.Dispose();
            //GC.Collect();//Работает, всё передается
            //GC.WaitForPendingFinalizers();
        }

        private void EntranceWindow_Resize(object sender, EventArgs e)
        {
            
        }

        private void checkBoxPasswordVision_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPasswordVision.Checked) PasswordBox.PasswordChar = '\0';
            else PasswordBox.PasswordChar = '*';
        }
    }
}
