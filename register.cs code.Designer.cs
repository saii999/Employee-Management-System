namespace WindowsFormsApp2
{
    partial class Register_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_page));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.regsignup_lkl = new System.Windows.Forms.LinkLabel();
            this.regalreadyacc_bt = new System.Windows.Forms.Button();
            this.regbutton = new System.Windows.Forms.Button();
            this.regspass_tb = new System.Windows.Forms.TextBox();
            this.reguname_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regmobnum_tb = new System.Windows.Forms.TextBox();
            this.regemail_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.regconfpass_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(858, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 644);
            this.panel1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Employee Management System";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // regsignup_lkl
            // 
            this.regsignup_lkl.AutoSize = true;
            this.regsignup_lkl.Location = new System.Drawing.Point(833, 572);
            this.regsignup_lkl.Name = "regsignup_lkl";
            this.regsignup_lkl.Size = new System.Drawing.Size(66, 20);
            this.regsignup_lkl.TabIndex = 21;
            this.regsignup_lkl.TabStop = true;
            this.regsignup_lkl.Text = "Sign Up";
            this.regsignup_lkl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.regsignup_lkl_LinkClicked);
            // 
            // regalreadyacc_bt
            // 
            this.regalreadyacc_bt.BackColor = System.Drawing.Color.Aqua;
            this.regalreadyacc_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regalreadyacc_bt.Location = new System.Drawing.Point(750, 489);
            this.regalreadyacc_bt.Name = "regalreadyacc_bt";
            this.regalreadyacc_bt.Size = new System.Drawing.Size(203, 67);
            this.regalreadyacc_bt.TabIndex = 19;
            this.regalreadyacc_bt.Text = "Already Have An Account";
            this.regalreadyacc_bt.UseVisualStyleBackColor = false;
            // 
            // regbutton
            // 
            this.regbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.regbutton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.regbutton.Location = new System.Drawing.Point(326, 546);
            this.regbutton.Name = "regbutton";
            this.regbutton.Size = new System.Drawing.Size(329, 46);
            this.regbutton.TabIndex = 18;
            this.regbutton.Text = "Register";
            this.regbutton.UseVisualStyleBackColor = false;
            this.regbutton.Click += new System.EventHandler(this.regbutton_Click);
            // 
            // regspass_tb
            // 
            this.regspass_tb.Location = new System.Drawing.Point(330, 178);
            this.regspass_tb.Name = "regspass_tb";
            this.regspass_tb.Size = new System.Drawing.Size(348, 26);
            this.regspass_tb.TabIndex = 16;
            // 
            // reguname_tb
            // 
            this.reguname_tb.Location = new System.Drawing.Point(330, 71);
            this.reguname_tb.Name = "reguname_tb";
            this.reguname_tb.Size = new System.Drawing.Size(348, 26);
            this.reguname_tb.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = " Set Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(325, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(50, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Register Page";
            // 
            // regmobnum_tb
            // 
            this.regmobnum_tb.Location = new System.Drawing.Point(326, 501);
            this.regmobnum_tb.Name = "regmobnum_tb";
            this.regmobnum_tb.Size = new System.Drawing.Size(348, 26);
            this.regmobnum_tb.TabIndex = 27;
            // 
            // regemail_tb
            // 
            this.regemail_tb.Location = new System.Drawing.Point(326, 386);
            this.regemail_tb.Name = "regemail_tb";
            this.regemail_tb.Size = new System.Drawing.Size(348, 26);
            this.regemail_tb.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Lime;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mobile Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Lime;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(321, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Email_ID";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(453, 618);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 20);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "RESET";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // regconfpass_tb
            // 
            this.regconfpass_tb.Location = new System.Drawing.Point(326, 277);
            this.regconfpass_tb.Name = "regconfpass_tb";
            this.regconfpass_tb.Size = new System.Drawing.Size(348, 26);
            this.regconfpass_tb.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Lime;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(321, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "Confirm Password";
            // 
            // Register_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 647);
            this.Controls.Add(this.regconfpass_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.regmobnum_tb);
            this.Controls.Add(this.regemail_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.regsignup_lkl);
            this.Controls.Add(this.regalreadyacc_bt);
            this.Controls.Add(this.regbutton);
            this.Controls.Add(this.regspass_tb);
            this.Controls.Add(this.reguname_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Register_page";
            this.Text = "reguname_tb";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel regsignup_lkl;
        private System.Windows.Forms.Button regalreadyacc_bt;
        private System.Windows.Forms.Button regbutton;
        private System.Windows.Forms.TextBox regspass_tb;
        private System.Windows.Forms.TextBox reguname_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox regmobnum_tb;
        private System.Windows.Forms.TextBox regemail_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox regconfpass_tb;
        private System.Windows.Forms.Label label7;
    }
}