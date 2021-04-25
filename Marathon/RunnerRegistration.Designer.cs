
namespace Marathon
{
    partial class runnerRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(runnerRegistrationForm));
            this.downPanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.paswordLabel = new System.Windows.Forms.Label();
            this.passwordAgainTextBox = new System.Windows.Forms.TextBox();
            this.paswordAgainLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.photoLabel = new System.Windows.Forms.Label();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.photoButton = new System.Windows.Forms.Button();
            this.birthLabel = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.countryLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.upPanel = new System.Windows.Forms.Panel();
            this.btnSwn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.downPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.upPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.downPanel.Controls.Add(this.timerLabel);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 584);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(866, 60);
            this.downPanel.TabIndex = 9;
            // 
            // timerLabel
            // 
            this.timerLabel.Font = new System.Drawing.Font("Open Sans", 20.25F);
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
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.Black;
            this.descriptionLabel.Location = new System.Drawing.Point(67, 118);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(772, 52);
            this.descriptionLabel.TabIndex = 11;
            this.descriptionLabel.Text = "Пожалуйста заполните всю информацию, чтобы зарегистрироваться в качестве \r\nбегуна" +
    "";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Open Sans", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.ForeColor = System.Drawing.Color.Black;
            this.registerLabel.Location = new System.Drawing.Point(263, 62);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(382, 51);
            this.registerLabel.TabIndex = 10;
            this.registerLabel.Text = "Регистрация бегуна";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.emailTextBox.Location = new System.Drawing.Point(201, 206);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(224, 30);
            this.emailTextBox.TabIndex = 14;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(130, 210);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(67, 26);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.passwordTextBox.Location = new System.Drawing.Point(201, 256);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(194, 30);
            this.passwordTextBox.TabIndex = 16;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // paswordLabel
            // 
            this.paswordLabel.AutoSize = true;
            this.paswordLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paswordLabel.ForeColor = System.Drawing.Color.Black;
            this.paswordLabel.Location = new System.Drawing.Point(110, 259);
            this.paswordLabel.Name = "paswordLabel";
            this.paswordLabel.Size = new System.Drawing.Size(87, 26);
            this.paswordLabel.TabIndex = 15;
            this.paswordLabel.Text = "Пароль:";
            // 
            // passwordAgainTextBox
            // 
            this.passwordAgainTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.passwordAgainTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.passwordAgainTextBox.Location = new System.Drawing.Point(201, 303);
            this.passwordAgainTextBox.Multiline = true;
            this.passwordAgainTextBox.Name = "passwordAgainTextBox";
            this.passwordAgainTextBox.Size = new System.Drawing.Size(194, 30);
            this.passwordAgainTextBox.TabIndex = 18;
            this.passwordAgainTextBox.UseSystemPasswordChar = true;
            // 
            // paswordAgainLabel
            // 
            this.paswordAgainLabel.AutoSize = true;
            this.paswordAgainLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paswordAgainLabel.ForeColor = System.Drawing.Color.Black;
            this.paswordAgainLabel.Location = new System.Drawing.Point(7, 306);
            this.paswordAgainLabel.Name = "paswordAgainLabel";
            this.paswordAgainLabel.Size = new System.Drawing.Size(190, 26);
            this.paswordAgainLabel.TabIndex = 17;
            this.paswordAgainLabel.Text = "Повторите пароль:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nameTextBox.Location = new System.Drawing.Point(201, 352);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(194, 30);
            this.nameTextBox.TabIndex = 20;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(141, 356);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 26);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Имя:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lastNameTextBox.Location = new System.Drawing.Point(201, 398);
            this.lastNameTextBox.Multiline = true;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(194, 30);
            this.lastNameTextBox.TabIndex = 22;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.Black;
            this.lastNameLabel.Location = new System.Drawing.Point(94, 402);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(103, 26);
            this.lastNameLabel.TabIndex = 21;
            this.lastNameLabel.Text = "Фамилия:";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.ForeColor = System.Drawing.Color.Black;
            this.sexLabel.Location = new System.Drawing.Point(144, 449);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(53, 26);
            this.sexLabel.TabIndex = 23;
            this.sexLabel.Text = "Пол:";
            // 
            // sexComboBox
            // 
            this.sexComboBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.sexComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Location = new System.Drawing.Point(201, 446);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(170, 34);
            this.sexComboBox.TabIndex = 24;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.photoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("photoPictureBox.BackgroundImage")));
            this.photoPictureBox.Location = new System.Drawing.Point(675, 177);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(121, 151);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 25;
            this.photoPictureBox.TabStop = false;
            // 
            // photoLabel
            // 
            this.photoLabel.AutoSize = true;
            this.photoLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoLabel.ForeColor = System.Drawing.Color.Black;
            this.photoLabel.Location = new System.Drawing.Point(473, 326);
            this.photoLabel.Name = "photoLabel";
            this.photoLabel.Size = new System.Drawing.Size(116, 26);
            this.photoLabel.TabIndex = 26;
            this.photoLabel.Text = "Фото файл:";
            // 
            // photoTextBox
            // 
            this.photoTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.photoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.photoTextBox.Location = new System.Drawing.Point(477, 355);
            this.photoTextBox.Multiline = true;
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.ReadOnly = true;
            this.photoTextBox.Size = new System.Drawing.Size(191, 30);
            this.photoTextBox.TabIndex = 27;
            // 
            // photoButton
            // 
            this.photoButton.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoButton.ForeColor = System.Drawing.Color.Black;
            this.photoButton.Location = new System.Drawing.Point(674, 354);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(122, 30);
            this.photoButton.TabIndex = 34;
            this.photoButton.Text = "Просмотр...";
            this.photoButton.UseVisualStyleBackColor = true;
            this.photoButton.Click += new System.EventHandler(this.photoButton_Click);
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthLabel.ForeColor = System.Drawing.Color.Black;
            this.birthLabel.Location = new System.Drawing.Point(460, 401);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(160, 26);
            this.birthLabel.TabIndex = 35;
            this.birthLabel.Text = "Дата рождения:";
            // 
            // countryComboBox
            // 
            this.countryComboBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.countryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(626, 443);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(170, 34);
            this.countryComboBox.TabIndex = 36;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateTimePicker.Location = new System.Drawing.Point(626, 399);
            this.birthDateTimePicker.MaxDate = new System.DateTime(2011, 10, 21, 0, 0, 0, 0);
            this.birthDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(170, 33);
            this.birthDateTimePicker.TabIndex = 37;
            this.birthDateTimePicker.Value = new System.DateTime(1978, 7, 16, 0, 0, 0, 0);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.ForeColor = System.Drawing.Color.Black;
            this.countryLabel.Location = new System.Drawing.Point(535, 446);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(84, 26);
            this.countryLabel.TabIndex = 38;
            this.countryLabel.Text = "Страна:";
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.ForeColor = System.Drawing.Color.Black;
            this.registerButton.Location = new System.Drawing.Point(294, 512);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(175, 30);
            this.registerButton.TabIndex = 39;
            this.registerButton.Text = "Регистрация";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(478, 512);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(122, 30);
            this.cancelButton.TabIndex = 40;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
            this.upPanel.TabIndex = 117;
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
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // runnerRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 644);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.birthDateTimePicker);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.photoButton);
            this.Controls.Add(this.photoTextBox);
            this.Controls.Add(this.photoLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.passwordAgainTextBox);
            this.Controls.Add(this.paswordAgainLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.paswordLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.registerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(866, 644);
            this.MinimumSize = new System.Drawing.Size(866, 644);
            this.Name = "runnerRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - Register as a runner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.runnerRegistrationForm_FormClosing);
            this.Load += new System.EventHandler(this.runnerRegistrationForm_Load);
            this.downPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label paswordLabel;
        private System.Windows.Forms.TextBox passwordAgainTextBox;
        private System.Windows.Forms.Label paswordAgainLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Label photoLabel;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.Button photoButton;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Button btnSwn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}