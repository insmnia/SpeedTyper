namespace CourseProject
{
    public class TextService
    {
        private static int maxLength = 800;
        public static int minLength = 30;
        private static string[] englishTexts = { "eng1.txt", "eng2.txt" };
        private static string[] russianTexts = { "rus1.txt", "rus2.txt" };
        public static string eraseText(string text)
        {
            if (text.Length > maxLength)
            {
                return text.Substring(0, maxLength);
            }
            return text;
        }
        public static bool validateTextLength(string text)
        {
            return text.Length > minLength;
        }
        public static string[] selectSourceText(Language lang)
        {
            if(lang == Language.RUSSIAN)
            {
                return russianTexts;
            }
            else
            {
                return englishTexts;
            }
        }
    }
}
