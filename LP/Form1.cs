using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double Niso, Tatm, H, Cpt, Cdout, Ch, dPgate, dPout, N, Effiso, Eff, Ceff, CdgateKPD, CdoutKPD, Giso, Gdgate, Gt, Gexh, dCtgate, dCtout, Texh;
            Niso = Convert.ToDouble(textBox1.Text); // Мощность ISO
            Effiso = Convert.ToDouble(textBox2.Text); //КПД ISO
            dPgate = Convert.ToDouble(textBox3.Text);//Давление на входе
            dPout = Convert.ToDouble(textBox4.Text);//Давление на выходе
            Tatm = Convert.ToDouble(textBox5.Text); // Температура наружного воздуха
            H = Convert.ToDouble(textBox6.Text); // Высота над уровнем моря


            //y = 3E-11x6 + 2E-10x5 - 1E-07x4 + 2E-06x3 + 7E-06x2 - 0,0062x + 1,0834
            Cpt = 3E-11 * Math.Pow(Tatm, 6) + 2E-10 * Math.Pow(Tatm, 5) - 1E-07 * Math.Pow(Tatm, 4) + 2E-06 * Math.Pow(Tatm, 3) + 7E-06 * Math.Pow(Tatm, 2) - 0.0062 * Tatm + 1.0834;

            //y = 8E-12x6 + 1E-09x5 - 1E-08x4 - 4E-06x3 + 2E-05x2 - 0,0012x - 0,5217
            Cdout = 8E-12 * Math.Pow(Tatm, 6) + 1E-09 * Math.Pow(Tatm, 5) - 1E-08 * Math.Pow(Tatm, 4) + 4E-06 * Math.Pow(Tatm, 3) + 2E-05 * Math.Pow(Tatm, 2) - 0.0012 * Tatm - 0.5217;

            Ch = 1 - 0.000116 * H;

            //y = 3E-11x6 + 2E-09x5 - 1E-07x4 - 8E-08x3 + 3E-05x2 - 0,0059x + 1,0848
            Ceff = 3E-11 * Math.Pow(Tatm, 6) + 2E-09 * Math.Pow(Tatm, 5) - 1E-07 * Math.Pow(Tatm, 4) + 8E-08 * Math.Pow(Tatm, 3) + 3E-05 * Math.Pow(Tatm, 2) - 0.0059 * Tatm + 1.0848;

            //y = 3E-11x6 - 5E-10x5 - 8E-08x4 + 2E-06x3 + 3E-05x2 + 0,0025x + 0,5488 
            CdgateKPD = 3E-11 * Math.Pow(Tatm, 6) - 5E-10 * Math.Pow(Tatm, 5) - 8E-08 * Math.Pow(Tatm, 4) + 2E-06 * Math.Pow(Tatm, 3) + 3E-05 * Math.Pow(Tatm, 2) + 0.0025 * Tatm + 0.05488;

            //y = -4E-12x6 - 1E-09x5 - 2E-09x4 + 4E-06x3 - 9E-06x2 + 0,0011x + 0,5268
            CdoutKPD = -4E-12 * Math.Pow(Tatm, 6) - 1E-09 * Math.Pow(Tatm, 5) - 2E-09 * Math.Pow(Tatm, 4) + 4E-06 * Math.Pow(Tatm, 3) - 9E-06 * Math.Pow(Tatm, 2) + 0.0011 * Tatm + 0.5268;

            //y = 4E-10x6 - 7E-09x5 - 2E-06x4 + 6E-05x3 - 0,0028x2 - 0,3253x + 106,06
            Giso = -4E-10 * Math.Pow(Tatm, 6) - 7E-09 * Math.Pow(Tatm, 5) - 2E-06 * Math.Pow(Tatm, 4) + 6E-05 * Math.Pow(Tatm, 3) - 0.0028 * Math.Pow(Tatm, 2) - 0.3253 * Tatm + 106.06;

            //y = 2E-12x6 + 2E-08x5 + 3E-07x4 - 8E-05x3 + 1E-05x2 - 0,0985x + 45,724
            Gt = 2E-12 * Math.Pow(Tatm, 6) + 2E-08 * Math.Pow(Tatm, 5) + 3E-07 * Math.Pow(Tatm, 4) - 8E-05 * Math.Pow(Tatm, 3) + 1E-05 * Math.Pow(Tatm, 2) - 0.0985 * Tatm + 45.724;

            //y = 3E-10x6 - 2E-08x5 - 3E-07x4 + 3E-05x3 + 0,0002x2 - 0,0026x + 1,3744
            dCtgate = 3E-10 * Math.Pow(Tatm, 6) - 2E-08 * Math.Pow(Tatm, 5) - 3E-07 * Math.Pow(Tatm, 4) + 3E-05 * Math.Pow(Tatm, 3) + 0.0002 * Math.Pow(Tatm, 2) - 0.0026 * Tatm + 1.3744;

            //y = -3E-11x6 + 5E-09x5 - 2E-07x4 - 2E-06x3 + 0,0004x2 + 0,002x + 1,3969
            dCtout = -3E-11 * Math.Pow(Tatm, 6) + 5E-09 * Math.Pow(Tatm, 5) - 2E-07 * Math.Pow(Tatm, 4) - 2E-06 * Math.Pow(Tatm, 3) + 0.0004 * Math.Pow(Tatm, 2) - 0.002 * Tatm + 1.3969;

            N = Niso * Cpt * (1 + (dPgate / 100) * (Cdout / 100)) * (1 + (dPout / 100) * (Cdout / 100)) * Ch;
            Eff = Effiso * Ceff * (1 + (dPgate / 100) * (CdgateKPD / 100)) * (1 + (dPout / 100) * (CdoutKPD / 100));
            Gdgate = (1 - 0.95 / 100) * (dPgate / 98.1);
            Gexh = (Giso * Gt * Gdgate * Ch) / 100;
            Texh = (Cpt + dCtgate + dCtout) * 100;

            this.textBox7.Text = Convert.ToString(string.Format("{0:F3}", N));
            this.textBox8.Text = Convert.ToString(string.Format("{0:F3}", Eff));
            this.textBox9.Text = Convert.ToString(string.Format("{0:F3}", Gexh));
            this.textBox10.Text = Convert.ToString(string.Format("{0:F3}", Texh));
        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
