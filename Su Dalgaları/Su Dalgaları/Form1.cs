using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Su_Dalgaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int per, boy, hiz;

        void Duzenle()
        {
            int sayac = 0;
            foreach (var i in this.Controls)
            {
                if (i is Panel)
                {
                    Panel pnl = (Panel)i;
                    foreach (var item in pnl.Controls)
                    {
                        if (item is Label)
                        {
                            Label lbl = (Label)item;
                            if (lbl.Name.StartsWith("lbl"))
                            {
                                lbl.Location = new Point(16 * sayac, lbl.Location.Y);
                                sayac++;
                            }
                        }
                    }
                }
            }
        }

        void Gizle(int artac)
        {
            int sabit = artac;
            foreach (var i in this.Controls)
            {
                if (i is Panel)
                {
                    Panel pnl = (Panel)i;
                    foreach (var item in pnl.Controls)
                    {
                        if (item is Label)
                        {
                            Label lbl = (Label)item;
                            if (lbl.Name.StartsWith("lbl") && artac == 0)
                            {
                                lbl.Visible = false;
                                artac = sabit;
                            }
                            else artac--;
                        }
                    }
                }
            }
        }

        private void NumBoy_ValueChanged(object sender, EventArgs e)
        {
            Duzenle();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Aç")
            {
                timer1.Enabled = true;
                button1.Text = "Kapat";
                Labellar(false);
            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "Aç";
                Labellar(true);
            }
        }

        private void NumPer_ValueChanged(object sender, EventArgs e)
        {
            lblFrekans.Text = (1 / numPer.Value).ToString();
            Duzenle();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            boy = Convert.ToInt32(numBoy.Value);
            per = Convert.ToInt32(numPer.Value);
            hiz = boy * per;
            foreach (var i in this.Controls)
            {
                if (i is Panel)
                {
                    Panel pnl = (Panel)i;
                    foreach (var item in pnl.Controls)
                    {
                        if (item is Label)
                        {
                            Label lbl = (Label)item;
                            if (lbl.Name.StartsWith("lbl"))
                            {
                                lbl.Location = new Point(lbl.Location.X + (hiz * 16), lbl.Location.Y);
                                if (lbl.Location.X >= 560)
                                {
                                    lbl.Location = new Point(0, lbl.Location.Y);
                                }
                            }
                        }
                    }
                }
            }
            lblhiz.Text = hiz.ToString();
            switch (boy)
            {
                case 1:
                    Labellar(false);
                    //pass
                    break;
                case 2:
                    Labellar(false);
                    Gizle(2);
                    break;
                case 3:
                    Labellar(false);
                    Gizle(3); break;
                case 4:
                    Labellar(false);
                    Gizle(4); break;

            }
        }

        void Labellar(bool gizle)
        {
            if (gizle)
            {
                foreach (var i in this.Controls)
                {
                    if (i is Panel)
                    {
                        Panel pnl = (Panel)i;
                        foreach (var item in pnl.Controls)
                        {
                            if (item is Label)
                            {
                                Label lbl = (Label)item;
                                if (lbl.Name.StartsWith("lbl"))
                                {
                                    lbl.Visible = false;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var i in this.Controls)
                {
                    if (i is Panel)
                    {
                        Panel pnl = (Panel)i;
                        foreach (var item in pnl.Controls)
                        {
                            if (item is Label)
                            {
                                Label lbl = (Label)item;
                                if (lbl.Name.StartsWith("lbl"))
                                {
                                    lbl.Show();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1;i < 37; i++)
            {
                Label lbl = new Label();
                lbl.Name = "lbl" + i;
                lbl.Width = 10;
                lbl.Height = 336;
                lbl.Location = new Point(16 * i, 0);
                switch (i % 6)
                {
                    case 1:
                        lbl.BackColor = Color.Black; break;
                    case 2:
                        lbl.BackColor = Color.DimGray; break;
                    case 3:
                        lbl.BackColor = Color.Gray; break;
                    case 4:
                        lbl.BackColor = Color.DarkGray; break;
                    case 5:
                        lbl.BackColor = Color.Silver; break;
                    case 6:
                        lbl.BackColor = Color.LightGray; break;
                }
                panel2.Controls.Add(lbl);
            }
            Duzenle();

            Labellar(true);
        }
    }
}
