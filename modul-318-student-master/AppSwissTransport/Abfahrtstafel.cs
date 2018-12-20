using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSwissTransport
{
    public partial class Abfahrtstafel : Form
    {
        Transport transport = new Transport();
        public Abfahrtstafel()
        {
            InitializeComponent();
        }

        public void combox(ComboBox comboBoxName)
        {
            if (!string.IsNullOrEmpty(comboBoxName.Text))
            {
                List<Station> stations = transport.GetStations(comboBoxName.Text).StationList;
                if (stations.Count > 0)
                {
                    comboBoxName.Items.Clear();
                    foreach (Station station in stations)
                    {
                        comboBoxName.Items.Add(station.Name);
                    }
                }
                comboBoxName.Text = "";
                comboBoxName.SelectedIndex = 0;
            }
        }

        private void btnSuche_Click_1(object sender, EventArgs e)
        {
            dgrdAbfahrtsTafel.Rows.Clear();

            List<StationBoard> stationBoard = transport.GetStationBoard(cbAbfahrt.Text, "20").Entries;

            stationBoard.ForEach(delegate (StationBoard con)
            {
                dgrdAbfahrtsTafel.Rows.Add
                (
                    con.To.ToString(),
                    con.Stop.Departure.Hour.ToString() +
                    ":" +
                    con.Stop.Departure.Minute.ToString()
                );
            });

            cbAbfahrt.Text = "";
        }

        private void btnAutoFill_Click(object sender, EventArgs e)
        {
            combox(cbAbfahrt);
        }
    }
}
