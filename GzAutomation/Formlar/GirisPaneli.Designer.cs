namespace GzAutomation.Formlar
{
    partial class GirisPaneli
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
            this.EnterButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logintxtbox = new System.Windows.Forms.TextBox();
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.userimage = new System.Windows.Forms.Button();
            this.passwordimage = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.Red;
            this.EnterButton.FlatAppearance.BorderSize = 0;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EnterButton.Location = new System.Drawing.Point(90, 182);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(194, 32);
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "Giriş Yap";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Red;
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.Exitbutton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(386, 90);
            this.TopPanel.TabIndex = 1;
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackgroundImage = global::GzAutomation.Properties.Resources.icon;
            this.Exitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exitbutton.FlatAppearance.BorderSize = 0;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Location = new System.Drawing.Point(351, 0);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(35, 33);
            this.Exitbutton.TabIndex = 0;
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.passwordimage);
            this.panel1.Controls.Add(this.userimage);
            this.panel1.Controls.Add(this.passwordtxtbox);
            this.panel1.Controls.Add(this.logintxtbox);
            this.panel1.Controls.Add(this.EnterButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 268);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(95, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yetkili Girişi";
            // 
            // logintxtbox
            // 
            this.logintxtbox.Location = new System.Drawing.Point(165, 56);
            this.logintxtbox.Name = "logintxtbox";
            this.logintxtbox.PasswordChar = '*';
            this.logintxtbox.Size = new System.Drawing.Size(100, 20);
            this.logintxtbox.TabIndex = 1;
            this.logintxtbox.Text = "admin";
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Location = new System.Drawing.Point(165, 111);
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.PasswordChar = '*';
            this.passwordtxtbox.Size = new System.Drawing.Size(100, 20);
            this.passwordtxtbox.TabIndex = 2;
            this.passwordtxtbox.Text = "admin";
            // 
            // userimage
            // 
            this.userimage.BackgroundImage = global::GzAutomation.Properties.Resources.man_user;
            this.userimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userimage.Enabled = false;
            this.userimage.FlatAppearance.BorderSize = 0;
            this.userimage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userimage.Location = new System.Drawing.Point(72, 41);
            this.userimage.Name = "userimage";
            this.userimage.Size = new System.Drawing.Size(77, 49);
            this.userimage.TabIndex = 3;
            this.userimage.UseVisualStyleBackColor = true;
            // 
            // passwordimage
            // 
            this.passwordimage.BackgroundImage = global::GzAutomation.Properties.Resources._lock;
            this.passwordimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.passwordimage.Enabled = false;
            this.passwordimage.FlatAppearance.BorderSize = 0;
            this.passwordimage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordimage.Location = new System.Drawing.Point(70, 96);
            this.passwordimage.Name = "passwordimage";
            this.passwordimage.Size = new System.Drawing.Size(79, 49);
            this.passwordimage.TabIndex = 4;
            this.passwordimage.UseVisualStyleBackColor = true;
            // 
            // GirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 358);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisPaneli";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button passwordimage;
        private System.Windows.Forms.Button userimage;
        private System.Windows.Forms.TextBox passwordtxtbox;
        private System.Windows.Forms.TextBox logintxtbox;
    }
}