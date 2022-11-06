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
    public class ParentController : BaseController<Parent>
    {
        public ParentController(IBaseService<Parent> storage) : base(storage)
        {
        }
        
    }
}