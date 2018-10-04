// <copyright file="DAOMock.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hoczkiewicz.Audi.DAO
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using static Hoczkiewicz.Audi.CORE.Audi;
    using static Hoczkiewicz.Audi.INTERFACES.Interfaces;

    public class DAOMock : IDAO
    {
        private readonly ObservableCollection<IAudi> audis = new ObservableCollection<IAudi>()
        {
            new CORE.Car(string.Empty, 8, 268, 314000, CarColor.Czarny),
            new CORE.SUV(string.Empty, 3, 122, 125000, CarColor.Czerwony),
            new CORE.SUV("RS", 7, 388, 450000, CarColor.Bialy),
        };

        public ObservableCollection<IAudi> GetAudis()
        {
            return this.audis;
        }
    }
}
