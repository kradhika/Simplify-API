using System.Net;
using System.ComponentModel;
using DH.Simplify.Core.Enterprise.Enums;

namespace DH.Simplify.Core.Enterprise.Common
{
    /// <summary>
    /// Services response codes, messages for below supported HTTPStatusCodes 
    /// 200 - OK            (Success)
    /// 201 - Created       (Success)
    /// 400 - Bad Request   (Client Error)
    /// 401 - Unauthorized  (Client Error)
    /// 403 - Forbidden     (Client Error)
    /// 404 - NotFound      (Client Error)
    /// 500 - Internal Server Error (Server Error)
    /// </summary>
    public enum ResponseCodes
    {
        /// <summary>
        /// Success
        /// </summary>
        [HttpStatus(HttpStatusCode.OK)]
        [Description("Success")]
        OK = 2000,

        /// <summary>
        /// The request was processed successfully
        /// </summary>
        [HttpStatus(HttpStatusCode.Created)]
        [Description("The request was processed successfully")]
        CREATED = 2001,

        /// <summary>
        /// Invalid Or missing parameters
        /// </summary>
        [HttpStatus(HttpStatusCode.BadRequest)]
        [Description("Invalid Or missing parameters :")]
        INVALID_MISSING_INPUTS = 4000,

        /// <summary>
        /// Unauthorized access
        /// </summary>
        [HttpStatus(HttpStatusCode.Unauthorized)]
        [Description("Unauthorized access")]
        UNAUTHORIZED = 4001,

        /// <summary>
        /// Resource not found with the given details
        /// </summary>
        [HttpStatus(HttpStatusCode.NotFound)]
        [Description("Resource not found with the given details")]
        RESOURCE_NOTFOUND = 4101,

        /// <summary>
        /// An unexpected error occurred. Please contact administrator
        /// </summary>
        [HttpStatus(HttpStatusCode.InternalServerError)]
        [Description("An unexpected error occurred. Please contact administrator")]
        INTERNAL_SEREVR_ERROR = 5000
    }
}
