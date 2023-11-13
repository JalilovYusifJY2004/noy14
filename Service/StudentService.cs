using _14noy.Dal;
using _14noy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14noy.Service
{
    internal class StudentService
    {
        private static AppDbContext _context = new AppDbContext();


        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }


        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(student => student.Id == id);
        }

        public void Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var studentToDelete = GetById(id);
            if (studentToDelete != null)
            {
                _context.Students.Remove(studentToDelete);
                _context.SaveChanges();
            }
        }
    }
}
