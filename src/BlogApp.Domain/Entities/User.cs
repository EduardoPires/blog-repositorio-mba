﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BlogApp.Domain.Entities
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }

        // Relacionamentos
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}