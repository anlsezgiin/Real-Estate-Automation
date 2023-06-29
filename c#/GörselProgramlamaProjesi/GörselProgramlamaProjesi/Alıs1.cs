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
    public partial class Alıs1 : Form
    {
        public Alıs1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9JD22EE\\anıl; Initial Catalog = SezginEmlakKonut; Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("Lütfen hesabınıza erişme izni için kutucuğu işaretleyiniz!");
            }
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_SezginEmlakKonut Where IlanNo=@p1", baglanti);
            komutsil.Parameters.AddWithValue("@p1", TxtBoxIlan.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satın alım isteğiniz işleme alınmıştır, şimdiden hayırlı olsun!");
        }

        private void Alıs1_Load(object sender, EventArgs e)
        {
            
            this.tbl_SezginEmlakKonutTableAdapter.Fill(this.sezginEmlakKonutDataSet2.Tbl_SezginEmlakKonut);

        }

        void temizle2()
        {
            TxtBoxIlan.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temizle2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tbl_SezginEmlakKonutTableAdapter.Fill(this.sezginEmlakKonutDataSet2.Tbl_SezginEmlakKonut);
        }
    }
}
