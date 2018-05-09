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
        private Assembly DAODummy2 = Assembly.UnsafeLoadFrom(Properties.Settings.Default.filePath);

        public List<IAudi> GetDataBase()
        {
            Type lateBoundType = DAODummy2.GetType("Hoczkiewicz.Audi.DAO.DAOMock2"); //TODO Szukac po idao

            foreach (var r in DAODummy2.GetTypes())
            {
                Console.WriteLine(r);
            }

            var lateBound = Activator.CreateInstance(lateBoundType);
            dao = (IDAO)lateBound;

            return dao.GetAudis();
        }
    }
}
