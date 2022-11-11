using System;

namespace Services.ServicesManager
{
    public interface IServicesManager
    {
        ICategoryLogic CategoryLogic { get; }
        IChapterLogic ChapterLogic { get; }
        ICursoLogic CursoLogic { get; }
        IStudentLogic StudentLogic { get; }
        IUserLogic UserLogic { get; }
    }
}
