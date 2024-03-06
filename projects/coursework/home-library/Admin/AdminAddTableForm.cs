
using home_library.Static;
using MaterialSkin.Controls;

namespace home_library.Admin
{
    public partial class AdminAddTableForm : MaterialForm
    {
        private readonly string TableName;
        private readonly int NumOfColumns;
        private string[] tables;
        public AdminAddTableForm(string table_name, int num_of_columns)
        {
            InitializeComponent();

            TableName = table_name;
            NumOfColumns = num_of_columns;

            // add ID field
            //groupBox1.Controls.Add(CreateControl<TextBox>($"ID", $"ID", 1));
            //groupBox1.Controls[0].Enabled = false;
            //groupBox1.Controls.Add(new ComboBox()
            //{
            //    Name = "ID",
            //    Text = "counter(1, 1) NOT NULL Primary key",
            //    Location = new Point(250, 30),
            //    Width = 210,
            //    Enabled = false
            //}
            //);

            AddFieldsToGroupBox();
            tables = Logic.GetAllTables();
            SelectTable.Items.AddRange(tables);
        }

        private void AddFieldsToGroupBox()
        {
            for (int i = 0; i < NumOfColumns; i++)
            {
                groupBox1.Controls.Add(CreateControl<TextBox>($"field_{i + 1}", $"Поле {i + 1}", i + 1));
                groupBox1.Controls.Add(CreateComboBox($"type_{i + 1}", $"VARCHAR", i + 1));
                groupBox1.Controls.Add(CreateKeyComboBox($"key_{i + 1}", $"НЕ КЛЮЧ", i + 1));
            }
        }


        private static T CreateControl<T>(string name, string text, int i) where T : Control, new()
            => new()
            {
                Name = name,
                Text = text,
                Location = new Point(20, i * 30),
                Width = 210
            };

        private static ComboBox CreateComboBox(string name, string text, int i)
        {
            ComboBox cmbbx = new()
            {
                Name = name,
                Text = text,
                Location = new Point(250, i * 30),
                Width = 210
            };
            cmbbx.Items.AddRange(new string[] { "INT", "VARCHAR" });
            return cmbbx;
        }
        private static ComboBox CreateKeyComboBox(string name, string text, int i)
        {
            ComboBox cmbbx = new()
            {
                Name = name,
                Text = text,
                Location = new Point(470, i * 30),
                Width = 210
            };
            cmbbx.Items.AddRange(new string[] { "НЕ КЛЮЧ", "КЛЮЧ" });
            return cmbbx;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            CreateTable();
        }
        private void CreateTable()
        {
            if (tables.Contains(TableName))
            {
                MessageBox.Show($"Таблица {TableName} уже существует", "Error!");
                return;
            }
            List<string> field_names = new();
            List<string> field_values = new();
            int key = 0;
            int iter = -1;

            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox textBox)
                {
                    field_names.Add(textBox.Text);
                    iter++;
                }
                else if (control is ComboBox cbx)
                {
                    if (control.Text == "КЛЮЧ" || control.Text == "НЕ КЛЮЧ") continue;
                    if (control.GetNextControl(control, true)?.Text == "КЛЮЧ")
                    {
                        key = iter;
                    }
                    else
                    {
                        field_values.Add(cbx.Text);
                    }
                }
            }

            List<TableColumn> columns = new();
            for (int i = 0; i < NumOfColumns; i++)
                columns.Add(new TableColumn()
                {
                    Name = field_names[i].Replace(" ", "_"),
                    Value = i == key ? $"{field_values[i]} NOT NULL PRIMARY KEY" : field_values[i]
                });

            string query = Queries.CreateTable(TableName, columns);
            //try
            //{
                Logic.ExecuteNonQuery(query);
                MessageBox.Show("Таблица успешно создана!", "Успех!");
                tables = tables.Append(TableName).ToArray();
            //}
            //catch
            //{
            //    MessageBox.Show("Произошла ошибка. попробуйте позже...", "Error!");
            //}


            if (!string.IsNullOrEmpty(SelectTable.Text))
            {
                string table_name = SelectTable.Text;

                query = Queries.AddRelatedField(table_name, TableName, field_names[key].Replace(" ", "_"), field_values[key].Split(" ")[0]);
                //try
                //{
                    Logic.ExecuteNonQuery(query);

                    query = Queries.AddRelation(table_name, TableName, field_names[key].Replace(" ", "_"), field_values[key].Split(" ")[0]);
                    Logic.ExecuteNonQuery(query);

                    MessageBox.Show($"Связь успешна установлена!", "Успех!");
                //}
                //catch
                //{
                //    MessageBox.Show("Что-то пошло не так", "Error!");
                //}
                SelectTable.Text = "";
            }
        }
    }
}
