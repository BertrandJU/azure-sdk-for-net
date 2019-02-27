// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Payload for Add Users operation on a Lab.
    /// </summary>
    public partial class AddUsersPayload
    {
        /// <summary>
        /// Initializes a new instance of the AddUsersPayload class.
        /// </summary>
        public AddUsersPayload()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddUsersPayload class.
        /// </summary>
        /// <param name="emailAddresses">List of user emails addresses to add
        /// to the lab.</param>
        public AddUsersPayload(IList<string> emailAddresses)
        {
            EmailAddresses = emailAddresses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of user emails addresses to add to the lab.
        /// </summary>
        [JsonProperty(PropertyName = "emailAddresses")]
        public IList<string> EmailAddresses { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EmailAddresses == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EmailAddresses");
            }
        }
    }
}