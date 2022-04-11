using EFAndLinqPractice_SchoolAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFAndLinqPractice_SchoolAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly SchoolContext _dbContext;

        public StudentService(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Student Create(Student student)
        {
            if (student == null) throw new ArgumentNullException(nameof(student));

            _dbContext.Add(student);
            _dbContext.SaveChanges();

            return _dbContext.Students.OrderBy( s => s.Id ).Last();
        }

        public Student GetById(int id)
        {
            if(id < 1) throw new NotSupportedException(nameof(id));

            var studentItem = _dbContext.Students.FirstOrDefault( s => s.Id == id );

            if (studentItem == null) throw new KeyNotFoundException(nameof(id));

            return studentItem;
        }

        public IEnumerable<Student> GetAll()
        {
            return _dbContext.Students;
        }

        public IEnumerable<Student> GetStudentsByCourseId(int courseId)
        {
            if(courseId < 1) throw new NotSupportedException(nameof(courseId));

            var studentItems = _dbContext.Courses
                .Where( c => c.Id == courseId )
                .SelectMany( c => c.Students );

            if (!studentItems.Any()) throw new NullReferenceException(nameof(courseId));

            return studentItems;    

        }

        public void DeleteById(int id)
        {
            var studentItem = _dbContext.Students.FirstOrDefault( s => s.Id == id);

            if (studentItem == null) throw new KeyNotFoundException(nameof(id));

            _dbContext.Remove(studentItem);
            _dbContext.SaveChanges();

        }
    }
}