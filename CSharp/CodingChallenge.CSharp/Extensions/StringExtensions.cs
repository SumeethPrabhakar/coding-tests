namespace Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Extension method for IsNullOrEmpty.
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>true if null or empty else false</returns>
        public static bool IsNullOrEmpty(this string inputString)
        {
            return inputString == null || inputString.Length == 0;
        }
    }
}