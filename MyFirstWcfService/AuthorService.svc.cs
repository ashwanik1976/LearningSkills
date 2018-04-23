using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyFirstWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuthorService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AuthorService.svc or AuthorService.svc.cs at the Solution Explorer and start debugging.
    public class AuthorService : IAuthorService
    {
        private const string AuthorId = "101";
        public AuthorResponse GetInfo(AuthorRequest Req)
        {
            if (Req.AuthorId != AuthorId)
            {
                CustomException cx = new CustomException();
                string ReqOrderId ="Passing Author Id :" + Req.AuthorId;
                throw new FaultException<CustomException>(cx, new FaultReason(ReqOrderId));
            }
            AuthorResponse authorResponse = new AuthorResponse();

            // create an object of Auther Class

            authorResponse.Author = new Author();
            authorResponse.Author.FirstName = "Amit";
            authorResponse.Author.LastName = "Tiwari";
            authorResponse.Author.Artical = "Learn WCF";
            return authorResponse;
        }
    }
}
