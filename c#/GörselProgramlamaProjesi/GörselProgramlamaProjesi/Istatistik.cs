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
    public partial class Istatistik : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9JD22EE\\anıl; Initial Catalog = SezginEmlakKonut; Integrated Security = True");

        public Istatistik()
        {
            InitializeComponent();
        }

        private void Istatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutSatılık = new SqlCommand("Select Count(*) From Tbl_SezginEmlakKonut where IlanTürü='SATILIK'", baglanti);
            SqlDataReader s1 = komutSatılık.ExecuteReader();
            while (s1.Read())
            {
                label3.Text = s1[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutKiralık = new SqlCommand("Select Count(*) From Tbl_SezginEmlakKonut where IlanTürü='KİRALIK'", baglanti);
            SqlDataReader k1 = komutKiralık.ExecuteReader();
            while (k1.Read())
            {
                label2.Text = k1[0].ToString();
            }
            baglanti.Close();
        }
    }
}
