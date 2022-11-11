using System;

namespace Repository.IRepositoryGeneric
{
    public interface IUnitOfWord : IDisposable
    {
        IRepositoryGeneric<Category> Category { get; }
        IRepositoryGeneric<ChapterModel> ChapeterModel { get; }
        IRepositoryGeneric<Course> Course { get; }
        IRepositoryGeneric<Student> Student { get; }
        IRepositoryGeneric<User> User { get; }
        Task SaveAsync();
    }
}
