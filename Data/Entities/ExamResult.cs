using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Base;
namespace Data.Entities
{
    public class ExamResult : BaseEntity
    {
        public int? ExamId { get; set; }
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }

        [MaxLength(45)]
        public string? Marks { get; set; }

        public Exam Exam { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
