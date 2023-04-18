using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWorkshop5.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected List<T> items;
        public Repository(IEnumerable<T> items)
        {
            this.items = items.ToList();
        }

        public void Create(T item)
        {
            this.items.Add(item);
        }

        public IEnumerable<T> ReadAll()
        {
            return this.items;
        }
    }
}
