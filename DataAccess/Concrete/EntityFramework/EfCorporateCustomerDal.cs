using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCorporateCustomerDal : ICorporateCustomerDal
    {   //yeni bir kurumsal müşteri ekle
        public CorporateCustomer Add(CorporateCustomer entity)
        {
            throw new NotImplementedException();
        }
        // belirtilen kurumsal müşteriyi sil
        public CorporateCustomer Delete(CorporateCustomer entity)
        {
            throw new NotImplementedException();
        }
       
        public CorporateCustomer Delete(CorporateCustomer entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }
        // belirli  koşulu sağlayan kurumsal müşteriyi getir
        public CorporateCustomer? Get(Func<CorporateCustomer, bool> predicate)
        {
            throw new NotImplementedException();
        }
        // belirli koşulu sağlayan bütün kurumsal müşterileri liste halinde getir
        public IList<CorporateCustomer> GetList(Func<CorporateCustomer, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }
        // daha önce kaydı yapılmış kurumsal müşteriyi güncelle
        public CorporateCustomer Update(CorporateCustomer entity)
        {
            throw new NotImplementedException();
        }
    }
}
