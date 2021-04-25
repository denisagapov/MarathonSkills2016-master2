
namespace Marathon
{
    partial class mainMenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenuForm));
            this.upPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSwn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dayLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.marathonLabel = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.runnerButton = new System.Windows.Forms.Button();
            this.sponsorButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.upPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.downPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // upPanel
            // 
            this.upPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.upPanel.Controls.Add(this.panel1);
            this.upPanel.Controls.Add(this.dayLabel);
            this.upPanel.Controls.Add(this.countryLabel);
            this.upPanel.Controls.Add(this.marathonLabel);
            this.upPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upPanel.Location = new System.Drawing.Point(0, 0);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(866, 194);
            this.upPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btnSwn);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 40);
            this.panel1.TabIndex = 113;
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
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dayLabel.Location = new System.Drawing.Point(278, 140);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(320, 37);
            this.dayLabel.TabIndex = 2;
            this.dayLabel.Text = "Среда, 21 октября 2021";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.countryLabel.Location = new System.Drawing.Point(334, 99);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(218, 37);
            this.countryLabel.TabIndex = 1;
            this.countryLabel.Text = "Москва, Россия";
            // 
            // marathonLabel
            // 
            this.marathonLabel.AutoSize = true;
            this.marathonLabel.Font = new System.Drawing.Font("Open Sans Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marathonLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.marathonLabel.Location = new System.Drawing.Point(246, 43);
            this.marathonLabel.Name = "marathonLabel";
            this.marathonLabel.Size = new System.Drawing.Size(391, 51);
            this.marathonLabel.TabIndex = 0;
            this.marathonLabel.Text = "Marathon Skills 2021";
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.downPanel.Controls.Add(this.timerLabel);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 615);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(866, 49);
            this.downPanel.TabIndex = 1;
            // 
            // timerLabel
            // 
            this.timerLabel.Font = new System.Drawing.Font("Arial", 20.25F);
            this.timerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.timerLabel.Location = new System.Drawing.Point(12, 8);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(826, 32);
            this.timerLabel.TabIndex = 41;
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // runnerButton
            // 
            this.runnerButton.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runnerButton.ForeColor = System.Drawing.Color.Black;
            this.runnerButton.Location = new System.Drawing.Point(284, 229);
            this.runnerButton.Name = "runnerButton";
            this.runnerButton.Size = new System.Drawing.Size(308, 83);
            this.runnerButton.TabIndex = 2;
            this.runnerButton.Text = "Я хочу стать бегуном";
            this.runnerButton.UseVisualStyleBackColor = true;
            this.runnerButton.Click += new System.EventHandler(this.runnerButton_Click);
            // 
            // sponsorButton
            // 
            this.sponsorButton.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sponsorButton.ForeColor = System.Drawing.Color.Black;
            this.sponsorButton.Location = new System.Drawing.Point(284, 331);
            this.sponsorButton.Name = "sponsorButton";
            this.sponsorButton.Size = new System.Drawing.Size(308, 83);
            this.sponsorButton.TabIndex = 3;
            this.sponsorButton.Text = "Я хочу стать спонсором бегуна";
            this.sponsorButton.UseVisualStyleBackColor = true;
            this.sponsorButton.Click += new System.EventHandler(this.sponsorButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoButton.ForeColor = System.Drawing.Color.Black;
            this.infoButton.Location = new System.Drawing.Point(284, 437);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(308, 83);
            this.infoButton.TabIndex = 4;
            this.infoButton.Text = "Я хочу узнать больше о событии";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(718, 526);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(120, 44);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Marathon.Properties.Resources.logo_2016_monochrome;
            this.pictureBox1.Location = new System.Drawing.Point(18, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // mainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 664);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.sponsorButton);
            this.Controls.Add(this.runnerButton);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.upPanel);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(866, 664);
            this.MinimumSize = new System.Drawing.Size(866, 664);
            this.Name = "mainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainMenuForm_FormClosing);
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.downPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Label marathonLabel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Button runnerButton;
        private System.Windows.Forms.Button sponsorButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSwn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

