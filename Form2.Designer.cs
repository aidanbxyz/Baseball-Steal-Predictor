namespace stealpredictor
{
    partial class creditsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(creditsWindow));
            this.ctext1 = new System.Windows.Forms.Label();
            this.clink1 = new System.Windows.Forms.LinkLabel();
            this.ctext2 = new System.Windows.Forms.Label();
            this.clink2 = new System.Windows.Forms.LinkLabel();
            this.dlfromtext = new System.Windows.Forms.Label();
            this.dllink = new System.Windows.Forms.LinkLabel();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctext1
            // 
            this.ctext1.AutoSize = true;
            this.ctext1.Font = new System.Drawing.Font("Veteran Typewriter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctext1.Location = new System.Drawing.Point(297, 41);
            this.ctext1.Name = "ctext1";
            this.ctext1.Size = new System.Drawing.Size(207, 36);
            this.ctext1.TabIndex = 0;
            this.ctext1.Text = "Inspired by:";
            // 
            // clink1
            // 
            this.clink1.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
            this.clink1.AutoSize = true;
            this.clink1.DisabledLinkColor = System.Drawing.SystemColors.ControlText;
            this.clink1.LinkColor = System.Drawing.SystemColors.ControlText;
            this.clink1.Location = new System.Drawing.Point(345, 93);
            this.clink1.Name = "clink1";
            this.clink1.Size = new System.Drawing.Size(110, 13);
            this.clink1.TabIndex = 1;
            this.clink1.TabStop = true;
            this.clink1.Text = "Jabrils\' Steal Predictor";
            this.clink1.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            this.clink1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clink1_LinkClicked);
            // 
            // ctext2
            // 
            this.ctext2.AutoSize = true;
            this.ctext2.Font = new System.Drawing.Font("Veteran Typewriter", 24F, System.Drawing.FontStyle.Bold);
            this.ctext2.Location = new System.Drawing.Point(353, 129);
            this.ctext2.Name = "ctext2";
            this.ctext2.Size = new System.Drawing.Size(94, 36);
            this.ctext2.TabIndex = 2;
            this.ctext2.Text = "Font:";
            // 
            // clink2
            // 
            this.clink2.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
            this.clink2.AutoSize = true;
            this.clink2.DisabledLinkColor = System.Drawing.SystemColors.ControlText;
            this.clink2.LinkColor = System.Drawing.SystemColors.ControlText;
            this.clink2.Location = new System.Drawing.Point(352, 175);
            this.clink2.Name = "clink2";
            this.clink2.Size = new System.Drawing.Size(96, 13);
            this.clink2.TabIndex = 3;
            this.clink2.TabStop = true;
            this.clink2.Text = "Veteran Typewriter";
            this.clink2.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            this.clink2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clink2_LinkClicked);
            // 
            // dlfromtext
            // 
            this.dlfromtext.AutoSize = true;
            this.dlfromtext.Font = new System.Drawing.Font("Veteran Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlfromtext.Location = new System.Drawing.Point(641, 394);
            this.dlfromtext.Name = "dlfromtext";
            this.dlfromtext.Size = new System.Drawing.Size(147, 12);
            this.dlfromtext.TabIndex = 5;
            this.dlfromtext.Text = "downloaded from aidanb.xyz";
            // 
            // dllink
            // 
            this.dllink.AutoSize = true;
            this.dllink.Font = new System.Drawing.Font("Veteran Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dllink.Location = new System.Drawing.Point(12, 394);
            this.dllink.Name = "dllink";
            this.dllink.Size = new System.Drawing.Size(161, 12);
            this.dllink.TabIndex = 4;
            this.dllink.TabStop = true;
            this.dllink.Text = "DOWNLOAD FROM OFFICIAL SITE";
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Veteran Typewriter", 8.25F);
            this.exit.Location = new System.Drawing.Point(713, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 6;
            this.exit.Text = "Back";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // creditsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dlfromtext);
            this.Controls.Add(this.dllink);
            this.Controls.Add(this.clink2);
            this.Controls.Add(this.ctext2);
            this.Controls.Add(this.clink1);
            this.Controls.Add(this.ctext1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "creditsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ctext1;
        private System.Windows.Forms.LinkLabel clink1;
        private System.Windows.Forms.Label ctext2;
        private System.Windows.Forms.LinkLabel clink2;
        private System.Windows.Forms.Label dlfromtext;
        private System.Windows.Forms.LinkLabel dllink;
        private System.Windows.Forms.Button exit;
    }
}