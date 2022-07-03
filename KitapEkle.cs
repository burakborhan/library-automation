using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace $safeprojectname$
{
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-05G6QG0\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kitap(BarkodNo,Ad,Yazar,Yayınevi,SayfaSayısı,Tür,StokSayısı,RafNo,kayittarihi) values (@BarkodNo,@Ad,@Yazar,@Yayınevi,@SayfaSayısı,@Tür,@StokSayısı,@RafNo,@kayittarihi)", baglanti);
            komut.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@Ad", txtKitapAdı.Text);
            komut.Parameters.AddWithValue("@Yazar", txtYazar.Text);
            komut.Parameters.AddWithValue("@Yayınevi", txtYayınevi.Text);
            komut.Parameters.AddWithValue("@SayfaSayısı", txtSayfaSayısı.Text);
            komut.Parameters.AddWithValue("@Tür", cmbTür.Text);
            komut.Parameters.AddWithValue("@StokSayısı", txtStokSayısı.Text);
            komut.Parameters.AddWithValue("@RafNo", txtRafNo.Text);
            komut.Parameters.AddWithValue("@kayittarihi", DateTime.Now.ToShortDateString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt işlemi tamamlanmıştır.");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item != textBox1)
                    {
                        item.Text = "";
                    }
                    
                }
            }
        }
    }
}
