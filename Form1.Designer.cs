namespace stealpredictor
{
    partial class variableSetWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(variableSetWindow));
            this.bsp = new System.Windows.Forms.Label();
            this.creditsButton = new System.Windows.Forms.Button();
            this.dllink = new System.Windows.Forms.LinkLabel();
            this.dlfromtext = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.varDefineText = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.TextBox();
            this.option2 = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.option4 = new System.Windows.Forms.TextBox();
            this.option5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.option6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.option7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.option8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.option9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.option0 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bsp
            // 
            this.bsp.AutoSize = true;
            this.bsp.Font = new System.Drawing.Font("Veteran Typewriter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bsp.Location = new System.Drawing.Point(196, 9);
            this.bsp.Name = "bsp";
            this.bsp.Size = new System.Drawing.Size(409, 36);
            this.bsp.TabIndex = 0;
            this.bsp.Text = "Baseball Steal Predictor";
            // 
            // creditsButton
            // 
            this.creditsButton.Font = new System.Drawing.Font("Veteran Typewriter", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsButton.Location = new System.Drawing.Point(339, 264);
            this.creditsButton.Name = "creditsButton";
            this.creditsButton.Size = new System.Drawing.Size(122, 46);
            this.creditsButton.TabIndex = 1;
            this.creditsButton.Text = "Credits";
            this.creditsButton.UseVisualStyleBackColor = true;
            this.creditsButton.Click += new System.EventHandler(this.creditsButton_Click);
            // 
            // dllink
            // 
            this.dllink.AutoSize = true;
            this.dllink.Location = new System.Drawing.Point(12, 394);
            this.dllink.Name = "dllink";
            this.dllink.Size = new System.Drawing.Size(161, 12);
            this.dllink.TabIndex = 2;
            this.dllink.TabStop = true;
            this.dllink.Text = "DOWNLOAD FROM OFFICIAL SITE";
            this.dllink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dllink_LinkClicked);
            // 
            // dlfromtext
            // 
            this.dlfromtext.AutoSize = true;
            this.dlfromtext.Location = new System.Drawing.Point(641, 394);
            this.dlfromtext.Name = "dlfromtext";
            this.dlfromtext.Size = new System.Drawing.Size(147, 12);
            this.dlfromtext.TabIndex = 3;
            this.dlfromtext.Text = "downloaded from aidanb.xyz";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Veteran Typewriter", 21.75F);
            this.startButton.Location = new System.Drawing.Point(339, 86);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(122, 46);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // varDefineText
            // 
            this.varDefineText.AutoSize = true;
            this.varDefineText.Font = new System.Drawing.Font("Veteran Typewriter", 24F, System.Drawing.FontStyle.Bold);
            this.varDefineText.Location = new System.Drawing.Point(294, 9);
            this.varDefineText.Name = "varDefineText";
            this.varDefineText.Size = new System.Drawing.Size(246, 36);
            this.varDefineText.TabIndex = 5;
            this.varDefineText.Text = "Define Signals";
            this.varDefineText.Visible = false;
            // 
            // option1
            // 
            this.option1.Location = new System.Drawing.Point(351, 48);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(120, 20);
            this.option1.TabIndex = 6;
            this.option1.Visible = false;
            // 
            // option2
            // 
            this.option2.Location = new System.Drawing.Point(351, 74);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(120, 20);
            this.option2.TabIndex = 7;
            this.option2.Visible = false;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Veteran Typewriter", 21.75F);
            this.submit.Location = new System.Drawing.Point(339, 316);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(120, 46);
            this.submit.TabIndex = 16;
            this.submit.Text = "SUBMIT";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Visible = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // option3
            // 
            this.option3.Location = new System.Drawing.Point(351, 100);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(120, 20);
            this.option3.TabIndex = 8;
            this.option3.Visible = false;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(713, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 17;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "1. ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "2. ";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "3. ";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "4. ";
            this.label4.Visible = false;
            // 
            // option4
            // 
            this.option4.Location = new System.Drawing.Point(351, 126);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(120, 20);
            this.option4.TabIndex = 9;
            this.option4.Visible = false;
            // 
            // option5
            // 
            this.option5.Location = new System.Drawing.Point(351, 152);
            this.option5.Name = "option5";
            this.option5.Size = new System.Drawing.Size(120, 20);
            this.option5.TabIndex = 10;
            this.option5.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "5. ";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "6. ";
            this.label6.Visible = false;
            // 
            // option6
            // 
            this.option6.Location = new System.Drawing.Point(351, 178);
            this.option6.Name = "option6";
            this.option6.Size = new System.Drawing.Size(120, 20);
            this.option6.TabIndex = 11;
            this.option6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "7. ";
            this.label7.Visible = false;
            // 
            // option7
            // 
            this.option7.Location = new System.Drawing.Point(351, 204);
            this.option7.Name = "option7";
            this.option7.Size = new System.Drawing.Size(120, 20);
            this.option7.TabIndex = 12;
            this.option7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "8. ";
            this.label8.Visible = false;
            // 
            // option8
            // 
            this.option8.Location = new System.Drawing.Point(351, 230);
            this.option8.Name = "option8";
            this.option8.Size = new System.Drawing.Size(120, 20);
            this.option8.TabIndex = 13;
            this.option8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "9. ";
            this.label9.Visible = false;
            // 
            // option9
            // 
            this.option9.Location = new System.Drawing.Point(351, 256);
            this.option9.Name = "option9";
            this.option9.Size = new System.Drawing.Size(120, 20);
            this.option9.TabIndex = 14;
            this.option9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(329, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 32;
            this.label10.Text = "0. ";
            this.label10.Visible = false;
            // 
            // option0
            // 
            this.option0.Location = new System.Drawing.Point(351, 282);
            this.option0.Name = "option0";
            this.option0.Size = new System.Drawing.Size(120, 20);
            this.option0.TabIndex = 15;
            this.option0.Visible = false;
            // 
            // variableSetWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.option0);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.option9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.option8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.option7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.option6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.option5);
            this.Controls.Add(this.option4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.varDefineText);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.dlfromtext);
            this.Controls.Add(this.dllink);
            this.Controls.Add(this.creditsButton);
            this.Controls.Add(this.bsp);
            this.Font = new System.Drawing.Font("Veteran Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "variableSetWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baseball Steal Predictor by aidanb.xyz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bsp;
        private System.Windows.Forms.Button creditsButton;
        private System.Windows.Forms.LinkLabel dllink;
        private System.Windows.Forms.Label dlfromtext;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label varDefineText;
        private System.Windows.Forms.TextBox option1;
        private System.Windows.Forms.TextBox option2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox option3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox option4;
        private System.Windows.Forms.TextBox option5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox option6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox option7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox option8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox option9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox option0;
    }
}

