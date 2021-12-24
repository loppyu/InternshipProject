using Intenship.Domain.Enums;
using System;

namespace Intenship.Domain.Models
{
    public class Project
    {
        public int id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public CurentStatus CurrentStatus { get; set; }
        public Priority Priority { get; set; }
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }
    }
}
