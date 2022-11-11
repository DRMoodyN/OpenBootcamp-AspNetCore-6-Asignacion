using System;

namespace UnivercityApiBackend.Controllers
{
    public class CategoryController : MyController
    {
        private IServicesManager _services;
        public CategoryController(IServicesManager services)
        {
            _services = services;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Category model)
        {
            var result = await _services.CategoryLogic.AddAsync(model);
            return StatusCode(StatusCodes.Status201Created, result);
        }
    }
}
