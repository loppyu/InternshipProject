using Intenship.Domain.Enums;

namespace Intenship.Domain.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
    }
}
