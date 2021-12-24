using Intenship.Domain.Enums;
using Intenship.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Internship.Business.Dto
{
     public class ProjectDto
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
