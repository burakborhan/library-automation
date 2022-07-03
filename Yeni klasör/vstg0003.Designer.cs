
namespace $safeprojectname$
{
    partial class emanetKitapİadefrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emanetKitapİadefrm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTeslimAl = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.txtTCAra = new System.Windows.Forms.TextBox();
            this.txtBarkodNoAra = new System.Windows.Forms.TextBox();
            this.lblTCyeGöre = new System.Windows.Forms.Label();
            this.lblBarkodNoyaGöre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(215, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeslimAl.Location = new System.Drawing.Point(534, 343);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(75, 23);
            this.btnTeslimAl.TabIndex = 1;
            this.btnTeslimAl.Text = "Teslim Al";
            this.btnTeslimAl.UseVisualStyleBackColor = true;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİptal.Location = new System.Drawing.Point(634, 343);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 2;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // txtTCAra
            // 
            this.txtTCAra.Location = new System.Drawing.Point(421, 47);
            this.txtTCAra.Name = "txtTCAra";
            this.txtTCAra.Size = new System.Drawing.Size(100, 20);
            this.txtTCAra.TabIndex = 3;
            this.txtTCAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBarkodNoAra
            // 
            this.txtBarkodNoAra.Location = new System.Drawing.Point(609, 47);
            this.txtBarkodNoAra.Name = "txtBarkodNoAra";
            this.txtBarkodNoAra.Size = new System.Drawing.Size(100, 20);
            this.txtBarkodNoAra.TabIndex = 4;
            this.txtBarkodNoAra.TextChanged += new System.EventHandler(this.txtBarkodNoAra_TextChanged);
            // 
            // lblTCyeGöre
            // 
            this.lblTCyeGöre.BackColor = System.Drawing.Color.Transparent;
            this.lblTCyeGöre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTCyeGöre.Location = new System.Drawing.Point(353, 46);
            this.lblTCyeGöre.Name = "lblTCyeGöre";
            this.lblTCyeGöre.Size = new System.Drawing.Size(62, 20);
            this.lblTCyeGöre.TabIndex = 5;
            this.lblTCyeGöre.Text = "TC ye göre";
            this.lblTCyeGöre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBarkodNoyaGöre
            // 
            this.lblBarkodNoyaGöre.BackColor = System.Drawing.Color.Transparent;
            this.lblBarkodNoyaGöre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBarkodNoyaGöre.Location = new System.Drawing.Point(537, 47);
            this.lblBarkodNoyaGöre.Name = "lblBarkodNoyaGöre";
            this.lblBarkodNoyaGöre.Size = new System.Drawing.Size(72, 20);
            this.lblBarkodNoyaGöre.TabIndex = 6;
            this.lblBarkodNoyaGöre.Text = "Barkod No ya göre";
            this.lblBarkodNoyaGöre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emanetKitapİadefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBarkodNoyaGöre);
            this.Controls.Add(this.lblTCyeGöre);
            this.Controls.Add(this.txtBarkodNoAra);
            this.Controls.Add(this.txtTCAra);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnTeslimAl);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "emanetKitapİadefrm";
            this.Text = "Emanet Kitap İade Sayfası";
            this.Load += new System.EventHandler(this.emanetKitapİadefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTeslimAl;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.TextBox txtTCAra;
        private System.Windows.Forms.TextBox txtBarkodNoAra;
        private System.Windows.Forms.Label lblTCyeGöre;
        private System.Windows.Forms.Label lblBarkodNoyaGöre;
    }
}