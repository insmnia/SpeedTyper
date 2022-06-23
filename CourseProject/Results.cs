using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourseProject
{
    public partial class Results : Form
    {
        public DataSet ds;
        public SqlDataAdapter adapter;
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tarlo\source\repos\CourseProject\CourseProject\Results.mdf;Integrated Security=True";
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            updateTables();
        }
        public void updateTables()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Tests", connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
