using System;

namespace INotifyPropertyChangedExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Banka banka = new Banka();
            banka.PropertyChanged += Banka_PropertyChanged;
            banka.Para += 100;

            Console.Read();
        }

        private static void Banka_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine("Para eklendi");
        }
    }
}
