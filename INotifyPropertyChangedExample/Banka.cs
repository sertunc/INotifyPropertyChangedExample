using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace INotifyPropertyChangedExample
{
    public class Banka : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double para;

        public double Para
        {
            get => para;
            set
            {
                para = value;

                NotifyPropertyChanged();
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
