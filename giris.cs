using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace HastaneKayit
{
    public partial class giris : Form
    { 
        int sayi;
        public giris()
        {
           
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
        }

        private void giris_Load(object sender, EventArgs e)
        {
            timer1.Start();
            GraphicsPath sekil = new GraphicsPath();
            sekil.AddEllipse(0, 0, this.Width, this.Height);
            Region sekilbolge = new Region(sekil);
            this.Region = sekilbolge;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi +=20;
            timer1.Interval = 1000;
            prgsbar.Value = sayi;
            if (prgsbar.Value==100)
            {
                timer1.Stop();
                this.Hide();
                  Form1 frm = new Form1();
                  frm.Show();
        }
    }

        private void prgsbar_Click(object sender, EventArgs e)
        {

        }
    }
}