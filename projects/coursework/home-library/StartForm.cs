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
            
            // ��������� ���������� � ��
            Logic.Connection.Open();
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ��������� ���������� � ��
            Logic.Connection.Close();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            // ��������� �������� ���� � ��������� �����������
            Visible = false;


            AdminLoginForm adminLoginForm = new();
            adminLoginForm.ShowDialog();


            // �� �������� ��������� ���� ��������� � ��������
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
                    // ��������� �������� ���� � ��������� �����������
                    Visible = false;
                    // ��������� ����������� genre
                    //Logic.IsGenre = Logic.CheckGenre();

                    userForm.ShowDialog();
                    Visible = true;
                }
                else
                {
                    MessageBox.Show($"��� ������������ � ������ {inputName}!", "Error!");
                }
            }
            if (!valid) MessageBox.Show($"��� ������������ � ������ {inputName}!", "Error!");

            reader.Close();
        }
    }
}