using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tutar = Convert.ToInt32(textBox1.Text);
            double sonuc = 0;

            String doviz1 = dvz1.SelectedItem.ToString();
            String doviz2 = dvz2.SelectedItem.ToString();
            if (doviz1 == "TL")
            {
                switch (doviz2)
                {
                    case "TL":
                        sonuc = tutar * 1;
                        break;
                    case "$":
                        sonuc = tutar * 0.020;
                        break;
                    case "€":
                        sonuc = tutar * 0.018;
                        break;
                    case "GND":
                        sonuc = tutar * 0.015;
                        break;
                }
            }

            else if (doviz1 == "$")
            {
                switch (doviz2)
                {
                    case "TL":
                        sonuc = tutar * 49;
                        break;
                    case "$":
                        sonuc = tutar * 1;
                        break;
                    case "€":
                        sonuc = tutar * 0.89;
                        break;
                    case "GND":
                        sonuc = tutar * 0.76;
                        break;
                }
            }

            else if (doviz1 == "€")
            {
                switch (doviz2)
                {
                    case "TL":
                        sonuc = tutar * 55.24;
                        break;
                    case "$":
                        sonuc = tutar * 1.12;
                        break;
                    case "€":
                        sonuc = tutar * 1;
                        break;
                    case "GND":
                        sonuc = tutar * 0.85;
                        break;
                }
            }

            else if (doviz1 == "GND")
            {
                switch (doviz2)
                {
                    case "TL":
                        sonuc = tutar * 65.16;
                        break;
                    case "$":
                        sonuc = tutar * 1.32;
                        break;
                    case "€":
                        sonuc = tutar * 1.18;
                        break;
                    case "GND":
                        sonuc = tutar * 1;
                        break;
                }
            }
            textBox2.Text = Convert.ToInt32(sonuc).ToString();
        }

        private void dvz1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int gun = (int) dateTimePicker1.Value.DayOfWeek;
            switch (gun)
            {
                case 1:
                    MessageBox.Show("Pazartesi", "Bildirim", MessageBoxButtons.OK);
                    break;
                case 2:
                    MessageBox.Show("Salı", "Bildirim", MessageBoxButtons.OK);
                    break;
                case 3:
                    MessageBox.Show("Çarşamba", "Bildirim", MessageBoxButtons.OK);
                    break;
                case 4:
                    MessageBox.Show("Perşembe", "Bildirim", MessageBoxButtons.OK);
                    break;
                case 5:
                    MessageBox.Show("Cuma", "Bildirim", MessageBoxButtons.OK);
                    break;
                case 6:
                    MessageBox.Show("Cumartesi", "Bildirim", MessageBoxButtons.OK);
                    break;
                case 7:
                    MessageBox.Show("Pazar", "Bildirim", MessageBoxButtons.OK);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dvz1.SelectedIndex = 1;
            dvz2.SelectedIndex = 0;
            lblSes.Text = "Ses yok";

            for (int i = 1; i <= 12; i++)
            {
                cmbSinif.Items.Add(i);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int ses = trackBar1.Value;
            if (ses == 0)
            {
                lblSes.Text = "Ses yok";
                lblSes.ForeColor = Color.Black;
            }
            else if (ses > 0 && ses <=5)
            {
                lblSes.Text = "Düşük ses seviyesi";
                lblSes.ForeColor = Color.Green;
            }
            else if (ses > 5)
            {
                lblSes.Text = "Yüksek ses seviyesi";
                lblSes.ForeColor = Color.Red;
            }
        }

        private void cmbSinif_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sinif = (int)cmbSinif.SelectedItem;
            if( sinif > 0 && sinif <= 4)
            {
                lblSinif.Text = "İlkokul";
            }
            else if (sinif > 4 && sinif <= 8)
            {
                lblSinif.Text = "Ortaokul";
            }
            else
            {
                lblSinif.Text = "Lise";
            }
        }
    }
}
