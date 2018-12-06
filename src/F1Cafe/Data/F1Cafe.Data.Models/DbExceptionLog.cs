using F1Cafe.Data.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Data.Models
{
    public class DbExceptionLog : BaseModel<int>
    {
        [Required]
        public string ExeptionType { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public string StackTrace { get; set; }

        public string Area { get; set; }

        public string Page { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        [Required]
        public DateTime LogTime { get; set; }

        [Required]
        public string User { get; set; }
    }
}
