﻿using ProjectEF.Data.IRepositories;
using ProjectEF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEF.Service.Interfaces
{
    public interface IStudentService 
    {
         
        Task<Student> GetAsync(Expression<Func<Student, bool>> predicate);

    }
}
