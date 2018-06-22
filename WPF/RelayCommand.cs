using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Galazkiewicz.ProjectTireCatalog.WPF
{
    public class RelayCommand: ICommand
    {

        #region ICommand
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute != null)
            {
                return _canExecute(parameter);
            }

            return true;
        }

        public void Execute(object parameter)
        {
            if (_execute != null)
            {
                _execute(parameter);
            }
        }
        #endregion

        private Action<Object> _execute;
        private Predicate<Object> _canExecute;

        public RelayCommand(Action<Object> action)
        {
            _execute = action;
        }

        public RelayCommand(Action<Object> action, Predicate<Object> predicate)
        {
            _execute = action;
            _canExecute = predicate;
        }
    }
}
