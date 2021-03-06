
namespace Marathon
{
    partial class runnerProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(runnerProfileForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.countryLabel = new System.Windows.Forms.Label();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.birthLabel = new System.Windows.Forms.Label();
            this.photoButton = new System.Windows.Forms.Button();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.photoLabel = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passwordAgainTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.paswordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.downPanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.paswordAgainLabel = new System.Windows.Forms.Label();
            this.emailUserLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.upPanel = new System.Windows.Forms.Panel();
            this.btnSwn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.downPanel.SuspendLayout();
            this.upPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(447, 494);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(122, 30);
            this.cancelButton.TabIndex = 66;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.ForeColor = System.Drawing.Color.Black;
            this.registerButton.Location = new System.Drawing.Point(294, 494);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(132, 30);
            this.registerButton.TabIndex = 65;
            this.registerButton.Text = "Сохранить";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.ForeColor = System.Drawing.Color.Black;
            this.countryLabel.Location = new System.Drawing.Point(83, 401);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(84, 26);
            this.countryLabel.TabIndex = 64;
            this.countryLabel.Text = "Страна:";
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateTimePicker.Location = new System.Drawing.Point(170, 351);
            this.birthDateTimePicker.MaxDate = new System.DateTime(2011, 2, 4, 0, 0, 0, 0);
            this.birthDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(170, 33);
            this.birthDateTimePicker.TabIndex = 63;
            this.birthDateTimePicker.Value = new System.DateTime(1978, 7, 16, 0, 0, 0, 0);
            // 
            // countryComboBox
            // 
            this.countryComboBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.countryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(170, 395);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(170, 34);
            this.countryComboBox.TabIndex = 62;
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthLabel.ForeColor = System.Drawing.Color.Black;
            this.birthLabel.Location = new System.Drawing.Point(7, 356);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(160, 26);
            this.birthLabel.TabIndex = 61;
            this.birthLabel.Text = "Дата рождения:";
            // 
            // photoButton
            // 
            this.photoButton.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoButton.ForeColor = System.Drawing.Color.Black;
            this.photoButton.Location = new System.Drawing.Point(674, 258);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(122, 30);
            this.photoButton.TabIndex = 60;
            this.photoButton.Text = "Просмотр...";
            this.photoButton.UseVisualStyleBackColor = true;
            this.photoButton.Click += new System.EventHandler(this.photoButton_Click);
            // 
            // photoTextBox
            // 
            this.photoTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.photoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.photoTextBox.Location = new System.Drawing.Point(477, 259);
            this.photoTextBox.Multiline = true;
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(191, 30);
            this.photoTextBox.TabIndex = 59;
            // 
            // photoLabel
            // 
            this.photoLabel.AutoSize = true;
            this.photoLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoLabel.ForeColor = System.Drawing.Color.Black;
            this.photoLabel.Location = new System.Drawing.Point(472, 230);
            this.photoLabel.Name = "photoLabel";
            this.photoLabel.Size = new System.Drawing.Size(116, 26);
            this.photoLabel.TabIndex = 58;
            this.photoLabel.Text = "Фото файл:";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.photoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("photoPictureBox.BackgroundImage")));
            this.photoPictureBox.Location = new System.Drawing.Point(674, 101);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(121, 151);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 57;
            this.photoPictureBox.TabStop = false;
            // 
            // sexComboBox
            // 
            this.sexComboBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.sexComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Location = new System.Drawing.Point(169, 305);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(170, 34);
            this.sexComboBox.TabIndex = 56;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.ForeColor = System.Drawing.Color.Black;
            this.sexLabel.Location = new System.Drawing.Point(114, 308);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(53, 26);
            this.sexLabel.TabIndex = 55;
            this.sexLabel.Text = "Пол:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lastNameTextBox.Location = new System.Drawing.Point(169, 260);
            this.lastNameTextBox.Multiline = true;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(194, 30);
            this.lastNameTextBox.TabIndex = 54;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.Black;
            this.lastNameLabel.Location = new System.Drawing.Point(64, 264);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(103, 26);
            this.lastNameLabel.TabIndex = 53;
            this.lastNameLabel.Text = "Фамилия:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nameTextBox.Location = new System.Drawing.Point(169, 214);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(194, 30);
            this.nameTextBox.TabIndex = 52;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(111, 217);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 26);
            this.nameLabel.TabIndex = 51;
            this.nameLabel.Text = "Имя:";
            // 
            // passwordAgainTextBox
            // 
            this.passwordAgainTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.passwordAgainTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.passwordAgainTextBox.Location = new System.Drawing.Point(602, 444);
            this.passwordAgainTextBox.Multiline = true;
            this.passwordAgainTextBox.Name = "passwordAgainTextBox";
            this.passwordAgainTextBox.Size = new System.Drawing.Size(194, 30);
            this.passwordAgainTextBox.TabIndex = 50;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.passwordTextBox.Location = new System.Drawing.Point(602, 397);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(194, 30);
            this.passwordTextBox.TabIndex = 48;
            // 
            // paswordLabel
            // 
            this.paswordLabel.AutoSize = true;
            this.paswordLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paswordLabel.ForeColor = System.Drawing.Color.Black;
            this.paswordLabel.Location = new System.Drawing.Point(509, 400);
            this.paswordLabel.Name = "paswordLabel";
            this.paswordLabel.Size = new System.Drawing.Size(87, 26);
            this.paswordLabel.TabIndex = 47;
            this.paswordLabel.Text = "Пароль:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(102, 176);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(67, 26);
            this.emailLabel.TabIndex = 45;
            this.emailLabel.Text = "Email:";
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Open Sans", 18.75F);
            this.registerLabel.ForeColor = System.Drawing.Color.Black;
            this.registerLabel.Location = new System.Drawing.Point(131, 101);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(331, 34);
            this.registerLabel.TabIndex = 43;
            this.registerLabel.Text = "Редактирование профиля";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.downPanel.Controls.Add(this.timerLabel);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 604);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(866, 60);
            this.downPanel.TabIndex = 42;
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
            // paswordAgainLabel
            // 
            this.paswordAgainLabel.AutoSize = true;
            this.paswordAgainLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paswordAgainLabel.ForeColor = System.Drawing.Color.Black;
            this.paswordAgainLabel.Location = new System.Drawing.Point(406, 447);
            this.paswordAgainLabel.Name = "paswordAgainLabel";
            this.paswordAgainLabel.Size = new System.Drawing.Size(190, 26);
            this.paswordAgainLabel.TabIndex = 49;
            this.paswordAgainLabel.Text = "Повторите пароль:";
            // 
            // emailUserLabel
            // 
            this.emailUserLabel.AutoSize = true;
            this.emailUserLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailUserLabel.ForeColor = System.Drawing.Color.Gray;
            this.emailUserLabel.Location = new System.Drawing.Point(170, 176);
            this.emailUserLabel.Name = "emailUserLabel";
            this.emailUserLabel.Size = new System.Drawing.Size(229, 26);
            this.emailUserLabel.TabIndex = 67;
            this.emailUserLabel.Text = "the.email@address.com";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Open Sans", 17.75F);
            this.changeLabel.ForeColor = System.Drawing.Color.Black;
            this.changeLabel.Location = new System.Drawing.Point(543, 301);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(179, 33);
            this.changeLabel.TabIndex = 68;
            this.changeLabel.Text = "Смена пароля";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.Black;
            this.descriptionLabel.Location = new System.Drawing.Point(452, 334);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(363, 52);
            this.descriptionLabel.TabIndex = 69;
            this.descriptionLabel.Text = "Оставьте эти поля, незаполненными,\r\nесли вы не хотите изменять пароль";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.upPanel.TabIndex = 118;
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
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutButton.ForeColor = System.Drawing.Color.Black;
            this.logoutButton.Location = new System.Drawing.Point(773, 46);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(89, 30);
            this.logoutButton.TabIndex = 117;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Marathon.Properties.Resources.logo_2016_monochrome;
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // runnerProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 664);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.emailUserLabel);
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
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.paswordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.paswordAgainLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(866, 664);
            this.MinimumSize = new System.Drawing.Size(866, 664);
            this.Name = "runnerProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - Edit runner profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.runnerProfileForm_FormClosing);
            this.Load += new System.EventHandler(this.runnerProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.downPanel.ResumeLayout(false);
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Button photoButton;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.Label photoLabel;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox passwordAgainTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label paswordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Label paswordAgainLabel;
        private System.Windows.Forms.Label emailUserLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Button btnSwn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}