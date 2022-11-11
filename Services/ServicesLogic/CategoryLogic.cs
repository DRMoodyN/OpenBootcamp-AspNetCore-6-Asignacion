using System;

namespace Services.ServicesManager
{
    public class CategoryLogic : ICategoryLogic
    {
        private readonly UnivercityContext _context;
        public CategoryLogic(UnivercityContext context)
        {
            _context = context;
        }

        public async Task<Category> AddAsync(Category model)
        {
            await _context.Categories.AddAsync(model);
            return model;
        }
    }
}
