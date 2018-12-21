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
    public partial class Standortmaps : Form
    {
        public Standortmaps()
        {
            InitializeComponent();
        }
        // Standortmaps Form schliessen
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        // komplette Applikation schliessen
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
