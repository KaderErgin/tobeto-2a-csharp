using AutoMapper;
using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Request.Car;
using Business.Responses.Car;
using Business;
using DataAccess.Abstract;
using Entities.Concrete;

public class CarManager : ICarService
{
    private readonly ICarDal _carDal;
    private readonly CarBusinessRules _carBusinessRules;
    private IMapper _mapper;

    public CarManager(ICarDal carDal, CarBusinessRules carBusinessRules, IMapper mapper)
    {
        _carDal = carDal;
        _carBusinessRules = carBusinessRules;
        _mapper = mapper;
    }

    public AddCarResponse Add(AddCarRequest request)
    {
        //_carBusinessRules.CheckIfModelYearIsValid(request.Name);
        _carBusinessRules.CheckIfModelYearIsValid(request.ModelYear); // Check model year

        Car carToAdd = _mapper.Map<Car>(request);

        _carDal.Add(carToAdd);

        AddCarResponse response = _mapper.Map<AddCarResponse>(carToAdd);
        return response;
    }

    public AddCarResponse AddCarWithDetails(AddCarRequest request)
    {
        //_carBusinessRules.CheckIfModelYearIsValid(request.Name);
       _carBusinessRules.CheckIfModelYearIsValid(request.ModelYear); // Check model year

        Car carToAdd = _mapper.Map<Car>(request);

        _carDal.Add(carToAdd);

        AddCarResponse response = _mapper.Map<AddCarResponse>(carToAdd);
        return response;
    }

    public GetCarListResponse GetList(GetCarListRequest request)
    {
        IList<Car> carList = _carDal.GetList();
        GetCarListResponse response = _mapper.Map<GetCarListResponse>(carList);
        return response;
    }
}

