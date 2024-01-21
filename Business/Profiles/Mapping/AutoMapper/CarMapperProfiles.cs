using AutoMapper;
using Business.Dtos.Car;
using Business.Request.Car;
using Business.Responses.Car;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class CarMapperProfiles : Profile
    {
        public CarMapperProfiles()
        {
            CreateMap<AddCarRequest, Car>();
            CreateMap<Car, AddCarResponse>();
            CreateMap<Car, CarListItemDto>();

            CreateMap<List<Car>, GetCarListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));
        }
    }
}
