using Data;
using Data.Entities;
using Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Repository
{
    public class ExamTypeRepository: BaseRepository<ExamType>,IExamTypeRepository
    {
        public ExamTypeRepository(StudentContext repositoryContext)
           : base(repositoryContext)
        {
        }
    }
    public  interface IExamTypeRepository
    {
    }
}
