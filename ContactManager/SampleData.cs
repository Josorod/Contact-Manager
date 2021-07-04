using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager
{
    public class SampleData
    {
        public static void Initialize(UserContext context)
        {
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }
            context.Users.AddRange(
                    new User
                    {
                        Name = "Roman Shemenda",
                        BirthDay = new DateTime(2002,11,08),
                        IsMarried = false,
                        Phone = "0932308395",
                        Salary=5000 
                    },
                     new User
                     {
                         Name = "Antonio Khatri",
                         BirthDay = new DateTime(1980, 06, 08),
                         IsMarried = true,
                         Phone = "9123481972",
                         Salary = 10000
                     }                  
                );
            context.SaveChanges();
        }
    }
}
