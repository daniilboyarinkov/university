using System.Data.OleDb;
using home_library.Static;
using MaterialSkin.Controls;

namespace home_library
{
    public partial class AdminHistoryForm : MaterialForm
    {
        private readonly string step = string.Empty;
        public AdminHistoryForm(string step)
        {
            InitializeComponent();
            this.step = step;

            DataGridUser.Columns.Add("title", "Книга");
            DataGridUser.Columns.Add("reader_name", "Пользователь");

            if (step == "history")
            {
                Text = "История";

                SubmitBtn.Visible = false;
                RejectBtn.Visible = false;

                DataGridUser.Columns.Add("take_date", "Дата взятия");
                DataGridUser.Columns.Add("return_date", "Дата возвращения");
            }
            else if (step == "take_applies")
            {
                Text = "Заявки на взятие книги";

                DataGridUser.Columns.Add("apply_date", "Дата заявки");
            }
            else if (step == "dept")
            {
                Text = "Просроченные книги";

                SubmitBtn.Visible = false;
                RejectBtn.Visible = false;

                DataGridUser.Columns.Add("taken_date", "Дата взятия");
                DataGridUser.Columns.Add("return_date", "Дата возвращения");
                DataGridUser.Columns.Add("dept_count", "Задолжность дней...");
            }

            AuthorFilter.Items.AddRange((new string[] { "Все авторы" })
                .Concat(Logic.GetAllAuthors()).ToArray());
            GenreFilter.Items.AddRange((new string[] { "Все жанры" })
                .Concat(Logic.GetAllGenres()).ToArray());
            UserFilter.Items.AddRange((new string[] { "Все читатели" })
                .Concat(Logic.GetAllReaders()).ToArray());

            UpdateBooks();
        }
        private void UpdateBooks()
        {
            string query = string.Empty;

            if (step == "history")
                query = Queries.GetAllHistory();
            else if (step == "take_applies")
                query = Queries.GetAllApplies();
            else if (step == "dept")
                query = Queries.GetDeptedBooks();
            else
            {
                MessageBox.Show("Произошла непредвиденная ошибка");
                return;
            }

            DataGridUser.Rows.Clear();
            Logic.ExecuteQuery(query)
                .ForEach(row => DataGridUser.Rows.Add(row.ToArray()));
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (DataGridUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись...", "Error!");
                return;
            }

            var row = DataGridUser.SelectedRows[0];

            string title = row.Cells[0].Value?.ToString()?.Trim() ?? "";
            string reader = row.Cells[1].Value?.ToString()?.Trim() ?? "";

            if (title.Length == 0 && reader.Length == 0)
            {
                MessageBox.Show("Выберите запись...", "Error!");
                return;
            }

            try
            {
                string query = Queries.AddLibriryMarker(title);
                OleDbCommand command = new(query, Logic.Connection);
                command.ExecuteNonQuery();

                query = Queries.AddToTakenBooks(title, reader);
                command = new(query, Logic.Connection);
                command.ExecuteNonQuery();

                query = Queries.RemoveUserTakeApply(reader, title);
                command = new(query, Logic.Connection);
                command.ExecuteNonQuery();

                UpdateBooks();
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так. Попробуйте снова позже.", "Error!");
            }
        }

        private void RejectBtn_Click(object sender, EventArgs e)
        {
            var row = DataGridUser.SelectedRows[0];

            string title = row.Cells[0].Value?.ToString()?.Trim() ?? "";
            string reader = row.Cells[1].Value?.ToString()?.Trim() ?? "";

            if (title.Length == 0 && reader.Length == 0)
            {
                MessageBox.Show("Выберите запись...", "Error!");
                return;
            }

            string query = Queries.RemoveUserTakeApply(reader, title);
            OleDbCommand command = new(query, Logic.Connection);
            command.ExecuteNonQuery();

            UpdateBooks();
        }

        private void AuthorFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UserFilter.Text = "";
            GenreFilter.Text = "";

            string query = string.Empty;

            if (step == "history")
            {
                if (AuthorFilter.Text == "Все авторы") query = Queries.GetAllHistory();
                else query = Queries.GetAllHistoryByAuthor(AuthorFilter.Text.Trim());
            }
            else if (step == "take_applies")
            {
                if (AuthorFilter.Text == "Все авторы") query = Queries.GetAllApplies();
                else query = Queries.GetAllAppliesByAuthor(AuthorFilter.Text.Trim());
            }
            else if (step == "dept")
            {
                if (AuthorFilter.Text == "Все авторы") query = Queries.GetDeptedBooks();
                else query = Queries.GetDeptedBooksByAuthor(AuthorFilter.Text.Trim());
            }
            else
            {
                MessageBox.Show("Произошла непредвиденная ошибка");
                return;
            }

            DataGridUser.Rows.Clear();
            Logic.ExecuteQuery(query)
                .ForEach(row => DataGridUser.Rows.Add(row.ToArray()));

        }

        private void GenreFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UserFilter.Text = "";
            AuthorFilter.Text = "";

            string query = string.Empty;

            if (step == "history")
            {
                if (GenreFilter.Text == "Все жанры") query = Queries.GetAllHistory();
                else query = Queries.GetAllHistoryByGenre(GenreFilter.Text.Trim());
            }
            else if (step == "take_applies")
            {
                if (GenreFilter.Text == "Все жанры") query = Queries.GetAllApplies();
                else query = Queries.GetAllAppliesByGenre(GenreFilter.Text.Trim());
            }
            else if (step == "dept")
            {
                if (GenreFilter.Text == "Все жанры") query = Queries.GetDeptedBooks();
                else query = Queries.GetDeptedBooksByGenre(GenreFilter.Text.Trim());
            }
            else
            {
                MessageBox.Show("Произошла непредвиденная ошибка");
                return;
            }

            DataGridUser.Rows.Clear();
            List<List<string>> rows = Logic.ExecuteQuery(query);
            rows.ForEach(row => DataGridUser.Rows.Add(row.ToArray()));

        }

        private void UserFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GenreFilter.Text = "";
            AuthorFilter.Text = "";

            string query = string.Empty;

            if (step == "history")
            {
                if (UserFilter.Text == "Все читатели") query = Queries.GetAllHistory();
                else query = Queries.GetAllHistoryByReader(UserFilter.Text.Trim());
            }
            else if (step == "take_applies")
            {
                if (UserFilter.Text == "Все читатели") query = Queries.GetAllApplies();
                else query = Queries.GetAlAppliesByReader(UserFilter.Text.Trim());
            }
            else if (step == "dept")
            {
                if (UserFilter.Text == "Все читатели") query = Queries.GetDeptedBooks();
                else query = Queries.GetDeptedBooksByUser(UserFilter.Text.Trim());
            }
            else
            {
                MessageBox.Show("Произошла непредвиденная ошибка");
                return;
            }

            DataGridUser.Rows.Clear();
            List<List<string>> rows = Logic.ExecuteQuery(query);
            rows.ForEach(row => DataGridUser.Rows.Add(row.ToArray()));

        }
    }
}
