

using DataAccess.Abstract;
using System;
using System.Linq;

namespace Business.BusinessRules
{
    public class CarBusinessRules
    {
        private readonly ICarDal _carDal;

        public CarBusinessRules(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void CheckIfModelYearIsValid(int modelYear)
        {
            // Şu zamanki yıl değerini al
            int currentYear = DateTime.Now.Year;

            // Model yılının en fazla 20 sene öncesine ait olup olmadığını ait kontrol et
            if (modelYear < currentYear - 20 || modelYear > currentYear)
            {
                throw new Exception("Model year must be within the last 20 years");
            }

            // Model isminin var olup olmadığını kontrol et
            bool isExists = _carDal.GetList().Any(m => m.ModelYear == modelYear);
            if (isExists)
            {
                throw new Exception("Car already exists.");
            }
        }
    }
}

