using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemHomework.Model
{
    public class Resource
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [EnumDataType(typeof(ResourceType))]
        public ResourceType ResourceType { get; set; }

        [Required]
        [Url]
        public string Url { get; set; }

        [Required]
        public int CourseId { get; set; }

        // Navigation property
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
    }
}
