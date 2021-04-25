
namespace Marathon
{
    partial class confirmRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirmRegistrationForm));
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.thankLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.downPanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.okButton = new System.Windows.Forms.Button();
            this.btnSwn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.upPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.downPanel.SuspendLayout();
            this.upPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.Black;
            this.descriptionLabel.Location = new System.Drawing.Point(84, 163);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(746, 84);
            this.descriptionLabel.TabIndex = 33;
            this.descriptionLabel.Text = "Спасибо за вашу регистрацию в качестве бегуна в Marathon Skills 2016!\r\n\r\nС вами с" +
    "вяжутся по поводу оплаты.";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thankLabel
            // 
            this.thankLabel.AutoSize = true;
            this.thankLabel.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thankLabel.ForeColor = System.Drawing.Color.Black;
            this.thankLabel.Location = new System.Drawing.Point(187, 79);
            this.thankLabel.Name = "thankLabel";
            this.thankLabel.Size = new System.Drawing.Size(496, 66);
            this.thankLabel.TabIndex = 31;
            this.thankLabel.Text = "Спасибо за вашу регистрацию в качестве\r\nбегуна!";
            this.thankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutButton.ForeColor = System.Drawing.Color.Black;
            this.logoutButton.Location = new System.Drawing.Point(774, 46);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(89, 30);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.downPanel.Controls.Add(this.timerLabel);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 447);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(866, 60);
            this.downPanel.TabIndex = 34;
            // 
            // timerLabel
            // 
            this.timerLabel.Font = new System.Drawing.Font("Arial", 20.25F);
            this.timerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.timerLabel.Location = new System.Drawing.Point(12, 14);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(826, 32);
            this.timerLabel.TabIndex = 41;
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.ForeColor = System.Drawing.Color.Black;
            this.okButton.Location = new System.Drawing.Point(381, 280);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(110, 39);
            this.okButton.TabIndex = 35;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // btnSwn
            // 
            this.btnSwn.Location = new System.Drawing.Point(800, 15);
            this.btnSwn.Name = "btnSwn";
            this.btnSwn.Size = new System.Drawing.Size(30, 10);
            this.btnSwn.TabIndex = 3;
            this.btnSwn.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(835, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 22);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // upPanel
            // 
            this.upPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.upPanel.Controls.Add(this.btnSwn);
            this.upPanel.Controls.Add(this.btnClose);
            this.upPanel.Controls.Add(this.backButton);
            this.upPanel.Controls.Add(this.headerLabel);
            this.upPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upPanel.Location = new System.Drawing.Point(0, 0);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(866, 40);
            this.upPanel.TabIndex = 109;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(12, 7);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(81, 28);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(326, 7);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(221, 28);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Marathon Skills 2021";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Marathon.Properties.Resources.logo_2016_monochrome;
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // confirmRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 507);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.thankLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(866, 664);
            this.MinimumSize = new System.Drawing.Size(512, 304);
            this.Name = "confirmRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - Registration confirmation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.confirmRegistrationForm_FormClosing);
            this.downPanel.ResumeLayout(false);
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label thankLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button btnSwn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}