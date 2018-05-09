using System;
using Microsoft.Azure.Documents.Client;

namespace DocumentDB.Repository
{
    using Microsoft.Azure.Documents;

    public class DocumentDbInitializer : IDocumentDbInitializer
    {
        public IDocumentClient GetClient(string endpointUrl, string authorizationKey, ConnectionPolicy connectionPolicy = null)
        {
            if (string.IsNullOrWhiteSpace(endpointUrl))
                throw new ArgumentNullException("endpointUrl");

            if (string.IsNullOrWhiteSpace(authorizationKey))
                throw new ArgumentNullException("authorizationKey");

            return new DocumentClient(new Uri(endpointUrl), authorizationKey, connectionPolicy ?? new ConnectionPolicy()
            {
                MaxConnectionLimit = 100,
                ConnectionMode = ConnectionMode.Direct,
                ConnectionProtocol = Protocol.Tcp,
                RetryOptions = new RetryOptions() { MaxRetryAttemptsOnThrottledRequests=3, MaxRetryWaitTimeInSeconds=60 }
            });
        }
    }
}