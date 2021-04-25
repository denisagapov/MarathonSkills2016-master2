using System;
using System.Windows.Forms;

namespace Marathon
{
    public partial class adminForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public adminForm() //Инициализация формы
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

        private void logoutButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Logout", переход на главный экран
        {
            adminForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void adminForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void inventoryButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Инвентарь", переход на экран инвентаря
        {
            adminForm.ActiveForm.Hide();
            inventoryForm form = new inventoryForm();
            form.Show();
        }

        private void volunterButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Волонтеры", переход на экран управления волонтерами
        {
            adminForm.ActiveForm.Hide();
            volunterManagerForm form = new volunterManagerForm();
            form.Show();

        }

        private void charityButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Благотворительные организации", переход на экран с организациями
        {
            adminForm.ActiveForm.Hide();
            foundationManagerForm form = new foundationManagerForm();
            form.Show();
        }

        private void usersButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Пользователи", переход на экран управления пользователями
        {
           
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            adminForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }
    }
}
