using System;
using System.Collections.Generic;
using System.Reflection;
using static Hoczkiewicz.Audi.INTERFACES.Interfaces;
using System.Configuration;
using static Hoczkiewicz.Audi.DAO.DAOMock;

namespace Hoczkiewicz.Audi.BL
{
    public class BL : IBL
    {
        private IDAO dao;
        private Assembly DAODummy = Assembly.UnsafeLoadFrom(Properties.Settings.Default.filePath);

        public List<IAudi> GetDataBase()
        {
            var types = DAODummy.GetTypes();
         
            Type lateBindingType = DAODummy.GetType(types[0].ToString());
            
            var lateBind = Activator.CreateInstance(lateBindingType);
            dao = (IDAO)lateBind;

            return dao.GetAudis();
        }
    }
}
