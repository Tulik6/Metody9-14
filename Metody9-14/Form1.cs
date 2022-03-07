﻿using System;
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
    }
}
