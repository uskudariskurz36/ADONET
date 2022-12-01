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
            SQLHelper helper = new SQLHelper();

            string uname = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            string query = "SELECT [Id] ,[Username] ,[Password] FROM [Users] WHERE Username = @uname AND Password = @pass";

            //helper.command.CommandText = query;
            //helper.command.Parameters.AddWithValue("@uname", uname);
            //helper.command.Parameters.AddWithValue("@pass", pass);



            //List<MyParameter> parameters = new List<MyParameter>();
            //parameters.Add(new MyParameter { ParameterName = "@uname", ParameterValue = uname });
            //parameters.Add(new MyParameter { ParameterName = "@pass", ParameterValue = pass });

            //helper.SetCommand(query, parameters);


            //helper.SetCommand(query,
            //    new MyParameter { ParameterName = "@uname", ParameterValue = uname },
            //    new MyParameter { ParameterName = "@pass", ParameterValue = pass });


            helper.SetCommand(query,
                new MyParameter("@uname", uname),
                new MyParameter("@pass", pass));


            helper.connection.Open();


            // İlk satır ilk kolon değerini döndürür. Object olarak döner.. İçindeki değeri kullanacaksanız unboxing(cast) yapmalısınız.
            // Eğer id değerini isteseydim kullanmak; int id = (int)result;

            //object result = command.ExecuteScalar();

            //bool isSuccess = false;

            //if (result != null)
            //{
            //    isSuccess = true;
            //}




            SqlDataReader reader = helper.command.ExecuteReader();

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

            helper.connection.Close();

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
