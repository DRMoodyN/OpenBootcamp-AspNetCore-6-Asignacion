using System;

namespace Services.ServicesLogic
{
    public class UserLogic : IUserLogic
    {
        private readonly UnivercityContext _context;
        public UserLogic(UnivercityContext context)
        {
            _context = context;
        }
    }
}
