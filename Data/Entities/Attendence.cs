using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Base;
namespace Data.Entities
{
    public class Attendence : BaseEntity
    {
        
        public DateTime? Date { get; set; }
        public int? StudentId { get; set; }
        public bool IssStatus { get; set; }
        [MaxLength(45)]
        public string? Remarks { get; set; }
        public Student Student { get; set; }
    }
}
