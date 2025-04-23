namespace Kriptoloji
{
    partial class sifrecöz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            sifre = new TextBox();
            çıktı = new TextBox();
            sçöz = new Button();
            yapistir = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(713, 544);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 9;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(377, 290);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 7;
            label2.Text = "Çıktı";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(275, 9);
            label1.Name = "label1";
            label1.Size = new Size(278, 32);
            label1.TabIndex = 6;
            label1.Text = "Şifrelenmiş Metni Girin";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // sifre
            // 
            sifre.Font = new Font("Segoe UI", 13F);
            sifre.Location = new Point(12, 54);
            sifre.Multiline = true;
            sifre.Name = "sifre";
            sifre.Size = new Size(776, 192);
            sifre.TabIndex = 5;
            // 
            // çıktı
            // 
            çıktı.Font = new Font("Segoe UI", 13F);
            çıktı.Location = new Point(12, 335);
            çıktı.Multiline = true;
            çıktı.Name = "çıktı";
            çıktı.Size = new Size(776, 203);
            çıktı.TabIndex = 10;
            çıktı.TextChanged += çıktı_TextChanged;
            // 
            // sçöz
            // 
            sçöz.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sçöz.Location = new Point(680, 275);
            sçöz.Name = "sçöz";
            sçöz.Size = new Size(108, 31);
            sçöz.TabIndex = 11;
            sçöz.Text = "Şifre Çöz";
            sçöz.UseVisualStyleBackColor = true;
            sçöz.Click += sçöz_Click;
            // 
            // yapistir
            // 
            yapistir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            yapistir.Location = new Point(526, 275);
            yapistir.Name = "yapistir";
            yapistir.Size = new Size(108, 31);
            yapistir.TabIndex = 12;
            yapistir.Text = "Yapıştır";
            yapistir.UseVisualStyleBackColor = true;
            yapistir.Click += yapistir_Click;
            // 
            // sifrecöz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 587);
            Controls.Add(yapistir);
            Controls.Add(sçöz);
            Controls.Add(çıktı);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sifre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "sifrecöz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox sifre;
        private TextBox çıktı;
        private Button sçöz;
        private Button yapistir;
    }
}