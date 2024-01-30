using System.Reflection;
using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;
using DataAccess.Concrete.InMemory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Business.DependencyResolvers;

public static class ServiceCollectionBusinessExtension
{
    // Extension method
    // Metodun ve barındığı class'ın static olması gerekiyor
    // İlk parametere genişleteceğimiz tip olmalı ve başında this keyword'ü olmalı.
    public static IServiceCollection AddBusinessServices(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services//Brand
            .AddSingleton<IBrandService, BrandManager>()
            .AddSingleton<IBrandDal, InMemoryBrandDal>()
            .AddSingleton<BrandBusinessRules>();
        // Fluent
        // Singleton: Tek bir nesne oluşturur ve herkese onu verir.
        // Ek ödev diğer yöntemleri araştırınız.

        services//Fuel
           .AddSingleton<IFuelService, FuelManager>()
           .AddSingleton<IFuelDal, InMemoryFuelDal>()
           .AddSingleton<FuelBusinessRules>();
    
        services//Transmission
          .AddSingleton<ITransmissionService,TransmissionManager>()
          .AddSingleton<ITransmissionDal, InMemoryTransmissionDal>()
          .AddSingleton<TransmissionBusinessRules>();

        services//Car
          .AddSingleton<ICarService, CarManager>()
          .AddSingleton<ICarDal, InMemoryCarDal>()
          .AddSingleton<CarBusinessRules>();

        services//Users
         .AddSingleton<IUsersService, UsersManager>()
         .AddSingleton<IUsersDal, InMemoryUsersDal>()
         .AddSingleton<UsersBusinessRules>();

        services//Customers
        .AddSingleton<ICustomersService, CustomersManager>()
        .AddSingleton<ICustomersDal, InMemoryCustomersDal>()
        .AddSingleton<CustomersBusinessRules>();

        services//IndividualCustomer
        .AddSingleton<IIndividualCustomerService, IndividualCustomerManager>()
        .AddSingleton<IIndividualCustomerDal, InMemoryIndividualCustomerDal>()
        .AddSingleton<IndividualCustomerBusinessRules>();


        services//CorporateCustomer
        .AddSingleton<ICorporateCustomerService, CorporateCustomerManager>()
        .AddSingleton<ICorporateCustomerDal, InMemoryCorporateCustomerDal>()
        .AddSingleton<CorporateCustomerBusinessRules>();

        services//Model  EfModelDal sınıfından alsın
            .AddScoped<IModelService, ModelManager>()
            .AddScoped<IModelDal, EfModelDal>()
            .AddScoped<ModelBusinessRules>(); // Fluent

        services.AddAutoMapper(Assembly.GetExecutingAssembly()); // AutoMapper.Extensions.Microsoft.DependencyInjection NuGet Paketi
        // Reflection yöntemi Profile class'ını kalıtım alan tüm class'ları bulur ve AutoMapper'a ekler.

        services.AddDbContext<RentACarContext>( // Scoped 
            options => options.UseSqlServer(configuration.GetConnectionString("RentACarMSSQL22"))
        );

        return services;
    }
}
