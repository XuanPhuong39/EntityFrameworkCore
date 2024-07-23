using EntityFrameworkCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var std = new Student()
                {
                    FirstName = "Bill",
                    LastName = "Gates"
                };
                context.Students.Add(std);
                context.SaveChanges();

                var studentToUpdate = context.Students.First<Student>();
                studentToUpdate.FirstName = "Steve";
                context.SaveChanges();

                var studentToDelete = context.Students.First<Student>();
                context.Students.Remove(studentToUpdate);
                context.SaveChanges();
            }
        }
    }
}
