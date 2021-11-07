﻿using System.Collections.Generic;
using System.Linq;

using ServiceLib;

namespace Server.Core.CoreModel
{
    public partial class EntityServ : ServiceLib.EntityService<EntityContext>
    {
        public EntityServ()
        { }
        public EntityServ(string connectionString)
            : base(connectionString)
        { }

        //public IQueryable<NSI_STREET> Get_NSI_STREET_1()
        //{
        //    IQueryable<NSI_STREET> items = Context.NSI_STREET;
        //    List<NSI_STREET> list = items.ToList(); ;
        //    return items;
        //}
        public IQueryable<NSI_STREET> Get_NSI_STREET() => Context.NSI_STREET;

        public IQueryable<NSI_VILLAGE> Get_NSI_VILLAGE() => Context.NSI_VILLAGE;

        public IQueryable<street> GetStreets() => Context.street;
        public IQueryable<type_street> GetTypeStreets() => Context.type_street;
    }
}
