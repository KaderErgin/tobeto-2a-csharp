namespace Business.Responses.Model
{
    public class AddModelResponse
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int FuelId { get; set; }
        public int TransmissionId { get; set; }
        public string Name { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime CreatedAt { get; set; }

        public AddModelResponse(int id, int brandId, int fuelId, int transmissionId, string name, decimal dailyPrice, DateTime createdAt)
        {
            Id = id;
            BrandId = brandId;
            FuelId = fuelId;
            TransmissionId = transmissionId;
            Name = name;
            DailyPrice = dailyPrice;
            CreatedAt = createdAt;
        }
    }
}

/*namespace Business.Responses.Model
{
    public class AddModelResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }

        public AddModelResponse(int id, string name, DateTime createdAt)
        {
            Id = id;
            Name = name;
            CreatedAt = createdAt;
        }
    }
}*/
