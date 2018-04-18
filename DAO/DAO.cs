using System;
using System.Collections.Generic;

namespace Hoczkiewicz.Audi.DAO
{
    public class DAOMock:INTERFACES.INTERFACES.IDAO
    {
        private List<CORE.Audi> audis = new List<CORE.Audi>()
        {
            new CORE.Audi("RS",7,288,320000),
            new CORE.Audi("A",5,170,210000),
            new CORE.Audi("S",3,210,180000)
        };
        public List<CORE.Audi> GetAudis()
        {
            return audis;
        }
    }
}
