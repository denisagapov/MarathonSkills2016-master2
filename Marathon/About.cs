using System;
using System.Windows.Forms;

namespace Marathon
{
    public partial class aboutForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public aboutForm() //Инициализация формы
        {
            InitializeComponent();
            btnClose.Click += (s, e) => { Close(); };
            btnSwn.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            int move = 0, x = 0, y = 0;
            upPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            upPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            upPanel.MouseUp += (s, e) => { move = 0; };
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера, который отображается внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void aboutForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void mapPictureBox_Click(object sender, EventArgs e) //Нажатие на карту и переход к ее информации
        {
            aboutForm.ActiveForm.Hide();
            mapForm form = new mapForm();
            form.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            aboutForm.ActiveForm.Hide();
            informationForm form = new informationForm();
            form.Show();
        }
    }
}
