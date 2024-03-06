namespace home_library.Extensions
{
    public static class StringExtensions
    {
        public static string? Capitalize(this string input)
        {
            if (string.IsNullOrEmpty(input)) return null;

            return char.ToUpper(input[0]) + input[1..];
        }
    }
}
