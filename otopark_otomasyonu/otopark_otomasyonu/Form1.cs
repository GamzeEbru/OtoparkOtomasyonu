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
namespace otopark_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public SqlConnection bag = new SqlConnection("Data Source=DESKTOP-0QML4U0;Initial Catalog=otopark;Integrated Security=True");
        public SqlCommand kmt = new SqlCommand();
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public DataSet dtst = new DataSet();
        public static string musteritc = null;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from musteri where TcKimlik='" + textBox1.Text + "' and sifre ='" + textBox2.Text + "'", bag);
            
            bag.Open();//bağlantıyı açık

            SqlDataReader oku = komut.ExecuteReader();//veriyi okutma emrini verdik
            if (oku.Read())//kullanıcı veritabanında kayıtlıysa
            {
                musteritc = textBox1.Text;
                MessageBox.Show("Giriş Başarılı !");//giriş başarılı 
                bag.Close();//bağlantıyı kapalı
                musteri menu = new musteri();//yeni menü
                menu.Show();//menü açar
                this.Hide();//sayfayı gizler

            }
            else
            {
                bag.Close();//bağlantıyı kapalı
                MessageBox.Show("Kullanıcı Adınız Yada Şifreniz Yanlış Yazılmıştır");//hayır veri okuyamadıysa uyarı verir
                textBox1.Text = "";
                textBox2.Text = "";
                
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifremi_unuttum unuttum = new sifremi_unuttum();
            unuttum.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from personel where tc='" + textBox3.Text + "' and sifre ='" + textBox4.Text + "'", bag);
         
            bag.Open();

            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
        
                MessageBox.Show("Giriş Başarılı !");
                bag.Close();//bağlantıyı kapalı
                personel menu = new personel();
                menu.Show();
                this.Hide();////mevcut sayfayı gizler

            }
            else
            {
                bag.Close();
                MessageBox.Show("Kullanıcı Adınız Yada Şifreniz Yanlış Yazılmıştır");
                textBox3.Text = "";
                textBox4.Text = "";
              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("select * from admin where k_adi='" + textBox5.Text + "' and sifre ='" + textBox6.Text + "'", bag);
           
            bag.Open();

            SqlDataReader oku = komut.ExecuteReader();//veriyi okutma emrini verdik
            if (oku.Read())
            {

                MessageBox.Show("Giriş Başarılı !");
                bag.Close();
                teknik_servis menu = new teknik_servis();
                menu.Show();
                this.Hide();

            }
            else
            {
                bag.Close();
                MessageBox.Show("Kullanıcı Adınız Yada Şifreniz Yanlış Yazılmıştır");
                textBox5.Text = "";
                textBox6.Text = "";
        
            }
        }
    }
}
