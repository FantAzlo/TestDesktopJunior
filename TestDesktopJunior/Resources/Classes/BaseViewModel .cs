using System.ComponentModel;

namespace test_desktop_junior.Resources.Classes
{
    /// <summary>
    /// Базовый класс, реализующиий INotifyPropertyChanged
    /// </summary>
    internal class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
