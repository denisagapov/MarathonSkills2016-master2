using System;
using System.Windows.Forms;

namespace Marathon
{
    public partial class mainMenuForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public mainMenuForm() //Инициализация объекта
        {
            InitializeComponent();
            btnClose.Click += (s, e) => { Close(); };
            btnSwn.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            int move = 0, x = 0, y = 0;
            upPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            upPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            upPanel.MouseUp += (s, e) => { move = 0; };
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void loginButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Login", переход на экран авторизации
        {
            mainMenuForm.ActiveForm.Hide();
            authorizationForm form = new authorizationForm();
            form.Show();

        }

        private void mainMenuForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void runnerButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Я хочу стать бегуном", переход на экран выбора
        {
            mainMenuForm.ActiveForm.Hide();
            choseForm form = new choseForm();
            form.Show();
        }

        private void sponsorButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Я хочу стать спонсором бегуна", переход на экран регистрации спонсора
        {
            mainMenuForm.ActiveForm.Hide();
            sponsorForm form = new sponsorForm();
            form.Show();
        }

        private void infoButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Я хочу узнать больше о событии", переход на экран информации
        {
            mainMenuForm.ActiveForm.Hide();
            informationForm form = new informationForm();
            form.Show();
        }
    }
}
