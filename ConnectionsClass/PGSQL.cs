using System.Data;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace Приложение_для_деканата_v1
{
    public class PGSQL
    {
        private NpgsqlConnection connector;
        private NpgsqlCommand command;
        public bool WorkCheck { get; private set; }
        public PGSQL(ConnectionInterface connectionInterface)
        {
            connector = new NpgsqlConnection($"Server = {connectionInterface.Server}; Port = {connectionInterface.Port};Database = {connectionInterface.DataBase};User Id = {connectionInterface.UserName}; Password = {connectionInterface.Password};");
            WorkCheck = true;
            try { connector.Open(); }
            catch (SocketException e)
            {
                //connector.Close();
                MessageBox.Show($"Ошибка при подключении!\nБудут задействованы стандартные настройки!\n\nSocketException[{e.ErrorCode}]: {e.Message}");
                //connector = new NpgsqlConnection($"Server = localhost; Port = 5432;Database = NewDecan;User Id = Default; Password = 12345;");
                //connector.ConnectionString = "Server = localhost; Port = 5432;Database = NewDecan;User Id = Default; Password = 12345;";
                WorkCheck=false;
            }
            catch (PostgresException e)
            {
                MessageBox.Show($"Ошибка при подключении!\nБудут задействованы стандартные настройки!\n\nPostgresException: {e.MessageText}");
                //connector.ConnectionString = "Server = localhost; Port = 5432;Database = NewDecan;User Id = Default; Password = 12345;";
                WorkCheck = false;
            }
            finally { connector.Close(); }
        }
        public DataTable SelectDB(string cmd)
        {
            if (!WorkCheck) return null;
            connector.Open();
            command = new NpgsqlCommand();
            command.CommandText = cmd;
            command.CommandType = CommandType.Text;
            command.Connection = connector;
            NpgsqlDataReader reader;
            try { reader = command.ExecuteReader(); }
            catch (PostgresException e)
            { MessageBox.Show($"Ошибка при выполнении команды!\nЗначение для возврата: null\n\nPostgresException {e.Message}"); reader = null; }
            catch (SocketException e)
            { MessageBox.Show($"Ошибка при выполнении команды!\nЗначение для возврата: null\n\nSocketException[{e.ErrorCode}]: {e.Message}"); reader = null; }
            DataTable result= new DataTable();
            if (reader != null) result.Load(reader);
            command.Dispose();
            connector.Close();
            return result;
        }
        public void InsertUpdateDeleteDB(string cmd)
        {
            if (!WorkCheck) return;
            connector.Open();
            command = new NpgsqlCommand();
            command.CommandText = cmd;
            command.CommandType = CommandType.Text;
            command.Connection = connector;
            try { command.ExecuteNonQuery(); }
            catch (PostgresException e)
            { MessageBox.Show($"Ошибка при выполнении команды!\nКоманда не выполнена!\n\nPostgresException {e.Message}"); }
            catch (SocketException e)
            { MessageBox.Show($"Ошибка при выполнении команды!\nКоманда не выполнена!l\n\nSocketException[{e.ErrorCode}]: {e.Message}"); }
            command.Dispose();
            connector.Close();
        }
    }
    class PGSQL<T> where T : ConnectionInterface
    {
        private NpgsqlConnection connector;
        private NpgsqlCommand command;
        ConnectionInterface connectionInterface;
        public PGSQL(ConnectionInterface connectionInterface)
        {
            connector = new NpgsqlConnection($"Server = {connectionInterface.Server}; Port = {connectionInterface.Port};Database = {connectionInterface.DataBase};User Id = {connectionInterface.UserName}; Password = {connectionInterface.Password};");
            try { connector.Open(); }
            catch (SocketException e)
            {
                //connector.Close();
                MessageBox.Show($"Ошибка при подключении!\nБудут задействованы стандартные настройки!\n\nSocketException[{e.ErrorCode}]: {e.Message}");
                //connector = new NpgsqlConnection($"Server = localhost; Port = 5432;Database = NewDecan;User Id = Default; Password = 12345;");
                connector.ConnectionString = "Server = localhost; Port = 5432;Database = NewDecan;User Id = Default; Password = 12345;";

            }
            catch (PostgresException e)
            {
                MessageBox.Show($"Ошибка при подключении!\nБудут задействованы стандартные настройки!\n\nPostgresException {e.Message}");
                connector.ConnectionString = "Server = localhost; Port = 5432;Database = NewDecan;User Id = Default; Password = 12345;";
            }
            finally { connector.Close(); }
            command = new NpgsqlCommand();
            this.connectionInterface = connectionInterface;
        }
        public DataTable SelectDB(string cmd)
        {
            connector.Open();
            command = new NpgsqlCommand();
            command.CommandText = cmd;
            command.CommandType = CommandType.Text;
            command.Connection = connector;
            NpgsqlDataReader reader;
            try { reader = command.ExecuteReader(); }
            catch (PostgresException e)
            { MessageBox.Show($"Ошибка при выполнении команды!\nЗначение для возврата: null\n\nPostgresException {e.Message}"); reader = null; }
            DataTable result = null;
            if (reader != null)
            {
                result = new DataTable();
                result.Load(reader);
            }
            command.Dispose();
            connector.Close();
            return result;
        }
        public void InsertUpdateDelete(string cmd) 
        {
            connector.Open();
            command = new NpgsqlCommand();
            command.CommandText = cmd;
            command.CommandType = CommandType.Text;
            command.Connection = connector;
            try { command.ExecuteNonQuery(); }
            catch (PostgresException e) 
            { MessageBox.Show($"Ошибка при выполнении команды!\nКоманда не выполнена!\n\nPostgresException {e.Message}"); }
            command.Dispose();
            connector.Close();
        }
    }
    static class staticPGSQL
    {
        private static NpgsqlConnection connector;
        private static NpgsqlCommand command;
    }

}