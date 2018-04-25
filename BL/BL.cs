using System;
using System.Collections.Generic;
using System.Reflection;
using static Hoczkiewicz.Audi.INTERFACES.Interfaces;

namespace Hoczkiewicz.Audi.BL
{
    public class BL:IBL
    {
        Assembly DAODummy2 = Assembly.UnsafeLoadFrom("C://DAO.dll");

        private DAO.DAOMock DAODummy = new DAO.DAOMock();
        //private DAO.DAOMock2 DAODummy2 = new DAO.DAOMock2();

        public List<IAudi> GetDataBase()
        {
            //Late bound testing (to be commented)
            Console.WriteLine(">Class specification: \n" + DAODummy2.GetName() +
                    "\n>Class types and methods:");
            foreach (var t in DAODummy2.GetTypes())
            {
                Console.WriteLine(t);
                foreach (var m in t.GetMethods())
                {
                    Console.WriteLine("\t" + m);
                }
            }
            Console.WriteLine(">New type test:");
            Type lateBoundType = DAODummy2.GetType("Hoczkiewicz.Audi.DAO.DAOMock2");
            var lateBound = Activator.CreateInstance(lateBoundType);

            Console.WriteLine(lateBound.ToString());

            MethodInfo toInvoke = lateBoundType.GetMethod("GetAudis");

            return (List<IAudi>)toInvoke.Invoke(lateBound, null);

            //return DAODummy.GetAudis(); //Old declaration without proper CORE classes differentiation (Car/SUV).
            //return DAODummy2.GetAudis();
        }
    }
}
