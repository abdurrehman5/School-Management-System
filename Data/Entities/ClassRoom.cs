using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Base;
namespace Data.Entities
{
    public class ClassRoom : BaseEntity
    {
        [MaxLength(4)]
        public string Year { get; set; }
        [MaxLength(45)]
        public string? Remarks { get; set; }
        [MaxLength(2)]
        public char Section { get; set; }
        public bool IsStatus { get; set; }
        public int? GradeId { get; set; }
        public int? TeacherId { get; set; }
        public Grade Grade { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<ClassRoomStudent> ClassRoomStudent { get; set; }
    }
}
