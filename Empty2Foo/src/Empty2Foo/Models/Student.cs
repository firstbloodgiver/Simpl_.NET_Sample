using System;
using System.Collections.Generic;

namespace Empty2Foo.Models
{
    public partial class Student
    {
        public int ObjId { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string StudentId { get; set; }
        public int TheSchool { get; set; }

        public virtual School TheSchoolNavigation { get; set; }
    }
}
