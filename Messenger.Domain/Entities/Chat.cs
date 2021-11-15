using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Domain.Entities
{
    public class Chat
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IList<User> Users { get; set; }
        public IList<Message> Messages { get; set; }
    }
}
