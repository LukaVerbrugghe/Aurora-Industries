using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAuroraIndustriesControlPanel
{
    public partial class frmAirstrike : Form
    {
        public frmAirstrike()
        {
            InitializeComponent();
            updateDateLabel();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            updateDateLabel();
        }

        private void updateDateLabel()
        {
            lblDate.Text = "Launch date: " + dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            lblLaunchTime.Text = txtTime.Text;
        }

        private void rdbStandaardAXEL_CheckedChanged(object sender, EventArgs e)
        {
            updateBomb("Standard AXEL");
        }

        private void grbStandardBULL_CheckedChanged(object sender, EventArgs e)
        {
            updateBomb("Standard BULL");
        }

        private void rebNonLeathalTeargass_CheckedChanged(object sender, EventArgs e)
        {
            updateBomb("Non-Leathal Teargass");
        }

        private void rdbSmokey_CheckedChanged(object sender, EventArgs e)
        {
            updateBomb("Smokey V23");
        }

        private void rdbARRTA_CheckedChanged(object sender, EventArgs e)
        {
            updateBomb("ARRTA");
        }

        private void rdbHulluEstar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbAuroraIndustriesBee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbAuroraIndustriesAir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbNuclearRocket_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbDistortion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void updateBomb(string name)
        {
            lblBomb.Text = "Selected bomb: " + name;
        }
    }
}
