using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UASFrontEnd.Services;
using Microsoft.AspNetCore.Components;

namespace UASFrontEnd.Pages
{
    public partial class DeleteStudent
    {
        [Parameter]
          public string Id { get; set; }

             [Inject]
          public IStudentServices StudentService { get; set; }

            [Inject]
          public NavigationManager NavigationManager { get; set; }
           protected async override Task OnInitializedAsync()
        {
            await StudentService.Delete(int.Parse(Id));
            NavigationManager.NavigateTo("/studentpage");
        }
    }
}