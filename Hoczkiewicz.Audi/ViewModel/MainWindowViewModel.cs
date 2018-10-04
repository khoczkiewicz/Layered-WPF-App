// <copyright file="MainWindowViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hoczkiewicz.Audi.ViewModel
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using static Hoczkiewicz.Audi.INTERFACES.Interfaces;

    internal class MainWindowViewModel
    {
        private BL.BL businessLogisticsLayer = new BL.BL();

        private ObservableCollection<IAudi> audis;

        public MainWindowViewModel()
        {
            this.Audis = this.BusinessLogisticsLayer.GetDataBase();
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

        public void SetPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
