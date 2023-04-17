using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test_desktop_junior.Resources.Classes
{
    /// <summary>
    /// Класс строки таблицы
    /// </summary>
    internal class XYR : INotifyPropertyChanged
    {
        private double _x, _y, _res, _a, _b, _c, _pow;
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
        public double Res
        {
            get
            {
                return _res;
            }
            set
            {
                _res = value;
                OnPropertyChanged("Res");
            }
        }

        
        public XYR() {
            _x = 0; _y = 0; _res = 0;
        }
        /// <summary>
        /// Расчет функции после изменения внешних параметров класса
        /// </summary>
        public void Calc(double a, double b, double c, int pow)
        {
            _a = a;
            _b = b;
            _c = c;
            _pow = pow;
            Res = _a * Math.Pow(_x, _pow) + _b * Math.Pow(_y, _pow - 1) + _c;
        }
        /// <summary>
        /// Расчет функции после изменения внутренних параметров класса
        /// </summary>
        public void Calc()
        {
            Res = _a * Math.Pow(_x, _pow) + _b * Math.Pow(_y, _pow - 1) + _c;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
             
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }

        }
    }
}
