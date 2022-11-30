using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaglantiTest_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = "Server=.;Database=Northwind;Trusted_Connection=True;";

            connection.Open();
            MessageBox.Show("Baðlantý açýldý.");

            connection.Close();
            MessageBox.Show("Baðlantý kapatýldý.");
        }

        private void btnVerileriListele_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            lstKategoriler.Items.Clear();

            // SELECT [CategoryID] ,[CategoryName] ,[Description] ,[Picture] FROM [Categories]

            //SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = "Server=.;Database=Northwind;Trusted_Connection=True;";

            //SqlCommand command = new SqlCommand();
            //command.Connection = connection;

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
            //command.DisposeAsync();
            //connection.DisposeAsync();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // INSERT INTO [dbo].[Categories] ([CategoryName] ,[Description] ,[Picture]) VALUES ('xxx' ,NULL ,NULL) 

            //SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = "Server=.;Database=Northwind;Trusted_Connection=True;";

            //SqlCommand command = new SqlCommand();
            //command.Connection = connection;

            string categoryName = txtYeniKategoriAdi.Text.Trim();
            string query = $"INSERT INTO [dbo].[Categories] ([CategoryName] ,[Description] ,[Picture]) VALUES ('{categoryName}' ,NULL ,NULL)";

            command.CommandText = query;

            connection.Open();

            int affectedRowCount = command.ExecuteNonQuery();

            connection.Close();


            if (affectedRowCount > 0)
            {
                LoadCategories();
                MessageBox.Show("Kategori eklendi.");
            }
            else
            {
                MessageBox.Show("Kategori eklenemedi");
            }

            //command.Dispose();
            //connection.Dispose();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = "Server=.;Database=Northwind;Trusted_Connection=True;";

            //SqlCommand command = new SqlCommand();
            //command.Connection = connection;

            string oldCategoryName = txtEskiKategoriAdi.Text.Trim();
            string newCategoryName = txtGuncelKategoriAdi.Text.Trim();

            string query = 
                $"UPDATE [dbo].[Categories] SET [CategoryName] = '{newCategoryName}' WHERE [CategoryName] = '{oldCategoryName}'";

            command.CommandText = query;

            connection.Open();

            int affectedRowCount = command.ExecuteNonQuery();

            connection.Close();

            if (affectedRowCount > 0)
            {
                LoadCategories();
                MessageBox.Show("Kategori güncellendi.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // DELETE FROM [dbo].[Categories] WHERE [CategoryName] = ''

            //SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = "Server=.;Database=Northwind;Trusted_Connection=True;";

            //SqlCommand command = new SqlCommand();
            //command.Connection = connection;

            string delCategoryName = txtSilinecekKategoriAdi.Text.Trim();

            string query = $"DELETE FROM [dbo].[Categories] WHERE [CategoryName] = '{delCategoryName}'";

            command.CommandText = query;

            connection.Open();

            int affectedRowCount = command.ExecuteNonQuery();

            connection.Close();

            if (affectedRowCount > 0)
            {
                LoadCategories();
                MessageBox.Show("Kategori silindi.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = "Server=.;Database=Northwind;Trusted_Connection=True;";
            command.Connection = connection;

            LoadCategories();
        }
    }
}