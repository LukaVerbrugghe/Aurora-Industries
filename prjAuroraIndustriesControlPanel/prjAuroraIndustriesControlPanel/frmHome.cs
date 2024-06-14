using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace prjAuroraIndustriesControlPanel
{
    
    public partial class frmHome : Form
    {
        //aantal keer gecanceld
        int intTimesCancelled = 0;
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
            string userName = Interaction.InputBox("Please provide a log in:", "User Name");
            DialogResult loginAnser = MessageBox.Show("You where automaticly logged in by Aurora Security Protocol (ASP) using your known credentials. \nClick ok to continue or cancel to cancel to log in request.\n\nWarning: Cancelling a log in request to often may trigger a security check.", "Notice of log in", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            //check the anser of the user
            if (loginAnser == DialogResult.OK)
            {
                //log in
                frmNavigatie frmNavigatie = new frmNavigatie();
                frmNavigatie.Show();
            }
            else if (loginAnser == DialogResult.Cancel)
            {
                //do nothing
                MessageBox.Show("Log in cancelled.");
                intTimesCancelled++;
                //check number of times cancelled
                if (intTimesCancelled >= 3)
                {
                    MessageBox.Show("Aurora Guardian Protection (AGP) has detected suspicious activity. Your account has been blocked. Please contect the Administrator Help Center. The number can be found in your phone.");
                }
            }
            else
            {
                //er is iets srs misgegaan
                MessageBox.Show("Fatal error: Dialog Result was not OK or CANCEL. Contact Aurora Industries.", "Error: Dialog Result did not match", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
