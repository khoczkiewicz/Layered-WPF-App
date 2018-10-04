// <copyright file="UI.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hoczkiewicz.Audi.UI
{
    using Hoczkiewicz.Audi.BL;

    public class UI
    {
        private static BL businessLogisticsLayer = new BL();

        public static BL BusinessLogisticsLayer { get => businessLogisticsLayer; set => businessLogisticsLayer = value; }

        public static void Main(string[] args)
        {
            /*BusinessLogisticsLayer.GetDataBase().ForEach(delegate (IAudi Audi)
            {
                Console.WriteLine(value: Audi.ToString());
            });
            Console.ReadLine();*/
        }
    }
}
