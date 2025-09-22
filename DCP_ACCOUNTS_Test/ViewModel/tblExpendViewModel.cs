using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DCP_ACCOUNTS_Test.ViewModel
{
    public class tblExpendViewModel
    {

    }
    public class RelayCommand : ICommand {
        public RelayCommand(Func<object, Task> executeAsync) => _executeAsync = executeAsync;
        private readonly Func<object, Task> _executeAsync;
        
        public event EventHandler? CanExecuteChanged;
        public bool CanExecute(object? parameter) => true;
        public async void Execute(object? parameter) => await _executeAsync(parameter!);

    }
}
