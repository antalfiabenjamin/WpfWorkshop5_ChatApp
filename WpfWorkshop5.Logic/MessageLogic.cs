using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfWorkshop5.Repository;

namespace WpfWorkshop5.Logic
{
    public class MessageLogic : IMessageLogic
    {
        IRepository<Message> repo;
        public MessageLogic(IRepository<Message> repo)
        {
            this.repo = repo;
        }

        public void Create(Message item)
        {
            repo.Create(item);
        }

        public IEnumerable<Message> ReadAll()
        {
            return repo.ReadAll();
        }
    }
}
