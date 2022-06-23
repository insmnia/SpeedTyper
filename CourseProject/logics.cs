using System;
using System.IO;



namespace CourseProject
{
    public class Logics
    {
        public static string[] getSourceTexts(Language language)
        {
            return TextService.selectSourceText(language);
        }
        public static string pickRandomText(Language language)
        {
            string[] sourceTexts = getSourceTexts(language);
            Random random = new Random();
            return LoadText(sourceTexts[random.Next(1, 2)]);

        }
        public static string LoadText(string filename)
        {
            string text;
            using (StreamReader sr = new StreamReader(filename))
            {
                text = sr.ReadToEnd();
                if (!TextService.validateTextLength(text))
                {
                    throw new Exception("incorrect length");
                }
                text = TextService.eraseText(text);
            }
            return text;
        }
        public static string LoadTextFromFile(string filename)
        {
            if (!filename.EndsWith(".txt"))
            {
                throw new Exception("incorrect file format");
            }
            return LoadText(filename);
        }
        public static string convertTime(int t)
        {
            return $"{t / 60}:{t % 60}";
        }
        public static string languageText(Language language) {
            if (language == Language.RUSSIAN)
            {
                return "Russian";
            }
            else if(language == Language.USERS)
            {
                return "Users custom";
            }
            else
            {
                return "English";
            }
        }
        public static string getSpeed(int timeTaken, int textLength)
        {
            return ((int)((float)textLength / timeTaken * 60)).ToString();
        }
    }
}
