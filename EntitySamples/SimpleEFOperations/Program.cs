using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SimpleEFOperations.DBcontext;
using SimpleEFOperations.Modles;
using System;
using System.Linq;

namespace SimpleEFOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var appDbContext = new AppDbContext())
            {
                foreach (var item in appDbContext.Staff)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("=============================================================");
                var Animal1 = appDbContext.Staff.FirstOrDefault();
                Console.WriteLine($"Updating [{Animal1.ToString()}]");
                Animal1.Hire_Date = DateTime.UtcNow;
                Console.WriteLine($"after Updating [{Animal1.ToString()}]");
                Console.WriteLine("=============================================================");

                Staff s = new Staff();
                s.Email = "omar.omar@hotmail.com";
                s.Hire_Date = DateTime.UtcNow.AddDays(-3);
                appDbContext.Staff.Add(s);
                Console.WriteLine("=============================================================");
                appDbContext.SaveChanges();
            }



        }
    }
}
