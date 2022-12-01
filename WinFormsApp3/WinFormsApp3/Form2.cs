using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        SqlConnection connection = new SqlConnection("Server=.;Database=Northwind;Trusted_connection=true");
        SqlCommand command;

        public Form2()
        {
            InitializeComponent();

            command = connection.CreateCommand();
        }

        private void btnReportListRefresh_Click(object sender, EventArgs e)
        {
            LoadReportNames();
        }

        private void LoadReportNames()
        {
            string query = "SELECT '[' + name + ']' AS name FROM sys.views ORDER BY name ASC";

            command.CommandText = query;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            cmbReportName.DataSource = null;
            cmbReportName.DataSource = table;
            cmbReportName.DisplayMember = "name";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadReportNames();
        }

        private void cmbReportName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void LoadReportData()
        {
            if (cmbReportName.SelectedIndex == -1)
            {
                dataGridView1.DataSource = null;
                return;
            }

            string viewName = (cmbReportName.SelectedItem as DataRowView)["name"].ToString();
            string query = $"SELECT * FROM {viewName}";

            command.CommandText = query;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;
        }

        private void btnDataRefresh_Click(object sender, EventArgs e)
        {
            LoadReportData();
        }
    }
}
