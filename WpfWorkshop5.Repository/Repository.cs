using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfWorkshop5.Logic;

namespace WpfWorkshop5.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected static List<T> items = new List<T>();
        public Repository(IEnumerable<T> items)
        {
            items = items.ToList();
        }

        public void Create(T item)
        {
            items.Add(item);
        }

        public IEnumerable<T> ReadAll()
        {
            return items;
        }
    }
}
