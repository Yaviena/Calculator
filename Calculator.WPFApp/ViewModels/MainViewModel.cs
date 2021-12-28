using Calculator.WPFApp.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Calculator.WPFApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _screenVal;

        public MainViewModel()
        {
            ScreenVal = "0";
            AddNumberCommand = new RelayCommand(AddNumber);
            AddOperationCommand = new RelayCommand(AddOperation);
            ClearScreenCommand = new RelayCommand(ClearScreen);
            GetResultCommand = new RelayCommand(ClearScreen);
        }

        private void ClearScreen(object obj)
        {
            throw new NotImplementedException();
        }

        private void AddOperation(object obj)
        {
            throw new NotImplementedException();
        }

        private void AddNumber(object obj)
        {
            MessageBox.Show(obj as string);
        }

        public ICommand AddNumberCommand { get; set; }
        public ICommand AddOperationCommand { get; set; }
        public ICommand ClearScreenCommand { get; set; }
        public ICommand GetResultCommand { get; set; }

        public string ScreenVal
        {
            get { return _screenVal; }
            set
            {
                _screenVal = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
