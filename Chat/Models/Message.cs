using System;

namespace Chat.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string SenderId { get; set; }
        public string SenderUsername { get; set; }
        public AppUser Sender { get; set; }

        public string RecipientId { get; set; }
        public string ResipientUsername { get; set; }
        public AppUser Recipient { get; set; }

        public string Content { get; set; }
        public Nullable<DateTime> DateRead { get; set; }
        public DateTime MessageSent { get; set; }
        public bool SenderDeleted { get; set; }
        public bool RecipientDeleted { get; set; }

    }
}
