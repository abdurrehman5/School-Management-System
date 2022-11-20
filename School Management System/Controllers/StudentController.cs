using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Repository.Base;
using School_Management_System.Controllers.Base;
//using School_Management_System.Middleware.ExceptionHandling;
using Services.BackgroundWoker;
using Services.Base;
using Services.StudentFolder;
namespace School_Management_System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : BaseController<Student>
    {
        private readonly IStudentService _studentService;
        private readonly IBackgroundQueue _backgroundQueue;
        private readonly IServiceScopeFactory _serviceScopeFactory;
        public StudentController(IBaseService<Student> storage,
            IBackgroundQueue backgroundQueue,
            IServiceScopeFactory serviceScopeFactory,
            IStudentService studentService) : base(storage)
        {
            _backgroundQueue= backgroundQueue;
            _serviceScopeFactory=serviceScopeFactory;
            _studentService = studentService;
        }
        [HttpGet("GetAllBackground")]
        public async Task<IActionResult> GetAllBackground()
        {
            //_backgroundQueue.QueueBackgroundWorkItem(async token =>
            //{
            //    using (var scope = _serviceScopeFactory.CreateScope())
            //    {
            //        var studentService = scope.ServiceProvider
            //                        .GetRequiredService<IStudentService>();
            //throw new DomainServiceException("Not Found");

            return new JsonResult( await _studentService.GetAllStudentBackground());
               // };
           // });
            //return Ok("In progress..");
        }
    }
}