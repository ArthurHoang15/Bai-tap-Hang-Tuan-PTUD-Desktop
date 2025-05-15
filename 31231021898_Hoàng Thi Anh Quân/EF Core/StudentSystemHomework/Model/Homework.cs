using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemHomework.Model
{
    public class Homework
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        [StringLength(50)]
        public string ContentType { get; set; } // application/pdf/zip

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime SubmissionDate { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        public int StudentId { get; set; }

        // Navigation properties
        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }
    }
}
