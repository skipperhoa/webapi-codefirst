using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using WebAPI_CodeFistEntityFramework.Models;
namespace WebAPI_CodeFistEntityFramework.Controllers
{
    public class StudentController : ApiController
    {
        private dbEntities _db = new dbEntities();

        //api/student/
        public IEnumerable<Student> Get()
        {
            /* var student = _db.Students.Select(s => new Student
             {
                 idStudent = s.idStudent,
                 Name = s.Name,
                Age = s.Age,
                address = s.address,
                BirthDay =s.BirthDay

             }).ToList();*/
            var student = _db.Students.ToList();
            return student;
            
        }

        //api/student
        public IHttpActionResult Get(int id)
        {
            var student = _db.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
         

        //api/student
        public IHttpActionResult Post([FromBody] Student _std)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Không thành công!");
            }
            _db.Students.Add(_std);
            _db.SaveChanges();
            return Ok(_std);
        }

        //api/student/1
        public IHttpActionResult  Put([FromBody] Student _std,int id)
        {
            var data = _db.Students.Where(s => s.idStudent == id).FirstOrDefault();
            if (data == null)
            {
                return BadRequest("ID không tồn tại"); 
            }
            data.Name = _std.Name;
            _db.SaveChanges();
            return Ok(data);
        }

        //api/student/1
        public IHttpActionResult Delete(int id)
        {
            var data = _db.Students.Find(id);
            if (data == null)
            {
                return BadRequest("Id không xóa được");
            }
            _db.Entry(data).State = EntityState.Deleted;
            _db.SaveChanges();
            return Ok("Ok");

        }
    }
}
