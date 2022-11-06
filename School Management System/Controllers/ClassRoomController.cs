using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using School_Management_System.Controllers.Base;
using Services;
using Services.Base;

namespace School_Management_System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassRoomController : BaseController<ClassRoom>
    {
        public ClassRoomController(IBaseService<ClassRoom> storage) : base(storage)
        {
        }

    }
}