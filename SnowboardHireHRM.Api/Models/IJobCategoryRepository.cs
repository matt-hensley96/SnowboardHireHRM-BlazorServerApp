using System.Collections.Generic;
using SnowboardHireHRM.Shared;

namespace SnowboardHireHRM.Api.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
