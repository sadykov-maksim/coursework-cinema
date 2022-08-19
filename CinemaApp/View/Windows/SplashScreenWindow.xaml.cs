using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CinemaApp.Classes;
using CinemaApp.View.Windows;

namespace CinemaApp.View.Windows
{
    /// <summary>
    /// Interaction logic for SplashScreenWindow.xaml
    /// </summary>
    public partial class SplashScreenWindow : Window
    {
        AssemblyClass assembly = new AssemblyClass();
        DatabaseClass database = new DatabaseClass();
        public SplashScreenWindow()
        {
            InitializeComponent();
        }
        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            Database();

        }
        private void WindowInitialized(object sender, EventArgs e)
        {
            this.Title = "Инициализация приложения...";
            TBlockAppStatus.Text = "Запуск «АРМ администратора кинозала»";
            TBlockAppVersion.Text = Convert.ToString(assembly.GetAppVersion());
        }
        private void Database()
        {
            WorkspaceWindow workspaceWindow = new WorkspaceWindow();
            try
            {
                database.CheckingConnection();
                TBlockAppStatus.Text = "Успешное подключение к базе данных";
                this.Close();
                workspaceWindow.Show();
            }
            catch (Exception ex)
            {
                TBlockAppStatus.Text = $"{ex.Message}";
            }
        }
        private void WindowMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void WindowClosing(object sender, CancelEventArgs e)
        {
            //((App)Application.Current).AppClosing(e);
        }
        private void BtnMinimizeClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnCloseClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
