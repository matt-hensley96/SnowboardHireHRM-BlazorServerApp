using System.Collections.Generic;
using System.Threading.Tasks;
using SnowboardHireHRM.Shared;

namespace SnowboardHireHRM.Server.Services
{
    public interface IJobCategoryDataService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
