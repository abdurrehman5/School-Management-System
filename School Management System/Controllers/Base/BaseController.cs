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
        public  async Task<IActionResult> Create(T entity)
        {
            return new JsonResult(await _baseService.Add(entity));
        }

        [HttpPut]
        public async Task<IActionResult> Edit(T entity)
        {
            return new JsonResult(await _baseService.Update(entity));
        }

        // GET: BaseController/Edit/5
        public async Task<IActionResult> Get(int id)
        {
            return new JsonResult(await _baseService.Get(id));
        }

        public async Task<IActionResult> Get(Expression<Func<T, bool>> expression)
        {
            return new JsonResult(await _baseService.FindByCondition(expression));
        }

        public async Task<IActionResult> Get()
        {
            return new JsonResult(await _baseService.GetAll());
        }

        // POST: BaseController/Edit/5

        // GET: BaseController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            return new JsonResult(await _baseService.Delete(id));
        }

    }
}
