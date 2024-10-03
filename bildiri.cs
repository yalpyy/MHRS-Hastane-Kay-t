using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace HastaneKayit
{
    public partial class bildiri : Form
    {
        
        public bildiri()
        {
            InitializeComponent();
       

        }
       
        private void bildiri_Load(object sender, EventArgs e)
        {
            GraphicsPath sekil = new GraphicsPath();
            sekil.AddEllipse(0, 0, this.Width, this.Height);
            Region sekilbolge = new Region(sekil);
            this.Region = sekilbolge;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Enyakınhastane enyakınhasta = new Enyakınhastane();  
            enyakınhasta.Show();
            this.Hide();
           
            
           
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Enyakınhastane enyakınhasta = new Enyakınhastane();
            enyakınhasta.Show();
            this.Hide();
            

        }

        private void bildiri_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
            
                contextMenuStrip1.Show();
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
