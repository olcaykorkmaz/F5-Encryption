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
    public partial class sifrecöz : Form
    {
        public sifrecöz()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void çıktı_TextChanged(object sender, EventArgs e)
        {
            çıktı.ReadOnly = true;
            çıktı.TabStop = false;
        }

        private Dictionary<char, int> harfSayi = new Dictionary<char, int>();
        private Dictionary<int, char> sayiHarf = new Dictionary<int, char>();
        private Dictionary<char, char> rakamSembol = new Dictionary<char, char>()
        {
            {'0', '#'}, {'1', '@'}, {'2', '&'}, {'3', '!'}, {'4', '$'},
            {'5', '%'}, {'6', '^'}, {'7', '*'}, {'8', '+'}, {'9', '~'}
        };
        private Dictionary<char, char> sembolRakam = new Dictionary<char, char>();


        private void sçöz_Click(object sender, EventArgs e)
        {
            string sifreli = sifre.Text;
            StringBuilder rakamlar = new StringBuilder();

            foreach (char c in sifreli)
            {
                if (sembolRakam.ContainsKey(c))
                    rakamlar.Append(sembolRakam[c]);
            }

            StringBuilder harfler = new StringBuilder();
            foreach (char r in rakamlar.ToString())
            {
                int rakam = int.Parse(r.ToString());
                if (sayiHarf.ContainsKey(rakam))
                    harfler.Append(sayiHarf[rakam]);
            }

            string harfStr = harfler.ToString();

            StringBuilder sonucSayi = new StringBuilder();
            foreach (char harf in harfStr)
            {
                int rakam = harf - 'a';
                sonucSayi.Append(rakam);
            }

            BigInteger tamSayi;
            try
            {
                tamSayi = BigInteger.Parse(sonucSayi.ToString());
            }
            catch
            {
                çıktı.Text = "Çözüm başarısız";
                return;
            }

            BigInteger orijinalSayi = tamSayi * 2;
            string orijinalStr = orijinalSayi.ToString();
            StringBuilder cozum = new StringBuilder();
            int i = 0;

            while (i < orijinalStr.Length)
            {
                bool matched = false;
                for (int len = 3; len >= 2; len--)
                {
                    if (i + len <= orijinalStr.Length)
                    {
                        string parcacik = orijinalStr.Substring(i, len);
                        if (int.TryParse(parcacik, out int deger) && harfSayi.ContainsValue(deger))
                        {
                            foreach (var kvp in harfSayi)
                            {
                                if (kvp.Value == deger)
                                {
                                    cozum.Append(kvp.Key);
                                    i += len;
                                    matched = true;
                                    break;
                                }
                            }
                            if (matched) break;
                        }
                    }
                }
                if (!matched) i++;
            }

            çıktı.Text = cozum.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void yapistir_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string panoMetni = Clipboard.GetText();
                sifre.Text = panoMetni;
            }
            else
            {
                MessageBox.Show("Panoda metin bulunamadı.");
            }
        }
    }
}
