using System;

namespace Services.IServicesLogic
{
    public interface ICategoryLogic
    {
        Task<Category> AddAsync(Category model);
    }
}
