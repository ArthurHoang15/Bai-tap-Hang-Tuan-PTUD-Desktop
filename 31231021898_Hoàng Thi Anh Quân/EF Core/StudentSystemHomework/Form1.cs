using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudentSystemHomework.Model;

namespace StudentSystemHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var context = new StudentSystemContext();
            var students = context.Homeworks.Include(s => s.Student).Select(s => new
            {
                Name = s.Student.Name,
                s.Content,
                s.ContentType,
            })
                .ToList();
            dataGridView1.DataSource = students;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            using var context = new StudentSystemContext();
            var resource = context.Resources.Include(r => r.Course).
                OrderBy(r => r.Course.StartDate)
        .ThenByDescending(r => r.Course.EndDate).
                Select(r => new
            {
                CourseName = r.Course.Name,
                CourseDescription = r.Course.Description,
                CourseStartDay = r.Course.StartDate,
                CourseEndDay = r.Course.EndDate,
                r.Name
            
            }).ToList();
                    
            dataGridView1.DataSource = resource;
        }
    }
}
