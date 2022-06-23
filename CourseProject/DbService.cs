using System.Data.SqlClient;


namespace CourseProject
{
    public class DbService
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tarlo\source\repos\CourseProject\CourseProject\Results.mdf;Integrated Security=True";

        public static void SaveResult(int textLength,int IntTime, string timeTaken, int errors, Language language)
        {
            string lang = Logics.languageText(language);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string wordsPerMinute = Logics.getSpeed(IntTime, textLength);
                string query = $"INSERT INTO Tests(symbols,time,errors,language,words_pm) VALUES ({textLength},'{timeTaken}',{errors},'{lang}','{wordsPerMinute}')";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
