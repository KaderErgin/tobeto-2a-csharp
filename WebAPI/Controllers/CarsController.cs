using Business;
using Business.Abstract;
using Business.Request.Car;
using Business.Responses.Car;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public ActionResult<GetCarListResponse> GetList([FromQuery] GetCarListRequest request)
        {
            GetCarListResponse response = _carService.GetList(request);
            return response;
        }
        [HttpPost]


        public ActionResult<AddCarResponse> Add(AddCarRequest request)
        {
            AddCarResponse response = _carService.Add(request);
            //200 OK
            return CreatedAtAction(nameof(GetList), response); // 201 Created 
        }

    }
}
