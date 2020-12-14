using FlappyBird.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int kaymaHizi = 6;
        int yerCekim = 10;
        int skor = 0;
        bool gecildi1, gecildi2, gecildi3, gecildi4;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kus.Top += yerCekim;

            boru1.Left -= kaymaHizi;
            boru2.Left -= kaymaHizi;
            boru3.Left -= kaymaHizi;
            boru4.Left -= kaymaHizi;

            if (boru1.Left + boru1.Width < 0)
            {
                boru1.Left = ClientSize.Width + rnd.Next(100);
                gecildi1 = false;
            }

            if (boru2.Left + boru2.Width < 0)
            {
                boru2.Left = ClientSize.Width + rnd.Next(100);
                gecildi2 = false;
            }

            if (boru3.Left + boru3.Width < 0)
            {
                boru3.Left = ClientSize.Width + rnd.Next(100);
                gecildi3 = false;
            }

            if (boru4.Left + boru4.Width < 0)
            {
                boru4.Left = ClientSize.Width + rnd.Next(100);
                gecildi4 = false;
            }

            #region Çarptı Mı?
            if (boru1.Bounds.IntersectsWith(kus.Bounds) 
                || boru2.Bounds.IntersectsWith(kus.Bounds) 
                || boru3.Bounds.IntersectsWith(kus.Bounds) 
                || boru4.Bounds.IntersectsWith(kus.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER");
            }
            #endregion

            #region Skor Arttırma
            if (kus.Left > boru1.Right && !gecildi1)
            {
                skor++;
                gecildi1 = true;
            }
            if (kus.Left > boru2.Right && !gecildi2)
            {
                skor++;
                gecildi2 = true;
            }
            if (kus.Left > boru3.Right && !gecildi3)
            {
                skor++;
                gecildi3 = true;
            }
            if (kus.Left > boru4.Right && !gecildi4)
            {
                skor++;
                gecildi4 = true;
            }

            lblSkor.Text = "Skor: " + skor;
            #endregion
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && timer1.Enabled)
            {
                kus.Top -= yerCekim * 6;
            }
        }
    }
}
