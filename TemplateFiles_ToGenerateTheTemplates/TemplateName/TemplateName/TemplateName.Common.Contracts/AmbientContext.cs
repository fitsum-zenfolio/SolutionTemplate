using System;

namespace TemplateName.Common.Contracts
{
    public class AmbientContext
    {
        public string AuthToken { get; set; }

        public Guid SessionId { get; set; }

        public int SellerId { get; set; }
    }
}
