namespace GzAutomation.Formlar
{
    partial class MusteriBilgileri
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.MsSilBtn = new System.Windows.Forms.Button();
            this.MsKartiBtn = new System.Windows.Forms.Button();
            this.MsKartinaEkleBtn = new System.Windows.Forms.Button();
            this.MsBilgiDuzenleBtn = new System.Windows.Forms.Button();
            this.YMsKaydiBtn = new System.Windows.Forms.Button();
            this.MsBilgiDataGrid = new System.Windows.Forms.DataGridView();
            this.TopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MsBilgiDataGrid)).BeginInit();
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
            this.TopPanel.Size = new System.Drawing.Size(844, 72);
            this.TopPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(317, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Bilgileri";
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackgroundImage = global::GzAutomation.Properties.Resources.icon;
            this.Exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exitbutton.FlatAppearance.BorderSize = 0;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Location = new System.Drawing.Point(809, 0);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(35, 33);
            this.Exitbutton.TabIndex = 0;
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SearchTxtBox);
            this.panel1.Controls.Add(this.MsSilBtn);
            this.panel1.Controls.Add(this.MsKartiBtn);
            this.panel1.Controls.Add(this.MsKartinaEkleBtn);
            this.panel1.Controls.Add(this.MsBilgiDuzenleBtn);
            this.panel1.Controls.Add(this.YMsKaydiBtn);
            this.panel1.Controls.Add(this.MsBilgiDataGrid);
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 441);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(684, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ara :";
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(729, 25);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(100, 20);
            this.SearchTxtBox.TabIndex = 5;
            this.SearchTxtBox.TextChanged += new System.EventHandler(this.Aramabox_TextChanged);
            // 
            // MsSilBtn
            // 
            this.MsSilBtn.BackColor = System.Drawing.Color.Red;
            this.MsSilBtn.FlatAppearance.BorderSize = 0;
            this.MsSilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MsSilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MsSilBtn.Location = new System.Drawing.Point(537, 14);
            this.MsSilBtn.Name = "MsSilBtn";
            this.MsSilBtn.Size = new System.Drawing.Size(122, 38);
            this.MsSilBtn.TabIndex = 4;
            this.MsSilBtn.Text = "Müşteri Sil";
            this.MsSilBtn.UseVisualStyleBackColor = false;
            this.MsSilBtn.Click += new System.EventHandler(this.MsSilBtn_Click);
            // 
            // MsKartiBtn
            // 
            this.MsKartiBtn.BackColor = System.Drawing.Color.Red;
            this.MsKartiBtn.FlatAppearance.BorderSize = 0;
            this.MsKartiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MsKartiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MsKartiBtn.Location = new System.Drawing.Point(409, 14);
            this.MsKartiBtn.Name = "MsKartiBtn";
            this.MsKartiBtn.Size = new System.Drawing.Size(122, 38);
            this.MsKartiBtn.TabIndex = 3;
            this.MsKartiBtn.Text = "Müşteri Kartı";
            this.MsKartiBtn.UseVisualStyleBackColor = false;
            this.MsKartiBtn.Click += new System.EventHandler(this.MsKartiBtn_Click);
            // 
            // MsKartinaEkleBtn
            // 
            this.MsKartinaEkleBtn.BackColor = System.Drawing.Color.Red;
            this.MsKartinaEkleBtn.FlatAppearance.BorderSize = 0;
            this.MsKartinaEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MsKartinaEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MsKartinaEkleBtn.Location = new System.Drawing.Point(281, 14);
            this.MsKartinaEkleBtn.Name = "MsKartinaEkleBtn";
            this.MsKartinaEkleBtn.Size = new System.Drawing.Size(122, 38);
            this.MsKartinaEkleBtn.TabIndex = 2;
            this.MsKartinaEkleBtn.Text = "Müşteri Kartına Ekle";
            this.MsKartinaEkleBtn.UseVisualStyleBackColor = false;
            this.MsKartinaEkleBtn.Click += new System.EventHandler(this.MsKartinaEkleBtn_Click);
            // 
            // MsBilgiDuzenleBtn
            // 
            this.MsBilgiDuzenleBtn.BackColor = System.Drawing.Color.Red;
            this.MsBilgiDuzenleBtn.FlatAppearance.BorderSize = 0;
            this.MsBilgiDuzenleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MsBilgiDuzenleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MsBilgiDuzenleBtn.Location = new System.Drawing.Point(153, 14);
            this.MsBilgiDuzenleBtn.Name = "MsBilgiDuzenleBtn";
            this.MsBilgiDuzenleBtn.Size = new System.Drawing.Size(122, 38);
            this.MsBilgiDuzenleBtn.TabIndex = 1;
            this.MsBilgiDuzenleBtn.Text = "Müşteri Bilgi Düzenle";
            this.MsBilgiDuzenleBtn.UseVisualStyleBackColor = false;
            this.MsBilgiDuzenleBtn.Click += new System.EventHandler(this.MsBilgiDuzenleBtn_Click);
            // 
            // YMsKaydiBtn
            // 
            this.YMsKaydiBtn.BackColor = System.Drawing.Color.Red;
            this.YMsKaydiBtn.FlatAppearance.BorderSize = 0;
            this.YMsKaydiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YMsKaydiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YMsKaydiBtn.Location = new System.Drawing.Point(25, 14);
            this.YMsKaydiBtn.Name = "YMsKaydiBtn";
            this.YMsKaydiBtn.Size = new System.Drawing.Size(122, 38);
            this.YMsKaydiBtn.TabIndex = 0;
            this.YMsKaydiBtn.Text = "Yeni Müşteri Kaydı";
            this.YMsKaydiBtn.UseVisualStyleBackColor = false;
            this.YMsKaydiBtn.Click += new System.EventHandler(this.YMsKaydiBtn_Click);
            // 
            // MsBilgiDataGrid
            // 
            this.MsBilgiDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MsBilgiDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.MsBilgiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MsBilgiDataGrid.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.MsBilgiDataGrid.Location = new System.Drawing.Point(25, 76);
            this.MsBilgiDataGrid.Name = "MsBilgiDataGrid";
            this.MsBilgiDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MsBilgiDataGrid.Size = new System.Drawing.Size(740, 316);
            this.MsBilgiDataGrid.TabIndex = 0;
            // 
            // MusteriBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusteriBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriBilgileri";
            this.Load += new System.EventHandler(this.MusteriBilgileri_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MsBilgiDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView MsBilgiDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.Button MsSilBtn;
        private System.Windows.Forms.Button MsKartiBtn;
        private System.Windows.Forms.Button MsKartinaEkleBtn;
        private System.Windows.Forms.Button MsBilgiDuzenleBtn;
        private System.Windows.Forms.Button YMsKaydiBtn;
    }
}