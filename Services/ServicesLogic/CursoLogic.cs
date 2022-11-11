using System;

namespace Services.ServicesLogic
{
    public class CursoLogic : ICursoLogic
    {
        private readonly UnivercityContext _context;
        public CursoLogic(UnivercityContext context)
        {
            _context = context;
        }
    }
}
