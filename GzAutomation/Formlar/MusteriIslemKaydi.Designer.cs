namespace GzAutomation.Formlar
{
    partial class MusteriIslemKaydi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AlinanUcretTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NotTxtBox = new System.Windows.Forms.TextBox();
            this.UygIslemTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.islemtarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MsCepTelTxtBox = new System.Windows.Forms.TextBox();
            this.MsAdSoyadTxtBox = new System.Windows.Forms.TextBox();
            this.VazgecBtn = new System.Windows.Forms.Button();
            this.KaydetBtn = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.TopPanel.Size = new System.Drawing.Size(670, 72);
            this.TopPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(230, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri İşlem Kaydı";
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackgroundImage = global::GzAutomation.Properties.Resources.icon;
            this.Exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exitbutton.FlatAppearance.BorderSize = 0;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Location = new System.Drawing.Point(635, 0);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(35, 33);
            this.Exitbutton.TabIndex = 0;
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AlinanUcretTxtBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.NotTxtBox);
            this.groupBox2.Controls.Add(this.UygIslemTxtBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.islemtarihi);
            this.groupBox2.Location = new System.Drawing.Point(42, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 317);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yapılan İşlemler";
            // 
            // AlinanUcretTxtBox
            // 
            this.AlinanUcretTxtBox.Location = new System.Drawing.Point(44, 250);
            this.AlinanUcretTxtBox.Name = "AlinanUcretTxtBox";
            this.AlinanUcretTxtBox.Size = new System.Drawing.Size(100, 20);
            this.AlinanUcretTxtBox.TabIndex = 5;
            this.AlinanUcretTxtBox.TextChanged += new System.EventHandler(this.AlinanUcretTxtBox_TextChanged);
            this.AlinanUcretTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlinanUcretTxtBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Alınan Ücret";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Not";
            // 
            // NotTxtBox
            // 
            this.NotTxtBox.Location = new System.Drawing.Point(386, 107);
            this.NotTxtBox.Multiline = true;
            this.NotTxtBox.Name = "NotTxtBox";
            this.NotTxtBox.Size = new System.Drawing.Size(206, 52);
            this.NotTxtBox.TabIndex = 4;
            // 
            // UygIslemTxtBox
            // 
            this.UygIslemTxtBox.Location = new System.Drawing.Point(44, 107);
            this.UygIslemTxtBox.Multiline = true;
            this.UygIslemTxtBox.Name = "UygIslemTxtBox";
            this.UygIslemTxtBox.Size = new System.Drawing.Size(320, 124);
            this.UygIslemTxtBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Uygulanan işlem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "İşlem Tarihi";
            // 
            // islemtarihi
            // 
            this.islemtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.islemtarihi.Location = new System.Drawing.Point(44, 50);
            this.islemtarihi.Name = "islemtarihi";
            this.islemtarihi.Size = new System.Drawing.Size(109, 20);
            this.islemtarihi.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MsCepTelTxtBox);
            this.groupBox1.Controls.Add(this.MsAdSoyadTxtBox);
            this.groupBox1.Location = new System.Drawing.Point(42, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşterinin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cep Telefonu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı Soyadı";
            // 
            // MsCepTelTxtBox
            // 
            this.MsCepTelTxtBox.Location = new System.Drawing.Point(322, 18);
            this.MsCepTelTxtBox.Name = "MsCepTelTxtBox";
            this.MsCepTelTxtBox.ReadOnly = true;
            this.MsCepTelTxtBox.Size = new System.Drawing.Size(100, 20);
            this.MsCepTelTxtBox.TabIndex = 0;
            // 
            // MsAdSoyadTxtBox
            // 
            this.MsAdSoyadTxtBox.Location = new System.Drawing.Point(97, 22);
            this.MsAdSoyadTxtBox.Name = "MsAdSoyadTxtBox";
            this.MsAdSoyadTxtBox.ReadOnly = true;
            this.MsAdSoyadTxtBox.Size = new System.Drawing.Size(100, 20);
            this.MsAdSoyadTxtBox.TabIndex = 0;
            // 
            // VazgecBtn
            // 
            this.VazgecBtn.BackColor = System.Drawing.Color.Red;
            this.VazgecBtn.FlatAppearance.BorderSize = 0;
            this.VazgecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VazgecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VazgecBtn.Location = new System.Drawing.Point(327, 466);
            this.VazgecBtn.Name = "VazgecBtn";
            this.VazgecBtn.Size = new System.Drawing.Size(122, 38);
            this.VazgecBtn.TabIndex = 8;
            this.VazgecBtn.Text = "Vazgeç\r\n";
            this.VazgecBtn.UseVisualStyleBackColor = false;
            this.VazgecBtn.Click += new System.EventHandler(this.VazgecBtn_Click);
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.BackColor = System.Drawing.Color.Red;
            this.KaydetBtn.FlatAppearance.BorderSize = 0;
            this.KaydetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KaydetBtn.Location = new System.Drawing.Point(199, 466);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(122, 38);
            this.KaydetBtn.TabIndex = 7;
            this.KaydetBtn.Text = "Kaydet\r\n";
            this.KaydetBtn.UseVisualStyleBackColor = false;
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // MusteriIslemKaydi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 507);
            this.Controls.Add(this.VazgecBtn);
            this.Controls.Add(this.KaydetBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusteriIslemKaydi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriIslemKaydi";
            this.Load += new System.EventHandler(this.MusteriIslemKaydi_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MsAdSoyadTxtBox;
        private System.Windows.Forms.TextBox MsCepTelTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AlinanUcretTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NotTxtBox;
        private System.Windows.Forms.TextBox UygIslemTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker islemtarihi;
        private System.Windows.Forms.Button VazgecBtn;
        private System.Windows.Forms.Button KaydetBtn;
    }
}