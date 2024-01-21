using Business;
using Business.Abstract;
using Business.Request.Transmission;
using Business.Responses.Transmission;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransmissionsController : ControllerBase
    {
        private readonly ITransmissionService _transmissionService;

        public TransmissionsController(ITransmissionService transmissionService)
        {
            _transmissionService = transmissionService;
        }

        [HttpGet]
     /*   public ActionResult<GetTransmissionListResponse> GetList()
        {
            GetTransmissionListResponse response = _transmissionService.GetList(new GetTransmissionListRequest());
            return Ok(response);
        }*/
        public GetTransmissionListResponse GetList([FromQuery] GetTransmissionListRequest request)// Referans tipleri varsayılan request body'den alır.
        {
            GetTransmissionListResponse response = _transmissionService.GetList(request);
            return response; //JSON
        }
        [HttpPost]
        public ActionResult<AddTransmissionResponse> Add(AddTransmissionRequest request)
        {
            AddTransmissionResponse response = _transmissionService.Add(request);
            return CreatedAtAction(nameof(GetList), response);
        }
    }
}

//using Business;
//using Business.Abstract;
//using Business.Request.Transmission;
//using Business.Responses.Transmission;
//using Entities.Concrete;
//using Microsoft.AspNetCore.Mvc;

//namespace WebAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class TransmissionsController : ControllerBase
//    {
//        private readonly ITransmissionService _transmissionService;

//        public TransmissionsController(ITransmissionService transmissionService)
//        {
//            _transmissionService = transmissionService;
//        }

//        [HttpGet]
//        public ActionResult<GetTransmissionListResponse> GetList()
//        {
//            GetTransmissionListResponse response = _transmissionService.GetList(new GetTransmissionListRequest());
//            return Ok(response);
//        }

//        [HttpPost]
//        public ActionResult<AddTransmissionResponse> Add(AddTransmissionRequest request)
//        {
//            AddTransmissionResponse response = _transmissionService.Add(request);
//            // 200 OK
//            return CreatedAtAction("GetList", response); // 201 Created 
//        }
//    }
//}
