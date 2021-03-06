﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scozzard.Model;
using Scozzard.Respository.Infrastructure;

namespace Scozzard.Respository.Repositories
{
    public class XboxUserRepository : RepositoryBase<XboxUser>, IXboxUserRepository
    {
        public XboxUserRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {}

        public XboxUser GetById(long id)
        {
            return this.DbContext
                .XboxUsers
                .Include("Activities")
                .Include("Friends.Activities")
                .FirstOrDefault(x => x.XboxUserID == id);
        }

        public List<XboxUser> GetAll()
        {
            return this.DbContext
                .XboxUsers
                .Include("Activities")
                .Include("Friends")
                .Include("Friends.Activities").ToList();
        }
    }
}
