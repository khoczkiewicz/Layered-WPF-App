using System;
using System.Collections.Generic;
using static Hoczkiewicz.Audi.INTERFACES.Interfaces;

namespace Hoczkiewicz.Audi.BL
{
    public class BL:IBL
    {
        private DAO.DAOMock DAODummy = new DAO.DAOMock();
        private DAO.DAOMock2 DAODummy2 = new DAO.DAOMock2();
        public List<IAudi> GetDataBase()
        {
            //return DAODummy.GetAudis(); //Old declaration without proper CORE classes differentiation (Car/SUV).
            return DAODummy2.GetAudis();
        }
    }
}
