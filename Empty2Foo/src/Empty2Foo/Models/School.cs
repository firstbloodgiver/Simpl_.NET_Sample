using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Empty2Foo.Models
{
    public partial class School
    {
        public School()
        {
            Student = new HashSet<Student>();
        }
        public int ObjId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "名称不能为空！")]
        public string Name { get; set; }
        [RegularExpression(@"http://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?", ErrorMessage = "请输入正确的网址！")]
        public string Site { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
