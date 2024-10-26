

namespace StringHelperExample
{
    public static class StringHelper
    {
        public static bool IsNullOrEmpty(string input)
        {
            return string.IsNullOrEmpty(input);
        }

        public static string CapitalizeFirstLetter(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }
    }

}
