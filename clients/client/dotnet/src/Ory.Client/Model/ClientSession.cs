/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.134
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
    /// A Session
    /// </summary>
    [DataContract(Name = "session")]
    public partial class ClientSession : IEquatable<ClientSession>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientSession()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSession" /> class.
        /// </summary>
        /// <param name="active">Active state. If false the session is no longer active..</param>
        /// <param name="authenticatedAt">The Session Authentication Timestamp  When this session was authenticated at. If multi-factor authentication was used this is the time when the last factor was authenticated (e.g. the TOTP code challenge was completed)..</param>
        /// <param name="authenticationMethods">A list of authenticators which were used to authenticate the session..</param>
        /// <param name="authenticatorAssuranceLevel">authenticatorAssuranceLevel.</param>
        /// <param name="expiresAt">The Session Expiry  When this session expires at..</param>
        /// <param name="id">id (required).</param>
        /// <param name="identity">identity (required).</param>
        /// <param name="issuedAt">The Session Issuance Timestamp  When this session was issued at. Usually equal or close to &#x60;authenticated_at&#x60;..</param>
        public ClientSession(bool active = default(bool), DateTime authenticatedAt = default(DateTime), List<ClientSessionAuthenticationMethod> authenticationMethods = default(List<ClientSessionAuthenticationMethod>), ClientAuthenticatorAssuranceLevel authenticatorAssuranceLevel = default(ClientAuthenticatorAssuranceLevel), DateTime expiresAt = default(DateTime), string id = default(string), ClientIdentity identity = default(ClientIdentity), DateTime issuedAt = default(DateTime))
        {
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ClientSession and cannot be null");
            }
            this.Id = id;
            // to ensure "identity" is required (not null)
            if (identity == null) {
                throw new ArgumentNullException("identity is a required property for ClientSession and cannot be null");
            }
            this.Identity = identity;
            this.Active = active;
            this.AuthenticatedAt = authenticatedAt;
            this.AuthenticationMethods = authenticationMethods;
            this.AuthenticatorAssuranceLevel = authenticatorAssuranceLevel;
            this.ExpiresAt = expiresAt;
            this.IssuedAt = issuedAt;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Active state. If false the session is no longer active.
        /// </summary>
        /// <value>Active state. If false the session is no longer active.</value>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// The Session Authentication Timestamp  When this session was authenticated at. If multi-factor authentication was used this is the time when the last factor was authenticated (e.g. the TOTP code challenge was completed).
        /// </summary>
        /// <value>The Session Authentication Timestamp  When this session was authenticated at. If multi-factor authentication was used this is the time when the last factor was authenticated (e.g. the TOTP code challenge was completed).</value>
        [DataMember(Name = "authenticated_at", EmitDefaultValue = false)]
        public DateTime AuthenticatedAt { get; set; }

        /// <summary>
        /// A list of authenticators which were used to authenticate the session.
        /// </summary>
        /// <value>A list of authenticators which were used to authenticate the session.</value>
        [DataMember(Name = "authentication_methods", EmitDefaultValue = false)]
        public List<ClientSessionAuthenticationMethod> AuthenticationMethods { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticatorAssuranceLevel
        /// </summary>
        [DataMember(Name = "authenticator_assurance_level", EmitDefaultValue = false)]
        public ClientAuthenticatorAssuranceLevel AuthenticatorAssuranceLevel { get; set; }

        /// <summary>
        /// The Session Expiry  When this session expires at.
        /// </summary>
        /// <value>The Session Expiry  When this session expires at.</value>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Identity
        /// </summary>
        [DataMember(Name = "identity", IsRequired = true, EmitDefaultValue = false)]
        public ClientIdentity Identity { get; set; }

        /// <summary>
        /// The Session Issuance Timestamp  When this session was issued at. Usually equal or close to &#x60;authenticated_at&#x60;.
        /// </summary>
        /// <value>The Session Issuance Timestamp  When this session was issued at. Usually equal or close to &#x60;authenticated_at&#x60;.</value>
        [DataMember(Name = "issued_at", EmitDefaultValue = false)]
        public DateTime IssuedAt { get; set; }

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
            sb.Append("class ClientSession {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  AuthenticatedAt: ").Append(AuthenticatedAt).Append("\n");
            sb.Append("  AuthenticationMethods: ").Append(AuthenticationMethods).Append("\n");
            sb.Append("  AuthenticatorAssuranceLevel: ").Append(AuthenticatorAssuranceLevel).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  IssuedAt: ").Append(IssuedAt).Append("\n");
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
            return this.Equals(input as ClientSession);
        }

        /// <summary>
        /// Returns true if ClientSession instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientSession input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.AuthenticatedAt == input.AuthenticatedAt ||
                    (this.AuthenticatedAt != null &&
                    this.AuthenticatedAt.Equals(input.AuthenticatedAt))
                ) && 
                (
                    this.AuthenticationMethods == input.AuthenticationMethods ||
                    this.AuthenticationMethods != null &&
                    input.AuthenticationMethods != null &&
                    this.AuthenticationMethods.SequenceEqual(input.AuthenticationMethods)
                ) && 
                (
                    this.AuthenticatorAssuranceLevel == input.AuthenticatorAssuranceLevel ||
                    (this.AuthenticatorAssuranceLevel != null &&
                    this.AuthenticatorAssuranceLevel.Equals(input.AuthenticatorAssuranceLevel))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
                ) && 
                (
                    this.IssuedAt == input.IssuedAt ||
                    (this.IssuedAt != null &&
                    this.IssuedAt.Equals(input.IssuedAt))
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
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.AuthenticatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticatedAt.GetHashCode();
                }
                if (this.AuthenticationMethods != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationMethods.GetHashCode();
                }
                if (this.AuthenticatorAssuranceLevel != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticatorAssuranceLevel.GetHashCode();
                }
                if (this.ExpiresAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Identity != null)
                {
                    hashCode = (hashCode * 59) + this.Identity.GetHashCode();
                }
                if (this.IssuedAt != null)
                {
                    hashCode = (hashCode * 59) + this.IssuedAt.GetHashCode();
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
