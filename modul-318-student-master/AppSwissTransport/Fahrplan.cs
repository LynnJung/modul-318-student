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
namespace AppSwissTransport
{
  
    public partial class Fahrplan : Form
    {
        Transport transport = new Transport();
        public Fahrplan()
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
        private void Create_GmapStation(string x, string y)
        {
            string url = "https://www.google.ch/maps/place/" + x + "," + y;
            webGoogle.Navigate(url);
        }
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

        private void btnVon_Click(object sender, EventArgs e)
        {
            combox(cbAbfahrt);
        }

        private void btnNach_Click(object sender, EventArgs e)
        {
            combox(cbAnkunft);
        }
        private void btnSuche_Click(object sender, EventArgs e)
        {
            dgvFahrplan.Rows.Clear();
            Connections cons = transport.GetConnections(cbAbfahrt.Text, cbAnkunft.Text);
            cons.ConnectionList.ForEach(delegate (Connection conn)
            {

                object[] arr = new object[3];

                DateTime dt = Convert.ToDateTime(conn.From.Departure);
                DateTime dt2 = Convert.ToDateTime(conn.To.Arrival);

                arr[0] = dt.ToString("HH:MM");
                arr[1] = dt2.ToString("HH:MM");
                arr[2] = conn.From.Platform;

                dgvFahrplan.Rows.Add(arr);
            });


        }

       
        private void btnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            Form Abfahrt = new Abfahrtstafel();
            Abfahrt.Show();
        }




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

        private void btnMapsSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
