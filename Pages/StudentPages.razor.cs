using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UASFrontEnd.Models;
using UASFrontEnd.Services;
using Microsoft.AspNetCore.Components;

namespace UASFrontEnd.Pages
{
    public partial class StudentPages
    {
        public List<Student> Student { get; set; } = new List<Student>();

        [Inject]
        public IStudentServices StudentServices{ get; set; }
        protected override async Task OnInitializedAsync()
        {
            Student = (await StudentServices.GetAll()).ToList();
        }
    }
}