using ProjectEF.Data.IRepositories;
using ProjectEF.Data.Repositories;
using ProjectEF.Domain.Models;
using ProjectEF.Service.Interfaces;
using ProjectEF.Service.Services;
using System;
using System.Threading.Tasks;

namespace ProjectEF
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            
            
            IStudentService studentService = new StudentService();

           var students = await studentService.GetAllInfoAsync(2, 1);


            foreach (var st in students)
            {
                Console.WriteLine($"{st.FirstName}  {st.LastName}  {st.Group.Name}");
            }
        }
    }
}
