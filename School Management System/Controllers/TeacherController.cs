using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Repository.Base;
using School_Management_System.Controllers.Base;
using Services;
using Services.Base;

namespace School_Management_System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : BaseController<Teacher>
    {
        public TeacherController(IBaseService<Teacher> storage) : base(storage)
        {
        }
        
    }
}