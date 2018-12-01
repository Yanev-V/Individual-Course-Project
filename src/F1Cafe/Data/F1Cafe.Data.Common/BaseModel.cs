using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Data.Common
{
    public abstract class BaseModel<T>
    {
        [Key]
        public T Id { get; set; }
    }
}
