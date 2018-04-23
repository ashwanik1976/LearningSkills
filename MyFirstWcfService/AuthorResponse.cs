using System.ServiceModel;

namespace MyFirstWcfService
{
    [MessageContract]
    public class AuthorResponse
    {
        [MessageBodyMember]
        public Author Author { get; set; }
    }
}