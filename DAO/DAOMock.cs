// <copyright file="DAOMock.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hoczkiewicz.Audi.DAO
{
    using System.Collections.Generic;
    using static Hoczkiewicz.Audi.INTERFACES.Interfaces;

    public class DAOMock : IDAO
    {
        private readonly List<IAudi> audis = new List<IAudi>()
        {
            new CORE.Car(string.Empty, 8, 268, 314000),
            new CORE.SUV(string.Empty, 3, 122, 125000),
            new CORE.SUV("RS", 7, 388, 450000)
        };

        public List<IAudi> GetAudis()
        {
            return this.audis;
        }
    }
}
