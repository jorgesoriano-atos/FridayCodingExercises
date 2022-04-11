
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFAndLinqPractice_SchoolAPI.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }


        //FK
        public virtual ICollection<Student> Students { get; set; }
    }
}