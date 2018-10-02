using System;
using $ext_projectname$.Common.Contracts;

namespace $safeprojectname$
{
    public abstract class ServiceContractBase
    {
        // just to make sure all our manager, engines, and accessors have a TestMe method for smoke tests
        public virtual string TestMe(string input)
        {
            string result = $"{input} : {GetType().Name}";
            Console.WriteLine(result);
            return result;
        }

        private static Logger _logger;
        protected static Logger Logger
        {
            get
            {
                if (_logger == null)
                {
                    _logger = new Logger();
                }

                return _logger;
            }
        }

        public AmbientContext Context
        {
            get; set;
        }
    }
}
