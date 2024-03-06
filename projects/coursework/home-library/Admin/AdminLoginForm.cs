
using home_library.Admin;
using home_library.Static;
using MaterialSkin.Controls;

namespace home_library
{
    public partial class AdminLoginForm : MaterialForm
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private bool IsLoginValid(string login)
        {
            string query = Queries.GetAdmin(login);
            List<List<string>> data = Logic.ExecuteQuery(query);
            return data.Count > 0;
        }

        private string GetDBHash(string login)
        {
            string query = Queries.GetAdminHash(login);
            List<List<string>> data = Logic.ExecuteQuery(query);
            return data[0][0];
        }

        private void RestorePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = 
                "Добрый день. \n\nУ одного из администраторов системы был утерян доступ к приложению. \n" +
                "Восстановите безопасность приложения как можно раньше. \n\n<b>Спасибо!</b>";
            try
            {
                Logic.SendMail(message, "Восстановление доступа пользователей");
                MessageBox.Show("Ваша ситуация отправлена на почту главного администратора. \n\nОбратитесь к нему для восстановления доступа.", "Ну с кем не бывает...");
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так. попробуйте снова позже...", "Ошибка!");
            }
        }

        private void EnterBtn_Click_1(object sender, EventArgs e)
        {
            string login = Login.Text.Trim();
            string password = Password.Text.Trim();

            if (!IsLoginValid(login))
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка!");
                return;
            }

            Admin.Admin.Login = login;
            string dbHash = GetDBHash(login);

            if (!Admin.Admin.VerifyHashedPassword(dbHash, password))
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка!");
                return;
            }

            AdminForm adminForm = new();
            Visible = false;
            adminForm.ShowDialog();
        }
    }
}
