// <copyright file="Interfaces.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hoczkiewicz.Audi.INTERFACES
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class Interfaces
    {
        public interface IBL
        {
            ObservableCollection<IAudi> GetDataBase();
        }

        public interface IDAO
        {
            ObservableCollection<IAudi> GetAudis();
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
