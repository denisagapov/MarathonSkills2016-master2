using System;
using System.Windows.Forms;

namespace Marathon
{
    public partial class coordinatorForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public coordinatorForm() //Инициализация фрагмента
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
    
        private void coordinatorForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void runnersButton_Click(object sender, EventArgs e) //Переход на экран управления бегунами
        {
            coordinatorForm.ActiveForm.Hide();
            runnerManagerForm form = new runnerManagerForm();
            form.Show();
        }

        private void sponsorsButton_Click(object sender, EventArgs e) //Переход на форму отображения всех спонсоров
        {
            coordinatorForm.ActiveForm.Hide();
            sponsorshipViewForm form = new sponsorshipViewForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            coordinatorForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            coordinatorForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }
    }
}
