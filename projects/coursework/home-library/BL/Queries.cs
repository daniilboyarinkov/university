
namespace home_library.Static
{
    public static class Queries
    {
        // все свободные
        public static string GetAllAvailableBooks() =>
            $"SELECT books.title, authors.fio, books.publication_year, genres.genre_name " +
            $"FROM authors INNER JOIN (genres INNER JOIN (books INNER JOIN library ON books.book_id = library.book) ON genres.genre_id = books.genre) ON authors.author_id = books.author " +
            $"WHERE (((library.taken)=False));";
        // те что у пользователя на руках
        public static string GetUserBooks(string username) =>
            $"SELECT books.title, authors.fio, books.publication_year, taken_books.taken_date, taken_books.return_date " +
            $"FROM readers INNER JOIN ((authors INNER JOIN books ON authors.author_id = books.author) " +
            $"INNER JOIN taken_books ON books.book_id = taken_books.book) ON readers.reader_id = taken_books.reader " +
            $"WHERE (((readers.reader_name)=\"{username}\"));";

        // история книг пользователя
        public static string GetUserHistory(string username) =>
            $"SELECT books.title, authors.fio, books.publication_year, history.take_date, history.return_date " +
            $"FROM readers INNER JOIN ((authors INNER JOIN books ON authors.author_id = books.author) " +
            $"INNER JOIN history ON books.book_id = history.book) ON readers.reader_id = history.reader " +
            $"WHERE (((readers.reader_name)=\"{username}\"));";
        // все свободные отфильтрованные по жанрам
        public static string GetAllAvailableBooksByGenre(string genre) =>
            $"SELECT books.title, authors.fio, books.publication_year, books.genre " +
            $"FROM genres INNER JOIN ((authors INNER JOIN books ON authors.author_id = books.author) " +
            $"INNER JOIN library ON books.book_id = library.book) ON genres.genre_id = books.genre " +
            $"WHERE (((genres.genre_name)=\"{genre}\") AND ((library.taken)=False));";
        // все свободные отфильтрованные по автору
        public static string GetAllAvailableBooksByAuthor(string author) =>
            $"{GetAllAvailableBooks()[..^1]} AND (((authors.fio)=\"{author}\"));";
        // получить всю историю
        public static string GetAllHistory() =>
            $"SELECT books.title, readers.reader_name, history.take_date,  history.return_date " +
            $"FROM readers INNER JOIN (books INNER JOIN history ON books.book_id = history.book) ON readers.reader_id = history.reader; ";
        public static string GetAllHistoryByAuthor(string author) =>
            $"SELECT books.title, readers.reader_name, history.take_date, history.return_date " +
            $"FROM authors INNER JOIN (readers INNER JOIN (books INNER JOIN history ON books.book_id = history.book) ON readers.reader_id = history.reader) ON authors.author_id = books.author" +
            $" WHERE (((authors.fio)=\"{author}\"));";

        public static string GetAllHistoryByGenre(string genre) =>
            $"SELECT books.title, readers.reader_name, history.take_date, history.return_date " +
            $"FROM genres INNER JOIN (readers INNER JOIN (books INNER JOIN history ON books.book_id = history.book) ON readers.reader_id = history.reader) ON genres.genre_id = books.genre" +
            $" WHERE (((genres.genre_name)=\"{genre}\"));";

        public static string GetAllHistoryByReader(string reader) =>
            $"{GetAllHistory().Trim()[..^1]} WHERE (((readers.reader_name)=\"{reader}\"));";
        // получить все заявки пользователей
        public static string GetAllApplies() =>
            $"SELECT books.title, readers.reader_name, take_applies.apply_date " +
            $"FROM readers INNER JOIN (books INNER JOIN take_applies ON books.book_id = take_applies.book) ON readers.reader_id = take_applies.reader; ";
        public static string GetAllAppliesByAuthor(string author) =>
            $"SELECT books.title, readers.reader_name, take_applies.apply_date " +
            $"FROM authors INNER JOIN (readers INNER JOIN (books INNER JOIN take_applies ON books.book_id = take_applies.book) ON readers.reader_id = take_applies.reader) ON authors.author_id = books.author " +
            $"WHERE (((authors.fio)=\"{author}\"));";

        public static string GetAllAppliesByGenre(string genre) =>
            $"SELECT books.title, readers.reader_name, take_applies.apply_date " +
            $"FROM genres INNER JOIN (readers INNER JOIN (books INNER JOIN take_applies ON books.book_id = take_applies.book) ON readers.reader_id = take_applies.reader) ON genres.genre_id = books.genre " +
            $"WHERE (((genres.genre_name)=\"{genre}\"));";

        public static string GetAlAppliesByReader(string reader) =>
            $"{GetAllApplies().Trim()[..^1]} WHERE (((readers.reader_name)=\"{reader}\"));";

        // получить все 
        public static string GetAllBooks() => $"SELECT books.title FROM books;";
        public static string GetAllGenres() => $"SELECT genres.genre_name FROM genres;";
        public static string GetAllReaders() => $"SELECT readers.reader_name FROM readers;";
        public static string GetAllAuthors() => $"SELECT authors.fio FROM authors;";
        public static string GetAllAdminExceptYourself(string admin) =>
            $"SELECT admins.username FROM admins WHERE (((admins.username)<>\"{admin}\"));";

        public static string GetAdminHash(string admin) => $"SELECT admins.hash_password FROM admins WHERE (((admins.username)=\"{admin}\")); ";

        // получить конкретное
        public static string GetBook(string title) => $"SELECT books.book_id, books.title, authors.fio, books.publication_year FROM authors INNER JOIN books ON authors.author_id = books.author WHERE (((books.title)=\"{title}\")); ";
        public static string GetGenre(string genre) => $"SELECT genres.* FROM genres WHERE (((genres.genre_name)=\"{genre}\")); ";
        public static string GetReader(string username) => $"SELECT readers.* FROM readers WHERE (((readers.reader_name)=\"{username}\")); ";
        public static string GetAuthor(string author) => $"SELECT authors.* FROM authors WHERE (((authors.fio)=\"{author}\")); ";
        public static string GetAdmin(string admin) => $"SELECT admins.* FROM admins WHERE (((admins.username)=\"{admin}\")); ";

        // добавить конкретное
        public static string AddBook(string title, string author, int publication_year) =>
            $"INSERT INTO books ( title, author, publication_year ) SELECT \"{title}\", authors.author_id, {publication_year} FROM authors WHERE authors.fio = '{author}';";
        public static string AddGenre(string name) =>
            $"INSERT INTO genres ( genre_name ) Values (\"{name}\");";
        public static string AddReader(string name, DateTime birth_date) =>
            $"INSERT INTO readers ( reader_name, birth_date ) Values (\"{name}\", \"{birth_date:dd/MM/yyyy}\");";
        public static string AddAuthor(string fio, DateTime birth_date, DateTime? death_date = null) =>
            $"INSERT INTO authors ( fio, birth_date , death_date) " +
            $"Values (\"{fio}\", \"{birth_date:dd/MM/yyyy}\", \"{(death_date == null ? "" : death_date?.ToString("dd/MM/yyyy"))}\");";
        public static string AddAdmin(string admin) =>
            $"insert into admins (username, hash_password) " +
            $"values (\"{admin}\", \"AHcSiW2Aa508Mq6f5bO+papFZW9wooockWBnZf+FLOSVT958nZQg/ekCcipKVygV6g==\");";

        // обновить конкретное
        public static string UpdateBook(string new_title, int new_author, string new_publication_year, string prev_title, int prev_author) =>
            $"UPDATE books SET books.title = \"{new_title}\", books.author = {new_author}, publication_year = {int.Parse(new_publication_year)} " +
            $"WHERE (((books.author)={prev_author}) AND ((books.title)=\"{prev_title}\")); ";
        public static string UpdateGenre(string new_name, string prev_name) =>
            $"UPDATE genres SET genres.genre_name = \"{new_name}\" " +
            $"WHERE (((genres.genre_name)=\"{prev_name}\")); ";
        public static string UpdateReader(string new_name, DateTime new_birth_date, string prev_name) =>
            $"UPDATE readers SET readers.reader_name = \"{new_name}\", readers.birth_date = #{new_birth_date.ToString("dd/MM/yyyy").Replace(".", "/")}# " +
            $"WHERE (((readers.reader_name)=\"{prev_name}\")); ";
        public static string UpdateAuthor(string new_fio, DateTime new_birth_date, string prev_fio, DateTime? new_death_date = null) =>
            $"UPDATE authors SET authors.fio = \"{new_fio}\", authors.birth_date = #{new_birth_date.ToString("dd/MM/yyyy").Replace(".", "/")}#, authors.death_date = \"{(new_death_date == null ? "" : new_death_date?.ToString("dd/MM/yyyy").Replace(".", "/"))}\" " +
            $"WHERE (((authors.fio)=\"{prev_fio}\"));\r\n";
        public static string UpdateAdmin(string new_admin, string prev_admin) =>
            $"UPDATE admins SET admins.username = \"{new_admin}\" WHERE (((admins.username)=\"{prev_admin}\"));\r\n";

        // удалить конкретное
        public static string DeleteBook(string title) =>
            $"DELETE books.*, books.title FROM books WHERE (((books.title)=\"{title}\")); ";
        public static string DeleteGenre(string name) =>
            $"DELETE genres.*, genres.genre_name FROM genres WHERE (((genres.genre_name)=\"{name}\")); ";
        public static string DeleteReader(string name) =>
        $"DELETE readers.*, readers.reader_name FROM readers WHERE (((readers.reader_name)=\"{name}\")); ";
        public static string DeleteAuthor(string fio) =>
            $"DELETE authors.*, authors.fio FROM authors WHERE (((authors.fio)=\"{fio}\")); ";
        public static string DeleteAdmin(string admin) =>
            $"DELETE admins.*, admins.username FROM admins WHERE (((admins.username)=\"{admin}\")); ";

        // получить айдишники 
        public static string GetReaderId(string username) => $"SELECT reader_id FROM readers WHERE ((readers.reader_name)=\"{username}\"); ";
        public static string GetAuthorId(string fio) => $"SELECT author_id FROM authors WHERE ((authors.fio)=\"{fio}\"); ";
        public static string GetBookId(string title) => $"SELECT book_id FROM books WHERE ((books.title)=\"{title}\"); ";


        // авторы у которых сегодня др
        public static string GetBirthdayAuthors() =>
            $"SELECT authors.fio, authors.death_date " +
            $"FROM authors " +
            $"WHERE (Month(authors.birth_date) = Month(Date())) " +
            $"AND ((Day(authors.birth_date) = Day(Date())));";

        public static string CheckUsersBirthDay(string username) =>
            $"SELECT readers.reader_name " +
            $"FROM readers " +
            $"WHERE (Month(readers.birth_date) = Month(Date())) " +
            $"AND ((Day(readers.birth_date) = Day(Date())) " +
            $"AND (readers.reader_name=\"{username}\") ); ";

        // просрочка
        public static string GetDeptedBooks() =>
            $"SELECT books.title, readers.reader_name, taken_books.taken_date, taken_books.return_date, DateDiff(\"d\",taken_books.return_date,Date()) AS dept " +
            $"FROM readers INNER JOIN (books INNER JOIN taken_books ON books.book_id = taken_books.book) ON readers.reader_id = taken_books.reader " +
            $"WHERE (((taken_books.return_date)<Date())); ";
        public static string GetDeptedBooksByUser(string username) =>
            $"{GetDeptedBooks().Trim()[..^1]} AND (((readers.reader_name)=\"{username}\"));";
        public static string GetDeptedBooksByAuthor(string author) =>
            $"SELECT books.title, readers.reader_name, taken_books.taken_date, taken_books.return_date, DateDiff(\"d\",taken_books.return_date,Date()) AS dept " +
            $"FROM authors INNER JOIN (readers INNER JOIN (books INNER JOIN taken_books ON books.book_id = taken_books.book) ON readers.reader_id = taken_books.reader) ON authors.author_id = books.author " +
            $"WHERE (((taken_books.return_date)<Date())) " +
            $"AND (((authors.fio)=\"{author}\"));";
        public static string GetDeptedBooksByGenre(string genre) =>
            $"SELECT books.title, readers.reader_name, taken_books.taken_date, taken_books.return_date, DateDiff(\"d\",taken_books.return_date,Date()) AS dept " +
            $"FROM genres INNER JOIN (readers INNER JOIN (books INNER JOIN taken_books ON books.book_id = taken_books.book) ON readers.reader_id = taken_books.reader) ON genres.genre_id = books.genre " +
            $"WHERE (((taken_books.return_date)<Date())) " +
            $"AND (((genres.genre_name)=\"{genre}\"));";
        public static string GetUserDeptedBooks(string username) =>
            $"SELECT books.title, taken_books.taken_date, taken_books.return_date, DateDiff(\"d\",taken_books.return_date,Date()) AS dept " +
            $"FROM readers INNER JOIN (books INNER JOIN taken_books ON books.book_id = taken_books.book) ON readers.reader_id = taken_books.reader " +
            $"WHERE (((taken_books.return_date)<Date())) AND readers.reader_name=\"{username}\"; ";

        // для юзера
        public static string AddUserTakeApply(string username, string title) =>
            $"INSERT INTO  take_applies( reader, book, apply_date ) " +
            $"SELECT readers.reader_id, books.book_id, DATE() " +
            $"FROM books, readers " +
            $"WHERE readers.reader_name=\"{username}\" AND books.title=\"{title}\";";
        public static string RemoveUserTakeApply(string username, string title) =>
            $"DELETE readers.reader_name, books.title, take_applies.* " +
            $"FROM readers INNER JOIN (books INNER JOIN take_applies ON books.book_id = take_applies.book) ON readers.reader_id = take_applies.reader " +
            $"WHERE (((readers.reader_name)=\"{username}\") AND ((books.title)=\"{title}\")); ";

        // для админа
        public static string AddLibriryMarker(string title) =>
            $"UPDATE books INNER JOIN library ON books.book_id = library.book SET library.taken = True " +
            $"WHERE (((books.title)=\"{title}\")); ";
        public static string RemoveLibraryMarker(string title) =>
            $"UPDATE books INNER JOIN library ON books.book_id = library.book SET library.taken = False " +
            $"WHERE (((books.title)=\"{title}\")); ";

        public static string AddToTakenBooks(string title, string username) =>
            $"INSERT INTO taken_books (book, reader, taken_date, return_date) " +
            $"SELECT books.book_id, readers.reader_id, DATE(), DateAdd('d', 14, DATE())  " +
            $" FROM books, readers WHERE books.title =\"{title}\" AND readers.reader_name = \"{username}\";";
        public static string RemoveFromTakenBooks(string title, string username) =>
            $"DELETE books.title, readers.reader_name, taken_books.*, * " +
            $"FROM readers INNER JOIN (books INNER JOIN taken_books ON books.book_id = taken_books.book) ON readers.reader_id = taken_books.reader " +
            $"WHERE (((books.title)=\"{title}\") AND ((readers.reader_name)=\"{username}\")); ";

        // добавить запись в историю
        public static string AddToHistory(string title, string username) =>
            $"INSERT INTO history ( reader, book, take_date, return_date ) " +
            $"SELECT taken_books.reader, taken_books.book, taken_books.taken_date, Date() AS Выражение1 " +
            $"FROM readers INNER JOIN (books INNER JOIN taken_books ON books.book_id = taken_books.book) ON readers.reader_id = taken_books.reader " +
            $"WHERE (((books.title)=\"{title}\") AND ((readers.reader_name)=\"{username}\"));";

        // table manipulation
        //public static string AddGenreTable(string table_name) =>
        //    $"CREATE TABLE {table_name} ( ID counter(1, 1) NOT NULL Primary key, name VARCHAR );";
        //public static string RemoveGenreTable() =>
        //    $"DROP TABLE genres;";
        //public static string AddGenreBookField() =>
        //    $"ALTER TABLE books ADD genre INT;";
        //public static string RemoveGenreBookField() =>
        //    $" ALTER TABLE books DROP COLUMN genre;";
        //public static string AddGenreConnection() =>
        //    $"ALTER TABLE books ADD CONSTRAINT genres FOREIGN KEY (genre) REFERENCES genres (genre_id) ;";
        //public static string RemoveGenreConnection() =>
        //    $"alter table books drop constraint genres;";

        public static string CreateTable(string table_name, List<TableColumn> columns) =>
            $"CREATE TABLE {table_name} ( {string.Join(", ", columns.Select(d => string.Join(" ", new string[] { d.Name, d.Value })).ToArray())} );";
        public static string DropTable(string table_name) =>
            $"DROP TABLE {table_name};";
        public static string AddRelatedField(string target_table, string table_name, string key_name, string key_type) =>
            $"ALTER TABLE {target_table} ADD {table_name} {key_type};";
        public static string AddRelation(string target_table, string table_name, string key_name, string key_type) =>
            $"ALTER TABLE {target_table} ADD CONSTRAINT {table_name} FOREIGN KEY ({table_name}) REFERENCES {table_name} ({key_name}) ;";
        public static string RemoveRelation(string target_table, string table_name) =>
            $"alter table {target_table} drop constraint {table_name};";
        public static string RemoveRelatedField(string target_table, string table_name) =>
            $"alter table {target_table} drop COLUMN {table_name};";

        public static string GetAllTables() =>
            $"SELECT Name FROM MSysObjects WHERE Type=1 AND Flags=0;";
    }
}
