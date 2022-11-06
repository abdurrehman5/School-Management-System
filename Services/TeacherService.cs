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
    public class TeacherService: BaseService<Teacher>,ITeacherService
    {
        public TeacherService(IBaseRepository<Teacher>  baseRepository ):base(baseRepository)
        {
        }
    }

    public  interface ITeacherService
    {
    }
}
