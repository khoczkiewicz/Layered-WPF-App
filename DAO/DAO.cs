using System.Collections.Generic;
using static Hoczkiewicz.Audi.INTERFACES.Interfaces;

namespace Hoczkiewicz.Audi.DAO
{
    public class DAOMock : IDAO
    {
        private List<IAudi> Audis = new List<IAudi>()
        {
            new CORE.Car("",8,268,314000),
            new CORE.SUV("",3,122,125000),
            new CORE.SUV("RS",7,388,450000)
        };

        public List<IAudi> GetAudis()
        {
            return Audis;
        }
    }
}
