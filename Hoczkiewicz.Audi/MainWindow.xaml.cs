// <copyright file="MainWindow.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hoczkiewicz.Audi
{
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;
    using Hoczkiewicz.Audi.BL;
    using static Hoczkiewicz.Audi.INTERFACES.Interfaces;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BL.BL businessLogisticsLayer = new BL.BL();

        // public List<string> auta = new List<string>();
        private List<IAudi> audis;

        public MainWindow()
        {
            this.Audis = this.BusinessLogisticsLayer.GetDataBase();
            this.InitializeComponent();
        }

        public List<IAudi> Audis
        {
            get { return this.audis; }
            set { this.audis = value; }
        }

        public BL.BL BusinessLogisticsLayer { get => this.businessLogisticsLayer; set => this.businessLogisticsLayer = value; }

        private void AudisList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
