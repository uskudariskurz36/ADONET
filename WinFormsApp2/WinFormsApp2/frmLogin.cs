using System.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=.;Database=Z36TodoAppDB;Trusted_Connection=true");

            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            string uname = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            string query = "SELECT [Id] ,[Username] ,[Password] FROM [Users] WHERE Username = @uname AND Password = @pass";

            command.CommandText = query;
            command.Parameters.AddWithValue("@uname", uname);
            command.Parameters.AddWithValue("@pass", pass);

            connection.Open();


            // İlk satır ilk kolon değerini döndürür. Object olarak döner.. İçindeki değeri kullanacaksanız unboxing(cast) yapmalısınız.
            // Eğer id değerini isteseydim kullanmak; int id = (int)result;

            //object result = command.ExecuteScalar();

            //bool isSuccess = false;

            //if (result != null)
            //{
            //    isSuccess = true;
            //}




            SqlDataReader reader = command.ExecuteReader();

            bool isSuccess = false;

            //while (reader.Read())
            //{
            //    isSuccess = true;
            //    break;
            //}
            //if(reader.Read())
            //{
            //    isSuccess = true;
            //}
            if (reader.HasRows)
            {
                isSuccess = true;
            }

            connection.Close();

            if (isSuccess)
            {
                this.Visible = false;

                frmMain frm = new frmMain();
                frm.ShowDialog();

                this.Close();
                //Application.Exit();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ve şifre.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
