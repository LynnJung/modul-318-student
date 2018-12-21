using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace AppSwissTransport
{

    public partial class Maps : Form
    {
        Transport transport = new Transport();
        private string ort;

        public Maps(string suche)
        {
            InitializeComponent();
            ort = suche;
        }

        private void Create_GmapStation(string x, string y)
        {
            string url = "https://www.google.ch/maps/place/" + x + "," + y;
            webGoogle.Navigate(url);
        }


        private void Maps_Load(object sender, EventArgs e)
        {
            if (ort != string.Empty)
            {
                Stations stations = transport.GetStations(ort);
                Station station = stations.StationList[0];
                Create_GmapStation(Convert.ToString(station.Coordinate.XCoordinate).Replace(',', '.'),
                Convert.ToString(station.Coordinate.YCoordinate).Replace(',', '.'));
            }
        }
    }
}
