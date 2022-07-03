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
    public partial class emanetKitapVerfrm : Form
    {
        public emanetKitapVerfrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-05G6QG0\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");

        DataSet daset = new DataSet();
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mevcutListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from mevcut",baglanti);
            adtr.Fill(daset, "mevcut");
            dataGridView1.DataSource = daset.Tables["mevcut"];
            baglanti.Close();
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (lblKitapSayısı.Text != "")
            {
                if (lblKayıtlıKitapS.Text == "" && int.Parse(lblKitapSayısı.Text) <= 3 || lblKayıtlıKitapS.Text != "" && int.Parse(lblKitapSayısı.Text)+int.Parse(lblKayıtlıKitapS.Text) <= 3) 
                {
                    if (txtTCAra.Text != "" && txtAdSoyad.Text != "" && txtYaş.Text !="" && txtTel.Text != "")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                        {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("insert into emanetkitaplar(TC,AdSoyad,Yaş,Telefon,BarkodNo,KitapAdı,Yazar,Yayınevi,SayfaSayısı,KitapSayısı,TeslimTarihi,İadeTarihi) values(@TC,@AdSoyad,@Yaş,@Telefon,@BarkodNo,@KitapAdı,@Yazar,@Yayınevi,@SayfaSayısı,@KitapSayısı,@TeslimTarihi,@İadeTarihi)", baglanti);
                            komut.Parameters.AddWithValue("@TC", txtTCAra.Text);
                            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                            komut.Parameters.AddWithValue("@Yaş", txtYaş.Text);
                            komut.Parameters.AddWithValue("@Telefon", txtTel.Text);
                            komut.Parameters.AddWithValue("@BarkodNo", dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString());
                            komut.Parameters.AddWithValue("@KitapAdı", dataGridView1.Rows[i].Cells["KitapAdı"].Value.ToString());
                            komut.Parameters.AddWithValue("@Yazar", dataGridView1.Rows[i].Cells["Yazar"].Value.ToString());
                            komut.Parameters.AddWithValue("@Yayınevi", dataGridView1.Rows[i].Cells["Yayınevi"].Value.ToString());
                            komut.Parameters.AddWithValue("@SayfaSayısı", dataGridView1.Rows[i].Cells["SayfaSayısı"].Value.ToString());
                            komut.Parameters.AddWithValue("@KitapSayısı", int.Parse(dataGridView1.Rows[i].Cells["KitapSayısı"].Value.ToString()));
                            komut.Parameters.AddWithValue("@TeslimTarihi", dataGridView1.Rows[i].Cells["TeslimTarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("@İadeTarihi", dataGridView1.Rows[i].Cells["İadeTarihi"].Value.ToString());
                            komut.ExecuteNonQuery();
                            SqlCommand komut2 = new SqlCommand("update kitap set StokSayısı = StokSayısı -'"+int.Parse(dataGridView1.Rows[i].Cells["kitapSayısı"].Value.ToString())+"'where BarkodNo='"+dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString()+"'", baglanti);
                            komut2.ExecuteNonQuery();
                            baglanti.Close();
                        }

                        baglanti.Open();
                        SqlCommand komut3 = new SqlCommand("delete from mevcut", baglanti);
                        komut3.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kitap(lar) emanet edildi.");
                        daset.Tables["mevcut"].Clear();
                        mevcutListele();
                        txtTCAra.Text = "";

                        lblKitapSayısı.Text = "";
                        kitapSayısı();
                        lblKayıtlıKitapS.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Önce üye bilgilerini doldurmanız gerekir!","Uyarı");
                    }
                }
                else
                {
                    MessageBox.Show("Emanet kitap sayısı 3'ten fazla olamaz!", "Uyarı");
                }
                
            }
            else
            {
                MessageBox.Show("Önce sepete kitap eklenmelidir!","Uyarı");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into mevcut(BarkodNo,KitapAdı,Yazar,Yayınevi,SayfaSayısı,KitapSayısı,TeslimTarihi,İadeTarihi) values (@BarkodNo,@KitapAdı,@Yazar,@Yayınevi,@SayfaSayısı,@KitapSayısı,@TeslimTarihi,@İadeTarihi)", baglanti);
            komut.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@KitapAdı", txtKitapAdı.Text);
            komut.Parameters.AddWithValue("@Yazar", txtYazarı.Text);
            komut.Parameters.AddWithValue("@Yayınevi", txtYayınevi.Text);
            komut.Parameters.AddWithValue("@KitapSayısı", int.Parse(txtKitapSayısı.Text));
            komut.Parameters.AddWithValue("@SayfaSayısı", txtSayfaSayısı.Text);
            komut.Parameters.AddWithValue("@TeslimTarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@İadeTarihi", dateTimePicker2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap(lar) sepete eklendi.");
            daset.Tables["mevcut"].Clear();
            mevcutListele();
            lblKitapSayısı.Text = "";
            kitapSayısı();
            foreach (Control item in grpKitapBilgi.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtKitapSayısı)
                    {
                        item.Text = " ";
                    }
                }
            }
        }

        private void kitapSayısı()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(KitapSayısı) from mevcut ",baglanti);
            lblKitapSayısı.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }

        private void emanetKitapVerfrm_Load(object sender, EventArgs e)
        {
            mevcutListele();
        }

        private void txtTCAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from uye where TC like'"+txtTCAra.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                txtAdSoyad.Text = read["AdSoyad"].ToString();
                txtYaş.Text = read["Yaş"].ToString();
                txtTel.Text = read["Telefon"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(KitapSayısı) from emanetkitaplar where TC='"+txtTCAra.Text+"'",baglanti);
            lblKayıtlıKitapS.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();

            if (txtTCAra.Text == "")
            {
                foreach (Control item in grupUyeBilgi.Controls)
                {
                    if (item is TextBox)
                    {
                    item.Text = "";
                    
                    }

                }
                lblKayıtlıKitapS.Text = "";
            }
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {

            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("select *from kitap where BarkodNo like'"+txtBarkodNo.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            

            
            while (read.Read())
            {
                txtKitapAdı.Text = read["Ad"].ToString();
                txtYazarı.Text = read["Yazar"].ToString();
                txtYayınevi.Text = read["Yayınevi"].ToString();
                txtSayfaSayısı.Text = read["SayfaSayısı"].ToString();                
            }
            baglanti.Close();
                  

            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in grpKitapBilgi.Controls)
                { 
                    if (item is TextBox)
                    {
                        if (item != txtKitapSayısı)
                        {
                            item.Text = "";
                        }
                    }
                }
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Kayıt silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialog==DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Mevcut where BarkodNo like '"+dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString()+"'",baglanti);            
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi gerçekleştirildi.");
                daset.Tables["mevcut"].Clear();
                mevcutListele();
                lblKitapSayısı.Text = "";
                kitapSayısı();
            }
        }

        private void lblKayıtlıKitapS_Click(object sender, EventArgs e)
        {

        }
    }
}
