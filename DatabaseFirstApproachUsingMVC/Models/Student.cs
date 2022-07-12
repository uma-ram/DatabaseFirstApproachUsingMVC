using System;
using System.Collections.Generic;

namespace DatabaseFirstApproachUsingMVC.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; } = null!;
        public string? EmailAddress { get; set; }
    }
}
