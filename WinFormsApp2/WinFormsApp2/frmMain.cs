using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace WinFormsApp2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadTodos();
        }

        private void LoadTodos()
        {
            lstTodos.Items.Clear();

            SQLHelper helper = new SQLHelper();
            string query = "SELECT Id, Text, DueDate, Done FROM Todos";

            helper.SetCommand(query);

            helper.connection.Open();

            SqlDataReader reader = helper.command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("Id");
                string text = reader.GetString("Text");
                DateTime? dueDate = reader.IsDBNull("DueDate") ? null : reader.GetDateTime("DueDate");
                bool done = reader.GetBoolean("Done");

                Todo todo = new Todo
                {
                    Id = id,
                    Text = text,
                    DueDate = dueDate,
                    Done = done,
                };

                lstTodos.Items.Add(todo);
            }

            helper.connection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SQLHelper helper = new SQLHelper();

            string query = "INSERT INTO Todos(Text, DueDate, Done) VALUES (@text , @duedate, @done)";

            helper.SetCommand(query,
                new MyParameter("@text", txtTitle.Text.Trim()),
                new MyParameter("@duedate", dtpDueDate.Checked ? dtpDueDate.Value : DBNull.Value),
                new MyParameter("@done", chkDone.Checked)
            );

            int result = helper.RunCommand();

            if (result > 0) {
                MessageBox.Show("Görev eklendi.");
                LoadTodos();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstTodos.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen güncelleme için bir görev seçiniz.");
                return;
            }

            Todo selectedTodo = lstTodos.SelectedItem as Todo;
            //Todo selectedTodo = (Todo)lstTodos.SelectedItem;

            string query = "UPDATE Todos SET Text=@text, DueDate=@duedate, Done=@done WHERE Id = @id";

            SQLHelper helper = new SQLHelper();
            helper.SetCommand(query,
                new MyParameter("@text", txtTitle.Text),
                new MyParameter("@duedate", dtpDueDate.Checked ? dtpDueDate.Value : DBNull.Value),
                new MyParameter("@done", chkDone.Checked),
                new MyParameter("@id", selectedTodo.Id)
            );

            int result = helper.RunCommand();

            if (result > 0)
            {
                MessageBox.Show("Görev güncellendi.");
                LoadTodos();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTodos.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silmek için bir görev seçiniz.");
                return;
            }

            Todo selectedTodo = lstTodos.SelectedItem as Todo;

            string query = "DELETE FROM Todos WHERE Id = @id";

            SQLHelper helper = new SQLHelper();

            helper.SetCommand(query,
                new MyParameter("@id", selectedTodo.Id));

            int result = helper.RunCommand();

            if (result > 0)
            {
                MessageBox.Show("Görev silindi.");
                LoadTodos();
            }
        }

        private void lstTodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTodos.SelectedIndex == -1)
            {
                return;
            }

            Todo selectedTodo = lstTodos.SelectedItem as Todo;

            txtTitle.Text = selectedTodo.Text;
            chkDone.Checked = selectedTodo.Done;

            if (selectedTodo.DueDate == null)
            {
                dtpDueDate.Checked = false;
            }
            else
            {
                dtpDueDate.Checked = true;
                dtpDueDate.Value = selectedTodo.DueDate.Value;
            }
        }
    }
}
