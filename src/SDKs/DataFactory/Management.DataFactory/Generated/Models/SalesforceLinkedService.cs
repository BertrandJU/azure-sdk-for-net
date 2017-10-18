// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Linked service for Salesforce.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Salesforce")]
    [Rest.Serialization.JsonTransformation]
    public partial class SalesforceLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the SalesforceLinkedService class.
        /// </summary>
        public SalesforceLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SalesforceLinkedService class.
        /// </summary>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="environmentUrl">The URL of Salesforce instance.
        /// Default is 'https://login.salesforce.com'. To copy data from
        /// sandbox, specify 'https://test.salesforce.com'. To copy data from
        /// custom domain, specify, for example,
        /// 'https://[domain].my.salesforce.com'. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="username">The username for Basic authentication of the
        /// Salesforce source. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="password">The password for Basic authentication of the
        /// Salesforce source.</param>
        /// <param name="securityToken">The security token is required to
        /// remotely access Salesforce source.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public SalesforceLinkedService(IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), object environmentUrl = default(object), object username = default(object), SecureString password = default(SecureString), SecureString securityToken = default(SecureString), object encryptedCredential = default(object))
            : base(connectVia, description)
        {
            EnvironmentUrl = environmentUrl;
            Username = username;
            Password = password;
            SecurityToken = securityToken;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL of Salesforce instance. Default is
        /// 'https://login.salesforce.com'. To copy data from sandbox, specify
        /// 'https://test.salesforce.com'. To copy data from custom domain,
        /// specify, for example, 'https://[domain].my.salesforce.com'. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.environmentUrl")]
        public object EnvironmentUrl { get; set; }

        /// <summary>
        /// Gets or sets the username for Basic authentication of the
        /// Salesforce source. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.username")]
        public object Username { get; set; }

        /// <summary>
        /// Gets or sets the password for Basic authentication of the
        /// Salesforce source.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecureString Password { get; set; }

        /// <summary>
        /// Gets or sets the security token is required to remotely access
        /// Salesforce source.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.securityToken")]
        public SecureString SecurityToken { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Password != null)
            {
                Password.Validate();
            }
            if (SecurityToken != null)
            {
                SecurityToken.Validate();
            }
        }
    }
}