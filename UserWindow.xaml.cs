using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace clientAppDB
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        string connectionString;

        public UserWindow()
        {
            InitializeComponent();

            comboBox1.Items.Add("Услуги");
            comboBox1.Items.Add("Заказы");
            comboBox1.Items.Add("Должности");
            comboBox1.Items.Add("Сотрудники");

        }


        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void NarrowButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void WideButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                //NarrowButton.Content = "1";
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                // NarrowButton.Content = "2";
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["clientAppDB.Properties.Settings.advertising_agencyConnectionString"].ConnectionString;

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                string sql = "SELECT * FROM orders";
                MySqlCommand cmd = new MySqlCommand(sql, connection);

                connection.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridDB.DataContext = dt;
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error" + ex);
            }

        }
    }
}
