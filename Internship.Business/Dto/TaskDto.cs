using Intenship.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internship.Business.Dto
{
    public class TaskDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
    }
}
