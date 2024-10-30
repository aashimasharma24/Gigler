using System.ComponentModel.DataAnnotations;

namespace Gigler.Core.DataObjects
{
    public class QuestionTitle
    {
        public int Id { get; set; }
        public required string Guid { get; set; }
        public int QuestionId { get; set; }
        public required string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
    }
}
