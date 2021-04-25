using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Marathon
{
    public partial class authorizationForm : Form
    {
        public static string email; 

        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);

        string connection = @"Data Source=DENISPC\SQLEXPRESS;Initial Catalog=Marathon; Integrated Security = True";
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;

        DataTable table;
        public authorizationForm() //Инициализация формы
        {
            InitializeComponent();
            btnClose.Click += (s, e) => { Close(); };
            btnSwn.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            int move = 0, x = 0, y = 0;
            upPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            upPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            upPanel.MouseUp += (s, e) => { move = 0; };
            connectionSql = new SqlConnection(connection);
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void loginButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Login", проверка введенных данных в базе данных и переход на форму, согласно роли пользователя
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"SELECT [Email], [Password], [RoleId] FROM [dbo].[User] WHERE [Email] = '{emailTextBox.Text}' and [Password] = '{passwordTextBox.Text}'", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                table = dataSet.Tables[0];

                if (table.Rows.Count != 0)
                {
                    email = emailTextBox.Text;
                    DataRow dataRow = table.Rows[0];
                    if (dataRow[2].ToString() == "A")
                    {
                        authorizationForm.ActiveForm.Hide();
                        adminForm form = new adminForm();
                        form.Show();
                    }
                    if (dataRow[2].ToString() == "C")
                    {
                        authorizationForm.ActiveForm.Hide();
                        coordinatorForm form = new coordinatorForm();
                        form.Show();
                    }
                    if (dataRow[2].ToString() == "R")
                    {
                        authorizationForm.ActiveForm.Hide();
                        runnerForm form = new runnerForm();
                        form.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connectionSql.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Cancel", переход на главный экран
        {
            authorizationForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void authorizationForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие программы при закрытии формы
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            authorizationForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }
    }
}
