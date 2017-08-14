using System.Web.Http.Filters;
using System.Net.Http;
using System.Net;
using DH.Simplify.Core.Enterprise.Common;
using DH.Simplify.Core.Enterprise.Logging;

namespace DH.Simplify.API.Infrastructure.Filters
{
    /// <summary>
    ///  Handles all exceptions
    /// </summary>
    public class HandleApiExceptionFilter : ExceptionFilterAttribute
    {
        /// <summary>
        /// Process all Exceptions in current context
        /// </summary>
        /// <param name="context"></param>
        public override void OnException(HttpActionExecutedContext context)
        {
            Logger.Instance.Log(
                $"Error occurred while processing Request: {context.Request.RequestUri} || Method : {context.Request.Method}"
                , context.Exception);

            context.Response = context.ActionContext.Request.CreateResponse(HttpStatusCode.InternalServerError
                                                                           , ServiceResponse.Instance.BuildResponse(ResponseCodes.INTERNAL_SEREVR_ERROR)
                                                                           );
        }
    }
}