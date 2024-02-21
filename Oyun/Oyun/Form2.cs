using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyun
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int hız = 30;
        int hız1 = 20;
        int saniye = 0;



        private void Form2_Load(object sender, EventArgs e)
        {
           
            baslatma();
            


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            hareket();
            oyunbitisi();
            dusmantemas();
            dusmanhareket();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            dusman1.Left -= hız;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            dusman1.Left += hız;
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            dusman2.Left -= hız1;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            dusman2.Left += hız1;
        }
        private void timer6_Tick(object sender, EventArgs e)
        {
            sure();
        }
        public void baslatma()
        {
            Cursor.Hide();
            timer1.Start();
            timer2.Start();
            timer5.Start();
            timer6.Start();
            saniye = 26;
            Cursor.Position = new Point(31, 24);
            dusman1.Location = new Point(731, 197);
            dusman2.Location = new Point(446, 379);
        }

        public void durdurma()
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            Cursor.Show();
        }

        public void hareket()
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            pictureBox1.Location = new Point(X, Y);
            yandın();
        }
         
        public void sure()
        {
            timer6.Interval = 1000;
            saniye--;
            label2.Text = "Kalan Süre:" + " " + saniye.ToString() + " " + "Saniye";

            if (saniye == 0)
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "SÜRENİZ DOLDU", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                   baslatma();
                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
        public void dusmanhareket()
        {
            if (dusman1.Bounds.IntersectsWith(sınır.Bounds))
            {
                timer2.Stop();
                timer3.Start();
            }
            else if (dusman1.Bounds.IntersectsWith(sınır1.Bounds))
            {
                timer3.Stop();
                timer2.Start();
            }

            if (dusman2.Bounds.IntersectsWith(sınır3.Bounds))
            {
                timer5.Stop();
                timer4.Start();
            }
            else if (dusman2.Bounds.IntersectsWith(sınır2.Bounds))
            {
                timer4.Stop();
                timer5.Start();
            }


        }
        public void dusmantemas()
        {


            if (pictureBox1.Bounds.IntersectsWith(dusman1.Bounds))
            {
                bolumsonu.Visible = true;
                durdurma();
                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUSMANA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    bolumsonu.Visible = false;
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }
            }

            if (pictureBox1.Bounds.IntersectsWith(dusman2.Bounds))
            {
                bolumsonu.Visible = true;
                durdurma();
                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUSMANA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    bolumsonu.Visible = false;
                    baslatma();


                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }
            }
            if (pictureBox1.Bounds.IntersectsWith(dusman3.Bounds))
            {
                bolumsonu.Visible = true;
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUSMANA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    bolumsonu.Visible = false;
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }
            }
                if (pictureBox1.Bounds.IntersectsWith(dusman4.Bounds))
                {
                bolumsonu.Visible = true;
                durdurma();
                    DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUSMANA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (secenek == DialogResult.Yes)
                    {
                    bolumsonu.Visible = false;
                    baslatma();

                    }
                    else if (secenek == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }
        
        public void oyunbitisi()
        {
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                oyunsonu.Visible = true;
                durdurma();                
                DialogResult secenek = MessageBox.Show("TEKRAR OYNAMAK İSTER MİSİN?", "TEBRİKLER OYUNU BİTİRDİNİZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    oyunsonu.Visible = false;
                    Bolum1 bolum = new Bolum1();
                    bolum.Show();
                    this.Hide();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        public void yandın()
        {
            if (pictureBox1.Bounds.IntersectsWith(duvar1.Bounds))
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    baslatma();


                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }

            }
            else if (pictureBox1.Bounds.IntersectsWith(duvar2.Bounds))
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }
            }
            else if (pictureBox1.Bounds.IntersectsWith(duvar3.Bounds))
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }

            }
            else if (pictureBox1.Bounds.IntersectsWith(duvar4.Bounds))
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }

            }
           

            
            else if (pictureBox1.Bounds.IntersectsWith(duvar6.Bounds))
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }

            }
        
 

            
            else if (pictureBox1.Bounds.IntersectsWith(duvar8.Bounds))
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }

            }
            else if (pictureBox1.Bounds.IntersectsWith(duvar18.Bounds))
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }

            }

            else if (pictureBox1.Bounds.IntersectsWith(duvar9.Bounds))
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }

            }

            else if (pictureBox1.Bounds.IntersectsWith(duvar10.Bounds))
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }

            }
            else if (pictureBox1.Bounds.IntersectsWith(duvar11.Bounds))
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }

            }
            else if (pictureBox1.Bounds.IntersectsWith(duvar12.Bounds))
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }
            }
            else if (pictureBox1.Bounds.IntersectsWith(duvar19.Bounds))
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }

            }
            else if (pictureBox1.Bounds.IntersectsWith(duvar13.Bounds))
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }

            }
            else if (pictureBox1.Bounds.IntersectsWith(duvar14.Bounds))
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }

            }

            else if (pictureBox1.Bounds.IntersectsWith(duvar16.Bounds))
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }
            }
            else if (pictureBox1.Bounds.IntersectsWith(duvar20.Bounds))
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK İSTER MİSİN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

       
    }
}
