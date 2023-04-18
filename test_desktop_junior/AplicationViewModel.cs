using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using test_desktop_junior.Resources.Classes;
using test_desktop_junior.Resources.Classes.test_desktop_junior.Resources.Classes;

namespace test_desktop_junior
{
    /// <summary>
    /// Модель отображения
    /// </summary>
    internal class AplicationViewModel : INotifyPropertyChanged
    {

        /// <summary>
        /// Коллекция функций
        /// </summary>
        public ObservableCollection<XYFunc> Funcs { get; set; }

        private Window _window;
        private Image _image;
        

        private RelayCommand _btClick;

        /// <summary>
        /// Обработчик нажжатия на кнопки управления окном
        /// </summary>
        public RelayCommand BtClick
        {
            get
            {
                return _btClick ??
                  (_btClick = new RelayCommand(obj =>
                  {
                      var param = obj as string;
                      switch (param)
                      {
                          case "Close":
                              {
                                  _window.Close();
                                  break;
                              }
                          case "Maximize":
                              {
                                  if (_window.WindowState == WindowState.Maximized)
                                  {
                                      _window.WindowState = WindowState.Normal;
                                      _image.Source = new BitmapImage(new Uri("/Resources/Images/MaximizeButton.png", UriKind.Relative));
                                  }
                                  else
                                  {
                                      _window.WindowState = WindowState.Maximized;
                                      _image.Source = new BitmapImage(new Uri("/Resources/Images/NormalizeButton.png", UriKind.Relative));
                                  }
                                  break;
                              }
                          case "Minimize":
                              {
                                  _window.WindowState = WindowState.Minimized;
                                  break;
                              }
                      }
                  }));
            }
        }

        private XYFunc _selectedFunc;

        /// <summary>
        /// Выбранная функция 
        /// </summary>
        public XYFunc SelectedFunc
        {
            get { return _selectedFunc; }
            set
            {
                _selectedFunc = value;
                OnPropertyChanged("SelectedFunc");
            }
        }

        /// <summary>
        /// Конструктор класса 
        /// </summary>
        /// <param name="window"> окно </param>
        /// <param name="image"> контейнер для измображения кнопки "Maximize/Normalize"</param>
        public AplicationViewModel(Window window, Image image)
        {
            _window = window;
            _image = image;

            Funcs = new ObservableCollection<XYFunc>()
            {
                new XYFunc("линейная", 1),
                new XYFunc("квадратичная", 2),
                new XYFunc("кубическая", 3),
                new XYFunc("4-ой степени", 4),
                new XYFunc("5-ой степени", 5),
            };
        }
        

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            _selectedFunc.Calculate();
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
