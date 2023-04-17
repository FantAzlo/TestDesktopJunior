using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using test_desktop_junior.Resources.Classes.test_desktop_junior.Resources.Classes;


[assembly: InternalsVisibleToAttribute("Test_test_desktop_junior")]
namespace test_desktop_junior.Resources.Classes
{
    /// <summary>
    /// Класс функции
    /// </summary>
    
    internal class XYFunc : INotifyPropertyChanged
    {
        private string _name;
        private double _varA;
        private double _varB;
        private int _varC;
        private double[] _cVariants;
        private int _pow;
        private ObservableCollection<XYR> _data = new ObservableCollection<XYR>();
        private RelayCommand _addCommand;

        /// <summary>
        /// Имя функции
        /// </summary>
        public string Name { get { return _name; } }

        /// <summary>
        /// Параметр A
        /// </summary>
        public double A
        {
            get { return _varA; }
            set {
                _varA = value;
                OnPropertyChanged("A");
            }
        }

        
        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ??
                  (_addCommand = new RelayCommand(obj =>
                  {
                      AddStr();
                  }));
            }
        }

        /// <summary>
        /// Параметр B
        /// </summary>
        public double B 
        {
            get { return _varB; }
            set
            {
                _varB = value;
                OnPropertyChanged("B");
            }
        }

        /// <summary>
        /// Параметр C
        /// </summary>
        public int C
        {
            get { return _varC; }
            set
            {
                _varC = value;
                OnPropertyChanged("C");
            }
        }


        /// <summary>
        /// Варианты параметра С 
        /// </summary>
        public double[] CVariants 
        { 
            get { return _cVariants; } 
        }


        /// <summary>
        /// Степень фукции
        /// </summary>
        public int Pow { get;}

        /// <summary>
        /// Коллекция строк таблицы
        /// </summary>
        public ObservableCollection<XYR> Data
        {
            get { return _data; }
        }


        /// <summary>
        /// Конструктор класса функции
        /// </summary>
        /// <param name="Name">Имя функции</param>
        /// <param name="pow">Степень функции</param>
        public XYFunc(string Name, int pow)
        {
            _varA = 0; _varB = 0; _varC = 0;
            _pow = pow;
            _name = Name;
            _cVariants = new double[5];
            
            var n = pow - 1;
            _cVariants[0] = 1 * Math.Pow(10, n);
            _cVariants[1] = 2 * Math.Pow(10, n);
            _cVariants[2] = 3 * Math.Pow(10, n);
            _cVariants[3] = 4 * Math.Pow(10, n);
            _cVariants[4] = 5 * Math.Pow(10, n);

            AddStr();
        }

        /// <summary>
        /// Добавление строки в таблицу
        /// </summary>
        public void AddStr()
        {
            _data.Add(new XYR());
            Calculate();
        }

        /// <summary>
        /// Расчет таблицы
        /// </summary>
        public void Calculate()
        {
            foreach(XYR d in _data)
            {
                d.Calc(_varA, _varB, _cVariants[_varC], _pow);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            Calculate();
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }

}
