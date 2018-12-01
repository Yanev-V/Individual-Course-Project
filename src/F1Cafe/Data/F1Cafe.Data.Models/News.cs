using F1Cafe.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Data.Models
{
    public class News : BaseModel<int>
    {
        public News()
        {
            this.Comments = new HashSet<Comment>();
        }

        [Required]
        public string Title { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public string Content { get; set; }

        public string Summary { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public string AuthorId { get; set; }
        [Required]
        public F1CafeUser Author { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
