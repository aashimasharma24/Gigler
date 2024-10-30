using System.ComponentModel.DataAnnotations;

namespace Gigler.Core.DataObjects
{
    public class Question
    {
        public int Id { get; set; }
        public required string Guid { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        public int Type { get; set; }
    }
}
