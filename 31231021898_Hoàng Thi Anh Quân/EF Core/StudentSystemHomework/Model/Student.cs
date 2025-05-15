using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemHomework.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Registration Date")]
        public DateTime RegisteredOn { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime? BirthDay { get; set; }

        // Navigation properties
        public ICollection<StudentCourse> EnrolledCourses { get; set; }
        public ICollection<Homework> HomeworkSubmissions { get; set; }
    }
}
