namespace CSharp_Arduino_CLI.Utils
{
    static class StringExtensions
    {
        public static string GetBefore(this string value, char x)
        {
            int xPos = value.IndexOf(x);
            return xPos == -1 ? string.Empty : value.Substring(0, xPos);
        }

        public static string GetAfter(this string value, char x)
        {
            int xPos = value.IndexOf(x);

            if (xPos == -1) return string.Empty;

            int startIndex = xPos + 1;
            return startIndex >= value.Length ? string.Empty : value.Substring(startIndex);
        }
    }
}
