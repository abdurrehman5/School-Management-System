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
namespace Services.StudentFolder
{
    public class StudentService : BaseService<Student>, IStudentService
    {
        private readonly IBaseRepository<Student> _studentRepository;
        public StudentService(IBaseRepository<Student> studentRepository) : base(studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public override void Validate(Student entity)
        {
            this.Validate(entity);
        }
        public async Task<IEnumerable<Student>> GetAllStudentBackground()
        {
            return _studentRepository.Get();
        }
    }
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudentBackground();
    }
}
