using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomersDal : ICustomersDal
    {
        public Customers Add(Customers entity)
        {
            throw new NotImplementedException();
        }

        public Customers Delete(Customers entity)
        {
            throw new NotImplementedException();
        }

        public Customers Delete(Customers entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }

        public Customers? Get(Func<Customers, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<Customers> GetList(Func<Customers, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public Customers Update(Customers entity)
        {
            throw new NotImplementedException();
        }
    }
}
