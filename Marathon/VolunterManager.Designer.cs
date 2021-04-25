
namespace Marathon
{
    partial class volunterManagerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(volunterManagerForm));
            this.sortLabel = new System.Windows.Forms.Label();
            this.loadLabel = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.sortOfLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.volunterLabel = new System.Windows.Forms.Label();
            this.volunterNumberLabel = new System.Windows.Forms.Label();
            this.volunterDataGrid = new System.Windows.Forms.DataGridView();
            this.timerLabel = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.managerLabel = new System.Windows.Forms.Label();
            this.upPanel = new System.Windows.Forms.Panel();
            this.btnSwn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.volunterDataGrid)).BeginInit();
            this.downPanel.SuspendLayout();
            this.upPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Font = new System.Drawing.Font("Open Sans", 18F);
            this.sortLabel.ForeColor = System.Drawing.Color.Black;
            this.sortLabel.Location = new System.Drawing.Point(57, 148);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(322, 33);
            this.sortLabel.TabIndex = 48;
            this.sortLabel.Text = "Сортировка и фильтрация";
            // 
            // loadLabel
            // 
            this.loadLabel.AutoSize = true;
            this.loadLabel.Font = new System.Drawing.Font("Open Sans", 18F);
            this.loadLabel.ForeColor = System.Drawing.Color.Black;
            this.loadLabel.Location = new System.Drawing.Point(655, 148);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(116, 33);
            this.loadLabel.TabIndex = 49;
            this.loadLabel.Text = "Загрузка";
            // 
            // sortComboBox
            // 
            this.sortComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Имя",
            "Фамилия",
            "Страна",
            "Пол"});
            this.sortComboBox.Location = new System.Drawing.Point(201, 192);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(184, 26);
            this.sortComboBox.TabIndex = 50;
            // 
            // sortOfLabel
            // 
            this.sortOfLabel.AutoSize = true;
            this.sortOfLabel.Font = new System.Drawing.Font("Open Sans", 16F);
            this.sortOfLabel.ForeColor = System.Drawing.Color.Black;
            this.sortOfLabel.Location = new System.Drawing.Point(23, 192);
            this.sortOfLabel.Name = "sortOfLabel";
            this.sortOfLabel.Size = new System.Drawing.Size(178, 30);
            this.sortOfLabel.TabIndex = 51;
            this.sortOfLabel.Text = "Сортировка по:";
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.refreshButton.ForeColor = System.Drawing.Color.Black;
            this.refreshButton.Location = new System.Drawing.Point(143, 234);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(122, 39);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.loadButton.ForeColor = System.Drawing.Color.Black;
            this.loadButton.Location = new System.Drawing.Point(595, 185);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(227, 39);
            this.loadButton.TabIndex = 52;
            this.loadButton.Text = "Загрузка волонтеров";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // volunterLabel
            // 
            this.volunterLabel.AutoSize = true;
            this.volunterLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.volunterLabel.ForeColor = System.Drawing.Color.Black;
            this.volunterLabel.Location = new System.Drawing.Point(326, 291);
            this.volunterLabel.Name = "volunterLabel";
            this.volunterLabel.Size = new System.Drawing.Size(200, 26);
            this.volunterLabel.TabIndex = 53;
            this.volunterLabel.Text = "Всего волонтеров:";
            // 
            // volunterNumberLabel
            // 
            this.volunterNumberLabel.AutoSize = true;
            this.volunterNumberLabel.Font = new System.Drawing.Font("Open Sans", 14.25F);
            this.volunterNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.volunterNumberLabel.Location = new System.Drawing.Point(523, 291);
            this.volunterNumberLabel.Name = "volunterNumberLabel";
            this.volunterNumberLabel.Size = new System.Drawing.Size(45, 26);
            this.volunterNumberLabel.TabIndex = 54;
            this.volunterNumberLabel.Text = "123";
            // 
            // volunterDataGrid
            // 
            this.volunterDataGrid.AllowUserToAddRows = false;
            this.volunterDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.volunterDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.volunterDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.volunterDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.volunterDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.volunterDataGrid.EnableHeadersVisualStyles = false;
            this.volunterDataGrid.Location = new System.Drawing.Point(53, 326);
            this.volunterDataGrid.Name = "volunterDataGrid";
            this.volunterDataGrid.ReadOnly = true;
            this.volunterDataGrid.RowHeadersVisible = false;
            this.volunterDataGrid.Size = new System.Drawing.Size(744, 233);
            this.volunterDataGrid.TabIndex = 55;
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
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.downPanel.Controls.Add(this.timerLabel);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 604);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(866, 60);
            this.downPanel.TabIndex = 71;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // managerLabel
            // 
            this.managerLabel.AutoSize = true;
            this.managerLabel.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managerLabel.ForeColor = System.Drawing.Color.Black;
            this.managerLabel.Location = new System.Drawing.Point(240, 71);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(426, 43);
            this.managerLabel.TabIndex = 72;
            this.managerLabel.Text = "Управление волонтерами";
            this.managerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.upPanel.TabIndex = 113;
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
            this.logoutButton.TabIndex = 112;
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
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // volunterManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 664);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.managerLabel);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.volunterDataGrid);
            this.Controls.Add(this.volunterNumberLabel);
            this.Controls.Add(this.volunterLabel);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.sortOfLabel);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.sortLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(866, 664);
            this.MinimumSize = new System.Drawing.Size(866, 664);
            this.Name = "volunterManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - Volunteer management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.volunterManagerForm_FormClosing);
            this.Load += new System.EventHandler(this.volunterManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volunterDataGrid)).EndInit();
            this.downPanel.ResumeLayout(false);
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.Label loadLabel;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Label sortOfLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label volunterLabel;
        private System.Windows.Forms.Label volunterNumberLabel;
        private System.Windows.Forms.DataGridView volunterDataGrid;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label managerLabel;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Button btnSwn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}