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
    public partial class emanetKitapİadefrm : Form
    {
        public emanetKitapİadefrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-05G6QG0\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();

        private void emanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar ", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
        }
        private void emanetKitapİadefrm_Load(object sender, EventArgs e)
        {
            emanetListele();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar where TC like '%" + txtTCAra.Text + "'", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            baglanti.Close();
            if (txtTCAra.Text == "")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                emanetListele();
            }
        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar where TC like '%" + txtBarkodNoAra.Text + "'", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            baglanti.Close();
            if (txtBarkodNoAra.Text == "")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                emanetListele();
            }
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from EmanetKitaplar where TC = @TC and BarkodNo = @BarkodNo", baglanti);
            komut.Parameters.AddWithValue("@TC", dataGridView1.CurrentRow.Cells["TC"].Value.ToString());
            komut.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update Kitap set StokSayısı=StokSayısı + '"+dataGridView1.CurrentRow.Cells["KitapSayısı"].Value.ToString()+"'where BarkodNo=@BarkodNo", baglanti);
            komut2.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap iadeniz gerçekleşmiştir.");
            daset.Tables["EmanetKitaplar"].Clear();
            emanetListele();

        }
    }
}
