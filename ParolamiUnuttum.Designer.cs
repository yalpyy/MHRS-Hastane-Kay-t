namespace HastaneKayit
{
    partial class ParolamiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParolamiUnuttum));
            this.button1 = new System.Windows.Forms.Button();
            this.maskedtxtTC = new System.Windows.Forms.MaskedTextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pkapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(-78, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedtxtTC
            // 
            this.maskedtxtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedtxtTC.Location = new System.Drawing.Point(197, 68);
            this.maskedtxtTC.Mask = "00000000000";
            this.maskedtxtTC.Name = "maskedtxtTC";
            this.maskedtxtTC.Size = new System.Drawing.Size(90, 22);
            this.maskedtxtTC.TabIndex = 4;
            this.maskedtxtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedtxtTC_KeyPress);
            // 
            // btnGonder
            // 
            this.btnGonder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGonder.Location = new System.Drawing.Point(309, 105);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(104, 31);
            this.btnGonder.TabIndex = 8;
            this.btnGonder.Text = "GÖNDER";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(21, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lütfen yukarıdan hatırlatma yöntemini seçerek gerekli \r\nalanları doldurduktan son" +
    "ra gönder düğmesine tıklayınız. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "T.C. Kimlik Numarası";
            // 
            // Pkapat
            // 
            this.Pkapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pkapat.BackgroundImage")));
            this.Pkapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pkapat.FlatAppearance.BorderSize = 0;
            this.Pkapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pkapat.Location = new System.Drawing.Point(356, 12);
            this.Pkapat.Name = "Pkapat";
            this.Pkapat.Size = new System.Drawing.Size(57, 51);
            this.Pkapat.TabIndex = 19;
            this.Pkapat.UseVisualStyleBackColor = true;
            this.Pkapat.Click += new System.EventHandler(this.Pkapat_Click);
            // 
            // ParolamiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Beige;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(425, 202);
            this.Controls.Add(this.Pkapat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedtxtTC);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 202);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(425, 202);
            this.Name = "ParolamiUnuttum";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Parola Hatırlatma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParolamiUnuttum_FormClosed);
            this.Load += new System.EventHandler(this.ParolamiUnuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedtxtTC;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Pkapat;
    }
}