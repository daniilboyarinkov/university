
using home_library.Admin;
using home_library.Extensions;
using home_library.Static;
using MaterialSkin.Controls;
using System.Text.RegularExpressions;

namespace home_library
{
    public partial class AdminFormStep2 : MaterialForm
    {
        private readonly string state;
        private readonly string action;
        public AdminFormStep2(string state, string action)
        {
            InitializeComponent();

            this.state = state;
            this.action = action;

            Text = $"{action.Capitalize()} {Admin.Admin.HardCodedIncline(state)}.";
            SaveBtn.Text = action.Capitalize();

            //MessageBox.Show(state, action);
            UpdateInterface();
        }

        private void UpdateInterface()
        {
            string query;

            if (action == "добавить" || action == "изменить")
            {
                switch (state)
                {
                    case "жанр":
                        groupBox1.Controls?.Add(CreateControl<Label>("genre_label", "Жанр: ", 1));
                        groupBox1.Controls?.Add(CreateControl<TextBox>("genre_textbox", "", 2));

                        break;
                    case "книга":
                        query = Queries.GetAllAuthors();
                        string[] authors = Logic.ExecuteQuery(query).Select(d => d[0]).ToArray();

                        groupBox1.Controls?.Add(CreateControl<Label>("title_label", "Название: ", 1));
                        groupBox1.Controls?.Add(CreateControl<TextBox>("title_textbox", "", 2));

                        groupBox1.Controls?.Add(CreateControl<Label>("author_label", "Автор: ", 3));
                        groupBox1.Controls?.Add(CreateComboBox("author_textbox", "", 4, authors));

                        groupBox1.Controls?.Add(CreateControl<Label>("publicationYear_label", "Год публикации: ", 5));
                        groupBox1.Controls?.Add(CreateControl<TextBox>("publicationYear_textbox", "", 6));

                        groupBox1.Controls?.Add(CreateControl<Label>("genre_label", "Жанр: ", 7));
                        groupBox1.Controls?.Add(CreateControl<TextBox>("genre_textbox", "", 8));

                        break;
                    case "пользователь":
                        groupBox1.Controls?.Add(CreateControl<Label>("name_label", "Имя: ", 1));
                        groupBox1.Controls?.Add(CreateControl<TextBox>("name_textbox", "", 2));

                        groupBox1.Controls?.Add(CreateControl<Label>("birthday_label", "Дата рождения: ", 3));
                        groupBox1.Controls?.Add(CreateControl<DateTimePicker>("birthday_datepicker", "", 4));

                        break;
                    case "автор":
                        groupBox1.Controls?.Add(CreateControl<Label>("name_label", "Имя: ", 1));
                        groupBox1.Controls?.Add(CreateControl<TextBox>("name_textbox", "", 2));

                        groupBox1.Controls?.Add(CreateControl<Label>("birthday_label", "Дата рождения: ", 3));
                        groupBox1.Controls?.Add(CreateControl<DateTimePicker>("birthday_datepicker", "", 4));

                        groupBox1.Controls?.Add(CreateControl<Label>("deathday_label", "Дата Смерти (может быть пустым): ", 5));
                        groupBox1.Controls?.Add(CreateControl<DateTimePicker>("deathhday_datepicker", "", 6));

                        break;
                    case "админ коллегия":
                        groupBox1.Controls?.Add(CreateControl<Label>("admin_label", "Админ: ", 1));
                        groupBox1.Controls?.Add(CreateControl<TextBox>("amdin_textbox", "", 2));

                        break;
                    default:
                        break;
                }
            }
            else if (action == "удалить")
            {
                switch (state)
                {
                    case "жанр":
                        query = Queries.GetAllGenres();
                        string[] genres = Logic.ExecuteQuery(query).Select(d => d[0]).ToArray();

                        groupBox1.Controls?.Add(CreateControl<Label>("genre_label", "Жанр: ", 1));
                        groupBox1.Controls?.Add(CreateComboBox("genre_combobox", "", 2, genres));

                        break;
                    case "книга":
                        query = Queries.GetAllBooks();
                        string[] books = Logic.ExecuteQuery(query).Select(d => d[0]).ToArray();

                        groupBox1.Controls?.Add(CreateControl<Label>("title_label", "Книга: ", 1));
                        groupBox1.Controls?.Add(CreateComboBox("title_combobox", "", 2, books));

                        break;
                    case "пользователь":
                        query = Queries.GetAllReaders();
                        string[] readers = Logic.ExecuteQuery(query).Select(d => d[0]).ToArray();

                        groupBox1.Controls?.Add(CreateControl<Label>("name_label", "Пользователь: ", 1));
                        groupBox1.Controls?.Add(CreateComboBox("name_combobox", "", 2, readers));

                        break;
                    case "автор":
                        query = Queries.GetAllAuthors();
                        string[] authors = Logic.ExecuteQuery(query).Select(d => d[0]).ToArray();

                        groupBox1.Controls?.Add(CreateControl<Label>("name_label", "Автор: ", 1));
                        groupBox1.Controls?.Add(CreateComboBox("name_combobox", "", 2, authors));

                        break;
                    case "админ коллегия":
                        query = Queries.GetAllAdminExceptYourself(Admin.Admin.Login);
                        string[] admins = Logic.ExecuteQuery(query).Select(d => d[0]).ToArray();

                        groupBox1.Controls?.Add(CreateControl<Label>("admin_label", "Админ: ", 1));
                        groupBox1.Controls?.Add(CreateComboBox("amdin_combobox", "", 2, admins));

                        break;
                    default:
                        break;
                }
            }
            else
            {
                Close();
            }
            if (action == "изменить")
            {
                switch (state)
                {
                    case "жанр":
                        query = Queries.GetAllGenres();
                        string[] genres = Logic.ExecuteQuery(query).Select(d => d[0]).ToArray();

                        groupBox1.Controls?.Add(CreateControl<Label>("genre_label", "Жанр: ", 1, "right"));
                        groupBox1.Controls?.Add(CreateComboBox("prev_combobox", "", 2, genres, "right"));

                        break;
                    case "книга":
                        query = Queries.GetAllBooks();
                        string[] books = Logic.ExecuteQuery(query).Select(d => d[0]).ToArray();

                        groupBox1.Controls?.Add(CreateControl<Label>("title_label", "Книга: ", 1, "right"));
                        groupBox1.Controls?.Add(CreateComboBox("prev_combobox", "", 2, books, "right"));

                        break;
                    case "пользователь":
                        query = Queries.GetAllReaders();
                        string[] readers = Logic.ExecuteQuery(query).Select(d => d[0]).ToArray();

                        groupBox1.Controls?.Add(CreateControl<Label>("name_label", "Пользователь: ", 1, "right"));
                        groupBox1.Controls?.Add(CreateComboBox("prev_combobox", "", 2, readers, "right"));

                        break;
                    case "автор":
                        query = Queries.GetAllAuthors();
                        string[] authors = Logic.ExecuteQuery(query).Select(d => d[0]).ToArray();

                        groupBox1.Controls?.Add(CreateControl<Label>("name_label", "Автор: ", 1, "right"));
                        groupBox1.Controls?.Add(CreateComboBox("prev_combobox", "", 2, authors, "right"));

                        break;
                    case "админ коллегия":
                        query = Queries.GetAllAdminExceptYourself(Admin.Admin.Login);
                        string[] admins = Logic.ExecuteQuery(query).Select(d => d[0]).ToArray();

                        groupBox1.Controls?.Add(CreateControl<Label>("name_label", "Автор: ", 1, "right"));
                        groupBox1.Controls?.Add(CreateComboBox("prev_combobox", "", 2, admins, "right"));

                        break;
                    default:
                        break;
                }
            }
        }

        private void UpdateFields(string value)
        {
            if (string.IsNullOrEmpty(value)) return;
            string query;

            switch (state)
            {
                case "жанр":
                    query = Queries.GetGenre(value);
                    break;
                case "книга":
                    query = Queries.GetBook(value);
                    break;
                case "пользователь":
                    query = Queries.GetReader(value);
                    break;
                case "автор":
                    query = Queries.GetAuthor(value);
                    break;
                case "админ коллегия":
                    query = Queries.GetAdmin(value);
                    break;
                default:
                    return;
            }
            List<List<string>> data = Logic.ExecuteQuery(query);

            int i = 1;
            foreach (Control control in groupBox1.Controls)
            {
                if (control is not Label)
                {
                    if (control is DateTimePicker)
                    {
                        ((DateTimePicker)control).Value = data[0][i].Length > 0 ? Convert.ToDateTime(data[0][i++]) : DateTime.Today;
                    }
                    else
                    {
                        if (i < data[0].Count)
                            control.Text = data[0][i++];
                    }
                }
            }
            i = 1;
        }

        private ComboBox CreateComboBox(string name, string text, int i, string[] items, string side = "left")
        {
            ComboBox cmbbx = new()
            {
                Name = name,
                Text = text,
                Location = new Point((side == "right" ? 250 : 20), i * 30),
                Width = 210
            };

            cmbbx.Items.AddRange(items);

            if (side == "right")
                cmbbx.SelectedValueChanged += (o, args) => UpdateFields(cmbbx.Text);

            return cmbbx;
        }


        private T CreateControl<T>(string name, string text, int i, string side = "left") where T : Control, new()
            => new()
                {
                    Name = name,
                    Text = text,
                    Location = new Point((side == "right" ? 250 : 20), i * 30),
                    Width = 210
                };


        private bool ValidateYear(string year) =>
            Regex.IsMatch(year, @"^[12]\d{3}$") && int.Parse(year) <= 2023;

        private bool ValidateFields()
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox && control.Text.Length == 0)
                {
                    MessageBox.Show("Заполните все поля!");
                    return false;
                }
                if (control is ComboBox && control.Text.Length == 0)
                {
                    MessageBox.Show("Заполните все поля!");
                    return false;
                }
                if (control is TextBox && control.Name.ToLower().Contains("year") && !ValidateYear(control.Text))
                {
                    MessageBox.Show(control.Text);
                    return false;
                }
            }
            return true;
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // validation
            bool valid = ValidateFields();
            if (!valid) return;


            // db quering
            if (action == "добавить")
            {
                AddAction();
            }
            else if (action == "удалить")
            {
                DeleteAction();
            }
            else if (action == "изменить")
            {
                ChangeAction();
            }
            else return;
        }

        private void AddAction()
        {
            string query;

            try
            {
                switch (state)
                {
                    case "жанр":
                        string name = groupBox1.Controls["genre_textbox"].Text;

                        query = Queries.AddGenre(name);
                        Logic.ExecuteNonQuery(query);

                        break;
                    case "книга":
                        string title = groupBox1.Controls["title_textbox"].Text;
                        string author = groupBox1.Controls["author_textbox"].Text;
                        int py = int.Parse(groupBox1.Controls["publicationYear_textbox"].Text);

                        query = Queries.AddBook(title, author, py);
                        Logic.ExecuteNonQuery(query);

                        break;
                    case "пользователь":
                        string username = groupBox1.Controls["name_textbox"].Text;
                        DateTime birth_date = ((DateTimePicker)groupBox1.Controls["birthday_datepicker"]).Value;

                        query = Queries.AddReader(username, birth_date);
                        Logic.ExecuteNonQuery(query);

                        break;
                    case "автор":
                        string fio = groupBox1.Controls["name_textbox"].Text;
                        DateTime birthDate = ((DateTimePicker)groupBox1.Controls["birthday_datepicker"]).Value;
                        DateTime? deathDate = ((DateTimePicker)groupBox1.Controls["deathhday_datepicker"]).Value;

                        query = Queries.AddAuthor(fio, birthDate, deathDate);
                        Logic.ExecuteNonQuery(query);

                        break;
                    case "админ коллегия":
                        string login = groupBox1.Controls["amdin_textbox"].Text;

                        query = Queries.AddAdmin(login);
                        Logic.ExecuteNonQuery(query);

                        break;
                    default:
                        break;
                }
                MessageBox.Show("Значение успешно добавлено", "Успех!");
            }
            catch
            {
                MessageBox.Show("Error!");
            }

        }
        private void DeleteAction()
        {
            string query;
            List<List<string>> data;

            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить значение?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    switch (state)
                    {
                        case "жанр":
                            string genre = groupBox1.Controls["genre_combobox"].Text;

                            query = Queries.DeleteGenre(genre);
                            Logic.ExecuteNonQuery(query);

                            // update combobox values
                            ((ComboBox)groupBox1.Controls["genre_combobox"]).Items.Clear();
                            ((ComboBox)groupBox1.Controls["genre_combobox"]).Text = "";

                            query = Queries.GetAllGenres();
                            data = Logic.ExecuteQuery(query);
                            string[] genres = Logic.ExecuteQuery(query).Select(d => d[0]).ToArray();
                            ((ComboBox)groupBox1.Controls["genre_combobox"]).Items.AddRange(genres);

                            break;
                        case "книга":
                            string title = groupBox1.Controls["title_combobox"].Text;

                            query = Queries.DeleteBook(title);
                            Logic.ExecuteNonQuery(query);

                            // update combobox values
                            ((ComboBox)groupBox1.Controls["title_combobox"]).Items.Clear();
                            ((ComboBox)groupBox1.Controls["title_combobox"]).Text = "";

                            query = Queries.GetAllBooks();
                            data = Logic.ExecuteQuery(query);
                            string[] books = Logic.ExecuteQuery(query).Select(d => d[0]).ToArray();
                            ((ComboBox)groupBox1.Controls["title_combobox"]).Items.AddRange(books);

                            break;
                        case "пользователь":
                            string username = groupBox1.Controls["name_combobox"].Text;

                            query = Queries.DeleteReader(username);
                            Logic.ExecuteNonQuery(query);

                            // update combobox values
                            ((ComboBox)groupBox1.Controls["name_combobox"]).Items.Clear();
                            ((ComboBox)groupBox1.Controls["name_combobox"]).Text = "";

                            query = Queries.GetAllReaders();
                            data = Logic.ExecuteQuery(query);
                            string[] readers = Logic.ExecuteQuery(query).Select(d => d[0]).ToArray();
                            ((ComboBox)groupBox1.Controls["name_combobox"]).Items.AddRange(readers);

                            break;
                        case "автор":
                            string fio = groupBox1.Controls["name_combobox"].Text;

                            query = Queries.DeleteAuthor(fio);
                            Logic.ExecuteNonQuery(query);

                            // update combobox values
                            ((ComboBox)groupBox1.Controls["name_combobox"]).Items.Clear();
                            ((ComboBox)groupBox1.Controls["name_combobox"]).Text = "";

                            query = Queries.GetAllAuthors();
                            data = Logic.ExecuteQuery(query);
                            string[] authors = Logic.ExecuteQuery(query).Select(d => d[0]).ToArray();
                            ((ComboBox)groupBox1.Controls["name_combobox"]).Items.AddRange(authors);

                            break;
                        case "админ коллегия":
                            string admin = groupBox1.Controls["amdin_combobox"].Text;

                            query = Queries.DeleteAdmin(admin);
                            Logic.ExecuteNonQuery(query);

                            // update combobox values
                            ((ComboBox)groupBox1.Controls["amdin_combobox"]).Items.Clear();
                            ((ComboBox)groupBox1.Controls["amdin_combobox"]).Text = "";

                            query = Queries.GetAllAdminExceptYourself(Admin.Admin.Login);
                            data = Logic.ExecuteQuery(query);
                            string[] admins = Logic.ExecuteQuery(query).Select(d => d[0]).ToArray();
                            ((ComboBox)groupBox1.Controls["amdin_combobox"]).Items.AddRange(admins);

                            break;
                        default:
                            break;
                    }
                    MessageBox.Show("Значение успешно удалено", "Успех!");
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
        }
        private void ChangeAction()
        {
            string query;
            List<List<string>> data;
            string prev;

            try
            {
                switch (state)
                {
                    case "жанр":
                        prev = ((ComboBox)groupBox1.Controls["prev_combobox"]).Text;

                        query = Queries.GetGenre(prev);
                        data = Logic.ExecuteQuery(query);

                        string prev_name = data[0][1];
                        string new_name = groupBox1.Controls["genre_textbox"].Text.Trim();

                        query = Queries.UpdateGenre(new_name, prev_name);
                        Logic.ExecuteNonQuery(query);

                        // update combobox values
                        query = Queries.GetAllGenres();
                        UpdateComboboxValues(query);

                        break;
                    case "книга":
                        prev = ((ComboBox)groupBox1.Controls["prev_combobox"]).Text;

                        query = Queries.GetBook(prev);
                        data = Logic.ExecuteQuery(query);

                        string prev_title = data[0][1];
                        string prev_author = data[0][2];
                        string new_title = groupBox1.Controls["title_textbox"].Text.Trim();
                        string new_author = groupBox1.Controls["author_textbox"].Text.Trim();
                        string new_publication_year = groupBox1.Controls["publicationYear_textbox"].Text.Trim();

                        query = Queries.GetAuthorId(prev_author);
                        int prev_author_int = int.Parse(Logic.ExecuteQuery(query)[0][0]);
                        query = Queries.GetAuthorId(new_author);
                        int new_author_int = int.Parse(Logic.ExecuteQuery(query)[0][0]);

                        query = Queries.UpdateBook(new_title, new_author_int, new_publication_year, prev_title, prev_author_int);
                        Logic.ExecuteNonQuery(query);

                        // update combobox values
                        query = Queries.GetAllBooks();
                        UpdateComboboxValues(query);

                        break;
                    case "пользователь":
                        prev = ((ComboBox)groupBox1.Controls["prev_combobox"]).Text;

                        query = Queries.GetReader(prev);

                        string prev_username = Logic.ExecuteQuery(query)[0][1];
                        string new_username = groupBox1.Controls["name_textbox"].Text.Trim();
                        DateTime new_birth_date = GetDateTimPickerValue("birthday_datepicker");

                        query = Queries.UpdateReader(new_username, new_birth_date, prev_username);
                        Logic.ExecuteNonQuery(query);

                        // update combobox values
                        query = Queries.GetAllReaders();
                        UpdateComboboxValues(query);

                        break;
                    case "автор":
                        prev = ((ComboBox)groupBox1.Controls["prev_combobox"]).Text;

                        query = Queries.GetAuthor(prev);
                        string prev_fio = Logic.ExecuteQuery(query)[0][1];

                        string new_fio = groupBox1.Controls["name_textbox"].Text.Trim();
                        DateTime new_birthDate = GetDateTimPickerValue("birthday_datepicker");
                        DateTime new_death_date = GetDateTimPickerValue("deathhday_datepicker");

                        query = Queries.UpdateAuthor(new_fio, new_birthDate, prev_fio, new_death_date);
                        Logic.ExecuteNonQuery(query);

                        // update combobox values
                        query = Queries.GetAllAuthors();
                        UpdateComboboxValues(query);

                        break;
                    case "админ коллегия":
                        prev = ((ComboBox)groupBox1.Controls["prev_combobox"]).Text;

                        query = Queries.GetAdmin(prev);
                        string prev_admin = Logic.ExecuteQuery(query)[0][1];
                        string new_admin = groupBox1.Controls["amdin_textbox"].Text.Trim();

                        query = Queries.UpdateAdmin(new_admin, prev_admin);
                        Logic.ExecuteNonQuery(query);

                        // update combobox values
                        query = Queries.GetAllAdminExceptYourself(Admin.Admin.Login);
                        UpdateComboboxValues(query);

                        break;
                    default:
                        break;
                }
                MessageBox.Show("Значение успешно изменено", "Успех!");
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private DateTime GetDateTimPickerValue(string id) => 
            ((DateTimePicker)groupBox1.Controls[id]).Value;

        private void UpdateComboboxValues(string query)
        {
            ((ComboBox)groupBox1.Controls["prev_combobox"]).Items.Clear();
            ((ComboBox)groupBox1.Controls["prev_combobox"]).Text = "";
            string[] rows = Logic.ExecuteQuery(query).Select(d => d[0]).ToArray();
            ((ComboBox)groupBox1.Controls["prev_combobox"]).Items.AddRange(rows);
        }
    }

}
