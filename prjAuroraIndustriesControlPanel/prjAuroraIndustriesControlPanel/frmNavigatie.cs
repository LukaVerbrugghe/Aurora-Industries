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
    public partial class frmNavigatie : Form
    {
        public frmNavigatie()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlanAirStrike_Click(object sender, EventArgs e)
        {
            //ask for comfirmation
            DialogResult result = DialogResult.None;
            result = MessageBox.Show("Please confirm you want to plan an airstrike.\n\nClick OK to contiue planning the airstrike. Click cancel to cancel the action.\n\nPlease note, planning an airstrike is a destructive and inrevertable action.", "Confirm destructive action", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                result = MessageBox.Show("Please confirm again. Are you sure you want to plan an airstrike?", "Second confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //airstrike openen
                    frmAirstrike frmAirstrike = new frmAirstrike();
                    frmAirstrike.Show();
                }
                else
                {
                    MessageBox.Show("You have cancelled the planning phase of the airstrike.", "Cancelled", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("You have cancelled the planning phase of the airstrike.", "Cancelled", MessageBoxButtons.OK);
            }
        }
    }
}
