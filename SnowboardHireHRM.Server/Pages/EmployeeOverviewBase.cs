using SnowboardHireHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnowboardHireHRM.Server.Pages
{
    public class EmployeeOverviewBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync()
        {
            InitializeCountries();
            InitializeJobCategories();
            InitializeEmployees();
            return base.OnInitializedAsync();
        }

        private List<Country> Countries { get; set; }

        private List<JobCategory> JobCategories { get; set; }

        private void InitializeJobCategories()
        {
            JobCategories = new List<JobCategory>()
            {
                new JobCategory{JobCategoryId = 1, JobCategoryName = "Marketing"},
                new JobCategory{JobCategoryId = 2, JobCategoryName = "Sales"},
                new JobCategory{JobCategoryId = 3, JobCategoryName = "Management"},
                new JobCategory{JobCategoryId = 4, JobCategoryName = "Store staff"},
                new JobCategory{JobCategoryId = 5, JobCategoryName = "Finance"},
                new JobCategory{JobCategoryId = 8, JobCategoryName = "Cleaning"},
                new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"},
            };
        }

        private void InitializeCountries()
        {
            Countries = new List<Country>
            {
                new Country {CountryId = 1, Name = "Belgium"},
                new Country {CountryId = 2, Name = "Netherlands"},
                new Country {CountryId = 3, Name = "USA"},
                new Country {CountryId = 4, Name = "Japan"},
                new Country {CountryId = 5, Name = "China"},
                new Country {CountryId = 6, Name = "UK"},
                new Country {CountryId = 7, Name = "France"},
                new Country {CountryId = 8, Name = "Brazil"}
            };
        }

        private void InitializeEmployees()
        {
            var e1 = new Employee
            {
                CountryId = 2,
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1989, 3, 11),
                City = "Keystone",
                Email = "alana@keystoneboardhire.com",
                EmployeeId = 1,
                FirstName = "Alana ",
                LastName = "Smith",
                Gender = Gender.Female,
                PhoneNumber = "+324777888773",
                Smoker = true,
                Street = "Trailhead Drive",
                Zip = "CO 80435",
                JobCategoryId = 1,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2015, 3, 1)
            };

            var e2 = new Employee
            {
                CountryId = 3,
                MaritalStatus = MaritalStatus.Married,
                BirthDate = new DateTime(1979, 1, 16),
                City = "Breckenridge",
                Email = "eric@keystoneboardhire.com",
                EmployeeId = 2,
                FirstName = "Eric",
                LastName = "Koston",
                Gender = Gender.Male,
                PhoneNumber = "+33999909923",
                Smoker = false,
                Street = "Gold Flake Terrace",
                Zip = "CO 80220",
                JobCategoryId = 1,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2017, 12, 24)
            };
            Employees = new List<Employee> { e1, e2 };
        }
    }
}
