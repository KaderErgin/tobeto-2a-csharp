/*using Core.Entities;

namespace Entities.Concrete
{
    public class Car : Entity<int>
    {
        public string Name { get; set; }
        public Car()
        {

        }
        public Car(string name)
        {
            Name = name;
        }
    }
}
*/
using Core.Entities;

namespace Entities.Concrete
{
    public class Car : Entity<int>
    {
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public string CarState { get; set; }
        public int Kilometer { get; set; }
        public int ModelYear { get; set; }
        public string Plate { get; set; }
        public string Name { get; set; }   

        public Car()
        {

        }

        public Car(int colorId, int modelId, string carState, int kilometer, int modelYear, string plate, string name)
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
