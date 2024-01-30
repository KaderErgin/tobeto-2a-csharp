using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUsersDal : IUsersDal
    {
        public Users Add(Users entity)
        {
            throw new NotImplementedException();
        }

        public Users Delete(Users entity)
        {
            throw new NotImplementedException();
        }

        public Users Delete(Users entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }

        public Users? Get(Func<Users, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<Users> GetList(Func<Users, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public Users Update(Users entity)
        {
            throw new NotImplementedException();
        }
    }
}
