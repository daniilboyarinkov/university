using System.Data.OleDb;
using home_library.Static;
using MaterialSkin;
using MaterialSkin.Controls;

namespace home_library
{

    public partial class StartForm : MaterialForm
    {
        public StartForm()
        {
            InitializeComponent();
            
            // открываем соединение с бд
            Logic.Connection.Open();
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // закрываем соединение с бд
            Logic.Connection.Close();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            // переводим основное окно в состояние невидимости
            Visible = false;


            AdminLoginForm adminLoginForm = new();
            adminLoginForm.ShowDialog();


            // по закрытию дочернего окна закрываем и основное
            Visible =true;
        }

        private void UserButton_Click_1(object sender, EventArgs e)
        {
            string inputName = UserName.Text.ToLower();

            string query = $"SELECT reader_name FROM readers WHERE reader_name=\"{inputName}\"";
            OleDbCommand command = new(query, Logic.Connection);
            OleDbDataReader reader = command.ExecuteReader();

            bool valid = false;
            while (reader.Read())
            {
                if (inputName == reader[0].ToString()?.ToLower())
                {
                    valid = true;
                    UserForm userForm = new(inputName);
                    // переводим основное окно в состояние невидимости
                    Visible = false;
                    // проверяем злосчастный genre
                    //Logic.IsGenre = Logic.CheckGenre();

                    userForm.ShowDialog();
                    Visible = true;
                }
                else
                {
                    MessageBox.Show($"Нет пользователя с именем {inputName}!", "Error!");
                }
            }
            if (!valid) MessageBox.Show($"Нет пользователя с именем {inputName}!", "Error!");

            reader.Close();
        }
    }
}