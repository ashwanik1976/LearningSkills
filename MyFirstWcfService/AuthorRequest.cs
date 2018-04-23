using System.ServiceModel;

namespace MyFirstWcfService
{
    [MessageContract]
    public class AuthorRequest
    {
        [MessageHeader]
        public string AuthorId { get; set; }
    }
}