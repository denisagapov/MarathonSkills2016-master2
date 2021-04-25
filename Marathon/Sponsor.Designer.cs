
namespace Marathon
{
    partial class sponsorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sponsorForm));
            this.infoLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.runnerLabel = new System.Windows.Forms.Label();
            this.cardLabel = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.validityLabel = new System.Windows.Forms.Label();
            this.runnerComboBox = new System.Windows.Forms.ComboBox();
            this.cvvLabel = new System.Windows.Forms.Label();
            this.charityLabel = new System.Windows.Forms.Label();
            this.foundationLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.cvvTextBox = new System.Windows.Forms.MaskedTextBox();
            this.monthTextBox = new System.Windows.Forms.MaskedTextBox();
            this.yearTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cardNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cardTextBox = new System.Windows.Forms.TextBox();
            this.moneyTextBox = new System.Windows.Forms.MaskedTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.infoPictureBox = new System.Windows.Forms.PictureBox();
            this.downPanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.sponsorLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.upPanel = new System.Windows.Forms.Panel();
            this.btnSwn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).BeginInit();
            this.downPanel.SuspendLayout();
            this.upPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Open Sans Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.Black;
            this.infoLabel.Location = new System.Drawing.Point(51, 200);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(318, 33);
            this.infoLabel.TabIndex = 10;
            this.infoLabel.Text = "Информация о спонсоре";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(38, 250);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(110, 26);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Ваше имя:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nameTextBox.Location = new System.Drawing.Point(154, 250);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(224, 30);
            this.nameTextBox.TabIndex = 12;
            // 
            // runnerLabel
            // 
            this.runnerLabel.AutoSize = true;
            this.runnerLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runnerLabel.ForeColor = System.Drawing.Color.Black;
            this.runnerLabel.Location = new System.Drawing.Point(78, 290);
            this.runnerLabel.Name = "runnerLabel";
            this.runnerLabel.Size = new System.Drawing.Size(70, 26);
            this.runnerLabel.TabIndex = 13;
            this.runnerLabel.Text = "Бегун:";
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardLabel.ForeColor = System.Drawing.Color.Black;
            this.cardLabel.Location = new System.Drawing.Point(76, 335);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(72, 26);
            this.cardLabel.TabIndex = 15;
            this.cardLabel.Text = "Карта:";
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.cardNumberLabel.Location = new System.Drawing.Point(7, 375);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(141, 26);
            this.cardNumberLabel.TabIndex = 17;
            this.cardNumberLabel.Text = "Номер карты:";
            // 
            // validityLabel
            // 
            this.validityLabel.AutoSize = true;
            this.validityLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.validityLabel.ForeColor = System.Drawing.Color.Black;
            this.validityLabel.Location = new System.Drawing.Point(-5, 419);
            this.validityLabel.Name = "validityLabel";
            this.validityLabel.Size = new System.Drawing.Size(153, 26);
            this.validityLabel.TabIndex = 19;
            this.validityLabel.Text = "Срок действия:";
            // 
            // runnerComboBox
            // 
            this.runnerComboBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.runnerComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.runnerComboBox.FormattingEnabled = true;
            this.runnerComboBox.Location = new System.Drawing.Point(154, 288);
            this.runnerComboBox.Name = "runnerComboBox";
            this.runnerComboBox.Size = new System.Drawing.Size(224, 34);
            this.runnerComboBox.TabIndex = 21;
            this.runnerComboBox.SelectedIndexChanged += new System.EventHandler(this.runnerComboBox_SelectedIndexChanged);
            // 
            // cvvLabel
            // 
            this.cvvLabel.AutoSize = true;
            this.cvvLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvvLabel.ForeColor = System.Drawing.Color.Black;
            this.cvvLabel.Location = new System.Drawing.Point(97, 460);
            this.cvvLabel.Name = "cvvLabel";
            this.cvvLabel.Size = new System.Drawing.Size(51, 26);
            this.cvvLabel.TabIndex = 24;
            this.cvvLabel.Text = "CVV:";
            // 
            // charityLabel
            // 
            this.charityLabel.AutoSize = true;
            this.charityLabel.Font = new System.Drawing.Font("Open Sans Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.charityLabel.ForeColor = System.Drawing.Color.Black;
            this.charityLabel.Location = new System.Drawing.Point(494, 200);
            this.charityLabel.Name = "charityLabel";
            this.charityLabel.Size = new System.Drawing.Size(281, 33);
            this.charityLabel.TabIndex = 26;
            this.charityLabel.Text = "Благотворительность";
            // 
            // foundationLabel
            // 
            this.foundationLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foundationLabel.ForeColor = System.Drawing.Color.Black;
            this.foundationLabel.Location = new System.Drawing.Point(495, 250);
            this.foundationLabel.Name = "foundationLabel";
            this.foundationLabel.Size = new System.Drawing.Size(253, 22);
            this.foundationLabel.TabIndex = 27;
            this.foundationLabel.Text = "Фонды";
            this.foundationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Open Sans Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLabel.ForeColor = System.Drawing.Color.Black;
            this.countLabel.Location = new System.Drawing.Point(488, 311);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(294, 33);
            this.countLabel.TabIndex = 28;
            this.countLabel.Text = "Сумма пожертвования";
            // 
            // moneyLabel
            // 
            this.moneyLabel.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.ForeColor = System.Drawing.Color.Black;
            this.moneyLabel.Location = new System.Drawing.Point(489, 349);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(293, 56);
            this.moneyLabel.TabIndex = 29;
            this.moneyLabel.Text = "50$";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.minusButton.ForeColor = System.Drawing.Color.Black;
            this.minusButton.Location = new System.Drawing.Point(489, 421);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(82, 29);
            this.minusButton.TabIndex = 30;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.plusButton.ForeColor = System.Drawing.Color.Black;
            this.plusButton.Location = new System.Drawing.Point(700, 421);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(82, 30);
            this.plusButton.TabIndex = 32;
            this.plusButton.Text = "+";
            this.plusButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // payButton
            // 
            this.payButton.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payButton.ForeColor = System.Drawing.Color.Black;
            this.payButton.Location = new System.Drawing.Point(500, 480);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(127, 30);
            this.payButton.TabIndex = 33;
            this.payButton.Text = "Заплатить";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(638, 480);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 30);
            this.cancelButton.TabIndex = 34;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // cvvTextBox
            // 
            this.cvvTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.cvvTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cvvTextBox.Location = new System.Drawing.Point(154, 457);
            this.cvvTextBox.Mask = "000";
            this.cvvTextBox.Name = "cvvTextBox";
            this.cvvTextBox.Size = new System.Drawing.Size(59, 33);
            this.cvvTextBox.TabIndex = 35;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.monthTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.monthTextBox.Location = new System.Drawing.Point(154, 416);
            this.monthTextBox.Mask = "00";
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(59, 33);
            this.monthTextBox.TabIndex = 36;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.yearTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.yearTextBox.Location = new System.Drawing.Point(219, 417);
            this.yearTextBox.Mask = "0000";
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(64, 33);
            this.yearTextBox.TabIndex = 37;
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.cardNumberTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cardNumberTextBox.Location = new System.Drawing.Point(154, 372);
            this.cardNumberTextBox.Mask = "0000 0000 0000 0000";
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(224, 33);
            this.cardNumberTextBox.TabIndex = 38;
            // 
            // cardTextBox
            // 
            this.cardTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.cardTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cardTextBox.Location = new System.Drawing.Point(154, 331);
            this.cardTextBox.Multiline = true;
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(224, 30);
            this.cardTextBox.TabIndex = 16;
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.moneyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.moneyTextBox.Location = new System.Drawing.Point(577, 419);
            this.moneyTextBox.Mask = "000000";
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(117, 33);
            this.moneyTextBox.TabIndex = 39;
            this.moneyTextBox.Text = "50";
            this.moneyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.moneyTextBox.TextChanged += new System.EventHandler(this.moneyTextBox_TextChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // infoPictureBox
            // 
            this.infoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("infoPictureBox.Image")));
            this.infoPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("infoPictureBox.InitialImage")));
            this.infoPictureBox.Location = new System.Drawing.Point(751, 250);
            this.infoPictureBox.Name = "infoPictureBox";
            this.infoPictureBox.Size = new System.Drawing.Size(24, 22);
            this.infoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoPictureBox.TabIndex = 40;
            this.infoPictureBox.TabStop = false;
            this.infoPictureBox.Click += new System.EventHandler(this.infoPictureBox_Click);
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.downPanel.Controls.Add(this.timerLabel);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 604);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(866, 60);
            this.downPanel.TabIndex = 5;
            // 
            // timerLabel
            // 
            this.timerLabel.Font = new System.Drawing.Font("Open Sans", 20.25F);
            this.timerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.timerLabel.Location = new System.Drawing.Point(12, 9);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(826, 32);
            this.timerLabel.TabIndex = 40;
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sponsorLabel
            // 
            this.sponsorLabel.AutoSize = true;
            this.sponsorLabel.Font = new System.Drawing.Font("Open Sans", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sponsorLabel.ForeColor = System.Drawing.Color.Black;
            this.sponsorLabel.Location = new System.Drawing.Point(284, 54);
            this.sponsorLabel.Name = "sponsorLabel";
            this.sponsorLabel.Size = new System.Drawing.Size(308, 51);
            this.sponsorLabel.TabIndex = 6;
            this.sponsorLabel.Text = "Спонсор бегуна";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.Black;
            this.descriptionLabel.Location = new System.Drawing.Point(109, 115);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(634, 66);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Пожалуйста выберите бегуна, которого вы хотели бы спонсировать и сумму,\r\nкоторую " +
    "вы хотели  бы спонсировать. Спасибо за вашу поддержку бегунов и их\r\nблаготворите" +
    "льных учреждений.";
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
            // sponsorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 664);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.infoPictureBox);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.cardNumberTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.cvvTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.foundationLabel);
            this.Controls.Add(this.charityLabel);
            this.Controls.Add(this.cvvLabel);
            this.Controls.Add(this.runnerComboBox);
            this.Controls.Add(this.validityLabel);
            this.Controls.Add(this.cardNumberLabel);
            this.Controls.Add(this.cardTextBox);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.runnerLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.sponsorLabel);
            this.Controls.Add(this.downPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(866, 664);
            this.MinimumSize = new System.Drawing.Size(866, 664);
            this.Name = "sponsorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - Sponsor a runner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sponsorForm_FormClosing);
            this.Load += new System.EventHandler(this.sponsorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).EndInit();
            this.downPanel.ResumeLayout(false);
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label runnerLabel;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.Label validityLabel;
        private System.Windows.Forms.ComboBox runnerComboBox;
        private System.Windows.Forms.Label cvvLabel;
        private System.Windows.Forms.Label charityLabel;
        private System.Windows.Forms.Label foundationLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.MaskedTextBox cvvTextBox;
        private System.Windows.Forms.MaskedTextBox monthTextBox;
        private System.Windows.Forms.MaskedTextBox yearTextBox;
        private System.Windows.Forms.MaskedTextBox cardNumberTextBox;
        private System.Windows.Forms.TextBox cardTextBox;
        private System.Windows.Forms.MaskedTextBox moneyTextBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox infoPictureBox;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label sponsorLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Button btnSwn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}