/*namespace Business.Request.Car
{
    public class AddCarRequest
    {
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public string CarState { get; set; }
        public int Kilometer { get; set; }
        public int ModelYear { get; set; }
        public string Plate { get; set; }
        public string Name { get; set; }

        public AddCarRequest(int colorId, int modelId, string carState, int kilometer, short modelYear, string plate, string name)
        {
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;
            ModelYear = modelYear;
            Plate = plate;
            Name = name;
        }
    }
}
*/
namespace Business.Request.Car
{
    public class AddCarRequest
    {
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public string CarState { get; set; }
        public int Kilometer { get; set; }
        public int ModelYear { get; set; }
     //   public decimal DailyPrice { get; set; }//
        public string Plate { get; set; }
        public string Name { get; set; }

        public AddCarRequest(int colorId, int modelId, string carState, int kilometer, int modelYear, string plate, string name)
        {
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;
            ModelYear = modelYear;
            Plate = plate;
            Name = name;
        }
    }
}
