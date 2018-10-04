// <copyright file="MainWindowViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hoczkiewicz.Audi.ViewModel
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows.Input;
    using Hoczkiewicz.Audi.CORE;
    using Hoczkiewicz.Audi.INTERFACES;
    using Hoczkiewicz.Audi.Utils;
    using static Hoczkiewicz.Audi.INTERFACES.Interfaces;

    internal class MainWindowViewModel
    {
        private BL.BL businessLogisticsLayer = new BL.BL();

        private ObservableCollection<IAudi> audis;

        private IAudi selectedAudi;

        private ICommand addNewCommand;
        private ICommand removeCommand;
        private bool canExecute;

        public MainWindowViewModel()
        {
            this.Audis = this.BusinessLogisticsLayer.GetDataBase();

            this.canExecute = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<IAudi> Audis
        {
            get
            {
                return this.audis;
            }

            set
            {
                if (value != this.audis)
                {
                    this.audis = value;
                }

                this.SetPropertyChanged("Audis");
            }
        }

        public BL.BL BusinessLogisticsLayer { get => this.businessLogisticsLayer; set => this.businessLogisticsLayer = value; }

        public ICommand AddNewCommand
        {
            get
            {
                return this.addNewCommand ?? (this.addNewCommand = new RelayCommand(() => this.AddNewAction(), this.canExecute));
            }
        }

        public ICommand RemoveCommand
        {
            get
            {
                return this.removeCommand ?? (this.removeCommand = new RelayCommand(() => this.RemoveAction(), this.canExecute));
            }
        }

        public IAudi SelectedAudi
        {
            get => this.selectedAudi; set
            {
                this.selectedAudi = value;
                this.SetPropertyChanged("SelectedAudi");
            }
        }

        public void AddNewAction()
        {
            IAudi iAudi = new Car(string.Empty, 0, 0, 0, 0);
            this.Audis.Add(iAudi);
        }

        public void RemoveAction()
        {
            this.Audis.Remove(this.SelectedAudi);
        }

        public void SetPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
