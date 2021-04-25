using System;
using System.Data;
using System.Data.SqlClient;

using System.IO;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Marathon
{
    public partial class runnerRegistrationForm : Form
    {
        Bitmap image;
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);

        string connection = @"Data Source=DENISPC\SQLEXPRESS;Initial Catalog=Marathon; Integrated Security = True";
        SqlConnection connectionSql;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        string imageLocation = "";
        public runnerRegistrationForm() //Инициализация формы
        {
            InitializeComponent();
            btnClose.Click += (s, e) => { Close(); };
            btnSwn.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            int move = 0, x = 0, y = 0;
            upPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            upPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            upPanel.MouseUp += (s, e) => { move = 0; };
            connectionSql = new SqlConnection(connection);
            sexComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }


        private void registerButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Сохранить", добавление нового пользователя в базу данных + картинка
        {
            string result = checkToAdd();
            if (result == "ОК")
            {
                try
                {
                    connectionSql.Open();
                    
                    command = new SqlCommand($"insert into [dbo].[User] (Email, Password, FirstName, LastName, RoleId) values('{emailTextBox.Text}', '{passwordTextBox.Text}','{nameTextBox.Text.ToUpper()}','{lastNameTextBox.Text.ToUpper()}','R')", connectionSql);
                    command.ExecuteNonQuery();
                    connectionSql.Close();

                    if (photoTextBox.Text != "")
                    {
                        byte[] image = null;
                        FileStream fileStream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader binaryReader = new BinaryReader(fileStream);
                        image = binaryReader.ReadBytes((int)fileStream.Length);
                    }

                    connectionSql.Open();
                    command = new SqlCommand($"insert into [dbo].[Runner] (Email, Gender, DateOfBirth, CountryCode) values('{emailTextBox.Text}','{sexComboBox.Text}', '{birthDateTimePicker.Value}','{countryComboBox.Text}')", connectionSql);
                    command.ExecuteNonQuery();

                    authorizationForm.email = emailTextBox.Text;
                    runnerRegistrationForm.ActiveForm.Hide();
                    eventRegistrationForm form = new eventRegistrationForm();
                    form.Show();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    connectionSql.Close();
                }
            } else
            {
                MessageBox.Show(result);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Отмена", переход на главное меню
        {
            runnerRegistrationForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void runnerRegistrationForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие программы при закрытии формы
        {
            Application.Exit();
        }

        private void photoButton_Click(object sender, EventArgs e) // Открытие диалогового окна с картинкой
        {
            var Path = new OpenFileDialog();
            Path.Filter = "Image files (*.png;*.jpeg;*.jpg;*.bmp)|*.png;*.jpeg;*.jpg;*.bmp";
            if (Path.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(Path.FileName);
                    imageLocation = Path.FileName;
                    photoTextBox.Text= Path.FileName;
                    photoPictureBox.Image = image;
                    photoPictureBox.Invalidate();
                }
                catch (NotSupportedException)
                {
                    MessageBox.Show("Ошибка загрузки файла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void runnerRegistrationForm_Load(object sender, EventArgs e) //загрузка всех методов при загрузке формы
        {
            loadGender();
            loadCountries();
        }

        private void loadGender() //загрузка полов и выгрузка их в список
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT * from Gender", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                sexComboBox.DataSource = dataSet.Tables[0];
                sexComboBox.DisplayMember = "Gender";
                sexComboBox.ValueMember = "Gender";

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

        private void loadCountries() //загрузка стран и выгрузка их в список
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT [CountryCode] from Country", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                countryComboBox.DataSource = dataSet.Tables[0];
                countryComboBox.DisplayMember = "CountryCode";
                countryComboBox.ValueMember = "CountryCode";

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

        private string checkToAdd() //все проверки на текст, пароль и имейл
        {
            if (emailTextBox.Text == "" || passwordTextBox.Text == "" || passwordAgainTextBox.Text == "" || nameTextBox.Text == "" || lastNameTextBox.Text == "" || sexComboBox.Text == "" || countryComboBox.Text == "")
                return "Не все поля заполнены";

            try { var mail = new System.Net.Mail.MailAddress(emailTextBox.Text); }
            catch { return "Некорректный e-mail адрес"; }

            if (passwordTextBox.Text.Length < 6 || !Regex.IsMatch(passwordTextBox.Text, @"[0-9]") || !Regex.IsMatch(passwordTextBox.Text, @"[A-Z]") || !Regex.IsMatch(passwordTextBox.Text, @"[!@#$%^]"))
                return "Неверно введен пароль. Пароль должен имень минимум 6 символов, 1 прописную букву, 1 цифру и один из этих символов: !@#$%^";

            if (passwordTextBox.Text != passwordAgainTextBox.Text)
                return "Пароли не совпадают";

            DateTime today = DateTime.Today;
            if (today.Subtract(birthDateTimePicker.Value).Days / 365 < 10)
                return "Вам еще не исполнилось 10 лет";

            if (!nameTextBox.Text.All(c => char.IsLetter(c)))
                return "В имени есть лишние символы";

            if (!lastNameTextBox.Text.All(c => char.IsLetter(c)))
                return "В фамилии есть лишние символы";

            return "ОК";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            runnerRegistrationForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }
    }
}
