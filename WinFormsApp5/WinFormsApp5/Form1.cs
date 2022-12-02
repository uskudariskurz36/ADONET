using System.Data;
using Z36.Helpers.AdoNet;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        string connstr = "Server=.;Database=Z36GaleriDB;Trusted_Connection=true";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Title = "Resimleri Seç";
            ofd.Multiselect = true;
            ofd.Filter = "Resim Dosyalarý|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in ofd.FileNames)
                {
                    PictureBox pb = new PictureBox();
                    pb.ImageLocation = filename;
                    pb.Width = 100;
                    pb.Height = 100;
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.ContextMenuStrip = contextMenuStrip1;
                    pb.MouseClick += Pb_MouseClick;

                    flpResimler.Controls.Add(pb);
                }
            }
        }

        PictureBox _currentPicturebox;

        private void Pb_MouseClick(object? sender, MouseEventArgs e)
        {
            //if(e.Button == MouseButtons.Left)
            //{

            foreach (PictureBox pbox in flpResimler.Controls)
            {
                pbox.BorderStyle = BorderStyle.FixedSingle;
            }

            _currentPicturebox = (PictureBox)sender;
            _currentPicturebox.BorderStyle = BorderStyle.Fixed3D;

            //}
        }

        private void btnResmiSil_Click(object sender, EventArgs e)
        {
            flpResimler.Controls.Remove(_currentPicturebox);
        }

        private void btnGaleriKaydet_Click(object sender, EventArgs e)
        {
            string galeriAdi = txtGaleriAdi.Text.Trim();
            string galeriAciklama = txtGaleriAciklama.Text;
            List<string> resimler = new List<string>();

            foreach (PictureBox pbox in flpResimler.Controls)
            {
                resimler.Add(pbox.ImageLocation);
            }


            SQLHelper helper = new SQLHelper(connstr);

            string query = "INSERT INTO Galeriler VALUES (@id, @adi, @aciklama)";
            Guid galeriId = Guid.NewGuid();

            helper.SetCommand(query,
                new MySqlParameter("@id", galeriId),
                new MySqlParameter("@adi", galeriAdi),
                new MySqlParameter("@aciklama", galeriAciklama)
            );

            helper.RunQuery();

            foreach (string resim in resimler)
            {
                string query2 = "INSERT INTO Resimler VALUES(@id,@konum,@galeriid)";

                helper.SetCommand(query2,
                    new MySqlParameter("@id", Guid.NewGuid()),
                    new MySqlParameter("@konum", resim),
                    new MySqlParameter("@galeriid", galeriId)
                );

                helper.RunQuery();
            }

            LoadGaleriler();
            MessageBox.Show("Galeri Kaydedildi.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGaleriler();
        }

        private void LoadGaleriler()
        {
            lsvGaleriler.Items.Clear();

            SQLHelper helper = new SQLHelper(connstr);
            string query = "SELECT Id, Adi, Aciklama FROM Galeriler";

            helper.SetCommand(query);

            DataTable dt = helper.RunQueryForRead();

            foreach (DataRow dr in dt.Rows)
            {
                Guid id = (Guid)dr["Id"];
                string adi = dr["Adi"].ToString();
                string aciklama = dr["Aciklama"].ToString();

                ListViewItem lvi = new ListViewItem();
                lvi.Text = id.ToString();
                lvi.SubItems.Add(adi);
                lvi.SubItems.Add(aciklama);

                lsvGaleriler.Items.Add(lvi);
            }
        }

        private void btnGaleriSil_Click(object sender, EventArgs e)
        {
            if (lsvGaleriler.SelectedItems == null || lsvGaleriler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek bir seçiniz.");
                return;
            }

            ListViewItem selected = lsvGaleriler.SelectedItems[0];
            Guid galeriId = Guid.Parse(selected.Text);

            SQLHelper helper = new SQLHelper(connstr);
            string query = "DELETE FROM Galeriler WHERE Id = @id";

            helper.SetCommand(query, new MySqlParameter("@id", galeriId));
            int result = helper.RunQuery();

            if (result > 0)
            {
                MessageBox.Show("Galeri silindi.");
                LoadGaleriler();
            }
        }
    }
}