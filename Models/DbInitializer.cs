using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Pies.Any())
            {
                context.AddRange
                    (
                new Pie {  Name = "Apple Pie", Price = 12.95m, ShortDiscription = "Come in here", LongDiscription = "be sure you knw what you re doing" },
                new Pie {  Name = "Blueberry Cheese Cake", Price = 18, ShortDiscription = "Come in here", LongDiscription = "be sure you knw what you re doing" },
                new Pie {  Name = "Cheese Cake", Price = 18.95m, ShortDiscription = "Come in here", LongDiscription = "be sure you knw what you re doing" },
                new Pie {  Name = "Cherry Pie", Price = 15.95m, ShortDiscription = "Come in here", LongDiscription = "be sure you knw what you re doing" },
                new Pie { Name = "Cheese Cake", Price = 18.95m, ShortDiscription = "Come in here", LongDiscription = "be sure you knw what you re doing" },
                new Pie { Name = "Cherry Pie", Price = 15.95m, ShortDiscription = "Come in here", LongDiscription = "be sure you knw what you re doing" }

                    );
                context.SaveChanges();
            }
        }
    }
}
