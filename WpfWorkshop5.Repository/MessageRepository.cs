using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfWorkshop5.Logic;

namespace WpfWorkshop5.Repository
{
    public class MessageRepository : Repository<Message>, IRepository<Message>
    {
        public List<Message> Messages { get; set; }
        public MessageRepository(IEnumerable<Message> items) : base(items) 
        {
            Messages = items.ToList();
        }
    }
}
