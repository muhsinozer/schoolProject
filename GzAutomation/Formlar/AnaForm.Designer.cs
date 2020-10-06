namespace GzAutomation.Formlar
{
    partial class AnaForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.HRndVerBtn = new System.Windows.Forms.Button();
            this.RndVerBtn = new System.Windows.Forms.Button();
            this.MislemleriBtn = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BuAykiRndBtn = new System.Windows.Forms.Button();
            this.BugunkuRndBtn = new System.Windows.Forms.Button();
            this.IptalBtn = new System.Windows.Forms.Button();
            this.GelmediBtn = new System.Windows.Forms.Button();
            this.GeldiBtn = new System.Windows.Forms.Button();
            this.TarihSec = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MsRndDataGrid = new System.Windows.Forms.DataGridView();
            this.TopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MsRndDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Red;
            this.TopPanel.Controls.Add(this.button1);
            this.TopPanel.Controls.Add(this.HRndVerBtn);
            this.TopPanel.Controls.Add(this.RndVerBtn);
            this.TopPanel.Controls.Add(this.MislemleriBtn);
            this.TopPanel.Controls.Add(this.Exitbutton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(867, 90);
            this.TopPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GzAutomation.Properties.Resources.delete;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(791, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 33);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HRndVerBtn
            // 
            this.HRndVerBtn.BackColor = System.Drawing.SystemColors.Control;
            this.HRndVerBtn.FlatAppearance.BorderSize = 0;
            this.HRndVerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRndVerBtn.Location = new System.Drawing.Point(251, 24);
            this.HRndVerBtn.Name = "HRndVerBtn";
            this.HRndVerBtn.Size = new System.Drawing.Size(102, 33);
            this.HRndVerBtn.TabIndex = 3;
            this.HRndVerBtn.Text = "Hızlı Randevu Ver";
            this.HRndVerBtn.UseVisualStyleBackColor = false;
            this.HRndVerBtn.Click += new System.EventHandler(this.HRndVerBtn_Click);
            // 
            // RndVerBtn
            // 
            this.RndVerBtn.BackColor = System.Drawing.SystemColors.Control;
            this.RndVerBtn.FlatAppearance.BorderSize = 0;
            this.RndVerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RndVerBtn.Location = new System.Drawing.Point(143, 24);
            this.RndVerBtn.Name = "RndVerBtn";
            this.RndVerBtn.Size = new System.Drawing.Size(102, 33);
            this.RndVerBtn.TabIndex = 2;
            this.RndVerBtn.Text = "Randevu Ver";
            this.RndVerBtn.UseVisualStyleBackColor = false;
            this.RndVerBtn.Click += new System.EventHandler(this.RndVerBtn_Click);
            // 
            // MislemleriBtn
            // 
            this.MislemleriBtn.BackColor = System.Drawing.SystemColors.Control;
            this.MislemleriBtn.FlatAppearance.BorderSize = 0;
            this.MislemleriBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MislemleriBtn.Location = new System.Drawing.Point(35, 24);
            this.MislemleriBtn.Name = "MislemleriBtn";
            this.MislemleriBtn.Size = new System.Drawing.Size(102, 33);
            this.MislemleriBtn.TabIndex = 1;
            this.MislemleriBtn.Text = "Müşteri İşlemleri";
            this.MislemleriBtn.UseVisualStyleBackColor = false;
            this.MislemleriBtn.Click += new System.EventHandler(this.MislemleriBtn_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackgroundImage = global::GzAutomation.Properties.Resources.icon;
            this.Exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exitbutton.FlatAppearance.BorderSize = 0;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Location = new System.Drawing.Point(832, 0);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(35, 33);
            this.Exitbutton.TabIndex = 0;
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.BuAykiRndBtn);
            this.panel1.Controls.Add(this.TarihSec);
            this.panel1.Controls.Add(this.BugunkuRndBtn);
            this.panel1.Controls.Add(this.IptalBtn);
            this.panel1.Controls.Add(this.GelmediBtn);
            this.panel1.Controls.Add(this.GeldiBtn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 435);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BuAykiRndBtn
            // 
            this.BuAykiRndBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BuAykiRndBtn.FlatAppearance.BorderSize = 0;
            this.BuAykiRndBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuAykiRndBtn.Location = new System.Drawing.Point(652, 3);
            this.BuAykiRndBtn.Name = "BuAykiRndBtn";
            this.BuAykiRndBtn.Size = new System.Drawing.Size(163, 29);
            this.BuAykiRndBtn.TabIndex = 8;
            this.BuAykiRndBtn.Text = "Bu Ayki Randevular";
            this.BuAykiRndBtn.UseVisualStyleBackColor = false;
            this.BuAykiRndBtn.Click += new System.EventHandler(this.BuAykiRndBtn_Click);
            // 
            // BugunkuRndBtn
            // 
            this.BugunkuRndBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BugunkuRndBtn.FlatAppearance.BorderSize = 0;
            this.BugunkuRndBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BugunkuRndBtn.Location = new System.Drawing.Point(483, 3);
            this.BugunkuRndBtn.Name = "BugunkuRndBtn";
            this.BugunkuRndBtn.Size = new System.Drawing.Size(163, 29);
            this.BugunkuRndBtn.TabIndex = 7;
            this.BugunkuRndBtn.Text = "Bugünkü Randevular";
            this.BugunkuRndBtn.UseVisualStyleBackColor = false;
            this.BugunkuRndBtn.Click += new System.EventHandler(this.BugunkuRndBtn_Click);
            // 
            // IptalBtn
            // 
            this.IptalBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.IptalBtn.FlatAppearance.BorderSize = 0;
            this.IptalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IptalBtn.Location = new System.Drawing.Point(246, 12);
            this.IptalBtn.Name = "IptalBtn";
            this.IptalBtn.Size = new System.Drawing.Size(97, 23);
            this.IptalBtn.TabIndex = 6;
            this.IptalBtn.Text = "İptal";
            this.IptalBtn.UseVisualStyleBackColor = false;
            this.IptalBtn.Click += new System.EventHandler(this.IptalBtn_Click);
            // 
            // GelmediBtn
            // 
            this.GelmediBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.GelmediBtn.FlatAppearance.BorderSize = 0;
            this.GelmediBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GelmediBtn.Location = new System.Drawing.Point(143, 12);
            this.GelmediBtn.Name = "GelmediBtn";
            this.GelmediBtn.Size = new System.Drawing.Size(97, 23);
            this.GelmediBtn.TabIndex = 5;
            this.GelmediBtn.Text = "Gelmedi";
            this.GelmediBtn.UseVisualStyleBackColor = false;
            this.GelmediBtn.Click += new System.EventHandler(this.GelmediBtn_Click);
            // 
            // GeldiBtn
            // 
            this.GeldiBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.GeldiBtn.FlatAppearance.BorderSize = 0;
            this.GeldiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeldiBtn.Location = new System.Drawing.Point(40, 12);
            this.GeldiBtn.Name = "GeldiBtn";
            this.GeldiBtn.Size = new System.Drawing.Size(97, 23);
            this.GeldiBtn.TabIndex = 4;
            this.GeldiBtn.Text = "Geldi";
            this.GeldiBtn.UseVisualStyleBackColor = false;
            this.GeldiBtn.Click += new System.EventHandler(this.GeldiBtn_Click);
            // 
            // TarihSec
            // 
            this.TarihSec.Location = new System.Drawing.Point(615, 44);
            this.TarihSec.Name = "TarihSec";
            this.TarihSec.Size = new System.Drawing.Size(200, 20);
            this.TarihSec.TabIndex = 2;
            this.TarihSec.ValueChanged += new System.EventHandler(this.TarihSec_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MsRndDataGrid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 353);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bugün Randevusu Olan Müşteriler";
            // 
            // MsRndDataGrid
            // 
            this.MsRndDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MsRndDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.MsRndDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MsRndDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MsRndDataGrid.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.MsRndDataGrid.Location = new System.Drawing.Point(3, 16);
            this.MsRndDataGrid.MultiSelect = false;
            this.MsRndDataGrid.Name = "MsRndDataGrid";
            this.MsRndDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MsRndDataGrid.Size = new System.Drawing.Size(835, 334);
            this.MsRndDataGrid.TabIndex = 0;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MsRndDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button HRndVerBtn;
        private System.Windows.Forms.Button RndVerBtn;
        private System.Windows.Forms.Button MislemleriBtn;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BuAykiRndBtn;
        private System.Windows.Forms.Button BugunkuRndBtn;
        private System.Windows.Forms.Button IptalBtn;
        private System.Windows.Forms.Button GelmediBtn;
        private System.Windows.Forms.Button GeldiBtn;
        private System.Windows.Forms.DateTimePicker TarihSec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView MsRndDataGrid;
    }
}