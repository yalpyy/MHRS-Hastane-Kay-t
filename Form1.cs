using System;//
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;//

namespace HastaneKayit
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();//
        }
       public bildiri frm = new bildiri();

        public OleDbConnection uyelerBaglantisi = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=hastaneBilgileri.accdb");


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 10;
            frm.Opacity = 0;
            panel1.Visible = false;
            
            frm.Show();

            // for (int i = 0 ; i < 100; i++)
            //{
            //     frm.Location = new Point(1100+i, 200);
            // } 
             frm.Location = new Point(1100, 200);
        }
        bool giris_Yapildimi = false;
        bool banlanmismi = false;
        
        void BanGunuGuncelle()
        {
            string banGunu = "";
            string banTarihi = "";
            DateTime bugun = DateTime.Now;//
            banlanmismi = false;
            try
            {
                uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Uyeler where TC='"+maskedtxtTC.Text+"'",uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    banGunu = rd["ban"].ToString();
                    banTarihi = rd["banTarihi"].ToString();
                }                
                uyelerBaglantisi.Close();

                DateTime banTarihiDate = DateTime.Parse(banTarihi);
                banTarihiDate = banTarihiDate.AddDays(int.Parse(banGunu));
                DateTime bugununDate = DateTime.Parse(bugun.ToShortDateString());
                TimeSpan kalanGun = banTarihiDate - bugununDate;
                if (int.Parse(kalanGun.TotalDays.ToString()) > 0)//
                {
                    MessageBox.Show("Sisteme " + kalanGun.TotalDays.ToString() + " Gün Giriş İzniniz Yoktur");
                    giris_Yapildimi = true;
                    banlanmismi = true;
                }
                
            }
            catch (Exception )
            {
            }

        }

        bool Admin_Girdimi = false;
        bool Doktor_Girdimi = false;
        //
        void Admin_Girisi()
        {
            //Admin_Girdimi = false;
            //try
            //{
            //    uyelerBaglantisi.Open();
            //    OleDbCommand cmd0 = new OleDbCommand("Select * From Admin where KullaniciAdi='" + maskedtxtTC.Text + "' and Parola='" + txtParola.Text + "'", uyelerBaglantisi);
            //    cmd0.ExecuteNonQuery();
            //    OleDbDataReader rd0 = cmd0.ExecuteReader();
            //    while (rd0.Read())
            //    {
            //        AdminPaneli AmdPanel = new AdminPaneli();
            //        AmdPanel.Show();
            //        this.Hide();
            //        Admin_Girdimi = true;
            //        giris_Yapildimi = true;
            //    }
            //    uyelerBaglantisi.Close();
            //}
            //catch (Exception hata)
            //{                
            //    MessageBox.Show(hata.Message);
            //}
            if (maskedtxtTC.Text == "00000000000" && txtParola.Text == "00000")
            {
                AdminPaneli AmdPanel = new AdminPaneli();
                AmdPanel.Show();
                this.Hide();
                Admin_Girdimi = true;
                giris_Yapildimi = true;
            }
        }

        void Doktor_Girisi()
        {
            Doktor_Girdimi = false;
            Admin_Girdimi = false;
            try
            {
                uyelerBaglantisi.Open();
                OleDbCommand cmd0 = new OleDbCommand("Select * From Doktorlar where KullaniciAdi='" + maskedtxtTC.Text + "' and Sifre='" + txtParola.Text + "'", uyelerBaglantisi);
                cmd0.ExecuteNonQuery();
                OleDbDataReader rd0 = cmd0.ExecuteReader();
                while (rd0.Read())//
                {
                    Doktor dr = new Doktor(maskedtxtTC.Text,txtParola.Text);
                    dr.Show();
                    this.Hide();
                    Doktor_Girdimi = true;
                    giris_Yapildimi = true;
                }
                uyelerBaglantisi.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        void Uye_Girisi()
        {
            BanGunuGuncelle();

            try//
                {
                    uyelerBaglantisi.Open();
                    OleDbCommand cmd1 = new OleDbCommand("Select * From Uyeler where TC='" + maskedtxtTC.Text + "' and Parola='" + txtParola.Text + "'", uyelerBaglantisi);
                    cmd1.ExecuteNonQuery();
                    OleDbDataReader rd1 = cmd1.ExecuteReader();

                    while (rd1.Read())
                    {                 
                        if (banlanmismi == false)
                        {
                            randevuAra rara = new randevuAra(maskedtxtTC.Text, txtParola.Text);
                            rara.Show();
                            this.Hide();
                            giris_Yapildimi = true;
                        }
                    }
                    uyelerBaglantisi.Close();

                    if (giris_Yapildimi == false)
                    {
                        MessageBox.Show("Hatalı Kullanıcı Adı/Parola");
                    }
                }
                catch (Exception)
                {
                    uyelerBaglantisi.Close();
                    MessageBox.Show("Bağlantı Sağlanamadı");
                }
            //
        }
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            Admin_Girisi();
            frm.Hide();
            if (Admin_Girdimi==false)
            {
                Doktor_Girisi();
                this.Hide();
                
            }
            if (Admin_Girdimi==false && Doktor_Girdimi==false)
            {
                Uye_Girisi();
                this.Hide();
                
            }
        }

        private void btnYeniUye_Click(object sender, EventArgs e)
        {
            yeniUye yeniuye = new yeniUye();
            yeniuye.ShowDialog();
        }

        private void btnParolamiUnuttum_Click(object sender, EventArgs e)
        {
            ParolamiUnuttum pUnuttum = new ParolamiUnuttum();
            pUnuttum.ShowDialog();
        }

        private void maskedtxtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                SendKeys.Send("{TAB}");//
            }
        }

        private void txtParola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                btnGiris_Click(sender, e);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            uyelerBaglantisi.Close();//
        }

        private void frm1kapat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Hide();
            Application.Exit();
        }

        private void snlklavye_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void klavye7_Click(object sender, EventArgs e)
        {
            txtParola.Text = txtParola.Text + "7";
        }

        private void klavye8_Click(object sender, EventArgs e)
        {
            txtParola.Text = txtParola.Text + "8";
        }

        private void klavye9_Click(object sender, EventArgs e)
        {
            txtParola.Text = txtParola.Text + "9";
        }

        private void klavye4_Click(object sender, EventArgs e)
        {
            txtParola.Text = txtParola.Text + "4";
        }

        private void klavye5_Click(object sender, EventArgs e)
        {
            txtParola.Text = txtParola.Text + "5";
        }

        private void klavye6_Click(object sender, EventArgs e)
        {
            txtParola.Text = txtParola.Text + "6";
        }

        private void klavye1_Click(object sender, EventArgs e)
        {
            txtParola.Text = txtParola.Text + "1";
        }

        private void klavye2_Click(object sender, EventArgs e)
        {
            txtParola.Text = txtParola.Text + "2";
        }

        private void klavye3_Click(object sender, EventArgs e)
        {
            txtParola.Text = txtParola.Text + "3";
        }

        private void klavye0_Click(object sender, EventArgs e)
        {
            txtParola.Text = txtParola.Text + "0";
        }

        private void klavyeenter_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RandSorgu rnd = new RandSorgu();
            rnd.Show();
            this.Hide();
            
        }

        

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            frm.Opacity += 0.008;
        }
    }
}
