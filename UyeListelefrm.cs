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
    public partial class UyeListelefrm : Form
    {
        public UyeListelefrm()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTC.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-05G6QG0\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");

        private void UyeListelefrm_Load(object sender, EventArgs e)
        {
            uyeListele();
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from  uye where TC like '"+txtTC.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["AdSoyad"].ToString();
                txtYas.Text = read["Yaş"].ToString();
                cmbCinsiyet.Text = read["Cinsiyet"].ToString();
                txtTel.Text = read["Telefon"].ToString();
                txtAdres.Text = read["Adres"].ToString();
                txtEmail.Text = read["Email"].ToString();
            }
            baglanti.Close();
        }

        DataSet daset = new DataSet();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["uye"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select *from  uye where TC like'%"+textBox1.Text+"%'",baglanti);
            adtr.Fill(daset,"uye");
            dataGridView1.DataSource = daset.Tables["uye"];
            baglanti.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from uye where TC = @TC", baglanti);
                komut.Parameters.AddWithValue("@TC", dataGridView1.CurrentRow.Cells["TC"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi gerçekleşmiştir.");
                daset.Tables["uye"].Clear();
                uyeListele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = " ";
                    }
                }
            }
        }

        private void uyeListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from uye",baglanti);
            adtr.Fill(daset, "uye");
            dataGridView1.DataSource = daset.Tables["uye"];
            baglanti.Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update uye  set AdSoyad=@AdSoyad,Yaş=@Yaş,Cinsiyet=@Cinsiyet,Telefon=@Telefon,Adres=@Adres,Email=@Email where @TC = TC", baglanti);
            komut.Parameters.AddWithValue("@TC", txtTC.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@Yaş", txtYas.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTel.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@Email", txtEmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleştirildi.");
            daset.Tables["uye"].Clear();
            uyeListele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = " ";
                }
            }
        }
    }
}
