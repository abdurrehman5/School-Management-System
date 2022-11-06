using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public string? EditBy { get; set; }
        public DateTime? EditOn { get; set; }
        public bool IsDeleted { get; set; }

    }
}
