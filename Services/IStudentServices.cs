using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UASFrontEnd.Models;

namespace UASFrontEnd.Services
{
    public interface IStudentServices
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> GetById(int id);

        Task Delete(int id);

        Task<Student> Add(Student employee);

        Task<Student> Update(int id,Student Student);

    }
}