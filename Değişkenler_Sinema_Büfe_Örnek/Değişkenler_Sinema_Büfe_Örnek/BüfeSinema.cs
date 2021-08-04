using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Değişkenler_Sinema_Büfe_Örnek
{
    public partial class BüfeSinema : Form
    {
        public BüfeSinema()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        int cıro = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay,toplam;
            misir = Convert.ToInt16(TxtMısır.Text);
            bilet = Convert.ToInt16(TxtBılet.Text);
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(TxtCay.Text);
            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            LblToplam.Text = toplam.ToString()+" TL ";
            cıro = cıro + toplam;
            LblCıro.Text = cıro.ToString() + " TL ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBılet.Text = "";
            TxtCay.Text = "";
            TxtMısır.Text = "";
            TxtSu.Text = "";
            LblToplam.Text = "00 TL";
            TxtMısır.Focus();
        }
    }
}
