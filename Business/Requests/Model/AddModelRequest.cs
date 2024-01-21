namespace Business.Request.Model
{
    public class AddModelRequest
    {
        public int BrandId { get; set; }
        public int FuelId { get; set; }
        public int TransmissionId { get; set; }
        public string Name { get; set; }
        public decimal DailyPrice { get; set; }

        public AddModelRequest(int brandId, int fuelId, int transmissionId, string name, decimal dailyPrice)
        {
            BrandId = brandId;
            FuelId = fuelId;
            TransmissionId = transmissionId;
            Name = name;
            DailyPrice = dailyPrice;
        }
    }
}
