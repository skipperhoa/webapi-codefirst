using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebAPI_CodeFistEntityFramework.Models
{
    public class Exercise
    {
        [Key]
        public int idExercise { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public virtual ICollection<StudentExercise> StudentExercises { get; set; }
    }
}