using System.Data;
using Z36.Helpers.AdoNet;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "Server=.;Database=Northwind;Trusted_connection=true";
            SQLHelper helper = new SQLHelper(connStr);

            if (helper.ConnecionTest())
            {
                MessageBox.Show("Baðlantý baþarýlý");
            }

            helper.SetCommand("select * from categories");
            DataTable dt = helper.RunQueryForRead();

            object result1 = helper.RunQueryScalar();
            int result2 = helper.RunQueryScalar<int>();

            helper.SetCommand("INSERT INTO Categories(CategoryName, Description, Picture) VALUES(@name,@desc,null)",
                new MySqlParameter("@name", "zamazingo"),
                new MySqlParameter("@desc", null));

            int result3 = helper.RunQuery();
        }
    }
}