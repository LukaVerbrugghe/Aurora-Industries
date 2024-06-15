namespace prjAuroraIndustriesControlPanel
{
    partial class frmNavigatie
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlanAirStrike = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "AURORA INDUSTRIES CONTROL PANEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "©AURORA INDUSTRIES, IMPERIAL SCIENCE FOUNDATION";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 36);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlanAirStrike
            // 
            this.btnPlanAirStrike.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlanAirStrike.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlanAirStrike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanAirStrike.ForeColor = System.Drawing.Color.Crimson;
            this.btnPlanAirStrike.Location = new System.Drawing.Point(13, 73);
            this.btnPlanAirStrike.Name = "btnPlanAirStrike";
            this.btnPlanAirStrike.Size = new System.Drawing.Size(381, 33);
            this.btnPlanAirStrike.TabIndex = 6;
            this.btnPlanAirStrike.Text = "Plan an Airstrike";
            this.btnPlanAirStrike.UseVisualStyleBackColor = false;
            this.btnPlanAirStrike.Click += new System.EventHandler(this.btnPlanAirStrike_Click);
            // 
            // frmNavigatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlanAirStrike);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Name = "frmNavigatie";
            this.Text = "Navigatie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlanAirStrike;
    }
}