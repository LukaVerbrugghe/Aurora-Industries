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
            lblLaunchTime.Text = "Launch time " + txtTime.Text;
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
            updateBomb("Hullu E*");
        }

        private void rdbAuroraIndustriesBee_CheckedChanged(object sender, EventArgs e)
        {
            updateBomb("Aurora Industries Bee");
        }

        private void rdbAuroraIndustriesAir_CheckedChanged(object sender, EventArgs e)
        {
            updateBomb("Aurora Industries Air");
        }

        private void rdbNuclearRocket_CheckedChanged(object sender, EventArgs e)
        {
            updateBomb("Nuclear Rocket");
        }

        private void rdbDistortion_CheckedChanged(object sender, EventArgs e)
        {
            updateBomb("Distortion");
        }

        private void updateBomb(string name)
        {
            lblBomb.Text = "Selected bomb: " + name;
        }

        private void chbIncludeImperialLogo_CheckedChanged(object sender, EventArgs e)
        {
            updateExtraOptions();
        }

        private void chbLongDistance_CheckedChanged(object sender, EventArgs e)
        {
            updateExtraOptions();
        }

        private void chbDistortLaunchSignal_CheckedChanged(object sender, EventArgs e)
        {
            updateExtraOptions();
        }

        private void chbIncludePrototype_CheckedChanged(object sender, EventArgs e)
        {
            updateExtraOptions();
        }

        private void chbOnlyLocal_CheckedChanged(object sender, EventArgs e)
        {
            updateExtraOptions();
        }

        private void updateExtraOptions()
        {
            lsbAppliedOptions.Items.Clear();
            if (chbIncludeImperialLogo.Checked)
            {
                lsbAppliedOptions.Items.Add("Include Imperial Logo");
            }
            if (chbLongDistance.Checked)
            {
                lsbAppliedOptions.Items.Add("Long Distance");
            }
            if (chbDistortLaunchSignal.Checked)
            {
                lsbAppliedOptions.Items.Add("Distort Launch Signal");
            }
            if (chbIncludePrototype.Checked)
            {
                lsbAppliedOptions.Items.Add("Include Prototypes");
            }
            if (chbOnlyLocal.Checked)
            {
                lsbAppliedOptions.Items.Add("Only Local Bombs");
            }
        }

        private void lsbAppliedOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hier komt de code voor de extra uitleg
        }
    }
}
