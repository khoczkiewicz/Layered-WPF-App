using System;
using System.Collections.Generic;
using static Hoczkiewicz.Audi.INTERFACES.Interfaces;

namespace Hoczkiewicz.Audi.BL
{
    public class BL:IBL
    {
        private DAO.DAOMock DAODummy = new DAO.DAOMock();
        public List<IAudi> GetDataBase()
        {
            return DAODummy.GetAudis();
        }
    }
}
