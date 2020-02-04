using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using model;

namespace Gmapsapp
{
    public partial class Map : Form
    {
        private GMapOverlay markerOverlay;
        private GMarkerGoogle marker;
        private DataTable Dtable;

        private int selectedRow;
        private double initialLatitude;
        private double initialLongitude;
        private DataManager dm;

        public Map()
        {
            /*Iconos diseñados por <a href="https://www.flaticon.es/autores/dinosoftlabs" title="DinosoftLabs">DinosoftLabs</a> from <a href="https://www.flaticon.es/" title="Flaticon"> www.flaticon.es</a>*/
            InitializeComponent();
            initialLatitude = 35.2270889;
            initialLongitude = -80.843132;
            OpenFileDialog fd = new OpenFileDialog();
            
            fd.ShowDialog();
            string path = fd.FileName;
            /*System.IO.StreamReader sr = new StreamReader(path);

            string line = sr.ReadLine();
            string[] lines = sr.ReadLine().Split(',');
            string msg = "";
            for (int i = 0; i < lines.Length; i++) {
                msg += i + " --> " + lines[i] + "\n";
            }*/

            dm = new DataManager();
            dm.loadData(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dtable = new DataTable();
            Dtable.Columns.Add(new DataColumn("Description", typeof(string)));
            Dtable.Columns.Add(new DataColumn("Latitude", typeof(double)));
            Dtable.Columns.Add(new DataColumn("Longitude", typeof(double)));

            dataLocations.DataSource = Dtable;
            // default values of map
            gmap.DragButton = MouseButtons.Left;
            gmap.CanDragMap = true;
            gmap.MapProvider = GMapProviders.GoogleMap;
            gmap.Position = new PointLatLng(initialLatitude, initialLongitude);
            gmap.AutoScroll = true;

            // add marker
            markerOverlay = new GMapOverlay("Marker");
            marker = new GMarkerGoogle(new PointLatLng(initialLatitude, initialLongitude), GMarkerGoogleType.green);
            
            markerOverlay.Markers.Add(marker); //add to map

            // add a tooltip to map
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Location: \n Latitude: {0} \n Longitud: {1}", initialLatitude, initialLongitude);

            //add marker to map
            gmap.Overlays.Add(markerOverlay);
          

            
        }

        private void selectLocation(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRow = e.RowIndex;
            txtDescription.Text = dataLocations.Rows[selectedRow].Cells[0].Value.ToString();
            txtLatitude.Text = dataLocations.Rows[selectedRow].Cells[1].Value.ToString();
            txtLongitude.Text = dataLocations.Rows[selectedRow].Cells[2].Value.ToString();

            double currentLatitude = Convert.ToDouble(txtLatitude.Text);
            double currentLongitud = Convert.ToDouble(txtLongitude.Text);
            //assign values to marker
            marker.Position = new PointLatLng(currentLatitude, currentLongitud);
            gmap.Position = marker.Position;

        }

        private void doubleClick(PointLatLng pointClick, MouseEventArgs e)
        {
            double lat = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gmap.FromLocalToLatLng(e.X, e.Y).Lng;

            marker.Position = new PointLatLng(lat, lng);
            txtLatitude.Text = Convert.ToString(lat);
            txtLongitude.Text = Convert.ToString(lng);

            marker.ToolTipText = string.Format("Location: \n Latitude: {0} \n Longitud: {1}", lat, lng);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dtable.Rows.Add(txtDescription.Text, txtLatitude.Text, txtLongitude.Text);
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            Dtable.Rows.RemoveAt(selectedRow);
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            GMapOverlay route = new GMapOverlay("layerRoute");

            List<PointLatLng> points = new List<PointLatLng>();

            double lat, lng;

            for(int rows =0; rows<dataLocations.Rows.Count; rows++ )
            {
                lat = Convert.ToDouble(dataLocations.Rows[rows].Cells[1].Value);
                lng = Convert.ToDouble(dataLocations.Rows[rows].Cells[2].Value);
                points.Add(new PointLatLng(lat, lng));
            }
            GMapRoute routePoints = new GMapRoute(points, "Route");
            route.Routes.Add(routePoints);
            gmap.Overlays.Add(route);

            // update map
            gmap.Zoom = gmap.Zoom + 1;
            gmap.Zoom = gmap.Zoom - 1;
        }

        private void btnSatelite_Click(object sender, EventArgs e)
        {
            gmap.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            gmap.MapProvider = GMapProviders.GoogleMap ;
        }

        private void btnRelief_Click(object sender, EventArgs e)
        {
            gmap.MapProvider = GMapProviders.GoogleTerrainMap;
        }

       

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtScroll.Text = minutesScroll.Value.ToString();
        }
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            txtScroll2.Text = minutesScroll2.Value.ToString();
        }

        private void btnCalculateDelay(object sender, EventArgs e)
        {
            if (dataLocations.Rows.Count == 2)
            {
                
                    string origin = dataLocations.Rows[0].Cells[0].Value.ToString();
                    string dest = dataLocations.Rows[1].Cells[0].Value.ToString();
                 int minutes = Convert.ToInt32(txtScroll.Text);
                labelDel.Text = Convert.ToString(dm.probability(origin, dest, minutes));
            }
        }

        private void btnCalculateEarly(object sender, EventArgs e)
        {
            if (dataLocations.Rows.Count == 2)
            {

                string origin = dataLocations.Rows[0].Cells[0].Value.ToString();
                string dest = dataLocations.Rows[1].Cells[0].Value.ToString();
                int minutes = Convert.ToInt32(txtScroll2.Text);
                labelEarly.Text = Convert.ToString(dm.probability(origin, dest, minutes*(-1)));
            }
        }

       
    }
}
