﻿namespace prjAuroraIndustriesControlPanel
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "AURORA INDUSTRIES CONTROL PANEL";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Red;
            this.btnLogIn.Location = new System.Drawing.Point(43, 128);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(690, 238);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "©AURORA INDUSTRIES, IMPERIAL SCIENCE FOUNDATION";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Name = "frmHome";
            this.Text = "Homepage - AURORA INDSUTRIES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label label2;
    }
}

