namespace GzAutomation.Formlar
{
    partial class Randevu
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
            this.Exitbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MsCepTelTxtbox = new System.Windows.Forms.TextBox();
            this.KontrolBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MsBilDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.YapIslemTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RndTarihDTPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RndSaatGrpBox = new System.Windows.Forms.GroupBox();
            this.VazgecBtn = new System.Windows.Forms.Button();
            this.KaydetBtn = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MsBilDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Red;
            this.TopPanel.Controls.Add(this.Exitbutton);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1116, 72);
            this.TopPanel.TabIndex = 5;
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackgroundImage = global::GzAutomation.Properties.Resources.icon;
            this.Exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exitbutton.FlatAppearance.BorderSize = 0;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Location = new System.Drawing.Point(1081, 0);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(35, 33);
            this.Exitbutton.TabIndex = 0;
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(517, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Randevu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cep Telefonu";
            // 
            // MsCepTelTxtbox
            // 
            this.MsCepTelTxtbox.Location = new System.Drawing.Point(469, 93);
            this.MsCepTelTxtbox.Name = "MsCepTelTxtbox";
            this.MsCepTelTxtbox.Size = new System.Drawing.Size(100, 20);
            this.MsCepTelTxtbox.TabIndex = 7;
            // 
            // KontrolBtn
            // 
            this.KontrolBtn.BackColor = System.Drawing.Color.Red;
            this.KontrolBtn.FlatAppearance.BorderSize = 0;
            this.KontrolBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KontrolBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KontrolBtn.Location = new System.Drawing.Point(587, 82);
            this.KontrolBtn.Name = "KontrolBtn";
            this.KontrolBtn.Size = new System.Drawing.Size(122, 38);
            this.KontrolBtn.TabIndex = 8;
            this.KontrolBtn.Text = "Kontrol et";
            this.KontrolBtn.UseVisualStyleBackColor = false;
            this.KontrolBtn.Click += new System.EventHandler(this.KontrolBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MsBilDataGrid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.YapIslemTxtBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.RndTarihDTPicker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RndSaatGrpBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1050, 521);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Bilgileri";
            // 
            // MsBilDataGrid
            // 
            this.MsBilDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.MsBilDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MsBilDataGrid.Location = new System.Drawing.Point(609, 48);
            this.MsBilDataGrid.Name = "MsBilDataGrid";
            this.MsBilDataGrid.Size = new System.Drawing.Size(422, 177);
            this.MsBilDataGrid.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Randevu Verilen Müşteri Bilgileri";
            // 
            // YapIslemTxtBox
            // 
            this.YapIslemTxtBox.Location = new System.Drawing.Point(320, 45);
            this.YapIslemTxtBox.Multiline = true;
            this.YapIslemTxtBox.Name = "YapIslemTxtBox";
            this.YapIslemTxtBox.Size = new System.Drawing.Size(250, 85);
            this.YapIslemTxtBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Yapılacak İşlem";
            // 
            // RndTarihDTPicker
            // 
            this.RndTarihDTPicker.Location = new System.Drawing.Point(99, 48);
            this.RndTarihDTPicker.Name = "RndTarihDTPicker";
            this.RndTarihDTPicker.Size = new System.Drawing.Size(200, 20);
            this.RndTarihDTPicker.TabIndex = 4;
            this.RndTarihDTPicker.ValueChanged += new System.EventHandler(this.RndTarihDTPicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Saati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tarihi";
            // 
            // RndSaatGrpBox
            // 
            this.RndSaatGrpBox.Location = new System.Drawing.Point(86, 131);
            this.RndSaatGrpBox.Name = "RndSaatGrpBox";
            this.RndSaatGrpBox.Size = new System.Drawing.Size(484, 376);
            this.RndSaatGrpBox.TabIndex = 0;
            this.RndSaatGrpBox.TabStop = false;
            // 
            // VazgecBtn
            // 
            this.VazgecBtn.BackColor = System.Drawing.Color.Red;
            this.VazgecBtn.FlatAppearance.BorderSize = 0;
            this.VazgecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VazgecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VazgecBtn.Location = new System.Drawing.Point(551, 653);
            this.VazgecBtn.Name = "VazgecBtn";
            this.VazgecBtn.Size = new System.Drawing.Size(122, 38);
            this.VazgecBtn.TabIndex = 11;
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
            this.KaydetBtn.Location = new System.Drawing.Point(423, 653);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(122, 38);
            this.KaydetBtn.TabIndex = 10;
            this.KaydetBtn.Text = "Kaydet\r\n";
            this.KaydetBtn.UseVisualStyleBackColor = false;
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // Randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 696);
            this.Controls.Add(this.VazgecBtn);
            this.Controls.Add(this.KaydetBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.KontrolBtn);
            this.Controls.Add(this.MsCepTelTxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Randevu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu";
            this.Load += new System.EventHandler(this.Randevu_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MsBilDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MsCepTelTxtbox;
        private System.Windows.Forms.Button KontrolBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView MsBilDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox YapIslemTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker RndTarihDTPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox RndSaatGrpBox;
        private System.Windows.Forms.Button VazgecBtn;
        private System.Windows.Forms.Button KaydetBtn;
    }
}