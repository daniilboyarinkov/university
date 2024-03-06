using System.Data.OleDb;
using System.Net.Mail;
using System.Net;
using System.Data;

namespace home_library.Static
{
    public static class Logic
    {
        private static readonly string _connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB.mdb;";
        private static readonly string _emailAdress = "boyarinkov.daniil@gmail.com";
        private static readonly string _emailPsw = "futklkajignhagqx";
        public static OleDbConnection Connection { get; } = new OleDbConnection(_connectString);


        public static bool IsGenre { get; set; } = false;

        public static bool CheckGenre()
        {
            try
            {
                string query = "SELECT * FROM genres";
                ExecuteNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // возвращает лист строк со значениями 
        public static List<List<string>> ExecuteQuery(string query)
        {
            List<List<string>> data = new();

            object[] meta = new object[10];
            bool read;

            OleDbCommand command = new(query, Connection);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                do
                {
                    List<string> row = new();
                    int NumberOfColums = reader.GetValues(meta);
                    for (int i = 0; i < NumberOfColums; i++)
                    {
                        row.Add(meta[i].ToString() ?? "");
                    }
                    data.Add(row);
                    read = reader.Read();
                } while (read == true);
            }
            reader.Close();

            return data;
        }
        // выполняет запрос но ничего не взвращает
        public static void ExecuteNonQuery(string query)
        {
            OleDbCommand command = new(query, Connection);
            command.ExecuteNonQuery();
        }
        private static string[] ListListStringToArrString(List<List<string>> data)
        {
            return data.Select(d => d[0]).ToArray();
        }

        public static string[] GetAllAuthors()
        {
            string query = Queries.GetAllAuthors();
            List<List<string>> data = ExecuteQuery(query);
            return ListListStringToArrString(data);
        }
        public static string[] GetAllGenres()
        {
            string query = Queries.GetAllGenres();
            List<List<string>> data = ExecuteQuery(query);
            return ListListStringToArrString(data);
        }
        public static string[] GetAllReaders()
        {
            string query = Queries.GetAllReaders();
            List<List<string>> data = ExecuteQuery(query);
            return ListListStringToArrString(data);
        }
        public static string[] GetAllTables()
        {
            List<string> tables = new();
#pragma warning disable CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.
            DataTable d = Connection.GetSchema("Tables", new string[] { null, null, null, "TABLE" });
#pragma warning restore CS8625 // Литерал, равный NULL, не может быть преобразован в ссылочный тип, не допускающий значение NULL.

            foreach (DataRow row in d.Rows)
            {
                string TableName = row["TABLE_NAME"].ToString() ?? "";
                if (!TableName.Contains("~"))
                    tables.Add(TableName);
            }

            return tables.ToArray() ;
        }

        // Отправка сообщений на почту администратора
        public static void SendMail(string message, string subject = "Сообщение от прекрасного приложения домашней библиотеки")
        {
            using MailMessage mail = new();
            mail.From = new MailAddress(_emailAdress, "Home Library");
            mail.To.Add(_emailAdress);
            mail.Subject = subject;
            mail.Body = message;
            mail.IsBodyHtml = true;

            using SmtpClient smtp = new("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(_emailAdress, _emailPsw);
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}
