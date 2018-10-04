using System;

namespace $safeprojectname$
{
    public class AmbientContext
    {
        public string AuthToken { get; set; }

        public Guid SessionId { get; set; }

        public int SellerId { get; set; }
    }
}
