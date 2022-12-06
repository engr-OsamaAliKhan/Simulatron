namespace Sumilatron
{
    partial class Form1
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
            this.t24c1 = new System.Windows.Forms.CheckBox();
            this.heading = new System.Windows.Forms.Label();
            this.host = new System.Windows.Forms.Label();
            this.ubps = new System.Windows.Forms.Label();
            this.ubpssim = new System.Windows.Forms.CheckBox();
            this.bbh = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.t24c2 = new System.Windows.Forms.CheckBox();
            this.t24c5 = new System.Windows.Forms.CheckBox();
            this.t24c4 = new System.Windows.Forms.CheckBox();
            this.t24c3 = new System.Windows.Forms.CheckBox();
            this.log = new System.Windows.Forms.Label();
            this.ipadd = new System.Windows.Forms.Label();
            this.selectall = new System.Windows.Forms.Button();
            this.deselectall = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t24c1
            // 
            this.t24c1.AutoSize = true;
            this.t24c1.Location = new System.Drawing.Point(40, 91);
            this.t24c1.Name = "t24c1";
            this.t24c1.Size = new System.Drawing.Size(83, 17);
            this.t24c1.TabIndex = 0;
            this.t24c1.Text = "T24C1 Host";
            this.t24c1.UseVisualStyleBackColor = true;
            this.t24c1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // heading
            // 
            this.heading.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.Location = new System.Drawing.Point(92, 9);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(177, 35);
            this.heading.TabIndex = 4;
            this.heading.Text = "Simulatron";
            this.heading.Click += new System.EventHandler(this.heading_Click);
            // 
            // host
            // 
            this.host.AutoSize = true;
            this.host.Location = new System.Drawing.Point(37, 60);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(103, 13);
            this.host.TabIndex = 5;
            this.host.Text = "Bank Host Simulator";
            this.host.Click += new System.EventHandler(this.label1_Click);
            // 
            // ubps
            // 
            this.ubps.AutoSize = true;
            this.ubps.Location = new System.Drawing.Point(218, 60);
            this.ubps.Name = "ubps";
            this.ubps.Size = new System.Drawing.Size(82, 13);
            this.ubps.TabIndex = 6;
            this.ubps.Text = "UBPS Simulator";
            // 
            // ubpssim
            // 
            this.ubpssim.AutoSize = true;
            this.ubpssim.Location = new System.Drawing.Point(221, 91);
            this.ubpssim.Name = "ubpssim";
            this.ubpssim.Size = new System.Drawing.Size(82, 17);
            this.ubpssim.TabIndex = 7;
            this.ubpssim.Text = "UBPS-7777";
            this.ubpssim.UseVisualStyleBackColor = true;
            this.ubpssim.CheckedChanged += new System.EventHandler(this.ubpssim_CheckedChanged);
            // 
            // bbh
            // 
            this.bbh.AutoSize = true;
            this.bbh.Location = new System.Drawing.Point(218, 120);
            this.bbh.Name = "bbh";
            this.bbh.Size = new System.Drawing.Size(92, 13);
            this.bbh.TabIndex = 8;
            this.bbh.Text = "BB Host Simulator";
            this.bbh.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(221, 251);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(98, 23);
            this.startbtn.TabIndex = 10;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // t24c2
            // 
            this.t24c2.AutoSize = true;
            this.t24c2.Location = new System.Drawing.Point(40, 119);
            this.t24c2.Name = "t24c2";
            this.t24c2.Size = new System.Drawing.Size(83, 17);
            this.t24c2.TabIndex = 11;
            this.t24c2.Text = "T24C2 Host";
            this.t24c2.UseVisualStyleBackColor = true;
            this.t24c2.CheckedChanged += new System.EventHandler(this.t24c2_CheckedChanged);
            // 
            // t24c5
            // 
            this.t24c5.AutoSize = true;
            this.t24c5.Location = new System.Drawing.Point(40, 152);
            this.t24c5.Name = "t24c5";
            this.t24c5.Size = new System.Drawing.Size(83, 17);
            this.t24c5.TabIndex = 12;
            this.t24c5.Text = "T24C5 Host";
            this.t24c5.UseVisualStyleBackColor = true;
            this.t24c5.CheckedChanged += new System.EventHandler(this.t24c3_CheckedChanged);
            // 
            // t24c4
            // 
            this.t24c4.AutoSize = true;
            this.t24c4.Location = new System.Drawing.Point(40, 187);
            this.t24c4.Name = "t24c4";
            this.t24c4.Size = new System.Drawing.Size(83, 17);
            this.t24c4.TabIndex = 13;
            this.t24c4.Text = "T24C4 Host";
            this.t24c4.UseVisualStyleBackColor = true;
            this.t24c4.CheckedChanged += new System.EventHandler(this.t24c4_CheckedChanged);
            // 
            // t24c3
            // 
            this.t24c3.AutoSize = true;
            this.t24c3.Location = new System.Drawing.Point(221, 152);
            this.t24c3.Name = "t24c3";
            this.t24c3.Size = new System.Drawing.Size(65, 17);
            this.t24c3.TabIndex = 14;
            this.t24c3.Text = "BB Host";
            this.t24c3.UseVisualStyleBackColor = true;
            this.t24c3.CheckedChanged += new System.EventHandler(this.bbhost_CheckedChanged);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(333, 152);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(177, 73);
            this.log.TabIndex = 15;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // ipadd
            // 
            this.ipadd.Location = new System.Drawing.Point(359, 251);
            this.ipadd.Name = "ipadd";
            this.ipadd.Size = new System.Drawing.Size(141, 23);
            this.ipadd.TabIndex = 16;
            this.ipadd.Click += new System.EventHandler(this.ipadd_Click);
            // 
            // selectall
            // 
            this.selectall.Location = new System.Drawing.Point(221, 222);
            this.selectall.Name = "selectall";
            this.selectall.Size = new System.Drawing.Size(97, 23);
            this.selectall.TabIndex = 17;
            this.selectall.Text = "Select All";
            this.selectall.UseVisualStyleBackColor = true;
            this.selectall.Click += new System.EventHandler(this.selectall_Click);
            // 
            // deselectall
            // 
            this.deselectall.Location = new System.Drawing.Point(40, 222);
            this.deselectall.Name = "deselectall";
            this.deselectall.Size = new System.Drawing.Size(81, 23);
            this.deselectall.TabIndex = 18;
            this.deselectall.Text = "Deselect All";
            this.deselectall.UseVisualStyleBackColor = true;
            this.deselectall.Click += new System.EventHandler(this.deselectall_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(40, 250);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(81, 23);
            this.close.TabIndex = 19;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 309);
            this.Controls.Add(this.close);
            this.Controls.Add(this.deselectall);
            this.Controls.Add(this.selectall);
            this.Controls.Add(this.ipadd);
            this.Controls.Add(this.log);
            this.Controls.Add(this.t24c3);
            this.Controls.Add(this.t24c4);
            this.Controls.Add(this.t24c5);
            this.Controls.Add(this.t24c2);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.bbh);
            this.Controls.Add(this.ubpssim);
            this.Controls.Add(this.ubps);
            this.Controls.Add(this.host);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.t24c1);
            this.Name = "Form1";
            this.Text = "Simulatron";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox t24c1;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label host;
        private System.Windows.Forms.Label ubps;
        private System.Windows.Forms.CheckBox ubpssim;
        private System.Windows.Forms.Label bbh;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.CheckBox t24c2;
        private System.Windows.Forms.CheckBox t24c5;
        private System.Windows.Forms.CheckBox t24c4;
        private System.Windows.Forms.CheckBox t24c3;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Label ipadd;
        private System.Windows.Forms.Button selectall;
        private System.Windows.Forms.Button deselectall;
        private System.Windows.Forms.Button close;
    }
}

