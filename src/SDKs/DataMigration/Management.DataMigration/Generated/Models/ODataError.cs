// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Error information in OData format.
    /// </summary>
    public partial class ODataError
    {
        /// <summary>
        /// Initializes a new instance of the ODataError class.
        /// </summary>
        public ODataError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataError class.
        /// </summary>
        /// <param name="code">The machine-readable description of the error,
        /// such as 'InvalidRequest' or 'InternalServerError'</param>
        /// <param name="message">The human-readable description of the
        /// error</param>
        /// <param name="details">Inner errors that caused this error</param>
        public ODataError(string code = default(string), string message = default(string), IList<ODataError> details = default(IList<ODataError>))
        {
            Code = code;
            Message = message;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the machine-readable description of the error, such as
        /// 'InvalidRequest' or 'InternalServerError'
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the human-readable description of the error
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets inner errors that caused this error
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ODataError> Details { get; set; }

    }
}