using System;
using System.Windows.Input;
using System.Windows;

namespace test_desktop_junior.Resources.Classes
{
    /// <summary>
    /// Обработка перетаскивания окна
    /// </summary>
    public class DragWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var window = (Window)parameter;
            window.DragMove();
        }
    }
}
