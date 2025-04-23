namespace Kriptoloji
{
    partial class sifrele
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
            metin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            sifrelebtn = new Button();
            çıktı = new TextBox();
            kopyala = new Button();
            SuspendLayout();
            // 
            // metin
            // 
            metin.Font = new Font("Segoe UI", 13F);
            metin.Location = new Point(12, 45);
            metin.Multiline = true;
            metin.Name = "metin";
            metin.Size = new Size(776, 220);
            metin.TabIndex = 0;
            metin.TextChanged += metin_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(238, 10);
            label1.Name = "label1";
            label1.Size = new Size(289, 32);
            label1.TabIndex = 1;
            label1.Text = "Şifrelenecek Metni Girin";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(350, 284);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 2;
            label2.Text = "Çıktı";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(713, 544);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 4;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sifrelebtn
            // 
            sifrelebtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sifrelebtn.Location = new Point(676, 283);
            sifrelebtn.Name = "sifrelebtn";
            sifrelebtn.Size = new Size(112, 33);
            sifrelebtn.TabIndex = 5;
            sifrelebtn.Text = "Şifrele";
            sifrelebtn.UseVisualStyleBackColor = true;
            sifrelebtn.Click += sifrelebtn_Click;
            // 
            // çıktı
            // 
            çıktı.Font = new Font("Segoe UI", 13F);
            çıktı.Location = new Point(12, 333);
            çıktı.Multiline = true;
            çıktı.Name = "çıktı";
            çıktı.Size = new Size(776, 205);
            çıktı.TabIndex = 6;
            çıktı.TextChanged += çıktı_TextChanged;
            // 
            // kopyala
            // 
            kopyala.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kopyala.Location = new Point(592, 544);
            kopyala.Name = "kopyala";
            kopyala.Size = new Size(75, 31);
            kopyala.TabIndex = 7;
            kopyala.Text = "Kopyala";
            kopyala.UseVisualStyleBackColor = true;
            kopyala.Click += button2_Click;
            // 
            // sifrele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 587);
            Controls.Add(kopyala);
            Controls.Add(çıktı);
            Controls.Add(sifrelebtn);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(metin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "sifrele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifreleme";
            Load += sifrele_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox metin;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button sifrelebtn;
        private TextBox çıktı;
        private Button kopyala;
    }
}