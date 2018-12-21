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
using System.Net.Mail;
using System.Security.Policy;

namespace AppSwissTransport
{
  
    public partial class Fahrplan : Form
    {
        Transport transport = new Transport();
        private string url;
        public Fahrplan()
        {
            InitializeComponent();
        }
        //
        // Stationen In die Combobox einfügen und Auto complete
        //
        public void combox(ComboBox comboBoxName)
        {
            try
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
            catch
            {
                MessageBox.Show("Diese Station gibt es nicht!");
            }
        }
        //
        // Url für die Station zusammenstellen mit x und y koordinaten
        //
        private void Create_GmapStation(string x, string y)
        {
            url = "https://www.google.ch/maps/place/" + x + "," + y;
        }
        //
        // Table build für email
        // 
        public string Get_TableFromDataGrid()
        {
            StringBuilder strTable = new StringBuilder();
            try
            {
                strTable.Append("<table border='1' cellpadding='0' cellspacing='0'>");
                strTable.Append("<tr>");
                foreach (DataGridViewColumn col in dgvFahrplan.Columns)
                {
                    strTable.AppendFormat("<th>{0}</th>", col.HeaderText);
                }
                strTable.Append("</tr>");
                for (int i = 0; i < dgvFahrplan.Rows.Count; i++)
                {
                    strTable.Append("<tr>");
                    foreach (DataGridViewCell cell in dgvFahrplan.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            strTable.AppendFormat("<td>{0}</td>", cell.Value.ToString());
                        }
                    }
                    strTable.Append("</tr>");
                }
                strTable.Append("</table>");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return strTable.ToString();
        }
        
        // Suchen von stationen in Combobox Abfahrt
        
        private void btnVon_Click(object sender, EventArgs e)
        {
            cbAbfahrt.Focus();
            combox(cbAbfahrt);
            cbAbfahrt.DroppedDown = true;

        }

        // Suchen von stationen in Combobox Ankunft

        private void btnNach_Click(object sender, EventArgs e)
        {
            cbAnkunft.Focus();
            combox(cbAnkunft);
            cbAnkunft.DroppedDown = true;
        }
        //Methode um das Grid zu erstellen
        private void Get_Grid()
        {
            Cursor.Current = Cursors.WaitCursor;

            DataTable dtt_connections = new DataTable();
            dtt_connections.Columns.Add("Datum");
            dtt_connections.Columns.Add("Von");
            dtt_connections.Columns.Add("Abfahrt");
            dtt_connections.Columns.Add("Nach");
            dtt_connections.Columns.Add("Ankunft");
            dtt_connections.Columns.Add("Gleis");

            //Abfrage
            Connections connections = transport.GetConnections(cbAbfahrt.Text, cbAnkunft.Text, dtpDate.Value.ToString("yyyy-MM-dd"), dtpTime.Text);

            //Jedes Resulatat zur Liste hinzufügen
            foreach (Connection connection in connections.ConnectionList)
            {
                dtt_connections.Rows.Add(Get_Date(connection.From.Departure), connection.From.Station.Name, Get_Time(connection.From.Departure), connection.To.Station.Name, Get_Time(connection.To.Arrival), connection.To.Platform);
            }

            dgvFahrplan.DataSource = dtt_connections;
            UseWaitCursor = false;
        }

        //Wenn auf Button Suche Klicken Grid anzeigen mit Ausfallsicherung

        private void btnSuche_Click(object sender, EventArgs e)
        {
            if (cbAbfahrt.Text.Length <= 1)
            {
                MessageBox.Show("Bitte geben Sie eine Station an."); // Falls das eingabefeld Abfahrt leer ist gibt es diese Nachricht aus
            }

            if (cbAnkunft.Text.Length <= 1)
            {
                MessageBox.Show("Bitte geben Sie eine Station an."); // Falls das Eingabefeld Ankunft leer ist gibt es diese Nachricht aus
            }
            else // Wenn bei beiden Feldern etwas eingegeben wurde geht hier rein 
            { 
                 Get_Grid();
            }


        }
        // Datumformat
        private string Get_Date(string date1)
        {
            string date2 = date1.Remove(10);
            DateTime date3 = Convert.ToDateTime(date2);
            return date3.ToString("dd.MM.yyyy");
        }
        // Zeitformat 
        private string Get_Time(string time1) //Zeit kommt so 13:25:00 und die letzen 2 Stellen :00 werden hier gelöscht.
        {
            string time2 = time1.Remove(0, 11);
            time2 = time2.Remove(5);
            return time2;
        }


        //zu Form Abfahrtstafel wächseln
        private void btnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            Form Abfahrt = new Abfahrtstafel();
            Abfahrt.Show();
        }



        // Mail funktion über erstellte Email von Gmail
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
                MessageBox.Show("Bitte geben Sie eine Email-Adresse ein!");
            else
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("modul318.lynn.jung@gmail.com");
                    mail.To.Add(new MailAddress(Convert.ToString(this.txtMail)));
                    mail.Subject = "Fahrplan";
                    mail.Body = "Hallo, hier ein Fahrplan, den ich mit dir teilen wollte. ";
                    mail.Body += "<b>" + Get_TableFromDataGrid() + "</b>";
                    mail.IsBodyHtml = true;
                    SmtpClient SmtpServer = new SmtpClient();
                    SmtpServer.Host = "smtp.gmail.com";
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("modul318.lynn.jung@gmail.com", "Kennwort$11");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    MessageBox.Show("Email wurde erfolgreich gesendet");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        // Auf Form Maps wächseln
        private void btnMapsSearch_Click(object sender, EventArgs e)
        {
            if (cbAbfahrt.Text.Length > 1)
            {
                string ort = cbAbfahrt.Text;
                Form Googlemaps = new Maps(ort);
                Googlemaps.Show();
            }
            else
            {
                MessageBox.Show("Bitte Station Auswählen");
            }
        }

        // Auf Form Standortmaps wächseln
        private void btnNearby_Click(object sender, EventArgs e)
        {
            Form sMaps = new Standortmaps();
            sMaps.Show();
        }

        //Öffnet Google Maps in Browser mit der Ausgewählten Station
        private void linkStationMaps_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (cbAbfahrt.Text != null)
                {
                    Stations stations = transport.GetStations(cbAbfahrt.Text);
                    Station station = stations.StationList[0];
                    Create_GmapStation(Convert.ToString(station.Coordinate.XCoordinate).Replace(',', '.'),
                        Convert.ToString(station.Coordinate.YCoordinate).Replace(',', '.'));
                }
                    System.Diagnostics.Process.Start(url);
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie eine Station ein und versuchen Sie es nochmals!");
            }


        }

        // Öffnet Google Maps in Browser mit Stationen nearby
        private void linkStandortMaps_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.ch/maps/search/transit+stop+nearby/");
        }
    }
}
