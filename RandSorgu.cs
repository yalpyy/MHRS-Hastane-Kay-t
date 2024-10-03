using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace HastaneKayit
{
    public partial class RandSorgu : Form
    {
       public string tcNo="";
        public RandSorgu()
        {
            InitializeComponent();
            
        }
       
        Form1 frm1 = new Form1();
        private void frm1kapat_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
         void listviewGuncelle()
        {
            tcNo = textBox1.Text;
            listView1.Items.Clear();
            try
            {
               
                
                frm1.uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("select * from Randevular where Tc='"+tcNo+"' order by Randevuid desc ", frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                int no = 0;
                while (rd.Read())
                {
                    no++;
                    listView1.Items.Add(no.ToString());
                    listView1.Items[no - 1].SubItems.Add(rd["KlinikAdi"].ToString());
                    listView1.Items[no - 1].SubItems.Add(rd["DoktorAdi"].ToString());
                    listView1.Items[no - 1].SubItems.Add(rd["Tarih"].ToString());
                    listView1.Items[no - 1].SubItems.Add(rd["Saat"].ToString());
                    listView1.Items[no - 1].SubItems.Add(rd["Randevuid"].ToString());
                    listView1.Items[no - 1].SubItems.Add(rd["hastane"].ToString());
                   
                }
                frm1.uyelerBaglantisi.Close();
               
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

         private void RandSorgu_Load(object sender, EventArgs e)
         {
             
         }

         private void button1_Click(object sender, EventArgs e)
         {
             listviewGuncelle();
         }
    }
}
