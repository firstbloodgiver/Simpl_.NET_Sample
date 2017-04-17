using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Empty2Foo.Models
{
    public class Person
    {
        [Required(ErrorMessage = "姓名不能为空！")]
        public String Name { get; set; }
        [Range(15, 30, ErrorMessage = "年龄必须在15到30岁。")]
        public int Age { get; set; }


    }
}
