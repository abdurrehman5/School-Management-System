using Data;
using Data.Entities;
using Repository;
using Repository.Base;
using Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Services
{
    public class AttendenceService: BaseService<Attendence>,IAttendenceService
    {
        public AttendenceService(IBaseRepository<Attendence>  baseRepository ):base(baseRepository)
        {
        }
    }
    public  interface IAttendenceService
    {
    }
}
