using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Device.Location;
using System.Device;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.Data.OleDb;
using GMap.NET.WindowsForms.ToolTips;
using System.Threading;

namespace HastaneKayit
{
    public partial class Enyakınhastane : Form
    {
        public Enyakınhastane()
        {
            InitializeComponent();

        }



        
        
        GeoCoordinateWatcher wc;
        GMapOverlay markersOverlay = new GMapOverlay("markers");
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=hastaneBilgileri.accdb");
        GeoCoordinate location;
       




        private void frm1kapat_Click(object sender, EventArgs e)
        {
            this.Hide();
         //   Form1 frm = new Form1();
           //  frm.Show();
        }

        private void Enyakınhastane_Load(object sender, EventArgs e)
        {

            wc = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            wc.StatusChanged += Wc_StatusChanged;
            wc.Start();
            textBox2.Visible = false;
            textBox3.Visible = false;


        }

        private void gmap_Load(object sender, EventArgs e)
        {

            gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.SetPositionByKeywords("İstanbul, Turkey");
            gmap.Zoom = 10;




        }
        void pckonum()
        {
            PointLatLng st = new PointLatLng(location.Latitude, location.Longitude);
            gmap.Position = st;
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker1 = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)),
           GMarkerGoogleType.green);
            markersOverlay.Markers.Add(marker1);
            gmap.Overlays.Add(markersOverlay);

            marker1.ToolTipText = "Mevcut Konumunuz !";
            marker1.ToolTipMode = MarkerTooltipMode.Always;
            marker1.ToolTip.Foreground = Brushes.Black;
            marker1.ToolTip.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            var brush = new SolidBrush(Color.FromArgb(245,245,220));
            marker1.ToolTip.Fill = brush;
            markersOverlay.Markers.Add(marker1);
            gmap.Zoom = 14;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pckonum();


        }

        private void Wc_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            if (e.Status == GeoPositionStatus.Ready)
            {

                if (wc.Position.Location.IsUnknown)
                {

                    label1.Text = "Cannot find location data";
                }
                else
                {
                    location = wc.Position.Location;

                    textBox2.Text = location.Latitude.ToString();
                    textBox3.Text = location.Longitude.ToString();
                }
            }







        }

        private void hstnlergoster_Click(object sender, EventArgs e)
        {
            gmap.Zoom = 14;

            OleDbDataAdapter adp = new OleDbDataAdapter("SELECT * FROM hastanekonum", bag);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                DataRow dr = tablo.Rows[i];
                dr = tablo.Rows[i];

                PointLatLng a = new PointLatLng(Convert.ToDouble(dr["konum1"]), Convert.ToDouble(dr["konum2"]));
                //   MessageBox.Show(a.Lat.ToString(), a.Lng.ToString());
                // PointLatLng a = new PointLatLng(Convert.ToDouble(dr["konum1"].ToString().Replace(',', '.')), Convert.ToDouble(dr["konum2"].ToString().Replace(',', '.')));
                var yep = new GeoCoordinate(a.Lat, a.Lng);
                double sayı = Math.Ceiling(Convert.ToDouble(location.GetDistanceTo(yep)) / 1000);
                if (sayı <= 20)
                {
                    GMapOverlay markers = new GMapOverlay("markers");
                    GMapMarker marker = new GMarkerGoogle(a,GMarkerGoogleType.blue_pushpin);
                    markers.Markers.Add(marker);
                    gmap.Overlays.Add(markers);  
                    marker.ToolTipText = "\n" + dr["hastanead"] + "\n\n" + "\n Ortalama : " + sayı + "km" + " (" + Math.Ceiling((0.621371192 * sayı)) + " mil)\n\n";
                    marker.Tag = dr["hastanead"];
                   // marker.ToolTip = new GMapBaloonToolTip(mrk);
                  //  markersOverlay.Markers.Add(mrk);

                 
                    
                }

            }

        }



       
        }
    }

  





