using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_3
{
    public partial class LaskinFM : Form
    {
        public LaskinFM()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float luku1, luku2, vastaus;
            string merkki;
            luku1 = float.Parse(LukuYksiTB.Text); // 1+1=11
            luku2 = float.Parse(LukuKaksiTB.Text);
            merkki = LaskutoimitusCB.Text;
            switch(merkki)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus = luku1 - luku2;
                    break;
                case "*":
                    vastaus = luku1 / luku2;
                    break;
                default:
                    vastaus = 0;
                    break;
            }
            VastausLB.Text = Convert.ToString(vastaus);
            VastausLB.Visible = true;
    }

        private void LaskutoimitusCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
