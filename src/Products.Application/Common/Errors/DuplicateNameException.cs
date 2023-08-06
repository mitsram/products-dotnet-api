using System.Net;

namespace Products.Application.Common.Errors;

public class DuplicateNameException : Exception, IServiceException
{
    public HttpStatusCode StatusCode => HttpStatusCode.Conflict;

    public string ErrorMessage => "Name already exists.";
}