using ProjectEF.Data.IRepositories;
using ProjectEF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEF.Data.Repositories
{
    public class StudentRepository : GenericRepository<Student> , IStudentRepository
    {

    }
}
