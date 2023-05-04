using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using test_desktop_junior.Resources.Classes;
using test_desktop_junior.Resources.Classes.test_desktop_junior.Resources.Classes;

namespace test_desktop_junior
{
    /// <summary>
    /// Модель отображения
    /// </summary>
    internal class AplicationViewModel : BaseViewModel
    {
        private BitmapImage _imageSource = new BitmapImage(new Uri("/Resources/Images/MaximizeButton.png", UriKind.Relative));
        private WindowState _thisWindowState;
        private RelayCommand _closeWindow;
        private RelayCommand _maximizeWindow;
        private RelayCommand _minimizeWindow;
        private Function _selectedFunction;
        private int _windowHeight = 750;
        private int _windowWidth = 1400;
        private int _columnProperty = 0;
        private int _rowProperty = 1;
        private int _rowSpanProperty = 2;
        private Thickness _margin = new Thickness(0, 50, 0, 0);

        /// <summary>
        /// Коллекция функций
        /// </summary>
        public ObservableCollection<Function> Funcs { get; set; }
        public WindowState ThisWindowState { get => _thisWindowState; set { _thisWindowState = value; OnPropertyChanged("ThisWindowState"); } }
        public BitmapImage ImageSource
        {
            get => _imageSource; set
            {
                _imageSource = value;
                OnPropertyChanged("ImageSource");
            }
        }
        /// <summary>
        /// Отслеживание изменения размеров окна
        /// </summary>
        private void UpdateWindowSize()
        {
            WindowWidth = (int)Application.Current.MainWindow.ActualWidth;
            WindowHeight = (int)Application.Current.MainWindow.ActualHeight;
        }
        /// <summary>
        /// Команда закрытия окна
        /// </summary>
        public RelayCommand CloseWindow
        {
            get
            {
                return _closeWindow ??
                    (_closeWindow = new RelayCommand(obj =>
                    {
                        var param = obj as Window;
                        param.Close();
                    }));
            }
        }
        /// <summary>
        /// Команда "Развернуть"
        /// </summary>
        public RelayCommand MaximizeWindow
        {
            get
            {
                return _maximizeWindow ??
                  (_maximizeWindow = new RelayCommand(obj =>
                  {
                      if (ThisWindowState == WindowState.Maximized)
                      {
                          ThisWindowState = WindowState.Normal;
                          ImageSource = new BitmapImage(new Uri("/Resources/Images/MaximizeButton.png", UriKind.Relative));
                      }
                      else
                      {
                          ThisWindowState = WindowState.Maximized;
                          ImageSource = new BitmapImage(new Uri("/Resources/Images/NormalizeButton.png", UriKind.Relative));
                      }
                  }));
            }
        }
        /// <summary>
        /// Команда "Свернуть"
        /// </summary>
        public RelayCommand MinimizeWindow
        {
            get
            {
                return _minimizeWindow ??
                  (_minimizeWindow = new RelayCommand(obj =>
                  {
                      ThisWindowState = WindowState.Minimized;
                  }));
            }
        }
        /// <summary>
        /// Выбранная функция 
        /// </summary>
        public Function SelectedFunction
        {
            get { return _selectedFunction; }
            set
            {
                _selectedFunction = value;
                OnPropertyChanged("SelectedFunction");
            }
        }
        /// <summary>
        /// Высота окна 
        /// </summary>
        public int WindowHeight { get => _windowHeight; set
            {
                if (_windowHeight != value)
                {
                    _windowHeight = value;
                }
                
                OnPropertyChanged("WindpwHeight");
            }
        }
        /// <summary>
        /// Ширина окна
        /// </summary>
        public int WindowWidth { get => _windowWidth; set
            {
                if (_windowWidth != value) {
                    _windowWidth = value;
                    if (WindowWidth < 1400)
                    {
                        ColumnProperty = 0;
                        RowProperty = 1;
                        RowSpanProperty = 2;
                        Margin = new Thickness(0, 50, 0, 0);

                    }
                    else
                    {
                        ColumnProperty = 2;
                        RowProperty = 0;
                        RowSpanProperty = 1;
                        Margin = new Thickness(50, 0, 0, 0);
                    }
                }
                
                OnPropertyChanged("WindowWidth");
            }
        }
        /// <summary>
        /// Колонка grid, в которой размещена таблица 
        /// </summary>
        public int ColumnProperty { get => _columnProperty; set 
            { 
                _columnProperty = value;
                OnPropertyChanged("ColumnProperty");
            }
        }
        /// <summary>
        /// Строка grid, в которой размещена таблица 
        /// </summary>
        public int RowProperty { get => _rowProperty; set 
            { 
                _rowProperty = value;
                OnPropertyChanged("RowProperty");
            }
        }
        /// <summary>
        /// Объединение Строк
        /// </summary>
        public int RowSpanProperty { get => _rowSpanProperty; set 
            {
                _rowSpanProperty = value;
                OnPropertyChanged("RowSpanProperty");
            }
        }
        /// <summary>
        /// Отступ таблицы
        /// </summary>
        public Thickness Margin { get => _margin; set
            {
                _margin = value;
                OnPropertyChanged("Margin");

            }
        }



        /// <summary>
        /// Конструктор класса 
        /// </summary>
        public ICommand DragWindowCommand { get; }
        public AplicationViewModel()
        {
            UpdateWindowSize();
            DragWindowCommand = new DragWindowCommand();
            Application.Current.MainWindow.SizeChanged += (s, e) =>
            {
                UpdateWindowSize();
            };

            Funcs = new ObservableCollection<Function>()
            {
                new Function("линейная","f(x,y) = ax^1 + by^0 + c", 1),
                new Function("квадратичная", "f(x,y) = ax^2 + by^1 + c", 2),
                new Function("кубическая", "f(x,y) = ax^3 + by^2 + c", 3),
                new Function("4-ой степени", "f(x,y) = ax^4 + by^3 + c", 4),
                new Function("5-ой степени", "f(x,y) = ax^5 + by^4 + c", 5),
            };
        }
        
    }

}
