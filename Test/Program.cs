using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbClasses;
using DbClasses.Model;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var t = new TestContext())
            {
                var ta = new WorkTask()
                {
                    Description = "TESTETST"
                };

                var user = new User()
                {
                    FirstName = "Jürgen",
                    LastName = "Schöner"
                };

                ta.Owner = user;

                t.Tasks.Add(ta);

                t.SaveChanges();
            }
        }
    }
}
