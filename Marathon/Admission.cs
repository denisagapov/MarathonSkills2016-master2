using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Marathon
{
    public partial class admissionForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        string connection = @"Data Source=DENISPC\SQLEXPRESS;Initial Catalog=Marathon; Integrated Security = True";

        SqlConnection connectionSql;
        SqlCommand command;
        public admissionForm() //Инициализация формы
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
   
        private void admissionForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Сохранить", обновление данных из базы данных
        {
            try
            {
                connectionSql.Open();
                if (int.TryParse(idTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(idTextBox.Text)} where InventoryId = 1", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(rfidTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(rfidTextBox.Text)} where InventoryId = 2", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(baseballTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(baseballTextBox.Text)} where InventoryId = 3", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(waterTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(waterTextBox.Text)} where InventoryId = 4", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(tshirtTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(tshirtTextBox.Text)} where InventoryId = 5", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(souvenirTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(souvenirTextBox.Text)} where InventoryId = 6", connectionSql);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Данные успешно обновлены!");
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
            admissionForm.ActiveForm.Hide();
            inventoryForm form = new inventoryForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            admissionForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }
    }
}
