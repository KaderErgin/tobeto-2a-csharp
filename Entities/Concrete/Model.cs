using Core.Entities;
using Microsoft.VisualBasic.FileIO;
using System.Drawing;

namespace Entities.Concrete
{
    public class Model : Entity<int>
    {
        public int BrandId { get; set; }
        public int FuelId { get; set; }
        public int TransmissionId { get; set; }
        public string Name { get; set; }
        public decimal DailyPrice { get; set; }
        public short Year { get; set; }
        public Model()
        {

        }
        public Model(int brandId, int fuelId, int transmissionId, string name, decimal dailyPrice, short year)
        {
            BrandId = brandId;
            FuelId = fuelId;
            TransmissionId = transmissionId;
            Name = name;
            DailyPrice = dailyPrice;
            Year = year;
        }
    }
}
