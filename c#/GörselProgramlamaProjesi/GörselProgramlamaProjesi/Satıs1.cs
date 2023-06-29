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

namespace GörselProgramlamaProjesi
{
    public partial class Satıs1 : Form
    {
        public Satıs1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9JD22EE\\anıl; Initial Catalog = SezginEmlakKonut; Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("Satışınızı üstlenmemiz için lütfen izin kutucuğunu işaretleyiniz!");
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_SezginEmlakKonut(IlanTürü,EmlakTürü,EşyaTürü,KatSayısı,EvinKonumu,OdaSayısı,BinaYaşı,DaireAlan,DaireKat,Fiyat,KiraCesidi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglanti);
            komut.Parameters.AddWithValue("@p1", CmbBoxIlan.Text);
            komut.Parameters.AddWithValue("@p2", CmbBoxEmlak.Text);
            komut.Parameters.AddWithValue("@p3", CmbBoxEsya.Text);
            komut.Parameters.AddWithValue("@p4", TxtBoxKatSayısı.Text);
            komut.Parameters.AddWithValue("@p5", CmbBoxEvKonum.Text);
            komut.Parameters.AddWithValue("@p6", CmbBoxOdaSayısı.Text);
            komut.Parameters.AddWithValue("@p7", TxtBoxBinaYas.Text);
            komut.Parameters.AddWithValue("@p8", TxtBoxAlan.Text);
            komut.Parameters.AddWithValue("@p9", TxtBoxDaireKat.Text);
            komut.Parameters.AddWithValue("@p10", TxtBoxFiyat.Text);
            komut.Parameters.AddWithValue("@p11", CmbBoxKiraCesid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satışınız işleme alınmıştır!");
        }
        void temizle1()
        {
            CmbBoxIlan.Text = "";
            CmbBoxEmlak.Text = "";
            CmbBoxEsya.Text = "";
            TxtBoxKatSayısı.Text = "";
            CmbBoxEvKonum.Text = "";
            CmbBoxOdaSayısı.Text = "";
            TxtBoxBinaYas.Text = "";
            TxtBoxAlan.Text = "";
            TxtBoxDaireKat.Text = "";
            TxtBoxFiyat.Text = "";
            CmbBoxKiraCesid.Text = "";

        }

        private void Satıs1_Load(object sender, EventArgs e)
        {
            
            this.tbl_SezginEmlakKonutTableAdapter.Fill(this.sezginEmlakKonutDataSet1.Tbl_SezginEmlakKonut);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            temizle1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tbl_SezginEmlakKonutTableAdapter.Fill(this.sezginEmlakKonutDataSet1.Tbl_SezginEmlakKonut);
        }
    }
}
