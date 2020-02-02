using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Gmapsapp
{
    public partial class Map : Form
    {
        public Map()
        {
            /*Iconos diseñados por <a href="https://www.flaticon.es/autores/dinosoftlabs" title="DinosoftLabs">DinosoftLabs</a> from <a href="https://www.flaticon.es/" title="Flaticon"> www.flaticon.es</a>*/
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmap.Position = new GMap.NET.PointLatLng(48.8589507, 2.2775175);

            GMapOverlay markerOver = new GMapOverlay("marcador");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(48.8589507, 2.2775175), GMarkerGoogleType.green);
            markerOver.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = "hola";
            gmap.Overlays.Add(markerOver);

        }

      
    }
}
