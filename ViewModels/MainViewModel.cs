using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace WPF_LoginForm.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        //Fields
        private ViewModelBase _currentChildView;
        private CustomerViewModel _customerViewModel;
        private HomeViewModel _homeViewModel;

        public ViewModelBase CurrentChildView
        {
            get
            {
                return _currentChildView;
            }
            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }

        
        //--> Commands
        public ICommand ShowHomeViewCommand { get; }
        public ICommand ShowCustomerViewCommand { get; }
        public MainViewModel()
        {
            _customerViewModel = new CustomerViewModel();
            _homeViewModel = new HomeViewModel();


            //Initialize commands
            ShowHomeViewCommand = new ViewModelCommand(ExecuteShowHomeViewCommand);
            ShowCustomerViewCommand = new ViewModelCommand(ExecuteShowCustomerViewCommand);
            //Default view
            ExecuteShowHomeViewCommand(null);
           
            LoadCurrentUserData();
        }
        private void ExecuteShowCustomerViewCommand(object obj)
        {
            CurrentChildView = _customerViewModel;
        }
        private void ExecuteShowHomeViewCommand(object obj)
        {
            CurrentChildView = _homeViewModel;
        }
        private void LoadCurrentUserData()
        {
            
        }
    }
}
