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
    public class CourseRepository: BaseRepository<Course>,ICourseRepository
    {
        public CourseRepository(StudentContext repositoryContext)
           : base(repositoryContext)
        {
        }
    }
    public  interface ICourseRepository
    {
    }
}
