using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CinemaApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ApplicationStartup(object sender, StartupEventArgs e)
        {

        }
        public void AppClosing(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            if (e.Cancel == true)
            {
                MessageBoxButton messageBoxButton = MessageBoxButton.YesNo;
                MessageBoxResult messageBoxResult = MessageBox.Show("Вы уверены, что хотите выйти из приложения?", "Выход из приложения", messageBoxButton, MessageBoxImage.Question);
                switch (messageBoxResult)
                {
                    case MessageBoxResult.Yes:
                        Environment.Exit(0);
                        break;
                    case MessageBoxResult.No:
                        break;
                    default:
                        break;
                }
            }
            else if (e.Cancel == false)
            {

            }
        }
    }
}
