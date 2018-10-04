// <copyright file="BL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hoczkiewicz.Audi.BL
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using global::BL.Properties;
    using static Hoczkiewicz.Audi.INTERFACES.Interfaces;

    public class BL : IBL
    {
        private IDAO dao;
        private Assembly dAODummy = Assembly.UnsafeLoadFrom(Settings.Default.filePath);

        public Assembly DAODummy { get => this.dAODummy; set => this.dAODummy = value; }

        public List<IAudi> GetDataBase()
        {
            var types = this.DAODummy.GetTypes();
            Type lateBindingType = null;

            foreach (var t in this.DAODummy.GetTypes())
            {
                if (typeof(IDAO).IsAssignableFrom(t))
                {
                    lateBindingType = t;
                    break;
                }
            }

            if (lateBindingType != null)
            {
                var lateBind = Activator.CreateInstance(lateBindingType);
                this.dao = (IDAO)lateBind;
                return this.dao.GetAudis();
            }
            else
            {
                return null;
            }
        }
    }
}
