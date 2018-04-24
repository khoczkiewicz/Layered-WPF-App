using System;
using static Hoczkiewicz.Audi.INTERFACES.Interfaces;

namespace Hoczkiewicz.Audi.UI
{
    public class UI
    {
        private static BL.BL BusinessLogisticsLayer = new BL.BL();
        public static void Main(string[] args)
        {
            BusinessLogisticsLayer.GetDataBase().ForEach(delegate (IAudi Audi)
            {
                Console.WriteLine(value: Audi.ToString());
            });
            Console.ReadLine();
        }
    }
}
