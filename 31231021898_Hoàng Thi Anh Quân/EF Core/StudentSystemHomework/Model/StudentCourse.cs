using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemHomework.Model
{
    public class StudentCourse
    {
        [Key]
        [Column(Order = 1)]
        public int StudentId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int CourseId { get; set; }

        // Navigation properties
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
