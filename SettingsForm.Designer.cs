
namespace EpsonConnector
{
    partial class SettingsForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.musteriAdi = new System.Windows.Forms.TextBox();
            this.sunucuIp = new System.Windows.Forms.TextBox();
            this.yaziciAdi = new System.Windows.Forms.ComboBox();
            this.sablonPath = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.editorPath = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "Dosya seç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(380, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(461, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 19;
            this.button2.Text = "Onayla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(18, 274);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(518, 31);
            this.sifre.TabIndex = 13;
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Location = new System.Drawing.Point(18, 214);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(518, 31);
            this.kullaniciAdi.TabIndex = 14;
            // 
            // musteriAdi
            // 
            this.musteriAdi.Location = new System.Drawing.Point(18, 154);
            this.musteriAdi.Name = "musteriAdi";
            this.musteriAdi.Size = new System.Drawing.Size(518, 31);
            this.musteriAdi.TabIndex = 15;
            // 
            // sunucuIp
            // 
            this.sunucuIp.Location = new System.Drawing.Point(18, 94);
            this.sunucuIp.Name = "sunucuIp";
            this.sunucuIp.Size = new System.Drawing.Size(518, 31);
            this.sunucuIp.TabIndex = 16;
            // 
            // yaziciAdi
            // 
            this.yaziciAdi.DisplayMember = "Name";
            this.yaziciAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yaziciAdi.FormattingEnabled = true;
            this.yaziciAdi.Location = new System.Drawing.Point(18, 34);
            this.yaziciAdi.Name = "yaziciAdi";
            this.yaziciAdi.Size = new System.Drawing.Size(518, 31);
            this.yaziciAdi.TabIndex = 12;
            // 
            // sablonPath
            // 
            this.sablonPath.AutoSize = true;
            this.sablonPath.Font = new System.Drawing.Font("Calibri", 10F);
            this.sablonPath.Location = new System.Drawing.Point(139, 342);
            this.sablonPath.Name = "sablonPath";
            this.sablonPath.Size = new System.Drawing.Size(0, 17);
            this.sablonPath.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(14, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Etiket Şablonu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(14, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(14, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Müşteri Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sunucu IP Adresi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Yazıcı Adı";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "leb";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "LEB dosyası|*.leb";
            this.openFileDialog1.Title = "Şablon dosyasını seçin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(14, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Editör Konumu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F);
            this.label8.Location = new System.Drawing.Point(139, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 31);
            this.button4.TabIndex = 17;
            this.button4.Text = "Konum seç";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // editorPath
            // 
            this.editorPath.AutoSize = true;
            this.editorPath.Font = new System.Drawing.Font("Calibri", 10F);
            this.editorPath.Location = new System.Drawing.Point(139, 401);
            this.editorPath.Name = "editorPath";
            this.editorPath.Size = new System.Drawing.Size(0, 17);
            this.editorPath.TabIndex = 20;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.DefaultExt = "exe";
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "EXE dosyası|*.exe";
            this.openFileDialog2.Title = "Editör uygulamasını seçin";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 473);
            this.Controls.Add(this.editorPath);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.musteriAdi);
            this.Controls.Add(this.sunucuIp);
            this.Controls.Add(this.yaziciAdi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sablonPath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.TextBox musteriAdi;
        private System.Windows.Forms.TextBox sunucuIp;
        private System.Windows.Forms.ComboBox yaziciAdi;
        private System.Windows.Forms.Label sablonPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label editorPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

