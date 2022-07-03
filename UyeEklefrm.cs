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
    public partial class UyeEklefrm : Form
    {
        public UyeEklefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-05G6QG0\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Uye(TC,AdSoyad,Yaş,Cinsiyet,Telefon,Adres,Email) values (@TC,@AdSoyad,@Yaş,@Cinsiyet,@Telefon,@Adres,@Email)", baglanti);
            komut.Parameters.AddWithValue("@TC", txtTC.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@Yaş", txtYas.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTel.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@Email", txtEmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt işlemi tamamlanmıştır.");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
