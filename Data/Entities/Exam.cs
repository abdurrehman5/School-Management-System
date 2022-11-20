using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Base;
namespace Data.Entities
{
    public class Exam : BaseEntity
    {
        [MaxLength(45)]
        public string? Name { get; set; }
        public DateTime? StartDate { get; set; }
        public int? ExamTypeId { get; set; }
        public ExamType ExmpType { get; set; }
        public ICollection<ExamResult> ExamResult { get; set; }
    }
}
