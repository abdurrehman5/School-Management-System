using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Base;
namespace Data.Entities
{
    public class ClassRoomStudent : BaseEntity
    {
       

        public int? StudentId { get; set; }
        public int? ClassRoomId { get; set; }
        
        public Student Student { get; set; }
        public ClassRoom ClassRoom { get; set; }

    }
}
