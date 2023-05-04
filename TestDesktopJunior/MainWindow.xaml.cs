using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shell;

namespace test_desktop_junior
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowChrome windowChrome = new WindowChrome();//Своя не клиентская область окна
            windowChrome.ResizeBorderThickness = new Thickness(8);//Толщина рамки окна (для растягивания)
            windowChrome.CaptionHeight = 0;//Высота заголовка
            WindowChrome.SetWindowChrome(this, windowChrome);
           
            this.DataContext = new AplicationViewModel();
            InitializeComponent();
        }

    }
}
