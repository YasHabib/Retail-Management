using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace Retail_Management_WPF.UserInterface.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private LoginViewModel _loginViewModel;
        public ShellViewModel(LoginViewModel loginViewModel)
        {

            _loginViewModel = loginViewModel;
            ActivateItemAsync(_loginViewModel);

        }
    }
}
