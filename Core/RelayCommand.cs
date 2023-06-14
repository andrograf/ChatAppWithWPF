using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatAppWithWPF.Core
{
    class RelayCommand : ICommand
    {
        private Func<object, bool> _canExecuteChanged;
        private Action<object> _executeChanged;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        public bool CanExecute(object parameter)
        {
            return _canExecuteChanged == null || _canExecuteChanged(parameter);
        }

        public void Execute(object? parameter)
        {
            _executeChanged(parameter);
        }
    }
}
