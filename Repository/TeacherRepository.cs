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
    public class TeacherRepository: BaseRepository<Teacher>,ITeacherRepository
    {
        public TeacherRepository(StudentContext repositoryContext)
           : base(repositoryContext)
        {
        }
    }
    public  interface ITeacherRepository
    {
    }
}
