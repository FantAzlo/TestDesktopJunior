using System;

namespace test_desktop_junior.Resources.Classes
{
    /// <summary>
    /// Класс строки таблицы
    /// </summary>
    internal class FunctionRow : BaseViewModel
    {
        private double _x, _y, _result, _a, _b, _c, _power;
        /// <summary>
        /// Переменная X
        /// </summary>
        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
                Calc();
                
                OnPropertyChanged("X");
            }
        }
        /// <summary>
        /// Переменная Y
        /// </summary>
        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
                Calc();
                
                OnPropertyChanged("Y");
            }
        }
        /// <summary>
        /// Результат
        /// </summary>
        public double Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public FunctionRow() {
            _x = 0; _y = 0; _result = 0;
        }
        /// <summary>
        /// Расчет функции после изменения внешних параметров класса
        /// </summary>
        public void Calculate(double a, double b, double c, int power)
        {
            _a = a;
            _b = b;
            _c = c;
            _power = power;
            Result = _a * Math.Pow(_x, _power) + _b * Math.Pow(_y, _power - 1) + _c;
        }
        /// <summary>
        /// Расчет функции после изменения внутренних параметров класса
        /// </summary>
        public void Calc()
        {
            Result = _a * Math.Pow(_x, _power) + _b * Math.Pow(_y, _power - 1) + _c;
        }
        
    }
}
