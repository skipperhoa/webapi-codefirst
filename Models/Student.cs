using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebAPI_CodeFistEntityFramework.Models
{
    public class Student
    {
        [Key]
        public int idStudent { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
      
        public int Age { get; set; }
       
        public DateTime BirthDay { get; set; }
        [StringLength(50)]
        public string address { get; set; }
        public int idRoom { get; set; }

        public virtual Room Room { get; set; }

        public virtual ICollection<StudentExercise> StudentExercises { get; set; }
    }
}