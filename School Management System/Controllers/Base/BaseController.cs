using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Base;
using System.Linq.Expressions;
namespace School_Management_System.Controllers.Base
{
    [Route("api/[controller]")]
    public  class BaseController<T> : Controller where T : class
    {
        private readonly IBaseService<T> _baseService;
        public BaseController(IBaseService<T> baseService)
        {
            _baseService=baseService;
        }
        
        // POST: BaseController/Create
        [HttpPost]
        public  IActionResult Create(T entity)
        {
            return new JsonResult( _baseService.Add(entity));
        }
        [HttpPut]
        public IActionResult Edit(T entity)
        {
            return new JsonResult( _baseService.Update(entity));
        }
        // GET: BaseController/Edit/5
        [HttpGet]
        public IActionResult Get(int id)
        {
            return new JsonResult( _baseService.Get(id));
        }
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(_baseService.Get());
        }
        [HttpGet]
        public IActionResult Get(Expression<Func<T, bool>> expression)
        {
            return new JsonResult(_baseService.Get(expression));
        }
        //[HttpGet]
        //public async Task<IActionResult> Get(Expression<Func<T, bool>> expression)
        //{
        //    return new JsonResult(await _baseService.FindByCondition(expression));
        //}
        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    return new JsonResult(await _baseService.GetAll());
        //}
        // POST: BaseController/Edit/5
        // GET: BaseController/Delete/5
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return new JsonResult( _baseService.Delete(id));
        }
        [HttpDelete]
        public IActionResult Delete(T entity)
        {
            return new JsonResult(_baseService.Delete(entity));
        }
        [HttpPost]
        public IActionResult BulkInsert(IEnumerable<T> entities)
        {
            return new JsonResult(_baseService.BulkInsert(entities));
        }
        [HttpPut]
        public IActionResult BulkUpdate(IEnumerable<T> entities)
        {
            return new JsonResult(_baseService.BulkUpdate(entities));
        }
        [HttpDelete]
        public IActionResult BulkDelete(IEnumerable<T> entities)
        {
            return new JsonResult(_baseService.BulkDelete(entities));
        }
    }
}
