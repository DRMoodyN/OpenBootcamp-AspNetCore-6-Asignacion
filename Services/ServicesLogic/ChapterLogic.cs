using System;

namespace Services.ServicesManager
{
    public class ChapterLogic:IChapterLogic
    {
        private readonly UnivercityContext _context;
        public ChapterLogic(UnivercityContext context)
        {
            _context = context;
        }
    }
}
