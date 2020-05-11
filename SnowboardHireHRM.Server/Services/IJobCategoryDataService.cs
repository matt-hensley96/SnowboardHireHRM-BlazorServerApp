﻿using SnowboardHireHRM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnowboardHireHRM.Server.Services
{
    public interface IJobCategoryDataService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
