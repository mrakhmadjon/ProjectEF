using Microsoft.EntityFrameworkCore;
using ProjectEF.Data.Repositories;
using ProjectEF.Domain.Models;
using ProjectEF.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public async Task<IEnumerable<Student>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<Student, bool>> predicate)
        {
            IQueryable<Student> students = await _studentRepository.GetAllAsync(predicate);

            return await students.Skip(pageSize * (pageIndex - 1)).Take(pageIndex).ToListAsync();
        }

        public async Task<IEnumerable<Student>> GetAllInfoAsync(int pageSize, int pageIndex, Expression<Func<Student, bool>> predicate = null)
        {
           IQueryable<Student> students =  await _studentRepository.GetAllAsync(predicate);

            return students.Include("Group.Subject").Skip(pageSize * (pageIndex-1)).Take(pageSize);

        }

        public Task<Student> GetAsync(Expression<Func<Student, bool>> predicate)
        {
            var entity = _studentRepository.GetAsync(predicate);


            //Something here

            return entity;
        }
    }
}
