using SnowboardHireHRM.Server.Components;
using SnowboardHireHRM.Server.Services;
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
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
        protected AddEmployeeDialog AddEmployeeDialog { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }
        public async void AddEmployeeDialog_OnDialogClose()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            StateHasChanged();
        }

        protected void QuickAddEmployee()
        {
            AddEmployeeDialog.Show();
        }
    }
}
