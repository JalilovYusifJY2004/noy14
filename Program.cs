using _14noy.Models;
using _14noy.Service;

namespace _14noy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var studentService = new StudentService();

            var newStudent = new Student
            {
                Name = "Yusif",
                Surname = "Jalilov",
                AvgPoint = 67
            };

            studentService.Create(newStudent);

            var allStudents = studentService.GetAll();
            Console.WriteLine("All Students:");
            foreach (var student in allStudents)
            {
                Console.WriteLine($"{student.Id} - {student.Name} {student.Surname}, AvgPoint: {student.AvgPoint}");
            }

      
            var studentById = studentService.GetById(1);
            if (studentById != null)
            {
                Console.WriteLine($"Student with Id 1: {studentById.Name} {studentById.Surname}, AvgPoint: {studentById.AvgPoint}");
            }

            studentService.Delete(1);

            allStudents = studentService.GetAll();
            Console.WriteLine("\nAll Students after Deletion:");
            foreach (var student in allStudents)
            {
                Console.WriteLine($"{student.Id} - {student.Name} {student.Surname}, AvgPoint: {student.AvgPoint}");
            }
        }
    }
    }
