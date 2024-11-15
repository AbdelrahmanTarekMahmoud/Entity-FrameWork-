﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Model
{
    public class Post
    {
        public int Id { get; set; }
        public string Title {  get; set; }
        public string Content { get; set; }
        public int UserId { get; set; } //Foreign Key
        public int CategoryId { get; set; } //Foreign Key
        public DateTime CreatedAT { get; set; }

        //Navigation Property
        public User User { get; set; }
        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
