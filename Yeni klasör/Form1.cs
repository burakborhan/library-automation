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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            emanetKitapListelefrm emanetkitaplistele = new emanetKitapListelefrm();
            emanetkitaplistele.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEklefrm üyeEkle = new UyeEklefrm();
            üyeEkle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeListelefrm üyeListele = new UyeListelefrm();
            üyeListele.ShowDialog();
        }

        private void kitapEklemeIslemleri_Click(object sender, EventArgs e)
        {
            KitapEkle kitapekle = new KitapEkle();
            kitapekle.ShowDialog();
        }

        private void kitapListelemeIslemleri_Click(object sender, EventArgs e)
        {
            kitapListelemefrm kitaplistele = new kitapListelemefrm();
            kitaplistele.ShowDialog();
        }

        private void btnEKVermeIslemleri_Click(object sender, EventArgs e)
        {
            emanetKitapVerfrm emanetkitapver = new emanetKitapVerfrm();
            emanetkitapver.ShowDialog();
        }

        private void btnEKIIslemleri_Click(object sender, EventArgs e)
        {
            emanetKitapİadefrm kitapiade = new emanetKitapİadefrm();
            kitapiade.ShowDialog();
        }
    }
}
