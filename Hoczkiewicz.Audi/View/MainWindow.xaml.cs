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
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void AudisList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
