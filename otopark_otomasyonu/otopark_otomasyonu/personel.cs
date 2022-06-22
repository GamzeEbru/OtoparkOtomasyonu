using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otopark_otomasyonu
{
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arac_cikis cikis = new arac_cikis();
            cikis.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            arac_konumlari konum = new arac_konumlari();
            konum.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arac_giris giris = new arac_giris();
            giris.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musteri_islemleri must = new musteri_islemleri();
            must.Show();
            this.Hide();
        }
    }
}
