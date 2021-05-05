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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //string connectionString;
        SqlDataAdapter adapter;
        DataTable phonesTable;


        public MainWindow()
        {

        }

        
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            /*string sql = "SELECT * FROM Phones";
            phonesTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);

                // установка команды на добавление для вызова хранимой процедуры
                adapter.InsertCommand = new SqlCommand("sp_InsertPhone", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@title", SqlDbType.NVarChar, 50, "Title"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@company", SqlDbType.NVarChar, 50, "Company"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@price", SqlDbType.Int, 0, "Price"));
                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                parameter.Direction = ParameterDirection.Output;

                connection.Open();
                adapter.Fill(phonesTable);
                phonesGrid.ItemsSource = phonesTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }*/
        }

        private void UpdateDB()
        {
           // SqlCommandBuilder comandbuilder = new SqlCommandBuilder(adapter);
          //  adapter.Update(phonesTable);
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
           // UpdateDB();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
           /* if (phonesGrid.SelectedItems != null)
            {
                for (int i = 0; i < phonesGrid.SelectedItems.Count; i++)
                {
                    DataRowView datarowView = phonesGrid.SelectedItems[i] as DataRowView;
                    if (datarowView != null)
                    {
                        DataRow dataRow = (DataRow)datarowView.Row;
                        dataRow.Delete();
                    }
                }
            }
            UpdateDB();*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          /*  connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                string sql = "SELECT * FROM orders";
                MySqlCommand cmd = new MySqlCommand(sql, connection);

                connection.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridDB.DataContext = dt;
            }
            catch (MySqlException ex) {
                MessageBox.Show("error" +ex);
            }*/
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
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

        private void NarrowButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            RegWind regWind = new RegWind();
            regWind.Show();
            this.Hide();
        }

        private void EnterButton_Clik(object sender, RoutedEventArgs e)
        {
            UserWindow userWind = new UserWindow();
            userWind.Show();
            this.Hide();
        }
    }
}

