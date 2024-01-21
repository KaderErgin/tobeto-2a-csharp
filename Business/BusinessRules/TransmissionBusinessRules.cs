using DataAccess.Abstract;
using System;

namespace Business.BusinessRules
{
    public class TransmissionBusinessRules
    {
        private readonly ITransmissionDal _transmissionDal;

        public TransmissionBusinessRules(ITransmissionDal transmissionDal)
        {
            _transmissionDal = transmissionDal;
        }

        public void CheckIfTransmissionNameExists(string transmissionName)
        {
            bool isExists = _transmissionDal.GetList().Any(x => x.Name == transmissionName);
            if (isExists)
            {
                throw new Exception("Transmission name already exists.");
            }
        }
    }
}

