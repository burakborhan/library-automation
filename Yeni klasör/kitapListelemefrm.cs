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
    public partial class kitapListelemefrm : Form
    {
        public kitapListelemefrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-05G6QG0\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");

        DataSet daset = new DataSet();
        private void kitapListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kitap", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }

        private void kitapListelemefrm_Load(object sender, EventArgs e)
        {
            kitapListele();
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
                SqlCommand komut = new SqlCommand("delete from kitap where BarkodNo = @BarkodNo", baglanti);
                komut.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi gerçekleşmiştir.");
                daset.Tables["kitap"].Clear();
                kitapListele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = " ";
                    }
                }
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kitap  set Ad=@Ad,Yazar=@Yazar,Yayınevi=@Yayınevi,SayfaSayısı=@SayfaSayısı,Tür=@Tür,StokSayısı=@StokSayısı,RafNo=@RafNO,kayittarihi=@kayittarihi where @BarkodNo = BarkodNo", baglanti);
            komut.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@Ad", txtAd.Text);
            komut.Parameters.AddWithValue("@Yazar", txtYazar.Text);
            komut.Parameters.AddWithValue("@Tür", cmbTür.Text);
            komut.Parameters.AddWithValue("@SayfaSayısı", txtSayfaSayısı.Text);
            komut.Parameters.AddWithValue("@Yayınevi", txtYayınevi.Text);
            komut.Parameters.AddWithValue("@StokSayısı", txtStokSayısı.Text);
            komut.Parameters.AddWithValue("@RafNo", txtRafNo.Text);
            komut.Parameters.AddWithValue("@kayittarihi", DateTime.Now.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleştirildi.");
            daset.Tables["kitap"].Clear();
            kitapListele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = " ";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select *from  kitap where BarkodNo like'%" + textBox1.Text + "%'", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarkodNo.Text = dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from  kitap where BarkodNo like '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAd.Text = read["Ad"].ToString();
                txtYazar.Text = read["Yazar"].ToString();
                cmbTür.Text = read["Tür"].ToString();
                txtSayfaSayısı.Text = read["SayfaSayısı"].ToString();
                txtYayınevi.Text = read["Yayınevi"].ToString();
                txtStokSayısı.Text = read["StokSayısı"].ToString();
                txtRafNo.Text = read["RafNo"].ToString();

            }
            baglanti.Close();
        }
    }
}
