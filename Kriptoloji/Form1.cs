namespace Kriptoloji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sifrele sifrele = new sifrele();
            sifrele.ShowDialog();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifrecöz sifrecöz = new sifrecöz();
            sifrecöz.ShowDialog();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu programýn þifreleme algoritma mantýðý," +
                "yapým ve geliþtirilmesi Olcay Korkmaz tarafýndan tasarlanmýþtýr.");
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            linkLabel1.Text = "LinkedIn profilimi ziyaret et";
            linkLabel1.Links.Clear(); // varsa eski linkleri temizle
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://www.linkedin.com/in/olcaykorkmaz/");
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        }

        private void linkLabel1_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://www.linkedin.com/in/olcaykorkmaz/") { UseShellExecute = true });

        }


        private void OpenUrl(string url)
        {
            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Olmazsa açmaz!
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Link açýlamadý: " + ex.Message);
            }
        }

    }
}
