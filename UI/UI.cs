using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoczkiewicz.Audi.UI
{
    public class UI
    {
        private static BL.BL bl = new BL.BL();
        static void Main(string[] args)
        {
            bl.GetDataBase().ForEach(delegate (CORE.Audi audi)
            {
                Console.WriteLine(audi.ToString());
            });
            Console.ReadLine();
        }
    }
}
