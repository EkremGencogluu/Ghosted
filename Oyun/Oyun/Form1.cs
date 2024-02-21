using Microsoft.VisualBasic;
using System.Reflection.Emit;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace Oyun
{
    public partial class Bolum1 : Form
    {
        public Bolum1()
        {
            InitializeComponent();
           
        }
        int saniye = 0;
        private void Bolum1_Load(object sender, EventArgs e)
        {

            
            baslatma();
            Cursor.Position = pictureBox1.Location;
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hareket(); 
            yenibolum();
           
          
        }
        public void baslatma()
        {
            timer1.Start();
            timer2.Start();
            saniye = 21;
            Cursor.Hide();
            Cursor.Position = new Point(31, 24);
            

        }

        public void durdurma()
        {
            
            timer1.Stop();
            timer2.Stop();
            Cursor.Show();


        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            sure();
        }

        public void hareket()
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            pictureBox1.Location = new Point(X, Y);
            yandýn();





        }
        public void sure()
        {
            timer2.Interval = 1000;
            saniye--;
            label3.Text ="Kalan Süre:"+" "+saniye.ToString()+" "+"Saniye";

            if (saniye == 0)
            {
                durdurma();

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK ÝSTER MÝSÝN?", "SÜRENÝZ DOLDU", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
        public void yenibolum()
        {
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                
                durdurma();

                DialogResult secenek = MessageBox.Show("TEBRÝKLER BÖLÜMÜ GEÇTÝNÝZ", "BÖLÜM GEÇÝLDÝ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (secenek == DialogResult.OK)
                {
                    Form2 bolum2 = new Form2();
                    this.Hide();
                    bolum2.Show();

                }
            }
        }
        public void yandýn()
        {
            if (pictureBox1.Bounds.IntersectsWith(duvar1.Bounds))
            {
                durdurma();
               
                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK ÝSTER MÝSÝN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
               
                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK ÝSTER MÝSÝN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
               
                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK ÝSTER MÝSÝN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }

            }
            else if (pictureBox1.Bounds.IntersectsWith(duvar17.Bounds))
            {
                durdurma();
               
                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK ÝSTER MÝSÝN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                
                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK ÝSTER MÝSÝN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    
                    baslatma();

                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }

            }
            else if (pictureBox1.Bounds.IntersectsWith(duvar7.Bounds))
            {
                durdurma();
                
                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK ÝSTER MÝSÝN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                
                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK ÝSTER MÝSÝN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                
                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK ÝSTER MÝSÝN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                
                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK ÝSTER MÝSÝN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                
                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK ÝSTER MÝSÝN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                
                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK ÝSTER MÝSÝN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    
                    baslatma(); ;
                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }

            }
            else if (pictureBox1.Bounds.IntersectsWith(duvar13.Bounds))
            {
                durdurma();
                
                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK ÝSTER MÝSÝN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                
                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK ÝSTER MÝSÝN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    ;
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
                
                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK ÝSTER MÝSÝN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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

                DialogResult secenek = MessageBox.Show("TEKRAR DENEMEK ÝSTER MÝSÝN?", "DUVARA TEMAS ETTINIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    Cursor.Position = new Point(31, 24);
                    baslatma();
                }
                else if (secenek == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        
    }
}
