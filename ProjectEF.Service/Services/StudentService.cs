using Microsoft.EntityFrameworkCore;
using ProjectEF.Data.Contexts;
using ProjectEF.Data.Repositories;
using ProjectEF.Domain.Models;
using ProjectEF.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEF.Service.Services
{
    public class StudentService :  IStudentService
    {

        private readonly StudentRepository _studentRepository;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }
       
        public Task<Student> GetAsync(Expression<Func<Student, bool>> predicate)
        {
            var entity = _studentRepository.GetAsync(predicate);


            //Something here

            return entity;
        }
    }
}
