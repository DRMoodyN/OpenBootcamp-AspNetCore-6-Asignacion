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
    }
}
