using System.Collections.Generic;
using System.Threading.Tasks;
using SnowboardHireHRM.Shared;

namespace SnowboardHireHRM.Server.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
