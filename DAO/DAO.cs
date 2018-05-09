﻿using System.Collections.Generic;
using static Hoczkiewicz.Audi.INTERFACES.Interfaces;

namespace Hoczkiewicz.Audi.DAO
{
    public class DAOMock : IDAO
    {
        private List<IAudi> Audis = new List<IAudi>()
        {
            new CORE.Audi("",0,0,0) //Important template (?)
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
        };

        public List<IAudi> GetAudis()
        {
            return Audis;
        }
    }
}
