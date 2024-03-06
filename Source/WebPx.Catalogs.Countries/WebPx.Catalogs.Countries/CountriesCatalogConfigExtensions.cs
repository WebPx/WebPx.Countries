using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using WebPx.Catalogs;

namespace WebPx
{
    public static class CountriesCatalogConfigExtensions
    {
        public static IServiceCollection AddCountriesCatalog(this IServiceCollection services)
        {
            services.AddSingleton<ICountries, CountriesService>();
            return services;
        }
    }
}