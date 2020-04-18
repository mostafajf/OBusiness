using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OBusiness.Core.Data;
using OBusiness.Services.Interfaces;
using OBusiness.Services.Services;
using OBusinessApi.Infrastructure.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBusinessApi.Infrastructure
{
    public class IOC
    {
        public void RegisterServices(IServiceCollection services, MongoClientOptions mongoSetting)
        {
            services.AddSingleton<MongoDatabase>(sp =>
            {
                return new MongoDatabase(new MongoDB.Driver.MongoClientSettings
                {
                    Server = new MongoDB.Driver.MongoServerAddress(mongoSetting.Host, mongoSetting.Port),
                    ApplicationName = mongoSetting.DatabaseName
                });

            });
            services.AddScoped(typeof(IGenericRepostory<>), typeof(GenericRepostory<>));
            services.AddScoped<IStoreService, StoreService>();
            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<InitData>();
        }
    }
}
