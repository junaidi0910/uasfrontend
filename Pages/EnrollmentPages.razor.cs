using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UASFrontEnd.Models;
using UASFrontEnd.Services;
using Microsoft.AspNetCore.Components;

namespace UASFrontEnd.Pages
{
    public partial class EnrollmentPages
    {
         public List<Enrollment> Enrollment { get; set; } = new List<Enrollment>();

        [Inject]
        public IEnrollmentServices EnrollmentServices{ get; set; }
        protected override async Task OnInitializedAsync()
        {
            Enrollment = (await EnrollmentServices.GetAll()).ToList();
        }
    }
}