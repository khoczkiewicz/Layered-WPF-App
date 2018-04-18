using System;
using System.Collections.Generic;

namespace Hoczkiewicz.Audi.BL
{
    public class BL:INTERFACES.INTERFACES.IBL
    {
        private DAO.DAOMock dao = new DAO.DAOMock();
        public List<CORE.Audi> GetDataBase()
        {
            return dao.GetAudis();
        }
    }
}
