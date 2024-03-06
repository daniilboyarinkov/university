
using home_library.Static;
using MaterialSkin.Controls;
using System.Windows.Forms;

using Word  = Microsoft.Office.Interop.Word;
using Point = System.Drawing.Point;

namespace home_library
{
    public partial class UserForm : MaterialForm
    {
        private readonly string[] authors;
        private readonly string[] genres;
        public UserForm(string name)
        {
            InitializeComponent();

            User.User.Username = name;

            UpdateBooks();
            authors = Logic.GetAllAuthors();
            AddRadioButtonsFilters(authors);

            genres = Logic.GetAllGenres();
            filterByGenre.Items.AddRange((new string[] { "Все жанры" }).Concat(genres.ToArray()).ToArray());
            filterByGenre.SelectedValueChanged += (o, args) =>
            {
                UpdateBooks("Все авторы", filterByGenre.Text);
            };

            CheckDate();
        }

        private static void CheckDate()
        {
            CheckUserBirthDay();
            CheckAuthorAnniversary();
            CheckDeptBooks();
        }

        // проверка если у пользоваителя сегодня др
        private static void CheckUserBirthDay()
        {
            string query = Queries.CheckUsersBirthDay(User.User.Username);
            List<List<string>> rows = Logic.ExecuteQuery(query);
            if (rows.Count == 0 || rows[0].Count == 0) return;

            MessageBox.Show($"Сегодня {DateTime.Now:dd/MM/yyyy}. \n\n С днём рождения, {User.User.Username}!", "С днем рождения!");
        }
        // авторы у которых сегодня день рождения
        private static void CheckAuthorAnniversary()
        {
            string query = Queries.GetBirthdayAuthors();
            List<List<string>> rows = Logic.ExecuteQuery(query);
            if (rows.Count == 0 || rows[0].Count == 0) return;

            foreach (var row in rows) MessageBox.Show($"Сегодня день рождения у {row[0]}. ", $"День рождения {row[0]}!!!");
        }
        // проверка просрочки
        private static void CheckDeptBooks()
        {
            string query = Queries.GetUserDeptedBooks(User.User.Username);
            List<List<string>> rows = Logic.ExecuteQuery(query);
            if (rows.Count == 0 || rows[0].Count == 0) return;

            foreach (var row in rows) MessageBox.Show($"Пожалуйста, верните книгу {row[0]} как можно раньше.\nСрок возврата книги истек...", "Просроченные книги!");
        }
        private void AddRadioButtonsFilters(string[] authors)
        {
            // add change handlers on every btn
            AllAuthorsRadioBtn.CheckedChanged += (o, args) =>
            {
                if (AllAuthorsRadioBtn.Checked)
                    UpdateBooks(AllAuthorsRadioBtn.Text);
            };

            int i = 0;
            foreach (string author in authors)
            {
                RadioButton button = new()
                {
                    Text = author,
                    Name = author,
                    Location = new Point(7, 25 * i++ + 45),
                    Width = 200
                };
                button.CheckedChanged += (o, args) =>
                {
                    if (button.Checked)
                        UpdateBooks(button.Text);
                };

                AuthorFilterBox.Controls.Add(button);
            }
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void UpdateBooks(string authorFilter = "Все авторы", string genreFilter = "Все жанры")
        {
            string query = Queries.GetAllAvailableBooks();

            if (authorFilter != "Все авторы")
                query = Queries.GetAllAvailableBooksByAuthor(authorFilter);
            if (genreFilter != "Все жанры")
                query = Queries.GetAllAvailableBooksByGenre(genreFilter);

            DataGridUser.Rows.Clear();

            Logic.ExecuteQuery(query)
               .ForEach(row => DataGridUser.Rows.Add(row.ToArray()));
        }

        private void UserBooks_Click(object sender, EventArgs e)
        {
            UserFormStep2 userFormStep2 = new("user_books");
            userFormStep2.ShowDialog();
            // возвращаемся - получаем актуальные данные
            UpdateBooks();
        }
        private void ShowHistory_Click(object sender, EventArgs e)
        {
            UserFormStep2 userFormStep2 = new("user_history");
            userFormStep2.ShowDialog();
            // возвращаемся - получаем актуальные данные
            UpdateBooks();
        }

        private void GetBook_Click_1(object sender, EventArgs e)
        {
            var row = DataGridUser.SelectedRows[0];

            string title = row.Cells[0].Value?.ToString() ?? "";
            string author = row.Cells[1].Value?.ToString() ?? "";
            string publication_year = row.Cells[2].Value?.ToString() ?? "";

            if (title.Length == 0 && author.Length == 0 && publication_year.Length == 0)
            {
                MessageBox.Show("Выберите книгу...", "Error!");
                return;
            }

            string message = $"Добрый день. \n\nПользователь <b>{User.User.Username}</b> отправил завку на взятие книги " +
                $"{title} {author} {publication_year}г. \n\nРассимотрите заявку в ближайше возможное время. \nСпасибо.";

            try
            {
                //Logic.SendMail(message, "Заявка на взятие книги");

                string query = Queries.AddUserTakeApply(User.User.Username, title);
                Logic.ExecuteNonQuery(query);

                MessageBox.Show("Ваша заявка на взятие книги успешно отправлена! Ждите одобрения администратором.", "Успех!");
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так. Попробуйте снова позже.", "Error!");
            }
        }

        private void filterByGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void TranslateTableToWord()
        {
            int row_count = DataGridUser.RowCount;
            int col_count = DataGridUser.ColumnCount;
            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc;
            Word.Paragraph wordParag;
            Word.Table wordTable;

            //создаём новый документ Word и задаём параметры листа
            wordDoc = wordApp.Documents.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing); //создаём документ Word

            // первый параграф
            wordParag = wordDoc.Paragraphs.Add(Type.Missing);
            wordParag.Range.Font.Name = "Times New Roman";
            wordParag.Range.Font.Size = 14;
            wordParag.Range.Font.Bold = 1;
            wordParag.Range.Text = "Доступные в библиотеке книги";
            wordParag.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            // второй параграф, таблица из 10 строк и 2 колонок
            wordDoc.Paragraphs.Add(Type.Missing);
            wordParag.Range.Tables.Add(wordParag.Range, row_count, col_count, Type.Missing, Type.Missing);
            wordTable = wordDoc.Tables[1];
            wordTable.Range.Font.Bold = 1;
            wordTable.Range.Font.Size = 10;
            wordTable.Borders.Enable = 1;

            //задаём ширину колонок и высоту строк
            wordTable.Columns.PreferredWidthType = Word.WdPreferredWidthType.wdPreferredWidthPoints;
            wordTable.Columns[1].SetWidth(200f, Word.WdRulerStyle.wdAdjustNone);
            wordTable.Rows.SetHeight(20f,  Word.WdRowHeightRule.wdRowHeightExactly);
            wordTable.Rows.Alignment =  Word.WdRowAlignment.wdAlignRowCenter;
            wordTable.Range.Cells.VerticalAlignment =  Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            wordTable.Range.Select();

            //заполняем ячейки таблицы
            for (int i = 1; i < row_count; i++)
                for (int j = 1; j <= col_count; j++)
                {
                    var cell = DataGridUser.Rows[i - 1].Cells[j - 1];
                    wordTable.Cell(i, j).Range.Text = cell.Value.ToString();
                }
            //сохраняем документ, закрываем документ, выходим из Word
            wordDoc.SaveAs("C:\\All_available_books.doc");
            wordApp.ActiveDocument.Close();
            wordApp.Quit();
            MessageBox.Show("Успех!", "Успех!");
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            TranslateTableToWord();
        }
    }
}
