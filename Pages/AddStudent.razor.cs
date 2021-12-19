using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UASFrontEnd.Models;
using UASFrontEnd.Services;
using Microsoft.AspNetCore.Components;

namespace UASFrontEnd.Pages
{
    public partial class AddStudent
    {
        public Student Student { get; set; } = new Student();

        [Inject]
        public IStudentServices StudentServices { get; set; }

       
        [Inject]
        public NavigationManager NavigationManager { get; set; }



        protected async Task HandleValidSubmit()
        {
            
            var result = await StudentServices.Add(Student);
            NavigationManager.NavigateTo("studentpage"); 
        }
    }
}