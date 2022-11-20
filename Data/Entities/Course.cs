using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Base;
namespace Data.Entities
{
    public class Course : BaseEntity
    {
        [MaxLength(45)]
        public string? Name { get; set; }
        [MaxLength(45)]
        public string? Description { get; set; }
        public int? GradeId { get; set; }
        public Grade Grade { get; set; }
        public ICollection<ExamResult> ExamResult { get; set; }
    }
}
