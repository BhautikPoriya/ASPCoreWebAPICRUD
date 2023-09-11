using System;
using System.Collections.Generic;

namespace ASPCoreWebAPICRUD.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; } = null!;
        public string StudentGender { get; set; } = null!;
        public int StudentAge { get; set; }
        public int StudentStandard { get; set; }
    }
}
