using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDataAdapter_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=.;Database=Northwind;Trusted_Connection=true");
            SqlCommand command = connection.CreateCommand();
            //command.Connection = connection;

            string query = "SELECT [CategoryID] ,[CategoryName] ,[Description] FROM [Categories]";
            command.CommandText = query;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnReporter_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}