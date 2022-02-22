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

            var student = await studentService.GetAsync(p => p.Id == 1);

            Console.WriteLine(student.Id + " " + student.FirstName);
        }
    }
}
