// <copyright file="RelayCommand.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hoczkiewicz.Audi.Utils
{
    using System;
    using System.Windows.Input;

    internal class RelayCommand : ICommand
    {
        private Action action;
        private bool canExecute;

        public RelayCommand(Action action, bool canExecute)
        {
            this.action = action;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return this.canExecute;
        }

        public void Execute(object parameter)
        {
            this.action();
        }
    }
}
