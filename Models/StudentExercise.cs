using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebAPI_CodeFistEntityFramework.Models
{
    public class StudentExercise
    {
        [Key]
        public int StudentExerciseID { get; set; }
        public int idStudent { get; set; }
        public int idExercise { get; set; }
        public virtual Student Student { get; set; }
        public virtual Exercise Exercise { get; set; }
    }
}