
namespace $safeprojectname$
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUyeEklemeIslemleri = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kitapListelemeIslemleri = new System.Windows.Forms.Button();
            this.kitapEklemeIslemleri = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEKIIslemleri = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnEKVermeIslemleri = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnUyeEklemeIslemleri);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(339, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(20, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Üye Listeleme ve Güncelleme İşlemleri";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUyeEklemeIslemleri
            // 
            this.btnUyeEklemeIslemleri.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUyeEklemeIslemleri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeEklemeIslemleri.Location = new System.Drawing.Point(20, 22);
            this.btnUyeEklemeIslemleri.Name = "btnUyeEklemeIslemleri";
            this.btnUyeEklemeIslemleri.Size = new System.Drawing.Size(277, 23);
            this.btnUyeEklemeIslemleri.TabIndex = 3;
            this.btnUyeEklemeIslemleri.Text = "Üye Ekleme İşlemleri";
            this.btnUyeEklemeIslemleri.UseVisualStyleBackColor = false;
            this.btnUyeEklemeIslemleri.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.kitapListelemeIslemleri);
            this.groupBox2.Controls.Add(this.kitapEklemeIslemleri);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(339, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // kitapListelemeIslemleri
            // 
            this.kitapListelemeIslemleri.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.kitapListelemeIslemleri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapListelemeIslemleri.Location = new System.Drawing.Point(20, 51);
            this.kitapListelemeIslemleri.Name = "kitapListelemeIslemleri";
            this.kitapListelemeIslemleri.Size = new System.Drawing.Size(277, 23);
            this.kitapListelemeIslemleri.TabIndex = 6;
            this.kitapListelemeIslemleri.Text = "Kitap Listeleme İşlemleri";
            this.kitapListelemeIslemleri.UseVisualStyleBackColor = false;
            this.kitapListelemeIslemleri.Click += new System.EventHandler(this.kitapListelemeIslemleri_Click);
            // 
            // kitapEklemeIslemleri
            // 
            this.kitapEklemeIslemleri.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.kitapEklemeIslemleri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapEklemeIslemleri.Location = new System.Drawing.Point(20, 22);
            this.kitapEklemeIslemleri.Name = "kitapEklemeIslemleri";
            this.kitapEklemeIslemleri.Size = new System.Drawing.Size(277, 23);
            this.kitapEklemeIslemleri.TabIndex = 5;
            this.kitapEklemeIslemleri.Text = "Kitap Ekleme İşlemleri";
            this.kitapEklemeIslemleri.UseVisualStyleBackColor = false;
            this.kitapEklemeIslemleri.Click += new System.EventHandler(this.kitapEklemeIslemleri_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnEKIIslemleri);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.btnEKVermeIslemleri);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(339, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 128);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet Kitap İşlemleri";
            // 
            // btnEKIIslemleri
            // 
            this.btnEKIIslemleri.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEKIIslemleri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEKIIslemleri.Location = new System.Drawing.Point(20, 82);
            this.btnEKIIslemleri.Name = "btnEKIIslemleri";
            this.btnEKIIslemleri.Size = new System.Drawing.Size(277, 23);
            this.btnEKIIslemleri.TabIndex = 9;
            this.btnEKIIslemleri.Text = "Emanet Kitap İade İşlemleri";
            this.btnEKIIslemleri.UseVisualStyleBackColor = false;
            this.btnEKIIslemleri.Click += new System.EventHandler(this.btnEKIIslemleri_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button6.Cursor = System.Windows.Forms.Cursors.Default;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(20, 53);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(277, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Emanet Kitap Listeleme İşlemleri";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnEKVermeIslemleri
            // 
            this.btnEKVermeIslemleri.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEKVermeIslemleri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEKVermeIslemleri.Location = new System.Drawing.Point(20, 24);
            this.btnEKVermeIslemleri.Name = "btnEKVermeIslemleri";
            this.btnEKVermeIslemleri.Size = new System.Drawing.Size(277, 23);
            this.btnEKVermeIslemleri.TabIndex = 7;
            this.btnEKVermeIslemleri.Text = "Emanet Kitap Verme İşlemleri";
            this.btnEKVermeIslemleri.UseVisualStyleBackColor = false;
            this.btnEKVermeIslemleri.Click += new System.EventHandler(this.btnEKVermeIslemleri_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(271, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 51);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "HOŞGELDİNİZ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(930, 550);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUyeEklemeIslemleri;
        private System.Windows.Forms.Button kitapListelemeIslemleri;
        private System.Windows.Forms.Button kitapEklemeIslemleri;
        private System.Windows.Forms.Button btnEKIIslemleri;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnEKVermeIslemleri;
    }
}

