using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Chat.Models
{
    public class AppUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImgUrl { get; set; }
        public string ConnectionId { get; set; }
        public ICollection<Message> MessagesSent { get; set; }
        public ICollection<Message> MessageReceived { get; set; }
    }
}
