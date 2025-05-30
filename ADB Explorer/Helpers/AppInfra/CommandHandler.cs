﻿using ADB_Explorer.ViewModels;

namespace ADB_Explorer.Helpers;

public class CommandHandler : ICommand
{
    private readonly Action _action;
    private readonly Func<bool> _canExecute;

    /// <summary>
    /// Raises an event when the command is executed.
    /// </summary>
    public ObservableProperty<bool> OnExecute { get; set; } = new();

    public void Execute(object parameter)
    {
        _action();

        OnExecute.Value ^= true;
    }

    public bool CanExecute(object parameter)
    {
        return _canExecute.Invoke();
    }

    public CommandHandler(Action action, Func<bool> canExecute)
    {
        _action = action;
        _canExecute = canExecute;
    }

    public event EventHandler CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }

}

public class BaseAction : ViewModelBase
{
    private readonly Func<bool> canExecute;
    public bool IsEnabled => canExecute();

    private readonly Action action;

    private ICommand command;
    public ICommand Command => command ??= new CommandHandler(action, canExecute);

    public BaseAction(Func<bool> canExecute, Action action)
    {
        this.canExecute = canExecute ??= () => true;
        this.action = action;
    }

    public BaseAction()
    {
        canExecute = () => true;
        action = () => { };
    }

    public void Execute() => Command.Execute(null);
}
