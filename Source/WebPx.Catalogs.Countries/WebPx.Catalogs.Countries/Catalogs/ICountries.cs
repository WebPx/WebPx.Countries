using System.Collections.Generic;
using System.Text;

namespace WebPx.Catalogs
{
    /// <summary>
    /// Interface that provides a list of all countries in the world
    /// </summary>
    public interface ICountries
    {
        /// <summary>
        /// Gets an enumerator of all countries in alphabetical order using the localized name
        /// </summary>
        /// <returns>The new instance of an enumerator</returns>
        IEnumerable<Country> GetCountries();

        /// <summary>
        /// Gets an instance of a unique list of all countries in the world
        /// </summary>
        /// <returns>The instance of the list of countries</returns>
        List<Country> GetList();

        Country? GetCountry(int code);
        Country? GetCountryByCodeA2(string alphaCode2);
        Country? GetCountryByCodeA3(string alphaCode3);
    }
}