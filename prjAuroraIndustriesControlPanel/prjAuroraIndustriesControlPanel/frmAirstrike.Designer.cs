namespace prjAuroraIndustriesControlPanel
{
    partial class frmAirstrike
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grbAirstrikePlanning = new System.Windows.Forms.GroupBox();
            this.trbComposition1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.grbKindBomb = new System.Windows.Forms.GroupBox();
            this.rdbStandaardAXEL = new System.Windows.Forms.RadioButton();
            this.grbStandardBULL = new System.Windows.Forms.RadioButton();
            this.rebNonLeathalTeargass = new System.Windows.Forms.RadioButton();
            this.rdbSmokey = new System.Windows.Forms.RadioButton();
            this.rdbARRTA = new System.Windows.Forms.RadioButton();
            this.rdbHulluEstar = new System.Windows.Forms.RadioButton();
            this.rdbAuroraIndustriesBee = new System.Windows.Forms.RadioButton();
            this.rdbAuroraIndustriesAir = new System.Windows.Forms.RadioButton();
            this.rdbNuclearRocket = new System.Windows.Forms.RadioButton();
            this.rdbDistortion = new System.Windows.Forms.RadioButton();
            this.chbIncludeImperialLogo = new System.Windows.Forms.CheckBox();
            this.chbLongDistance = new System.Windows.Forms.CheckBox();
            this.chbDistortLaunchSignal = new System.Windows.Forms.CheckBox();
            this.chbIncludePrototype = new System.Windows.Forms.CheckBox();
            this.chbOnlyLocal = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWithDegrees = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNoordZuid = new System.Windows.Forms.ComboBox();
            this.txtWithMinutes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWidthSeconds = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHeightDegree = new System.Windows.Forms.TextBox();
            this.txtHeightMinute = new System.Windows.Forms.TextBox();
            this.txtHeightSeconds = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbOostWest = new System.Windows.Forms.ComboBox();
            this.grbAirstrikePlanning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbComposition1)).BeginInit();
            this.grbKindBomb.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // grbAirstrikePlanning
            // 
            this.grbAirstrikePlanning.Controls.Add(this.cmbOostWest);
            this.grbAirstrikePlanning.Controls.Add(this.label9);
            this.grbAirstrikePlanning.Controls.Add(this.cmbNoordZuid);
            this.grbAirstrikePlanning.Controls.Add(this.label8);
            this.grbAirstrikePlanning.Controls.Add(this.label6);
            this.grbAirstrikePlanning.Controls.Add(this.label7);
            this.grbAirstrikePlanning.Controls.Add(this.label5);
            this.grbAirstrikePlanning.Controls.Add(this.label4);
            this.grbAirstrikePlanning.Controls.Add(this.txtTime);
            this.grbAirstrikePlanning.Controls.Add(this.txtHeightSeconds);
            this.grbAirstrikePlanning.Controls.Add(this.label3);
            this.grbAirstrikePlanning.Controls.Add(this.txtHeightMinute);
            this.grbAirstrikePlanning.Controls.Add(this.txtWidthSeconds);
            this.grbAirstrikePlanning.Controls.Add(this.txtHeightDegree);
            this.grbAirstrikePlanning.Controls.Add(this.txtWithMinutes);
            this.grbAirstrikePlanning.Controls.Add(this.txtWithDegrees);
            this.grbAirstrikePlanning.Controls.Add(this.label2);
            this.grbAirstrikePlanning.Controls.Add(this.grbKindBomb);
            this.grbAirstrikePlanning.Controls.Add(this.dateTimePicker1);
            this.grbAirstrikePlanning.Location = new System.Drawing.Point(12, 12);
            this.grbAirstrikePlanning.Name = "grbAirstrikePlanning";
            this.grbAirstrikePlanning.Size = new System.Drawing.Size(513, 320);
            this.grbAirstrikePlanning.TabIndex = 1;
            this.grbAirstrikePlanning.TabStop = false;
            this.grbAirstrikePlanning.Text = "Variables";
            // 
            // trbComposition1
            // 
            this.trbComposition1.Location = new System.Drawing.Point(96, 135);
            this.trbComposition1.Name = "trbComposition1";
            this.trbComposition1.Size = new System.Drawing.Size(399, 45);
            this.trbComposition1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of bombs:";
            // 
            // grbKindBomb
            // 
            this.grbKindBomb.Controls.Add(this.chbOnlyLocal);
            this.grbKindBomb.Controls.Add(this.label1);
            this.grbKindBomb.Controls.Add(this.chbIncludePrototype);
            this.grbKindBomb.Controls.Add(this.trbComposition1);
            this.grbKindBomb.Controls.Add(this.chbDistortLaunchSignal);
            this.grbKindBomb.Controls.Add(this.chbLongDistance);
            this.grbKindBomb.Controls.Add(this.chbIncludeImperialLogo);
            this.grbKindBomb.Controls.Add(this.rdbDistortion);
            this.grbKindBomb.Controls.Add(this.rdbNuclearRocket);
            this.grbKindBomb.Controls.Add(this.rdbARRTA);
            this.grbKindBomb.Controls.Add(this.rdbAuroraIndustriesAir);
            this.grbKindBomb.Controls.Add(this.rdbSmokey);
            this.grbKindBomb.Controls.Add(this.rdbAuroraIndustriesBee);
            this.grbKindBomb.Controls.Add(this.rebNonLeathalTeargass);
            this.grbKindBomb.Controls.Add(this.rdbHulluEstar);
            this.grbKindBomb.Controls.Add(this.grbStandardBULL);
            this.grbKindBomb.Controls.Add(this.rdbStandaardAXEL);
            this.grbKindBomb.Location = new System.Drawing.Point(6, 46);
            this.grbKindBomb.Name = "grbKindBomb";
            this.grbKindBomb.Size = new System.Drawing.Size(501, 193);
            this.grbKindBomb.TabIndex = 3;
            this.grbKindBomb.TabStop = false;
            this.grbKindBomb.Text = "Bombs";
            // 
            // rdbStandaardAXEL
            // 
            this.rdbStandaardAXEL.AutoSize = true;
            this.rdbStandaardAXEL.Location = new System.Drawing.Point(7, 20);
            this.rdbStandaardAXEL.Name = "rdbStandaardAXEL";
            this.rdbStandaardAXEL.Size = new System.Drawing.Size(98, 17);
            this.rdbStandaardAXEL.TabIndex = 0;
            this.rdbStandaardAXEL.TabStop = true;
            this.rdbStandaardAXEL.Text = "Standard AXEL";
            this.rdbStandaardAXEL.UseVisualStyleBackColor = true;
            // 
            // grbStandardBULL
            // 
            this.grbStandardBULL.AutoSize = true;
            this.grbStandardBULL.Location = new System.Drawing.Point(7, 43);
            this.grbStandardBULL.Name = "grbStandardBULL";
            this.grbStandardBULL.Size = new System.Drawing.Size(98, 17);
            this.grbStandardBULL.TabIndex = 0;
            this.grbStandardBULL.TabStop = true;
            this.grbStandardBULL.Text = "Standard BULL";
            this.grbStandardBULL.UseVisualStyleBackColor = true;
            // 
            // rebNonLeathalTeargass
            // 
            this.rebNonLeathalTeargass.AutoSize = true;
            this.rebNonLeathalTeargass.Location = new System.Drawing.Point(7, 66);
            this.rebNonLeathalTeargass.Name = "rebNonLeathalTeargass";
            this.rebNonLeathalTeargass.Size = new System.Drawing.Size(116, 17);
            this.rebNonLeathalTeargass.TabIndex = 0;
            this.rebNonLeathalTeargass.TabStop = true;
            this.rebNonLeathalTeargass.Text = "Non lethal teargass";
            this.rebNonLeathalTeargass.UseVisualStyleBackColor = true;
            // 
            // rdbSmokey
            // 
            this.rdbSmokey.AutoSize = true;
            this.rdbSmokey.Location = new System.Drawing.Point(7, 89);
            this.rdbSmokey.Name = "rdbSmokey";
            this.rdbSmokey.Size = new System.Drawing.Size(91, 17);
            this.rdbSmokey.TabIndex = 0;
            this.rdbSmokey.TabStop = true;
            this.rdbSmokey.Text = "Smokey (V23)";
            this.rdbSmokey.UseVisualStyleBackColor = true;
            // 
            // rdbARRTA
            // 
            this.rdbARRTA.AutoSize = true;
            this.rdbARRTA.Location = new System.Drawing.Point(7, 112);
            this.rdbARRTA.Name = "rdbARRTA";
            this.rdbARRTA.Size = new System.Drawing.Size(62, 17);
            this.rdbARRTA.TabIndex = 0;
            this.rdbARRTA.TabStop = true;
            this.rdbARRTA.Text = "ARRTA";
            this.rdbARRTA.UseVisualStyleBackColor = true;
            // 
            // rdbHulluEstar
            // 
            this.rdbHulluEstar.AutoSize = true;
            this.rdbHulluEstar.Location = new System.Drawing.Point(139, 20);
            this.rdbHulluEstar.Name = "rdbHulluEstar";
            this.rdbHulluEstar.Size = new System.Drawing.Size(63, 17);
            this.rdbHulluEstar.TabIndex = 0;
            this.rdbHulluEstar.TabStop = true;
            this.rdbHulluEstar.Text = "Hullu E*";
            this.rdbHulluEstar.UseVisualStyleBackColor = true;
            // 
            // rdbAuroraIndustriesBee
            // 
            this.rdbAuroraIndustriesBee.AutoSize = true;
            this.rdbAuroraIndustriesBee.Location = new System.Drawing.Point(139, 43);
            this.rdbAuroraIndustriesBee.Name = "rdbAuroraIndustriesBee";
            this.rdbAuroraIndustriesBee.Size = new System.Drawing.Size(126, 17);
            this.rdbAuroraIndustriesBee.TabIndex = 0;
            this.rdbAuroraIndustriesBee.TabStop = true;
            this.rdbAuroraIndustriesBee.Text = "Aurora Industries Bee";
            this.rdbAuroraIndustriesBee.UseVisualStyleBackColor = true;
            // 
            // rdbAuroraIndustriesAir
            // 
            this.rdbAuroraIndustriesAir.AutoSize = true;
            this.rdbAuroraIndustriesAir.Location = new System.Drawing.Point(139, 66);
            this.rdbAuroraIndustriesAir.Name = "rdbAuroraIndustriesAir";
            this.rdbAuroraIndustriesAir.Size = new System.Drawing.Size(119, 17);
            this.rdbAuroraIndustriesAir.TabIndex = 0;
            this.rdbAuroraIndustriesAir.TabStop = true;
            this.rdbAuroraIndustriesAir.Text = "Aurora Industries Air";
            this.rdbAuroraIndustriesAir.UseVisualStyleBackColor = true;
            // 
            // rdbNuclearRocket
            // 
            this.rdbNuclearRocket.AutoSize = true;
            this.rdbNuclearRocket.Location = new System.Drawing.Point(139, 89);
            this.rdbNuclearRocket.Name = "rdbNuclearRocket";
            this.rdbNuclearRocket.Size = new System.Drawing.Size(100, 17);
            this.rdbNuclearRocket.TabIndex = 0;
            this.rdbNuclearRocket.TabStop = true;
            this.rdbNuclearRocket.Text = "Nuclear Rocket";
            this.rdbNuclearRocket.UseVisualStyleBackColor = true;
            // 
            // rdbDistortion
            // 
            this.rdbDistortion.AutoSize = true;
            this.rdbDistortion.Location = new System.Drawing.Point(139, 112);
            this.rdbDistortion.Name = "rdbDistortion";
            this.rdbDistortion.Size = new System.Drawing.Size(69, 17);
            this.rdbDistortion.TabIndex = 0;
            this.rdbDistortion.TabStop = true;
            this.rdbDistortion.Text = "Distortion";
            this.rdbDistortion.UseVisualStyleBackColor = true;
            // 
            // chbIncludeImperialLogo
            // 
            this.chbIncludeImperialLogo.AutoSize = true;
            this.chbIncludeImperialLogo.Location = new System.Drawing.Point(296, 21);
            this.chbIncludeImperialLogo.Name = "chbIncludeImperialLogo";
            this.chbIncludeImperialLogo.Size = new System.Drawing.Size(122, 17);
            this.chbIncludeImperialLogo.TabIndex = 1;
            this.chbIncludeImperialLogo.Text = "Include imperial logo";
            this.chbIncludeImperialLogo.UseVisualStyleBackColor = true;
            // 
            // chbLongDistance
            // 
            this.chbLongDistance.AutoSize = true;
            this.chbLongDistance.Location = new System.Drawing.Point(296, 43);
            this.chbLongDistance.Name = "chbLongDistance";
            this.chbLongDistance.Size = new System.Drawing.Size(199, 17);
            this.chbLongDistance.TabIndex = 1;
            this.chbLongDistance.Text = "Long distance (more easily detected)";
            this.chbLongDistance.UseVisualStyleBackColor = true;
            // 
            // chbDistortLaunchSignal
            // 
            this.chbDistortLaunchSignal.AutoSize = true;
            this.chbDistortLaunchSignal.Location = new System.Drawing.Point(296, 66);
            this.chbDistortLaunchSignal.Name = "chbDistortLaunchSignal";
            this.chbDistortLaunchSignal.Size = new System.Drawing.Size(127, 17);
            this.chbDistortLaunchSignal.TabIndex = 1;
            this.chbDistortLaunchSignal.Text = "Distort Launch Signal";
            this.chbDistortLaunchSignal.UseVisualStyleBackColor = true;
            // 
            // chbIncludePrototype
            // 
            this.chbIncludePrototype.AutoSize = true;
            this.chbIncludePrototype.Location = new System.Drawing.Point(296, 89);
            this.chbIncludePrototype.Name = "chbIncludePrototype";
            this.chbIncludePrototype.Size = new System.Drawing.Size(113, 17);
            this.chbIncludePrototype.TabIndex = 1;
            this.chbIncludePrototype.Text = "Include prototypes";
            this.chbIncludePrototype.UseVisualStyleBackColor = true;
            // 
            // chbOnlyLocal
            // 
            this.chbOnlyLocal.AutoSize = true;
            this.chbOnlyLocal.Location = new System.Drawing.Point(296, 112);
            this.chbOnlyLocal.Name = "chbOnlyLocal";
            this.chbOnlyLocal.Size = new System.Drawing.Size(106, 17);
            this.chbOnlyLocal.TabIndex = 1;
            this.chbOnlyLocal.Text = "Only local bombs";
            this.chbOnlyLocal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coordinates:";
            // 
            // txtWithDegrees
            // 
            this.txtWithDegrees.Location = new System.Drawing.Point(85, 243);
            this.txtWithDegrees.Name = "txtWithDegrees";
            this.txtWithDegrees.Size = new System.Drawing.Size(26, 20);
            this.txtWithDegrees.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time (HH:MM:SS):";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(324, 22);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(177, 20);
            this.txtTime.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "°";
            // 
            // cmbNoordZuid
            // 
            this.cmbNoordZuid.FormattingEnabled = true;
            this.cmbNoordZuid.Items.AddRange(new object[] {
            "N",
            "S"});
            this.cmbNoordZuid.Location = new System.Drawing.Point(230, 243);
            this.cmbNoordZuid.Name = "cmbNoordZuid";
            this.cmbNoordZuid.Size = new System.Drawing.Size(46, 21);
            this.cmbNoordZuid.TabIndex = 9;
            // 
            // txtWithMinutes
            // 
            this.txtWithMinutes.Location = new System.Drawing.Point(134, 243);
            this.txtWithMinutes.Name = "txtWithMinutes";
            this.txtWithMinutes.Size = new System.Drawing.Size(26, 20);
            this.txtWithMinutes.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(9, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "\'";
            // 
            // txtWidthSeconds
            // 
            this.txtWidthSeconds.Location = new System.Drawing.Point(181, 243);
            this.txtWidthSeconds.Name = "txtWidthSeconds";
            this.txtWidthSeconds.Size = new System.Drawing.Size(26, 20);
            this.txtWidthSeconds.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "\'\'";
            // 
            // txtHeightDegree
            // 
            this.txtHeightDegree.Location = new System.Drawing.Point(310, 242);
            this.txtHeightDegree.Name = "txtHeightDegree";
            this.txtHeightDegree.Size = new System.Drawing.Size(26, 20);
            this.txtHeightDegree.TabIndex = 5;
            // 
            // txtHeightMinute
            // 
            this.txtHeightMinute.Location = new System.Drawing.Point(359, 242);
            this.txtHeightMinute.Name = "txtHeightMinute";
            this.txtHeightMinute.Size = new System.Drawing.Size(26, 20);
            this.txtHeightMinute.TabIndex = 5;
            // 
            // txtHeightSeconds
            // 
            this.txtHeightSeconds.Location = new System.Drawing.Point(406, 242);
            this.txtHeightSeconds.Name = "txtHeightSeconds";
            this.txtHeightSeconds.Size = new System.Drawing.Size(26, 20);
            this.txtHeightSeconds.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "°";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(9, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "\'";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(438, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "\'\'";
            // 
            // cmbOostWest
            // 
            this.cmbOostWest.FormattingEnabled = true;
            this.cmbOostWest.Items.AddRange(new object[] {
            "E",
            "W"});
            this.cmbOostWest.Location = new System.Drawing.Point(455, 242);
            this.cmbOostWest.Name = "cmbOostWest";
            this.cmbOostWest.Size = new System.Drawing.Size(46, 21);
            this.cmbOostWest.TabIndex = 9;
            // 
            // frmAirstrike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbAirstrikePlanning);
            this.Name = "frmAirstrike";
            this.Text = "Airstrike planner";
            this.grbAirstrikePlanning.ResumeLayout(false);
            this.grbAirstrikePlanning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbComposition1)).EndInit();
            this.grbKindBomb.ResumeLayout(false);
            this.grbKindBomb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox grbAirstrikePlanning;
        private System.Windows.Forms.GroupBox grbKindBomb;
        private System.Windows.Forms.RadioButton grbStandardBULL;
        private System.Windows.Forms.RadioButton rdbStandaardAXEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbComposition1;
        private System.Windows.Forms.CheckBox chbIncludeImperialLogo;
        private System.Windows.Forms.RadioButton rdbDistortion;
        private System.Windows.Forms.RadioButton rdbNuclearRocket;
        private System.Windows.Forms.RadioButton rdbARRTA;
        private System.Windows.Forms.RadioButton rdbAuroraIndustriesAir;
        private System.Windows.Forms.RadioButton rdbSmokey;
        private System.Windows.Forms.RadioButton rdbAuroraIndustriesBee;
        private System.Windows.Forms.RadioButton rebNonLeathalTeargass;
        private System.Windows.Forms.RadioButton rdbHulluEstar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbOnlyLocal;
        private System.Windows.Forms.CheckBox chbIncludePrototype;
        private System.Windows.Forms.CheckBox chbDistortLaunchSignal;
        private System.Windows.Forms.CheckBox chbLongDistance;
        private System.Windows.Forms.TextBox txtWithDegrees;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNoordZuid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWithMinutes;
        private System.Windows.Forms.ComboBox cmbOostWest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHeightSeconds;
        private System.Windows.Forms.TextBox txtHeightMinute;
        private System.Windows.Forms.TextBox txtWidthSeconds;
        private System.Windows.Forms.TextBox txtHeightDegree;
    }
}