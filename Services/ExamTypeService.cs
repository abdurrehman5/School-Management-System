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
    public class ExamTypeService: BaseService<ExamType>,IExamTypeService
    {
        public ExamTypeService(IBaseRepository<ExamType>  baseRepository ):base(baseRepository)
        {
        }
    }

    public  interface IExamTypeService
    {
    }
}
