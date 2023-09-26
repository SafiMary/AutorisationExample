using NetworkUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutorisationExample
{
    public partial class Form1 : Form
    {
        private List<User> users;
        //СТАТУС,ПОЛ,ПОЛОЖЕНИЕ добавлено
        private string dbName = "user_database.db";
        private string create_table = $"CREATE TABLE IF NOT EXISTS REQUISITES (" +
            $"ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
            $"NAME NVARCHAR(25), PASSWORD NVARCHAR(25), " +
            $"STATUS NVARCHAR(25), " +
            $"GENDER NVARCHAR(25),  " +
           $"POSITION NVARCHAR(25),  " +
            $"ROLE NVARCHAR(15));";
        private string init_data = $"INSERT INTO REQUISITES (" +
            $"NAME,STATUS,GENDER,POSITION, PASSWORD, ROLE" +
            $") VALUES  (" +
            $"'Mary','important','W','head department', '0', 'Пользователь');";
        private string show_all_data = $"SELECT * FROM REQUISITES;";
        private string show_all_users = $"SELECT NAME, PASSWORD,STATUS ,GENDER,POSITION FROM REQUISITES;";
        private string delete_main_table = $"DROP TABLE IF EXISTS REQUISITES;";
        private SQLiteDataAdapter _adapter;
        private DataSet _dataSet;
        private DBWork dBWork;
        private SQLiteConnection _connection;
        
        public Form1()
        {
            InitializeComponent();
            users = new List<User>();
            initDB();
            comboBoxCh.Items.AddRange(new string[] { "Пользователь", "Администратор" });
        }
        private void initDB()
        {
            Action<string> action = (string _text) => { lbConnect.Text = _text; };
            dBWork = new DBWork(dbName, action, create_table);
            _connection =  dBWork.getConnection;
            updateGridFromDB();
            updateUsersFromDB();
        }
        private void updateUsersFromDB()
        {
            SQLiteCommand sQLiteCommand = 
                new SQLiteCommand(show_all_users, _connection);
            var reader =  sQLiteCommand.ExecuteReader();
            User user = new User("name", 1, "status","gender","position");
            users.Clear();
            while (reader.Read())
            {
                IDataRecord tmp = (IDataRecord)reader;
                string name = tmp[0].ToString();
                int password = Convert.ToInt32(tmp[1]);
                string status = tmp[2].ToString();
                string gender = tmp[3].ToString();
                string position = tmp[4].ToString();
                users.Add(new User(name, password, status, gender, position));
            } 
            
            
        }
        private void updateGridFromDB()
        {
            Action<string> action = (string _text) => { lbConnect.Text = _text; };
            _adapter = dBWork.getDataAdapter;
            _dataSet = dBWork.GetDataSet(show_all_data, action);
            // Создаём привязку
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = dBWork.getDataSet.Tables[0];
            dataGridViewUsers.DataSource = bindingSource1;
            SQLiteCommandBuilder sQLiteCommandBuilder = new SQLiteCommandBuilder(_adapter);
            _adapter.Update(_dataSet);
        }

        private void updateDbFromGrid()
        {
            _adapter = dBWork.getDataAdapter;
            Action<string> action = (string _text) => { lbConnect.Text = _text; };
            _dataSet = dBWork.GetDataSet("default", action);
            // Создаём привязку 
            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = dBWork.getDataSet.Tables[0];
            dataGridViewUsers.DataSource = bindingSource1;
            SQLiteCommandBuilder sQLiteCommandBuilder = new SQLiteCommandBuilder(_adapter);
            _adapter.Update(_dataSet);
            updateUsersFromDB();
        }
        private void doSqlQuery(string query)
        {
            Action<string> action = (string _text) => { lbConnect.Text = _text; };
            dataGridViewUsers.DataSource = dBWork.GetDataSet(query, action);
        }
        private void addUserToDB(string name,int password,string status, string gender, string position)
        {
            string add_dataUser = $"INSERT INTO REQUISITES (" +
            $"NAME,PASSWORD,STATUS,GENDER,POSITION, ROLE" +
            $") VALUES  (" +
            $"'{name}', '{password}','{status}','{gender}','{position}'" +
            $", 'Пользователь');";
            string add_dataAdmin = $"INSERT INTO REQUISITES (" +
            $"NAME,PASSWORD,STATUS,GENDER,POSITION, ROLE" +
            $") VALUES  (" +
            $"'{name}', '{password}','{status}','{gender}','{position}'" +
            $", 'Админ');";
            if(comboBoxCh.SelectedIndex == 0)
            {
            doSqlQuery(add_dataUser);
            }
            else doSqlQuery(add_dataAdmin);

        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != string.Empty && maskedTextBoxPassword.Text != string.Empty
  
                )
            {
                User user = new User(
                    textBoxLogin.Text,maskedTextBoxPassword.Text.GetHashCode(), 
                    textboxStatus.Text, textboxGend.Text, textboxPos.Text
                    );
                users.Add(user);
                labelUsers.Text = "Активные пользователи:\r\n";
                foreach (var item in users)
                {
                    addUserToDB(item.Name, item.Password, item.Status, item.Gender, item.Position);
                    labelUsers.Text += $"{item.Name} {item.Password}" + "\r\n";
                    
                }
                updateGridFromDB();
            }
        }

        private void buttonTestLogin_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = maskedTextBoxPassword.Text.GetHashCode();
            var status = textboxStatus.Text;
            var gender = textboxGend.Text;
            var position = textboxPos.Text;
            User user = new User(login, password, status, gender, position);
            
            foreach (var item in users)
            {
                if (user.Name == item.Name && user.Password == item.Password)
                   
                {
                    MessageBox.Show($"Пользователь {login} существует");
                }
           
            }
            
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
           //updateGridFromDB();
        }

        private void buttonSaveToDB_Click(object sender, EventArgs e)
        {
            updateDbFromGrid();
            
        }

       
    }
}
