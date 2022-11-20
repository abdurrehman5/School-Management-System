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
    public class ClassRoomRepository: BaseRepository<ClassRoom>,IClassRoomRepository
    {
        public ClassRoomRepository(StudentContext repositoryContext)
           : base(repositoryContext)
        {
        }
    }
    public  interface IClassRoomRepository
    {
    }
}
