using System;
using System.Collections.Generic;

namespace Messenger.Domain.Entities
{
    public class Chat
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IList<User> Users { get; set; }
        public IList<Message> Messages { get; set; }
    }
}
