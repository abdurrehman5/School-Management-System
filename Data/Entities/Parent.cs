using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Base;
namespace Data.Entities
{
    public class Parent : BaseEntity
    {
        [MaxLength(45)]
        public string? Email { get; set; }
        [MaxLength(45)]
        public string? Password { get; set; }
        [MaxLength(45)]
        public string? FirstName { get; set; }
        [MaxLength(45)]
        public string? LastName { get; set; }
        public DateTime? Dob { get; set; }

        [MaxLength(15)]
        public string? Phone { get; set; }
        [MaxLength(15)]
        public string? Mobile { get; set; }
        public bool IsStatus { get; set; }
        public DateTime? LastloginDate { get; set; }
        [MaxLength(45)]
        public string LastloginIp { get; set; }
        public ICollection<Student> Student { get; set; }
    }
}
