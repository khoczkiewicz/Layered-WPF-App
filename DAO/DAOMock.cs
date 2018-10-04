// <copyright file="DAOMock.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hoczkiewicz.Audi.DAO
{
    using System.Collections.ObjectModel;
    using Hoczkiewicz.Audi.CORE;
    using static Hoczkiewicz.Audi.CORE.Audi;
    using static Hoczkiewicz.Audi.INTERFACES.Interfaces;

    public class DAOMock : IDAO
    {
        private readonly ObservableCollection<IAudi> audis = new ObservableCollection<IAudi>()
        {
            new Car(string.Empty, 8, 268, 314000, CarColor.Czarny),
            new SUV(string.Empty, 3, 122, 125000, CarColor.Czerwony),
            new SUV("RS", 7, 388, 450000, CarColor.Biały),
        };

        public ObservableCollection<IAudi> GetAudis()
        {
            return this.audis;
        }
    }
}
