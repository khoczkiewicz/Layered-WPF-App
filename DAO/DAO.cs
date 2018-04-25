using System.Collections.Generic;
using static Hoczkiewicz.Audi.INTERFACES.Interfaces;

namespace Hoczkiewicz.Audi.DAO
{
    public class DAOMock : IDAO
    {
        private List<IAudi> Audis = new List<IAudi>()
        {
            new CORE.Audi("RS",7,288,320000),
            new CORE.Audi("A",5,170,210000),
            new CORE.Audi("S",3,210,180000)
        };

        public List<IAudi> GetAudis()
        {
            return Audis;
        }
    }
    public class DAOMock2 : IDAO
    {
        private List<IAudi> Audis = new List<IAudi>()
        {
            new CORE.SUV("",5,178,245000),
            new CORE.SUV("RS",7,248,315000),
            new CORE.Car("S",5,244,248000),
            new CORE.Car("",8,355,589000)
        };

        public List<IAudi> GetAudis()
        {
            return Audis;
        }
    }
}
