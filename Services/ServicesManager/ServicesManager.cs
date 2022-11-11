using System;

namespace Services.ServicesManager
{
    public class ServicesManager : IServicesManager
    {
        private Lazy<CategoryLogic> _category;
        private Lazy<ChapterLogic> _chapter;
        private Lazy<CursoLogic> _curso;
        private Lazy<StudentLogic> _student;
        private Lazy<UserLogic> _user;

        public ServicesManager(UnivercityContext context)
        {
            _category = new Lazy<CategoryLogic>(() => new CategoryLogic(context));
            _chapter = new Lazy<ChapterLogic>(() => new ChapterLogic(context));
            _curso = new Lazy<CursoLogic>(() => new CursoLogic(context));
            _student = new Lazy<StudentLogic>(() => new StudentLogic(context));
            _user = new Lazy<UserLogic>(() => new UserLogic(context));
        }

        public ICategoryLogic CategoryLogic => _category.Value;
        public IChapterLogic ChapterLogic => _chapter.Value;
        public ICursoLogic CursoLogic => _curso.Value;
        public IStudentLogic StudentLogic => _student.Value;
        public IUserLogic UserLogic => _user.Value;
    }
}
