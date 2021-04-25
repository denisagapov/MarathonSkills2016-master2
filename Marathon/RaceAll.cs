using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Marathon
{
    public partial class raceAllForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        string connection = @"Data Source=DENISPC\SQLEXPRESS;Initial Catalog=Marathon; Integrated Security = True";

        int minAge, maxAge = 0;
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        DataTable table;
        public raceAllForm() //Инициализируем форму
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
        private void showButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Показать все результаты", переход на экран со всеми результатами
        {
            raceResult.ActiveForm.Hide();
            raceAllForm form = new raceAllForm();
            form.Show();
        }

        private void raceAllForm_Load(object sender, EventArgs e)  //Загружаем все виды марафонов в список
        {
            try
            {
                takeAgesAndGender();
                connectionSql.Open();

                string query = "SELECT [RegistrationId], [MarathonName] as 'Марафон', [EventTypeName] as 'Дистанция', CONVERT(nvarchar, CONVERT(datetime, [RaceTime]/100000.0), 8)  AS 'Время' " +
                    "FROM[RegistrationEvent] " +
                    "inner join[Event] on[RegistrationEvent].[EventId] = [Event].[EventId] " +
                    "inner join[Marathon] on Event.[MarathonId] = [Marathon].[MarathonId] " +
                    "inner join[EventType] on Event.EventTypeId = EventType.EventTypeId " +
                    "where[RegistrationId] = (select RegistrationId from Registration where RunnerId = " +
                    $"(select RunnerId from Runner where Email = '{authorizationForm.email}'))";

                dataAdapter = new SqlDataAdapter(query, connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                table = dataSet.Tables[0];

                resultDataGrid.DataSource = table;
                resultDataGrid.Columns[0].Visible = false;
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
        private void takeAgesAndGender()//Выставляем диапазон возраста в зависимости от возраста нашего пользователя
        {
            try
            {
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter($"select YEAR(GETDATE())-YEAR([DateOfBirth]), [Gender] from [Runner] where  Email = '{authorizationForm.email}'", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                int age = (int)dataSet.Tables[0].Rows[0][0];
                sexLoadLabel.Text = (string)dataSet.Tables[0].Rows[0][1];

                if (age < 18)
                {
                    minAge = 0;
                    maxAge = 17;
                }
                if (age >= 18 && age <= 29)
                {
                    minAge = 18;
                    maxAge = 29;
                }
                if (age >= 30 && age <= 39)
                {
                    minAge = 30;
                    maxAge = 39;
                }
                if (age >= 40 && age <= 55)
                {
                    minAge = 40;
                    maxAge = 55;
                }
                if (age >= 56 && age <= 70)
                {
                    minAge = 56;
                    maxAge = 70;
                }
                if (age > 70)
                {
                    minAge = 71;
                    maxAge = 120;
                }
                ageLoadLabel.Text = $"{minAge}-{maxAge}";
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

        private void backButton_Click(object sender, EventArgs e)
        {
            raceResult.ActiveForm.Hide();
            runnerForm form = new runnerForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            raceResult.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void raceAllForm_FormClosing(object sender, FormClosingEventArgs e) //Закрываем приложение при закрытии формы
        {
            Application.Exit();
        }
    }
}