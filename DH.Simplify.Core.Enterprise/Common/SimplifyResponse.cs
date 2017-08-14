using System.Runtime.Serialization;

namespace DH.Simplify.Core.Enterprise.Common
{
    /// <summary>
    /// SimplifyResponse object
    /// </summary>
    /// <typeparam name="T">Type T</typeparam>
    [DataContract(Name = "SimplifyResponse{0}")]
    public class SimplifyResponse<T>
    {
        /// <summary>
        /// service custom code
        /// </summary>
        [DataMember]
        public int Code { get; set; }

        /// <summary>
        /// service custom message
        /// </summary>
        [DataMember]
        public string Message { get; set; }

        /// <summary>
        /// response object
        /// </summary>
        [DataMember]
        public T Data { get; set; }
    }

    /// <summary>
    /// SimplifyResponse object
    /// </summary>
    public class SimplifyResponse
    {
        /// <summary>
        /// service custom code
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// service custom message
        /// </summary>
        public string Message { get; set; }
    }
}
