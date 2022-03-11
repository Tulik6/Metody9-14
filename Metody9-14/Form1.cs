using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody9_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double x1, x2, d;
            Metody.KvadratickaRovnice(a, b, c, out x1, out x2, out d);
            if (d < 0) MessageBox.Show("Rovnice nema reseni v R");
            else if (d > 0) MessageBox.Show("Koren x1 je: " + x1 + " a koren x2 je: " + x2);
            else MessageBox.Show("Rovnice ma jedno dvojnasobne reseni " + x1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idk = textBox4.Text;
            int cifSoucet = 0, lichCifSoucet = 0, sudCifSoucet = 0;
            if (Metody.ObsahujeCislici(idk, out cifSoucet, out lichCifSoucet, out sudCifSoucet))
            {
                MessageBox.Show("Obsahuje číslici");
                MessageBox.Show("Ciferný součet je " + cifSoucet);
                MessageBox.Show("Ciferný součet lichých čísel je " + lichCifSoucet);
                MessageBox.Show("Ciferný součet sudých čísel je " + sudCifSoucet);
            }
            else MessageBox.Show("Neobsahuje cifry");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string retezec = textBox5.Text;
            string upravenyRetezec = " ";
            MessageBox.Show("Počet slov je " + Metody.PocetSlov1(retezec, out upravenyRetezec));
            MessageBox.Show("Po odstranění číslic: " + upravenyRetezec);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string retezec = textBox6.Text;
            string nejdelsiSlovo = "";
            string nejkratsiSlovo = "";
            if (Metody.ObsahujeSlovo(retezec, out nejdelsiSlovo, out nejkratsiSlovo))
            {
                MessageBox.Show("Obsahuje slovo, nejdelší slovo je " + nejdelsiSlovo + ", nejkratší slovo je " + nejkratsiSlovo);
            }
            else MessageBox.Show("Neobsahuje slovo");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string retezec = textBox7.Text;
            int pocetMalych = 0;
            int pocetVelkych = 0;
            int pocetJinych = 0;
            if (Metody.JeAlfanum(retezec, out pocetMalych, out pocetVelkych, out pocetJinych))
            {
                MessageBox.Show("Je alfanumerický");
                MessageBox.Show("Počet malých písmen je: " + pocetMalych);
                MessageBox.Show("Počet velkých písmen je: " + pocetVelkych);
                MessageBox.Show("Počet jiných znaků je: " + pocetJinych);
            }
            else
            {
                MessageBox.Show("Není alfanumerický");
                MessageBox.Show("Počet malých písmen je: " + pocetMalych);
                MessageBox.Show("Počet velkých písmen je: " + pocetVelkych);
                MessageBox.Show("Počet jiných znaků je: " + pocetJinych);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s1 = textBox8.Text;
            string s2 = textBox9.Text;
            int pocetOdlisnosti = 0;
            int indexOdlisnosti = -1;

            if (Metody.Identicke(s1, s2, out pocetOdlisnosti, out indexOdlisnosti))
            {
                MessageBox.Show("Jsou identické");
            }
            else MessageBox.Show("Nejsou identické, počet odlišností je " + pocetOdlisnosti + ", index první odlišnosti je " + indexOdlisnosti);
        }
    }
}
