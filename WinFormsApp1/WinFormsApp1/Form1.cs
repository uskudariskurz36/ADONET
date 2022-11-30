using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaglantiTest_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=.;Database=Northwind;Trusted_Connection=True;";

            connection.Open();
            MessageBox.Show("Baðlantý açýldý.");

            connection.Close();
            MessageBox.Show("Baðlantý kapatýldý.");
        }

        private void btnVerileriListele_Click(object sender, EventArgs e)
        {
            lstKategoriler.Items.Clear();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=.;Database=Northwind;Trusted_Connection=True;";

            // SELECT [CategoryID] ,[CategoryName] ,[Description] ,[Picture] FROM [Categories]

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT [CategoryID] ,[CategoryName] ,[Description] ,[Picture] FROM [Categories]";

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string categoryName = reader["CategoryName"].ToString();
                lstKategoriler.Items.Add(categoryName);
            }

            connection.Close();

            reader.DisposeAsync();
            command.DisposeAsync();
            connection.DisposeAsync();
        }
    }
}