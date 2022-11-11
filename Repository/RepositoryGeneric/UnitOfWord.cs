using System;

namespace Repository.RepositoryGeneric
{
    public class UnitOfWord : IUnitOfWord
    {
        private readonly UnivercityContext _context;
        public UnitOfWord(UnivercityContext context)
        {
            _context = context;
        }

        private IRepositoryGeneric<Category> _category;
        private IRepositoryGeneric<ChapterModel> _chapeterModel;
        private IRepositoryGeneric<Course> _course;
        private IRepositoryGeneric<Student> _student;
        private IRepositoryGeneric<User> _user;

        public IRepositoryGeneric<Category> Category
        => _category ??= new RepositoryGeneric<Category>(_context);

        public IRepositoryGeneric<ChapterModel> ChapeterModel
        => _chapeterModel ??= new RepositoryGeneric<ChapterModel>(_context);

        public IRepositoryGeneric<Course> Course
        => _course ??= new RepositoryGeneric<Course>(_context);

        public IRepositoryGeneric<Student> Student
        => _student ??= new RepositoryGeneric<Student>(_context);

        public IRepositoryGeneric<User> User
        => _user ??= new RepositoryGeneric<User>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
            await _context.DisposeAsync();
        }
    }
}
