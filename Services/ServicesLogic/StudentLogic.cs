using System;

namespace Services.ServicesLogic
{
    public class StudentLogic : IStudentLogic
    {
        private readonly UnivercityContext _context;
        public StudentLogic(UnivercityContext context)
        {
            _context = context;
        }
    }
}
