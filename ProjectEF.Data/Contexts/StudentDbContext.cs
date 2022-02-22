using Microsoft.EntityFrameworkCore;
using ProjectEF.Domain.Service;
using ProjectEF.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEF.Data.Contexts
{
    public class StudentDbContext : DbContext
    {

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Constants.STUDENT_CONNECTION_STRING);

        }


    }
}
