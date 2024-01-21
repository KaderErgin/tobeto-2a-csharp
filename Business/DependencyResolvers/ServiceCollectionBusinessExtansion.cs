using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business.DependencyResolvers
{
    public static class ServiceCollectionBusinessExtansion
    {
        //Extension method
        // Metodun ve barındığı class'ın static olması gerekiyor
        // İlk parametere genişleteceğimiz tip olmalı ve başında this keyword'ü olmalı.
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services
                .AddSingleton<IBrandService, BrandManager>()
                .AddSingleton<IBrandDal, InMemoryBrandDal>()
                .AddSingleton<BrandBusinessRules>();// Fluent
            // Singleton: Tek bir nesne oluşturur ve herkese onu verir.
            services
              .AddSingleton<IFuelService, FuelManager>()
              .AddSingleton<IFuelDal, InMemoryFuelDal>()
              .AddSingleton<FuelBusinessRules>();
            
            services
            .AddSingleton<ITransmissionService,TransmissionManager>()
            .AddSingleton<ITransmissionDal, InMemoryTransmissionDal>()
            .AddSingleton<TransmissionBusinessRules>();

            services
            .AddSingleton<IModelService, ModelManager>()
            .AddSingleton<IModelDal, InMemoryModelDal>()
            .AddSingleton<ModelBusinessRules>();

            services
           .AddSingleton<ICarService, CarManager>()
           .AddSingleton<ICarDal, InMemoryCarDal>()
           .AddSingleton<CarBusinessRules>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly()); // AutoMapper.Extensions.Microsoft.DependencyInjection NuGet Paketi
            return services;

        }

    }
}
