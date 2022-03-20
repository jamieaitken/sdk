/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.139
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;

namespace Ory.Client.Model
{
    /// <summary>
    /// ClientNormalizedProjectRevisionThirdPartyProvider
    /// </summary>
    [DataContract(Name = "normalizedProjectRevisionThirdPartyProvider")]
    public partial class ClientNormalizedProjectRevisionThirdPartyProvider : IEquatable<ClientNormalizedProjectRevisionThirdPartyProvider>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientNormalizedProjectRevisionThirdPartyProvider" /> class.
        /// </summary>
        /// <param name="applePrivateKey">applePrivateKey.</param>
        /// <param name="applePrivateKeyId">Apple Private Key Identifier  Sign In with Apple Private Key Identifier needed for generating a JWT token for client secret.</param>
        /// <param name="appleTeamId">Apple Developer Team ID  Apple Developer Team ID needed for generating a JWT token for client secret.</param>
        /// <param name="authUrl">AuthURL is the authorize url, typically something like: https://example.org/oauth2/auth Should only be used when the OAuth2 / OpenID Connect server is not supporting OpenID Connect Discovery and when &#x60;provider&#x60; is set to &#x60;generic&#x60;..</param>
        /// <param name="azureTenant">Tenant is the Azure AD Tenant to use for authentication, and must be set when &#x60;provider&#x60; is set to &#x60;microsoft&#x60;.  Can be either &#x60;common&#x60;, &#x60;organizations&#x60;, &#x60;consumers&#x60; for a multitenant application or a specific tenant like &#x60;8eaef023-2b34-4da1-9baa-8bc8c9d6a490&#x60; or &#x60;contoso.onmicrosoft.com&#x60;..</param>
        /// <param name="clientId">ClientID is the application&#39;s Client ID..</param>
        /// <param name="clientSecret">clientSecret.</param>
        /// <param name="id">id.</param>
        /// <param name="issuerUrl">IssuerURL is the OpenID Connect Server URL. You can leave this empty if &#x60;provider&#x60; is not set to &#x60;generic&#x60;. If set, neither &#x60;auth_url&#x60; nor &#x60;token_url&#x60; are required..</param>
        /// <param name="label">Label represents an optional label which can be used in the UI generation..</param>
        /// <param name="mapperUrl">Mapper specifies the JSONNet code snippet which uses the OpenID Connect Provider&#39;s data (e.g. GitHub or Google profile information) to hydrate the identity&#39;s data.  It can be either a URL (file://, http(s)://, base64://) or an inline JSONNet code snippet..</param>
        /// <param name="projectRevisionId">projectRevisionId.</param>
        /// <param name="provider">Provider is either \&quot;generic\&quot; for a generic OAuth 2.0 / OpenID Connect Provider or one of: generic google github gitlab microsoft discord slack facebook vk yandex apple.</param>
        /// <param name="providerId">ID is the provider&#39;s ID.</param>
        /// <param name="requestedClaims">requestedClaims.</param>
        /// <param name="scope">scope.</param>
        /// <param name="tokenUrl">TokenURL is the token url, typically something like: https://example.org/oauth2/token  Should only be used when the OAuth2 / OpenID Connect server is not supporting OpenID Connect Discovery and when &#x60;provider&#x60; is set to &#x60;generic&#x60;..</param>
        public ClientNormalizedProjectRevisionThirdPartyProvider(string applePrivateKey = default(string), string applePrivateKeyId = default(string), string appleTeamId = default(string), string authUrl = default(string), string azureTenant = default(string), string clientId = default(string), string clientSecret = default(string), string id = default(string), string issuerUrl = default(string), string label = default(string), string mapperUrl = default(string), string projectRevisionId = default(string), string provider = default(string), string providerId = default(string), Object requestedClaims = default(Object), List<string> scope = default(List<string>), string tokenUrl = default(string))
        {
            this.ApplePrivateKey = applePrivateKey;
            this.ApplePrivateKeyId = applePrivateKeyId;
            this.AppleTeamId = appleTeamId;
            this.AuthUrl = authUrl;
            this.AzureTenant = azureTenant;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.Id = id;
            this.IssuerUrl = issuerUrl;
            this.Label = label;
            this.MapperUrl = mapperUrl;
            this.ProjectRevisionId = projectRevisionId;
            this.Provider = provider;
            this.ProviderId = providerId;
            this.RequestedClaims = requestedClaims;
            this.Scope = scope;
            this.TokenUrl = tokenUrl;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets ApplePrivateKey
        /// </summary>
        [DataMember(Name = "apple_private_key", EmitDefaultValue = false)]
        public string ApplePrivateKey { get; set; }

        /// <summary>
        /// Apple Private Key Identifier  Sign In with Apple Private Key Identifier needed for generating a JWT token for client secret
        /// </summary>
        /// <value>Apple Private Key Identifier  Sign In with Apple Private Key Identifier needed for generating a JWT token for client secret</value>
        [DataMember(Name = "apple_private_key_id", EmitDefaultValue = false)]
        public string ApplePrivateKeyId { get; set; }

        /// <summary>
        /// Apple Developer Team ID  Apple Developer Team ID needed for generating a JWT token for client secret
        /// </summary>
        /// <value>Apple Developer Team ID  Apple Developer Team ID needed for generating a JWT token for client secret</value>
        [DataMember(Name = "apple_team_id", EmitDefaultValue = false)]
        public string AppleTeamId { get; set; }

        /// <summary>
        /// AuthURL is the authorize url, typically something like: https://example.org/oauth2/auth Should only be used when the OAuth2 / OpenID Connect server is not supporting OpenID Connect Discovery and when &#x60;provider&#x60; is set to &#x60;generic&#x60;.
        /// </summary>
        /// <value>AuthURL is the authorize url, typically something like: https://example.org/oauth2/auth Should only be used when the OAuth2 / OpenID Connect server is not supporting OpenID Connect Discovery and when &#x60;provider&#x60; is set to &#x60;generic&#x60;.</value>
        [DataMember(Name = "auth_url", EmitDefaultValue = false)]
        public string AuthUrl { get; set; }

        /// <summary>
        /// Tenant is the Azure AD Tenant to use for authentication, and must be set when &#x60;provider&#x60; is set to &#x60;microsoft&#x60;.  Can be either &#x60;common&#x60;, &#x60;organizations&#x60;, &#x60;consumers&#x60; for a multitenant application or a specific tenant like &#x60;8eaef023-2b34-4da1-9baa-8bc8c9d6a490&#x60; or &#x60;contoso.onmicrosoft.com&#x60;.
        /// </summary>
        /// <value>Tenant is the Azure AD Tenant to use for authentication, and must be set when &#x60;provider&#x60; is set to &#x60;microsoft&#x60;.  Can be either &#x60;common&#x60;, &#x60;organizations&#x60;, &#x60;consumers&#x60; for a multitenant application or a specific tenant like &#x60;8eaef023-2b34-4da1-9baa-8bc8c9d6a490&#x60; or &#x60;contoso.onmicrosoft.com&#x60;.</value>
        [DataMember(Name = "azure_tenant", EmitDefaultValue = false)]
        public string AzureTenant { get; set; }

        /// <summary>
        /// ClientID is the application&#39;s Client ID.
        /// </summary>
        /// <value>ClientID is the application&#39;s Client ID.</value>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets ClientSecret
        /// </summary>
        [DataMember(Name = "client_secret", EmitDefaultValue = false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The Project&#39;s Revision Creation Date
        /// </summary>
        /// <value>The Project&#39;s Revision Creation Date</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// IssuerURL is the OpenID Connect Server URL. You can leave this empty if &#x60;provider&#x60; is not set to &#x60;generic&#x60;. If set, neither &#x60;auth_url&#x60; nor &#x60;token_url&#x60; are required.
        /// </summary>
        /// <value>IssuerURL is the OpenID Connect Server URL. You can leave this empty if &#x60;provider&#x60; is not set to &#x60;generic&#x60;. If set, neither &#x60;auth_url&#x60; nor &#x60;token_url&#x60; are required.</value>
        [DataMember(Name = "issuer_url", EmitDefaultValue = false)]
        public string IssuerUrl { get; set; }

        /// <summary>
        /// Label represents an optional label which can be used in the UI generation.
        /// </summary>
        /// <value>Label represents an optional label which can be used in the UI generation.</value>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Mapper specifies the JSONNet code snippet which uses the OpenID Connect Provider&#39;s data (e.g. GitHub or Google profile information) to hydrate the identity&#39;s data.  It can be either a URL (file://, http(s)://, base64://) or an inline JSONNet code snippet.
        /// </summary>
        /// <value>Mapper specifies the JSONNet code snippet which uses the OpenID Connect Provider&#39;s data (e.g. GitHub or Google profile information) to hydrate the identity&#39;s data.  It can be either a URL (file://, http(s)://, base64://) or an inline JSONNet code snippet.</value>
        [DataMember(Name = "mapper_url", EmitDefaultValue = false)]
        public string MapperUrl { get; set; }

        /// <summary>
        /// Gets or Sets ProjectRevisionId
        /// </summary>
        [DataMember(Name = "project_revision_id", EmitDefaultValue = false)]
        public string ProjectRevisionId { get; set; }

        /// <summary>
        /// Provider is either \&quot;generic\&quot; for a generic OAuth 2.0 / OpenID Connect Provider or one of: generic google github gitlab microsoft discord slack facebook vk yandex apple
        /// </summary>
        /// <value>Provider is either \&quot;generic\&quot; for a generic OAuth 2.0 / OpenID Connect Provider or one of: generic google github gitlab microsoft discord slack facebook vk yandex apple</value>
        [DataMember(Name = "provider", EmitDefaultValue = false)]
        public string Provider { get; set; }

        /// <summary>
        /// ID is the provider&#39;s ID
        /// </summary>
        /// <value>ID is the provider&#39;s ID</value>
        [DataMember(Name = "provider_id", EmitDefaultValue = false)]
        public string ProviderId { get; set; }

        /// <summary>
        /// Gets or Sets RequestedClaims
        /// </summary>
        [DataMember(Name = "requested_claims", EmitDefaultValue = false)]
        public Object RequestedClaims { get; set; }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public List<string> Scope { get; set; }

        /// <summary>
        /// TokenURL is the token url, typically something like: https://example.org/oauth2/token  Should only be used when the OAuth2 / OpenID Connect server is not supporting OpenID Connect Discovery and when &#x60;provider&#x60; is set to &#x60;generic&#x60;.
        /// </summary>
        /// <value>TokenURL is the token url, typically something like: https://example.org/oauth2/token  Should only be used when the OAuth2 / OpenID Connect server is not supporting OpenID Connect Discovery and when &#x60;provider&#x60; is set to &#x60;generic&#x60;.</value>
        [DataMember(Name = "token_url", EmitDefaultValue = false)]
        public string TokenUrl { get; set; }

        /// <summary>
        /// Last Time Project&#39;s Revision was Updated
        /// </summary>
        /// <value>Last Time Project&#39;s Revision was Updated</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientNormalizedProjectRevisionThirdPartyProvider {\n");
            sb.Append("  ApplePrivateKey: ").Append(ApplePrivateKey).Append("\n");
            sb.Append("  ApplePrivateKeyId: ").Append(ApplePrivateKeyId).Append("\n");
            sb.Append("  AppleTeamId: ").Append(AppleTeamId).Append("\n");
            sb.Append("  AuthUrl: ").Append(AuthUrl).Append("\n");
            sb.Append("  AzureTenant: ").Append(AzureTenant).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssuerUrl: ").Append(IssuerUrl).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  MapperUrl: ").Append(MapperUrl).Append("\n");
            sb.Append("  ProjectRevisionId: ").Append(ProjectRevisionId).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  RequestedClaims: ").Append(RequestedClaims).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  TokenUrl: ").Append(TokenUrl).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientNormalizedProjectRevisionThirdPartyProvider);
        }

        /// <summary>
        /// Returns true if ClientNormalizedProjectRevisionThirdPartyProvider instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientNormalizedProjectRevisionThirdPartyProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientNormalizedProjectRevisionThirdPartyProvider input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplePrivateKey == input.ApplePrivateKey ||
                    (this.ApplePrivateKey != null &&
                    this.ApplePrivateKey.Equals(input.ApplePrivateKey))
                ) && 
                (
                    this.ApplePrivateKeyId == input.ApplePrivateKeyId ||
                    (this.ApplePrivateKeyId != null &&
                    this.ApplePrivateKeyId.Equals(input.ApplePrivateKeyId))
                ) && 
                (
                    this.AppleTeamId == input.AppleTeamId ||
                    (this.AppleTeamId != null &&
                    this.AppleTeamId.Equals(input.AppleTeamId))
                ) && 
                (
                    this.AuthUrl == input.AuthUrl ||
                    (this.AuthUrl != null &&
                    this.AuthUrl.Equals(input.AuthUrl))
                ) && 
                (
                    this.AzureTenant == input.AzureTenant ||
                    (this.AzureTenant != null &&
                    this.AzureTenant.Equals(input.AzureTenant))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IssuerUrl == input.IssuerUrl ||
                    (this.IssuerUrl != null &&
                    this.IssuerUrl.Equals(input.IssuerUrl))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.MapperUrl == input.MapperUrl ||
                    (this.MapperUrl != null &&
                    this.MapperUrl.Equals(input.MapperUrl))
                ) && 
                (
                    this.ProjectRevisionId == input.ProjectRevisionId ||
                    (this.ProjectRevisionId != null &&
                    this.ProjectRevisionId.Equals(input.ProjectRevisionId))
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.ProviderId == input.ProviderId ||
                    (this.ProviderId != null &&
                    this.ProviderId.Equals(input.ProviderId))
                ) && 
                (
                    this.RequestedClaims == input.RequestedClaims ||
                    (this.RequestedClaims != null &&
                    this.RequestedClaims.Equals(input.RequestedClaims))
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope != null &&
                    input.Scope != null &&
                    this.Scope.SequenceEqual(input.Scope)
                ) && 
                (
                    this.TokenUrl == input.TokenUrl ||
                    (this.TokenUrl != null &&
                    this.TokenUrl.Equals(input.TokenUrl))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ApplePrivateKey != null)
                {
                    hashCode = (hashCode * 59) + this.ApplePrivateKey.GetHashCode();
                }
                if (this.ApplePrivateKeyId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplePrivateKeyId.GetHashCode();
                }
                if (this.AppleTeamId != null)
                {
                    hashCode = (hashCode * 59) + this.AppleTeamId.GetHashCode();
                }
                if (this.AuthUrl != null)
                {
                    hashCode = (hashCode * 59) + this.AuthUrl.GetHashCode();
                }
                if (this.AzureTenant != null)
                {
                    hashCode = (hashCode * 59) + this.AzureTenant.GetHashCode();
                }
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.ClientSecret != null)
                {
                    hashCode = (hashCode * 59) + this.ClientSecret.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.IssuerUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerUrl.GetHashCode();
                }
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.MapperUrl != null)
                {
                    hashCode = (hashCode * 59) + this.MapperUrl.GetHashCode();
                }
                if (this.ProjectRevisionId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectRevisionId.GetHashCode();
                }
                if (this.Provider != null)
                {
                    hashCode = (hashCode * 59) + this.Provider.GetHashCode();
                }
                if (this.ProviderId != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderId.GetHashCode();
                }
                if (this.RequestedClaims != null)
                {
                    hashCode = (hashCode * 59) + this.RequestedClaims.GetHashCode();
                }
                if (this.Scope != null)
                {
                    hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                }
                if (this.TokenUrl != null)
                {
                    hashCode = (hashCode * 59) + this.TokenUrl.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
