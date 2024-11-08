using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; } // foregin key
        public int UserId { get; set; } // foregin key

        //Navigation Property
        public Post Post { get; set; }
        public User User { get; set; }
    }
}
