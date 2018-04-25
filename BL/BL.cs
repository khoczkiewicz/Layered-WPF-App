using System;
using System.Collections.Generic;
using System.Reflection;
using static Hoczkiewicz.Audi.INTERFACES.Interfaces;

namespace Hoczkiewicz.Audi.BL
{
    public class BL : IBL
    {
        private DAO.DAOMock DAODummy; //Why is it important?!
        private Assembly DAODummy2 = Assembly.UnsafeLoadFrom("C://DAO.dll");

        public List<IAudi> GetDataBase()
        {
            Type lateBoundType = DAODummy2.GetType("Hoczkiewicz.Audi.DAO.DAOMock2");
            var lateBound = Activator.CreateInstance(lateBoundType);

            MethodInfo GetAudis = lateBoundType.GetMethod("GetAudis");

            return (List<IAudi>)GetAudis.Invoke(lateBound, null);
        }
    }
}
