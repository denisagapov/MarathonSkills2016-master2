using System;
using System.Windows.Forms;

namespace Marathon
{
    public partial class choseForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public choseForm() //Инициализируем форму
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
        private void beforeButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Я учавствовал ранее", переход на эран авторизации
        {
            choseForm.ActiveForm.Hide();
            authorizationForm form = new authorizationForm();
            form.Show();

        }

        private void newButton_Click(object sender, EventArgs e)// Нажатие на кнопку "Я новый участник", переход на экран регистрации бегуна
        {
            choseForm.ActiveForm.Hide();
            runnerRegistrationForm form = new runnerRegistrationForm();
            form.Show();
        }

        private void choseForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            choseForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }
    }
}
