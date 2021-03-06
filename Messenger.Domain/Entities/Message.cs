using System;

namespace Messenger.Domain.Entities
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public User SentBy { get; set; }
        public DateTime SentAt { get; set; }
    }
}
