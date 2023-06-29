using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GörselProgramlamaProjesi
{
    public partial class Ekran1 : Form
    {
        public Ekran1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Satıs1 sts1 = new Satıs1();
            sts1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alıs1 als1 = new Alıs1();
            als1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Istatistik ıst = new Istatistik();
            ıst.Show();
        }
    }
}
