using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Marathon
{
    public partial class runnerForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);

        public runnerForm() //Инициализируем форму
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

        private void runnerForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void profileButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Редактирование профиля", переход на форму редактирования
        {
            runnerForm.ActiveForm.Hide();
            runnerProfileForm form = new runnerProfileForm();
            form.Show();
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            runnerForm.ActiveForm.Hide();
            raceAllForm  form = new raceAllForm();
            form.Show();
        }

        private void sponsorForm_Click(object sender, EventArgs e)
        {
            runnerForm.ActiveForm.Hide();
            sponsorshipForm form = new sponsorshipForm();
            form.Show();
        }

        private void contactsButton_Click(object sender, EventArgs e)
        {
            contactsForm form = new contactsForm();
            form.ShowDialog();
        }

        private void regMarathonButton_Click(object sender, EventArgs e)
        {
            runnerForm.ActiveForm.Hide();
            eventRegistrationForm form = new eventRegistrationForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            runnerForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            runnerForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }
    }
}
