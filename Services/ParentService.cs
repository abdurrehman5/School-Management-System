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
    public class ParentService: BaseService<Parent>,IParentService
    {
        public ParentService(IBaseRepository<Parent>  baseRepository ):base(baseRepository)
        {
        }
    }
    public  interface IParentService
    {
    }
}
