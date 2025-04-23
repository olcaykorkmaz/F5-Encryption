using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Kriptoloji
{
    public partial class sifrele : Form
    {
        public sifrele()
        {
            InitializeComponent();
            InitializeDictionaries();
        }

        private void InitializeDictionaries()
        {
            int[] sayilar = {20, 30, 40, 50, 60, 70, 80, 90,
                             10, 100, 110, 120, 130, 140, 150, 160,
                             170, 180, 190, 200, 210, 220, 230, 240, 250, 260};
            Random rnd = new Random(42);
            List<int> karisikSayilar = new List<int>(sayilar);
            karisikSayilar.Sort((a, b) => rnd.Next(-1, 2));

            for (int i = 0; i < 26; i++)
            {
                char harf = (char)('a' + i);
                harfSayi[harf] = karisikSayilar[i];
            }

            for (int i = 0; i <= 25; i++)
            {
                sayiHarf[i] = (char)('a' + i);
            }

            foreach (var kvp in rakamSembol)
            {
                sembolRakam[kvp.Value] = kvp.Key;
            }
        }

        private Dictionary<char, int> harfSayi = new Dictionary<char, int>();
        private Dictionary<int, char> sayiHarf = new Dictionary<int, char>();
        private Dictionary<char, char> rakamSembol = new Dictionary<char, char>()
        {
            {'0', '#'}, {'1', '@'}, {'2', '&'}, {'3', '!'}, {'4', '$'},
            {'5', '%'}, {'6', '^'}, {'7', '*'}, {'8', '+'}, {'9', '~'}
        };
        private Dictionary<char, char> sembolRakam = new Dictionary<char, char>();

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //form1.ShowDialog();
            this.Close();
        }

        private void metin_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifrele_Load(object sender, EventArgs e)
        {

        }

        private void sifrelebtn_Click(object sender, EventArgs e)
        {
            string giris = metin.Text.ToLower();
            StringBuilder sayisalDeger = new StringBuilder();

            foreach (char c in giris)
            {
                if (harfSayi.ContainsKey(c))
                    sayisalDeger.Append(harfSayi[c]);
            }

            string sayiStr = sayisalDeger.ToString();
            BigInteger sayi = BigInteger.Parse(sayiStr);
            sayi = sayi / 2;

            string sonuc = sayi.ToString();
            StringBuilder harfDonusum = new StringBuilder();

            foreach (char r in sonuc)
            {
                int rakam = int.Parse(r.ToString());
                if (sayiHarf.ContainsKey(rakam))
                    harfDonusum.Append(sayiHarf[rakam]);
            }

            StringBuilder semboller = new StringBuilder();
            foreach (char c in harfDonusum.ToString())
            {
                int pozisyon = c - 'a';
                char rakamChar = pozisyon.ToString()[0];
                if (rakamSembol.ContainsKey(rakamChar))
                    semboller.Append(rakamSembol[rakamChar]);
            }

            çıktı.Text = semboller.ToString();
        }



        private void çıktı_TextChanged(object sender, EventArgs e)
        {
            çıktı.ReadOnly = true;
            çıktı.TabStop = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Şifreli metni panoya kopyalama
            string sifreliMetin = çıktı.Text;
            if (!string.IsNullOrEmpty(sifreliMetin))
            {
                Clipboard.SetText(sifreliMetin);
                MessageBox.Show("Şifreli metin panoya kopyalandı!");
            }
            else
            {
                MessageBox.Show("Şifreli metin boş, lütfen önce şifreleme işlemi yapın.");
            }
        }
    }
}
