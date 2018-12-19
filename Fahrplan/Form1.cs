using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace Fahrplan
{
    public partial class Form1 : Form
    {
        Transport transport = new Transport();
        Coordinate coordinate = new Coordinate();
        public Form1()
        {
            InitializeComponent();
        }
        private void Get_Stations(string text, ListBox listBox)
        {
            if (text.Length >= 3)
            {
                listBox.Items.Clear();
                Stations stations = transport.GetStations(text);
                foreach (Station station in stations.StationList)
                {
                    listBox.Items.Add(station.Name);
                    listBox.Visible = true;
                    listBox.BringToFront();
                }
            }
        }
        public string Get_TableFromDataGrid()
        {
            StringBuilder strTable = new StringBuilder();
            try
            {
                strTable.Append("<table border='1' cellpadding='0' cellspacing='0'>");
                strTable.Append("<tr>");
                foreach (DataGridViewColumn col in dtgVerbindungen.Columns)
                {
                    strTable.AppendFormat("<th>{0}</th>", col.HeaderText);
                }
                strTable.Append("</tr>");
                for (int i = 0; i < dtgVerbindungen.Rows.Count; i++)
                {
                    strTable.Append("<tr>");
                    foreach (DataGridViewCell cell in dtgVerbindungen.Rows[i].Cells)
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

        private void Get_Grid()
        {
            Cursor.Current = Cursors.WaitCursor;
            lblLaden.Visible = true;
            DataTable dttConnections = new DataTable();
            dttConnections.Columns.Add("Datum");
            dttConnections.Columns.Add("Von");
            dttConnections.Columns.Add("Nach");
            dttConnections.Columns.Add("Abfahrt");
            dttConnections.Columns.Add("Ankunft");
            dttConnections.Columns.Add("Gleis");

            //Abfrage
            Connections connections = transport.GetConnections(txtVon.Text, txtNach.Text, dtpDate.Value.ToString("yyyy-MM-dd"), dtpTime.Text);

            //Jedes Resulatat zur Liste hinzufügen
            foreach (Connection connection in connections.ConnectionList)
            {
                dttConnections.Rows.Add(Get_Date(connection.From.Departure), connection.From.Station.Name, Get_Time(connection.From.Departure), connection.To.Station.Name, Get_Time(connection.To.Arrival), connection.To.Platform);
            }

            dtgVerbindungen.DataSource = dttConnections;
            lblLaden.Visible = false;
            UseWaitCursor = false;
        }

        private void Get_2_Grid()
        {
            DataTable dttRoutes = new DataTable();
            dttRoutes.Columns.Add("Zeit");
            dttRoutes.Columns.Add("Nach");
            dttRoutes.Columns.Add("Linie");

            //Definieren der Station für die Abfahrtstafel (Inhalt der Textbox wird übergeben)
            Station station = transport.GetStations(btnVon2.Text).StationList.First();
            StationBoardRoot departures = transport.GetStationBoard(station.Name, station.Id); //Beispiel für station.name ist Luzern, Beispiel für station.Id = 8505000

            foreach (StationBoard station_b in departures.Entries)
            {
                dttRoutes.Rows.Add(Get_Time(station_b.Stop.Departure.ToString()), station_b.To, (station_b.Category + " " + station_b.Number)); //Jede Linie die gefunden wird, wird hier durchgegangen
            }

            dtgVerbindungen2.DataSource = dttRoutes;
        }

        private string Get_Date(string date1)
        {
            string date2 = date1.Remove(10);
            DateTime date3 = Convert.ToDateTime(date2);
            return date3.ToString("dd.MM.yyyy");
        }

        private string Get_Time(string time1) //Zeit kommt so 13:25:00 und die letzen 2 Stellen :00 werden hier gelöscht.
        {
            string time2 = time1.Remove(0, 11);
            time2 = time2.Remove(5);
            return time2;
        }

        private void Create_GmapStation(string x, string y)
        {
            string url = "https://www.google.ch/maps/place/" + x + "," + y;
           webGoogleMaps.Navigate(url);
        }

        private void Switch_txt(TextBox textBox1, TextBox textBox2)
        {
            string temp = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = temp;
        }

        //Navigation 
        private void Form_Fahrplan_Load(object sender, EventArgs e)
        {
            pnl1.Visible = true;
            pnl2.Visible = false;
            pnl3.Visible = false;
            lblLaden.Visible = false;
        }

        private void BTN_nav1_Click(object sender, EventArgs e)
        {
            pnl1.Visible = true;
            pnl2.Visible = false;
            pnl3.Visible = false;
        }

        private void BTN_nav2_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = true;
            pnl3.Visible = false;
        }

        private void BTN_nav3_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = true;
        }

        //Menu1
        private void BTN_google_maps_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl1.Visible = false;
            pnl1.Visible = true;
        }

        private void TXT_von_TextChanged(object sender, EventArgs e)
        {
            Get_Stations(txtVon.Text, lbxVon);
        }

        private void TXT_nach_TextChanged(object sender, EventArgs e)
        {
            Get_Stations(txtNach.Text, lbxNach);
        }

        private void LBX_von_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtVon.Text = lbxVon.SelectedItem.ToString();
            btnSuche.Focus();
            lbxVon.Visible = false;
        }

        private void LBX_nach_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtNach.Text = lbxNach.SelectedItem.ToString();
            btnSuche.Focus();
            lbxNach.Visible = false;
        }

        //Menu2
        private void BTN_suche_2_Click(object sender, EventArgs e)
        {
            if (btnVon2.Text != string.Empty)
            {
                Get_2_Grid();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Ort ein!");
            }
        }

        private void BTN_von_2_TextChanged(object sender, EventArgs e)
        {
            Get_Stations(btnVon2.Text, lbxVon2);
        }

        private void LBX_von_2_DoubleClick(object sender, EventArgs e)
        {
            btnVon2.Text = lbxVon2.SelectedItem.ToString();
            btnSearch2.Focus();
            lbxVon2.Visible = false;
        }

        //Menu3
        private void BTN_suche_3_Click(object sender, EventArgs e)
        {
            if (txtStation.Text != string.Empty)
            {
                Stations stations = transport.GetStations(txtStation.Text);
                Station station = stations.StationList[0];
                Create_GmapStation(Convert.ToString(station.Coordinate.XCoordinate).Replace(',', '.'), Convert.ToString(station.Coordinate.YCoordinate).Replace(',', '.'));
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Ort ein!");
            }
        }

        private void txtStation_TextChanged(object sender, EventArgs e)
        {
            Get_Stations(txtStation.Text, lbxStation);
        }

        private void lbx_3_start_DoubleClick(object sender, EventArgs e)
        {
            txtStation.Text = lbxStation.SelectedItem.ToString();
            btnSuche3.Focus();
            lbxStation.Visible = false;
        }

        private void btnSuche_Click_1(object sender, EventArgs e)
        {
            if (txtVon.Text != string.Empty)
            {
                Get_Grid();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie zwei Orte ein!");
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Form2 exit = new Form2();
            exit.Visible = false;
            if (exit.ShowDialog(this) == DialogResult.OK)
            {
                Close();
            }
            else
            {
                exit.Dispose();
            }
        }

        private void pbSwitch_Click(object sender, EventArgs e)
        {

        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
                MessageBox.Show("Bitte geben Sie eine Email-Adresse ein!");
            else
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("modul318.andreas@gmail.com");
                    mail.To.Add(new MailAddress(Convert.ToString(this.txtEmail)));
                    mail.Subject = "Fahrplan";
                    mail.Body = "Hallo, hier ein Fahrplan, den ich mit dir teilen wollte. ";
                    mail.Body += "<b>" + Get_TableFromDataGrid() + "</b>";
                    mail.IsBodyHtml = true;
                    SmtpClient SmtpServer = new SmtpClient();
                    SmtpServer.Host = "smtp.gmail.com";
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("modul318.andreas@gmail.com", "Kennwort$21");
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
    }
}
