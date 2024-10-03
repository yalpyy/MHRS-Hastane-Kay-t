namespace HastaneKayit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnParolamiUnuttum = new System.Windows.Forms.Button();
            this.btnYeniUye = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.maskedtxtTC = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.klavyeenter = new System.Windows.Forms.Button();
            this.klavye9 = new System.Windows.Forms.Button();
            this.klavye6 = new System.Windows.Forms.Button();
            this.klavye3 = new System.Windows.Forms.Button();
            this.klavye2 = new System.Windows.Forms.Button();
            this.klavye5 = new System.Windows.Forms.Button();
            this.klavye8 = new System.Windows.Forms.Button();
            this.klavye7 = new System.Windows.Forms.Button();
            this.klavye4 = new System.Windows.Forms.Button();
            this.klavye1 = new System.Windows.Forms.Button();
            this.klavye0 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.snlklavye = new System.Windows.Forms.Button();
            this.frm1kapat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGiris.Location = new System.Drawing.Point(410, 320);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(106, 40);
            this.btnGiris.TabIndex = 14;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnParolamiUnuttum
            // 
            this.btnParolamiUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.btnParolamiUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParolamiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParolamiUnuttum.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnParolamiUnuttum.Location = new System.Drawing.Point(151, 320);
            this.btnParolamiUnuttum.Name = "btnParolamiUnuttum";
            this.btnParolamiUnuttum.Size = new System.Drawing.Size(170, 40);
            this.btnParolamiUnuttum.TabIndex = 16;
            this.btnParolamiUnuttum.Text = "PAROLAMI UNUTTUM";
            this.btnParolamiUnuttum.UseVisualStyleBackColor = false;
            this.btnParolamiUnuttum.Click += new System.EventHandler(this.btnParolamiUnuttum_Click);
            // 
            // btnYeniUye
            // 
            this.btnYeniUye.BackColor = System.Drawing.Color.Transparent;
            this.btnYeniUye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniUye.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYeniUye.Location = new System.Drawing.Point(45, 320);
            this.btnYeniUye.Name = "btnYeniUye";
            this.btnYeniUye.Size = new System.Drawing.Size(100, 40);
            this.btnYeniUye.TabIndex = 15;
            this.btnYeniUye.Text = "YENİ ÜYE";
            this.btnYeniUye.UseVisualStyleBackColor = false;
            this.btnYeniUye.Click += new System.EventHandler(this.btnYeniUye_Click);
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.Location = new System.Drawing.Point(207, 269);
            this.txtParola.MaxLength = 11;
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '●';
            this.txtParola.Size = new System.Drawing.Size(309, 35);
            this.txtParola.TabIndex = 13;
            this.txtParola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParola_KeyPress);
            // 
            // maskedtxtTC
            // 
            this.maskedtxtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedtxtTC.Location = new System.Drawing.Point(207, 228);
            this.maskedtxtTC.Mask = "00000000000";
            this.maskedtxtTC.Name = "maskedtxtTC";
            this.maskedtxtTC.Size = new System.Drawing.Size(309, 35);
            this.maskedtxtTC.TabIndex = 12;
            this.maskedtxtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedtxtTC_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(41, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "T.C. Kimlik Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(132, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "HASTANE RANDEVU MERKEZİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(178, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "T.C. SAĞLIK BAKANLIĞI";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.klavyeenter);
            this.panel1.Controls.Add(this.klavye9);
            this.panel1.Controls.Add(this.klavye6);
            this.panel1.Controls.Add(this.klavye3);
            this.panel1.Controls.Add(this.klavye2);
            this.panel1.Controls.Add(this.klavye5);
            this.panel1.Controls.Add(this.klavye8);
            this.panel1.Controls.Add(this.klavye7);
            this.panel1.Controls.Add(this.klavye4);
            this.panel1.Controls.Add(this.klavye1);
            this.panel1.Controls.Add(this.klavye0);
            this.panel1.Location = new System.Drawing.Point(522, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 141);
            this.panel1.TabIndex = 20;
            // 
            // klavyeenter
            // 
            this.klavyeenter.BackColor = System.Drawing.Color.Beige;
            this.klavyeenter.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.klavyeenter.Location = new System.Drawing.Point(73, 99);
            this.klavyeenter.Name = "klavyeenter";
            this.klavyeenter.Size = new System.Drawing.Size(53, 23);
            this.klavyeenter.TabIndex = 139;
            this.klavyeenter.Text = "Enter";
            this.klavyeenter.UseVisualStyleBackColor = false;
            this.klavyeenter.Click += new System.EventHandler(this.klavyeenter_Click);
            // 
            // klavye9
            // 
            this.klavye9.BackColor = System.Drawing.Color.Beige;
            this.klavye9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.klavye9.Location = new System.Drawing.Point(95, 12);
            this.klavye9.Name = "klavye9";
            this.klavye9.Size = new System.Drawing.Size(31, 23);
            this.klavye9.TabIndex = 138;
            this.klavye9.Text = "9";
            this.klavye9.UseVisualStyleBackColor = false;
            this.klavye9.Click += new System.EventHandler(this.klavye9_Click);
            // 
            // klavye6
            // 
            this.klavye6.BackColor = System.Drawing.Color.Beige;
            this.klavye6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.klavye6.Location = new System.Drawing.Point(95, 41);
            this.klavye6.Name = "klavye6";
            this.klavye6.Size = new System.Drawing.Size(31, 23);
            this.klavye6.TabIndex = 137;
            this.klavye6.Text = "6";
            this.klavye6.UseVisualStyleBackColor = false;
            this.klavye6.Click += new System.EventHandler(this.klavye6_Click);
            // 
            // klavye3
            // 
            this.klavye3.BackColor = System.Drawing.Color.Beige;
            this.klavye3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.klavye3.Location = new System.Drawing.Point(95, 70);
            this.klavye3.Name = "klavye3";
            this.klavye3.Size = new System.Drawing.Size(31, 23);
            this.klavye3.TabIndex = 136;
            this.klavye3.Text = "3";
            this.klavye3.UseVisualStyleBackColor = false;
            this.klavye3.Click += new System.EventHandler(this.klavye3_Click);
            // 
            // klavye2
            // 
            this.klavye2.BackColor = System.Drawing.Color.Beige;
            this.klavye2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.klavye2.Location = new System.Drawing.Point(59, 70);
            this.klavye2.Name = "klavye2";
            this.klavye2.Size = new System.Drawing.Size(30, 23);
            this.klavye2.TabIndex = 134;
            this.klavye2.Text = "2";
            this.klavye2.UseVisualStyleBackColor = false;
            this.klavye2.Click += new System.EventHandler(this.klavye2_Click);
            // 
            // klavye5
            // 
            this.klavye5.BackColor = System.Drawing.Color.Beige;
            this.klavye5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.klavye5.Location = new System.Drawing.Point(59, 41);
            this.klavye5.Name = "klavye5";
            this.klavye5.Size = new System.Drawing.Size(30, 23);
            this.klavye5.TabIndex = 133;
            this.klavye5.Text = "5";
            this.klavye5.UseVisualStyleBackColor = false;
            this.klavye5.Click += new System.EventHandler(this.klavye5_Click);
            // 
            // klavye8
            // 
            this.klavye8.BackColor = System.Drawing.Color.Beige;
            this.klavye8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.klavye8.Location = new System.Drawing.Point(59, 12);
            this.klavye8.Name = "klavye8";
            this.klavye8.Size = new System.Drawing.Size(30, 23);
            this.klavye8.TabIndex = 132;
            this.klavye8.Text = "8";
            this.klavye8.UseVisualStyleBackColor = false;
            this.klavye8.Click += new System.EventHandler(this.klavye8_Click);
            // 
            // klavye7
            // 
            this.klavye7.BackColor = System.Drawing.Color.Beige;
            this.klavye7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.klavye7.Location = new System.Drawing.Point(23, 12);
            this.klavye7.Name = "klavye7";
            this.klavye7.Size = new System.Drawing.Size(30, 23);
            this.klavye7.TabIndex = 131;
            this.klavye7.Text = "7";
            this.klavye7.UseVisualStyleBackColor = false;
            this.klavye7.Click += new System.EventHandler(this.klavye7_Click);
            // 
            // klavye4
            // 
            this.klavye4.BackColor = System.Drawing.Color.Beige;
            this.klavye4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.klavye4.Location = new System.Drawing.Point(23, 41);
            this.klavye4.Name = "klavye4";
            this.klavye4.Size = new System.Drawing.Size(30, 23);
            this.klavye4.TabIndex = 130;
            this.klavye4.Text = "4";
            this.klavye4.UseVisualStyleBackColor = false;
            this.klavye4.Click += new System.EventHandler(this.klavye4_Click);
            // 
            // klavye1
            // 
            this.klavye1.BackColor = System.Drawing.Color.Beige;
            this.klavye1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.klavye1.Location = new System.Drawing.Point(23, 70);
            this.klavye1.Name = "klavye1";
            this.klavye1.Size = new System.Drawing.Size(30, 23);
            this.klavye1.TabIndex = 129;
            this.klavye1.Text = "1";
            this.klavye1.UseVisualStyleBackColor = false;
            this.klavye1.Click += new System.EventHandler(this.klavye1_Click);
            // 
            // klavye0
            // 
            this.klavye0.BackColor = System.Drawing.Color.Beige;
            this.klavye0.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.klavye0.Location = new System.Drawing.Point(23, 99);
            this.klavye0.Name = "klavye0";
            this.klavye0.Size = new System.Drawing.Size(48, 23);
            this.klavye0.TabIndex = 128;
            this.klavye0.Text = "0";
            this.klavye0.UseVisualStyleBackColor = false;
            this.klavye0.Click += new System.EventHandler(this.klavye0_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(540, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // snlklavye
            // 
            this.snlklavye.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("snlklavye.BackgroundImage")));
            this.snlklavye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snlklavye.FlatAppearance.BorderSize = 0;
            this.snlklavye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snlklavye.Location = new System.Drawing.Point(522, 271);
            this.snlklavye.Name = "snlklavye";
            this.snlklavye.Size = new System.Drawing.Size(39, 28);
            this.snlklavye.TabIndex = 19;
            this.snlklavye.UseVisualStyleBackColor = true;
            this.snlklavye.Click += new System.EventHandler(this.snlklavye_Click);
            // 
            // frm1kapat
            // 
            this.frm1kapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frm1kapat.BackgroundImage")));
            this.frm1kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frm1kapat.FlatAppearance.BorderSize = 0;
            this.frm1kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frm1kapat.Location = new System.Drawing.Point(632, 12);
            this.frm1kapat.Name = "frm1kapat";
            this.frm1kapat.Size = new System.Drawing.Size(57, 51);
            this.frm1kapat.TabIndex = 18;
            this.frm1kapat.UseVisualStyleBackColor = true;
            this.frm1kapat.Click += new System.EventHandler(this.frm1kapat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 66);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(736, 503);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.snlklavye);
            this.Controls.Add(this.frm1kapat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnParolamiUnuttum);
            this.Controls.Add(this.btnYeniUye);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.maskedtxtTC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                 ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnParolamiUnuttum;
        private System.Windows.Forms.Button btnYeniUye;
        private System.Windows.Forms.TextBox txtParola;
        public System.Windows.Forms.MaskedTextBox maskedtxtTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button frm1kapat;
        private System.Windows.Forms.Button snlklavye;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button klavyeenter;
        private System.Windows.Forms.Button klavye9;
        private System.Windows.Forms.Button klavye6;
        private System.Windows.Forms.Button klavye3;
        private System.Windows.Forms.Button klavye2;
        private System.Windows.Forms.Button klavye5;
        private System.Windows.Forms.Button klavye8;
        private System.Windows.Forms.Button klavye7;
        private System.Windows.Forms.Button klavye4;
        private System.Windows.Forms.Button klavye1;
        private System.Windows.Forms.Button klavye0;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}

