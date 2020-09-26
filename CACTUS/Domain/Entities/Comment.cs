using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CACTUS.Domain.Entities
{
    public class Comment
    {
        public Comment()
        {
            this.CommentId = Guid.NewGuid();
            this.Date = DateTime.UtcNow;
        }

        [Required]
        public Guid CommentId { get; set; }

        [Required]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        [Required]
        public Guid ItemId { get; set; }
        public string Item { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }
    }
}
