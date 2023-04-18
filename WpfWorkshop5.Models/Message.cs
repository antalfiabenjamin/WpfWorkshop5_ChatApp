using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWorkshop5.Logic
{
    public class Message
    {
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string Sender { get; set; }

        public Message(string content, DateTime date, string sender)
        {
            Content = content;
            Date = date;
            Sender = sender;
        }
    }
}
