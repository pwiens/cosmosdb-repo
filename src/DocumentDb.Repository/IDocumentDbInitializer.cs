using Microsoft.Azure.Documents.Client;
using System.Threading.Tasks;

namespace DocumentDB.Repository
{
    using Microsoft.Azure.Documents;

    public interface IDocumentDbInitializer
    {
        IDocumentClient GetClient(string endpointUrl, string authorizationKey, ConnectionPolicy connectionPolicy = null);
    }
}