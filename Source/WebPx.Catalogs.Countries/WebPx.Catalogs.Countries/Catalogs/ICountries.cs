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

        /// <summary>
        /// Gets an instance of a unique list of all countries in a region identified by its unique code in <see cref="RegionCode"/>
        /// </summary>
        /// <param name="code">The region unique code</param>
        /// <returns>A list of countries in the region</returns>
        List<Country> GetListByRegion(RegionCode code);

        /// <summary>
        /// Gets the data for country identified by its unique number code
        /// </summary>
        /// <param name="code">The numeric code</param>
        /// <returns>The instance of the country identified by <see cref="code"/></returns>
        Country? GetCountry(int code);

        /// <summary>
        /// Gets the data for country identified by its unique alpha-2 code
        /// </summary>
        /// <param name="alphaCode2">The alpha-2 code</param>
        /// <returns>The instance of the country identified by <see cref="alphaCode2"/></returns>
        Country? GetCountryByCodeA2(string alphaCode2);

        /// <summary>
        /// Gets the data for country identified by its unique alpha-3 code
        /// </summary>
        /// <param name="alphaCode3">The alpha-2 code</param>
        /// <returns>The instance of the country identified by <see cref="alphaCode3"/></returns>
        Country? GetCountryByCodeA3(string alphaCode3);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="regionCode"></param>
        /// <param name="allDescendants"></param>
        /// <returns></returns>
        IEnumerable<Region> GetRegions(RegionCode regionCode, bool allDescendants = false);

        /// <summary>
        /// Gets the list of all regions in the world
        /// </summary>
        /// <returns>The list of regions</returns>
        List<Region> GetRegionList();

        /// <summary>
        /// Gets the region identified by its unique code in <see cref="RegionCode"/>
        /// </summary>
        /// <param name="regionCode"></param>
        /// <returns>Returns the corresponding region</returns>
        Region GetRegion(RegionCode regionCode);

        /// <summary>
        /// Get region for a country by it's unique code
        /// </summary>
        /// <param name="countryCode">The country code</param>
        /// <returns>The region for the country</returns>
        Region? GetRegionByCountry(int countryCode);
    }
}