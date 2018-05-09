using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentDb.Repository
{
    public class DocumentClientSettings
    {
        public string EndpointUrl { get; set; }
        public string AuthorizationKey { get; set; }
        public string DatabaseId { get; set; }
    }
}
