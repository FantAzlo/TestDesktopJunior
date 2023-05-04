using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using test_desktop_junior.Resources.Classes.test_desktop_junior.Resources.Classes;


[assembly: InternalsVisibleToAttribute("UnitTests")]
namespace test_desktop_junior.Resources.Classes
{
    /// <summary>
    /// Класс функции
    /// </summary>

    internal class Function : BaseViewModel
    {
        private string _name;
        private string _description;
        private double _varA;
        private double _varB;
        private int _varC;
        private double[] _cVariants;
        private int _power;
        private ObservableCollection<FunctionRow> _data = new ObservableCollection<FunctionRow>();
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
                Calculate();
                OnPropertyChanged("A");
            }
        }

        /// <summary>
        /// Добавление строки
        /// </summary>
        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ??
                  (_addCommand = new RelayCommand(obj =>
                  {
                      AddRow();
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
                Calculate();
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
                Calculate();
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
        public int Power { get;}

        /// <summary>
        /// Коллекция строк таблицы
        /// </summary>
        public ObservableCollection<FunctionRow> Data
        {
            get { return _data; }
        }

        public string Description { get => _description; set => _description = value; }

        /// <summary>
        /// Конструктор класса функции
        /// </summary>
        /// <param name="Name">Имя функции</param>
        /// <param name="Power">Степень функции</param>
        public Function(string Name, string Description, int Power)
        {
            _varA = 0; _varB = 0; _varC = 0;
            _power = Power;
            _name = Name;
            _description = Description;
            _cVariants = new double[5];
            
            var n = Power - 1;
            _cVariants[0] = 1 * Math.Pow(10, n);
            _cVariants[1] = 2 * Math.Pow(10, n);
            _cVariants[2] = 3 * Math.Pow(10, n);
            _cVariants[3] = 4 * Math.Pow(10, n);
            _cVariants[4] = 5 * Math.Pow(10, n);

            AddRow();
        }

        /// <summary>
        /// Добавление строки в таблицу
        /// </summary>
        public void AddRow()
        {
            _data.Add(new FunctionRow());
            Calculate();
        }

        /// <summary>
        /// Расчет таблицы
        /// </summary>
        public void Calculate()
        {
            foreach(FunctionRow d in _data)
            {
                d.Calculate( _varA, _varB, _cVariants[_varC], _power);
            }
        }

    }

}
