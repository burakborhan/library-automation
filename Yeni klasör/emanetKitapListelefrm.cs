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
    public partial class emanetKitapListelefrm : Form
    {
        public emanetKitapListelefrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-05G6QG0\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");

        DataSet daset = new DataSet();

        private void emanetKitapListelefrm_Load(object sender, EventArgs e)
        {
            emanetListele();
            comboBox1.SelectedIndex = 0;
        }

        private void emanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar ", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                emanetListele();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar where '" + DateTime.Now.ToShortDateString() + "'> İadeTarihi", baglanti);
                adtr.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar where '" + DateTime.Now.ToShortDateString() + "'<= İadeTarihi", baglanti);
                adtr.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                baglanti.Close();
            }
        }
    }
}
