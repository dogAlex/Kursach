using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для PeopleInfo.xaml
    /// </summary>
    public partial class PeopleInfo : Window
    {
        private void shomaretextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // xaml.cs code
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }
        public PeopleInfo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBox.Show("Аккаунт успешно зарегестрированн","Регистрация завершена",button,icon,MessageBoxResult.OK);

            System.Threading.Thread.Sleep(50);
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
