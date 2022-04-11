
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFAndLinqPractice_SchoolAPI.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        public decimal Height { get; set; }

        [Required]
        public float Weight { get; set; }

        //FK
        public virtual ICollection<Course> Courses { get; set; }
    }
}