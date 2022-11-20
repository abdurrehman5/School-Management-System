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
    public class CourseController : BaseController<Course>
    {
        public CourseController(IBaseService<Course> storage) : base(storage)
        {
        }
        
    }
}