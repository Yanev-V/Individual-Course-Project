using F1Cafe.Data.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Data.Models
{
    public class Comment : BaseModel<int>
    {
        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Message { get; set; }

        public string AuthorId { get; set; }
        [Required]
        public F1CafeUser Author { get; set; }

        public int NewsId { get; set; }
        [Required]
        public News News { get; set; }

        [Required]
        public DateTime CommentedOn { get; set; }
    }
}
