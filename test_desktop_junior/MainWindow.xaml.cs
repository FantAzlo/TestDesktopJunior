using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using test_desktop_junior.Resources.Classes;

namespace test_desktop_junior
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowChrome windowChrome = new WindowChrome();
            windowChrome.ResizeBorderThickness = new Thickness(8);
            windowChrome.CaptionHeight = 0;

            WindowChrome.SetWindowChrome(this, windowChrome);

            InitializeComponent();
            this.DataContext = new AplicationViewModel(this, maximize_bt);        
        }

        /// <summary>
        /// Валидация ввода, не нашел адекватной реализации для MVVM без огромного кода
        /// </summary>
        public void IsAllowedInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.-]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        /// <summary>
        /// Перетаскивание окна
        /// </summary>
        private void HeadPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }


        /// <summary>
        /// Адаптивность
        /// </summary>
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Console.WriteLine("size_changed");
            if (main_window.Width < 1400)
            {
                data_table_panel.SetValue(Grid.ColumnProperty, 0);
                data_table_panel.SetValue(Grid.RowProperty, 1);
                data_table_panel.SetValue(Grid.RowSpanProperty, 2);
                data_table_panel.Margin = new Thickness(0, 50, 0, 0);
                
            }
            else
            {
                data_table_panel.SetValue(Grid.ColumnProperty, 2);
                data_table_panel.SetValue(Grid.RowProperty, 0);
                data_table_panel.SetValue(Grid.RowSpanProperty, 1);
                data_table_panel.Margin = new Thickness(50, 0, 0, 0);
            }
            if (main_window.Height >= 600)
            {
                head_panel.Height = main_window.Height * 0.11;
            }
            
        }

    }
}
