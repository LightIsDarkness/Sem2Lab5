using System.Windows.Input;

namespace Sem2Lab5.src
{
    public class RelayCommands : ICommand
    {
        private Action<object> execute;
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
        public RelayCommands(Action<object> execute)
        {
            this.execute = execute;
        }
    }
}
