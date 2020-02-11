using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebAPI_CodeFistEntityFramework.Models
{
    public class Room
    {
        [Key]
        public int idRoom { get; set;}
        [StringLength(50)]
        public string Title { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}