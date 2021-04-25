using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Marathon
{
    public partial class listOfCharitiesForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        string connection = @"Data Source=DENISPC\SQLEXPRESS;Initial Catalog=Marathon; Integrated Security = True";

        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        public listOfCharitiesForm() //Инициализировать форму
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

        private void listOfCharitiesForm_Load(object sender, EventArgs e) //Выгрузка всех организаций из БД и заполнение кастомного элемента для отображения организаций при загрузке формы
        {
            try
            {
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter("SELECT * from Charity", connectionSql);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                sponsorOrganizationUserControl[] control = new sponsorOrganizationUserControl[dataSet.Tables[0].Rows.Count];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    control[i] = new sponsorOrganizationUserControl();
                    control[i].Title = dataSet.Tables[0].Rows[i][1].ToString();
                    control[i].Message = dataSet.Tables[0].Rows[i][2].ToString();
                    control[i].Icon = Bitmap.FromFile(@"..\..\Images\" + dataSet.Tables[0].Rows[i][3].ToString());
                    control[i].Check = false;
                    
                    flowLayoutPanel.Controls.Add(control[i]);
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

        private void listOfCharitiesForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            listOfCharitiesForm.ActiveForm.Hide();
            informationForm form = new informationForm();
            form.Show();
        }
    }
}
