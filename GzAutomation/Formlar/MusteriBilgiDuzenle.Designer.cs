namespace GzAutomation.Formlar
{
    partial class MusteriBilgiDuzenle
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VazgecBtn = new System.Windows.Forms.Button();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.DogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CepTelTxtBox = new System.Windows.Forms.TextBox();
            this.EPostaTxtBox = new System.Windows.Forms.TextBox();
            this.AdSoyadTxtBox = new System.Windows.Forms.TextBox();
            this.TopPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Red;
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.Exitbutton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(828, 72);
            this.TopPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(283, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Bilgi Düzenle";
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackgroundImage = global::GzAutomation.Properties.Resources.icon;
            this.Exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exitbutton.FlatAppearance.BorderSize = 0;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Location = new System.Drawing.Point(793, 0);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(35, 33);
            this.Exitbutton.TabIndex = 0;
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VazgecBtn);
            this.groupBox1.Controls.Add(this.GuncelleBtn);
            this.groupBox1.Controls.Add(this.DogumTarihi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CepTelTxtBox);
            this.groupBox1.Controls.Add(this.EPostaTxtBox);
            this.groupBox1.Controls.Add(this.AdSoyadTxtBox);
            this.groupBox1.Location = new System.Drawing.Point(132, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 230);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşterinin";
            // 
            // VazgecBtn
            // 
            this.VazgecBtn.BackColor = System.Drawing.Color.Red;
            this.VazgecBtn.FlatAppearance.BorderSize = 0;
            this.VazgecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VazgecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VazgecBtn.Location = new System.Drawing.Point(280, 170);
            this.VazgecBtn.Name = "VazgecBtn";
            this.VazgecBtn.Size = new System.Drawing.Size(122, 38);
            this.VazgecBtn.TabIndex = 6;
            this.VazgecBtn.Text = "Vazgeç\r\n";
            this.VazgecBtn.UseVisualStyleBackColor = false;
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.BackColor = System.Drawing.Color.Red;
            this.GuncelleBtn.FlatAppearance.BorderSize = 0;
            this.GuncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuncelleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GuncelleBtn.Location = new System.Drawing.Point(143, 170);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(122, 38);
            this.GuncelleBtn.TabIndex = 5;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.UseVisualStyleBackColor = false;
            this.GuncelleBtn.Click += new System.EventHandler(this.GuncelleBtn_Click);
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.Location = new System.Drawing.Point(366, 33);
            this.DogumTarihi.Name = "DogumTarihi";
            this.DogumTarihi.Size = new System.Drawing.Size(175, 20);
            this.DogumTarihi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cep Telefonu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "E Posta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı Soyadı";
            // 
            // CepTelTxtBox
            // 
            this.CepTelTxtBox.Location = new System.Drawing.Point(366, 93);
            this.CepTelTxtBox.Name = "CepTelTxtBox";
            this.CepTelTxtBox.Size = new System.Drawing.Size(100, 20);
            this.CepTelTxtBox.TabIndex = 4;
            // 
            // EPostaTxtBox
            // 
            this.EPostaTxtBox.Location = new System.Drawing.Point(131, 93);
            this.EPostaTxtBox.Name = "EPostaTxtBox";
            this.EPostaTxtBox.Size = new System.Drawing.Size(100, 20);
            this.EPostaTxtBox.TabIndex = 3;
            // 
            // AdSoyadTxtBox
            // 
            this.AdSoyadTxtBox.Location = new System.Drawing.Point(131, 41);
            this.AdSoyadTxtBox.Name = "AdSoyadTxtBox";
            this.AdSoyadTxtBox.Size = new System.Drawing.Size(100, 20);
            this.AdSoyadTxtBox.TabIndex = 1;
            // 
            // MusteriBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusteriBilgiDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriBilgiDuzenle";
            this.Load += new System.EventHandler(this.MusteriBilgiDuzenle_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button VazgecBtn;
        private System.Windows.Forms.Button GuncelleBtn;
        private System.Windows.Forms.DateTimePicker DogumTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CepTelTxtBox;
        private System.Windows.Forms.TextBox EPostaTxtBox;
        private System.Windows.Forms.TextBox AdSoyadTxtBox;
    }
}