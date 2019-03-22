using ASP.NET_CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if(_pies == null)
            {
                InitializePies();
            }
        }
        private void InitializePies()
        {
            _pies = new List<Pie>
            {
                new Pie{Id = 1, Name = "Apple Pie", Price = 12.95m, ShortDiscription = "Come in here", LongDiscription ="be sure you knw what you re doing"},
                new Pie{Id = 2, Name = "Blueberry Cheese Cake", Price = 18, ShortDiscription = "Come in here", LongDiscription ="be sure you knw what you re doing"},
                new Pie{Id = 3, Name = "Cheese Cake", Price = 18.95m ,  ShortDiscription = "Come in here", LongDiscription ="be sure you knw what you re doing"},
                new Pie{Id = 4, Name = "Cherry Pie", Price = 15.95m,  ShortDiscription = "Come in here", LongDiscription ="be sure you knw what you re doing"}

            };
        }
        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
