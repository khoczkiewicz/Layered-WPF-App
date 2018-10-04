// <copyright file="Interfaces.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hoczkiewicz.Audi.INTERFACES
{
    using System.Collections.Generic;

    public class Interfaces
    {
        public interface IBL
        {
            List<IAudi> GetDataBase();
        }

        public interface IDAO
        {
            List<IAudi> GetAudis();
        }

        public interface IAudi
        {
            string Type { get; set; }

            int Model { get; set; }

            int PS { get; set; }

            int Price { get; set; }
        }
    }
}
