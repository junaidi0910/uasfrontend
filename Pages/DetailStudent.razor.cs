using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UASFrontEnd.Models;
using UASFrontEnd.Services;
using Microsoft.AspNetCore.Components;

namespace UASFrontEnd.Pages
{
    public partial class DetailStudent
    {
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IStudentServices StudentServices{ get; set; }


        public Student Student { get; set; } = new Student();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Student = await StudentServices.GetById(int.Parse(id));
        }
    }
}