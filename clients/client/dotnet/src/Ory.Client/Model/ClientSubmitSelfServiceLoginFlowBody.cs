/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.127
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Ory.Client.Model
{
    /// <summary>
    /// ClientSubmitSelfServiceLoginFlowBody
    /// </summary>
    [JsonConverter(typeof(ClientSubmitSelfServiceLoginFlowBodyJsonConverter))]
    [DataContract(Name = "submitSelfServiceLoginFlowBody")]
    public partial class ClientSubmitSelfServiceLoginFlowBody : AbstractOpenAPISchema, IEquatable<ClientSubmitSelfServiceLoginFlowBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubmitSelfServiceLoginFlowBody" /> class
        /// with the <see cref="ClientSubmitSelfServiceLoginFlowWithLookupSecretMethodBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientSubmitSelfServiceLoginFlowWithLookupSecretMethodBody.</param>
        public ClientSubmitSelfServiceLoginFlowBody(ClientSubmitSelfServiceLoginFlowWithLookupSecretMethodBody actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubmitSelfServiceLoginFlowBody" /> class
        /// with the <see cref="ClientSubmitSelfServiceLoginFlowWithOidcMethodBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientSubmitSelfServiceLoginFlowWithOidcMethodBody.</param>
        public ClientSubmitSelfServiceLoginFlowBody(ClientSubmitSelfServiceLoginFlowWithOidcMethodBody actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubmitSelfServiceLoginFlowBody" /> class
        /// with the <see cref="ClientSubmitSelfServiceLoginFlowWithPasswordMethodBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientSubmitSelfServiceLoginFlowWithPasswordMethodBody.</param>
        public ClientSubmitSelfServiceLoginFlowBody(ClientSubmitSelfServiceLoginFlowWithPasswordMethodBody actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubmitSelfServiceLoginFlowBody" /> class
        /// with the <see cref="ClientSubmitSelfServiceLoginFlowWithTotpMethodBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientSubmitSelfServiceLoginFlowWithTotpMethodBody.</param>
        public ClientSubmitSelfServiceLoginFlowBody(ClientSubmitSelfServiceLoginFlowWithTotpMethodBody actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSubmitSelfServiceLoginFlowBody" /> class
        /// with the <see cref="ClientSubmitSelfServiceLoginFlowWithWebAuthnMethodBody" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientSubmitSelfServiceLoginFlowWithWebAuthnMethodBody.</param>
        public ClientSubmitSelfServiceLoginFlowBody(ClientSubmitSelfServiceLoginFlowWithWebAuthnMethodBody actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(ClientSubmitSelfServiceLoginFlowWithLookupSecretMethodBody))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientSubmitSelfServiceLoginFlowWithOidcMethodBody))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientSubmitSelfServiceLoginFlowWithPasswordMethodBody))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientSubmitSelfServiceLoginFlowWithTotpMethodBody))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientSubmitSelfServiceLoginFlowWithWebAuthnMethodBody))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ClientSubmitSelfServiceLoginFlowWithLookupSecretMethodBody, ClientSubmitSelfServiceLoginFlowWithOidcMethodBody, ClientSubmitSelfServiceLoginFlowWithPasswordMethodBody, ClientSubmitSelfServiceLoginFlowWithTotpMethodBody, ClientSubmitSelfServiceLoginFlowWithWebAuthnMethodBody");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ClientSubmitSelfServiceLoginFlowWithLookupSecretMethodBody`. If the actual instance is not `ClientSubmitSelfServiceLoginFlowWithLookupSecretMethodBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientSubmitSelfServiceLoginFlowWithLookupSecretMethodBody</returns>
        public ClientSubmitSelfServiceLoginFlowWithLookupSecretMethodBody GetClientSubmitSelfServiceLoginFlowWithLookupSecretMethodBody()
        {
            return (ClientSubmitSelfServiceLoginFlowWithLookupSecretMethodBody)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientSubmitSelfServiceLoginFlowWithOidcMethodBody`. If the actual instance is not `ClientSubmitSelfServiceLoginFlowWithOidcMethodBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientSubmitSelfServiceLoginFlowWithOidcMethodBody</returns>
        public ClientSubmitSelfServiceLoginFlowWithOidcMethodBody GetClientSubmitSelfServiceLoginFlowWithOidcMethodBody()
        {
            return (ClientSubmitSelfServiceLoginFlowWithOidcMethodBody)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientSubmitSelfServiceLoginFlowWithPasswordMethodBody`. If the actual instance is not `ClientSubmitSelfServiceLoginFlowWithPasswordMethodBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientSubmitSelfServiceLoginFlowWithPasswordMethodBody</returns>
        public ClientSubmitSelfServiceLoginFlowWithPasswordMethodBody GetClientSubmitSelfServiceLoginFlowWithPasswordMethodBody()
        {
            return (ClientSubmitSelfServiceLoginFlowWithPasswordMethodBody)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientSubmitSelfServiceLoginFlowWithTotpMethodBody`. If the actual instance is not `ClientSubmitSelfServiceLoginFlowWithTotpMethodBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientSubmitSelfServiceLoginFlowWithTotpMethodBody</returns>
        public ClientSubmitSelfServiceLoginFlowWithTotpMethodBody GetClientSubmitSelfServiceLoginFlowWithTotpMethodBody()
        {
            return (ClientSubmitSelfServiceLoginFlowWithTotpMethodBody)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientSubmitSelfServiceLoginFlowWithWebAuthnMethodBody`. If the actual instance is not `ClientSubmitSelfServiceLoginFlowWithWebAuthnMethodBody`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientSubmitSelfServiceLoginFlowWithWebAuthnMethodBody</returns>
        public ClientSubmitSelfServiceLoginFlowWithWebAuthnMethodBody GetClientSubmitSelfServiceLoginFlowWithWebAuthnMethodBody()
        {
            return (ClientSubmitSelfServiceLoginFlowWithWebAuthnMethodBody)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientSubmitSelfServiceLoginFlowBody {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, ClientSubmitSelfServiceLoginFlowBody.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ClientSubmitSelfServiceLoginFlowBody
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ClientSubmitSelfServiceLoginFlowBody</returns>
        public static ClientSubmitSelfServiceLoginFlowBody FromJson(string jsonString)
        {
            ClientSubmitSelfServiceLoginFlowBody newClientSubmitSelfServiceLoginFlowBody = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newClientSubmitSelfServiceLoginFlowBody;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientSubmitSelfServiceLoginFlowWithLookupSecretMethodBody).GetProperty("AdditionalProperties") == null)
                {
                    newClientSubmitSelfServiceLoginFlowBody = new ClientSubmitSelfServiceLoginFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceLoginFlowWithLookupSecretMethodBody>(jsonString, ClientSubmitSelfServiceLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newClientSubmitSelfServiceLoginFlowBody = new ClientSubmitSelfServiceLoginFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceLoginFlowWithLookupSecretMethodBody>(jsonString, ClientSubmitSelfServiceLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientSubmitSelfServiceLoginFlowWithLookupSecretMethodBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientSubmitSelfServiceLoginFlowWithLookupSecretMethodBody: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientSubmitSelfServiceLoginFlowWithOidcMethodBody).GetProperty("AdditionalProperties") == null)
                {
                    newClientSubmitSelfServiceLoginFlowBody = new ClientSubmitSelfServiceLoginFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceLoginFlowWithOidcMethodBody>(jsonString, ClientSubmitSelfServiceLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newClientSubmitSelfServiceLoginFlowBody = new ClientSubmitSelfServiceLoginFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceLoginFlowWithOidcMethodBody>(jsonString, ClientSubmitSelfServiceLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientSubmitSelfServiceLoginFlowWithOidcMethodBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientSubmitSelfServiceLoginFlowWithOidcMethodBody: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientSubmitSelfServiceLoginFlowWithPasswordMethodBody).GetProperty("AdditionalProperties") == null)
                {
                    newClientSubmitSelfServiceLoginFlowBody = new ClientSubmitSelfServiceLoginFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceLoginFlowWithPasswordMethodBody>(jsonString, ClientSubmitSelfServiceLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newClientSubmitSelfServiceLoginFlowBody = new ClientSubmitSelfServiceLoginFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceLoginFlowWithPasswordMethodBody>(jsonString, ClientSubmitSelfServiceLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientSubmitSelfServiceLoginFlowWithPasswordMethodBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientSubmitSelfServiceLoginFlowWithPasswordMethodBody: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientSubmitSelfServiceLoginFlowWithTotpMethodBody).GetProperty("AdditionalProperties") == null)
                {
                    newClientSubmitSelfServiceLoginFlowBody = new ClientSubmitSelfServiceLoginFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceLoginFlowWithTotpMethodBody>(jsonString, ClientSubmitSelfServiceLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newClientSubmitSelfServiceLoginFlowBody = new ClientSubmitSelfServiceLoginFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceLoginFlowWithTotpMethodBody>(jsonString, ClientSubmitSelfServiceLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientSubmitSelfServiceLoginFlowWithTotpMethodBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientSubmitSelfServiceLoginFlowWithTotpMethodBody: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientSubmitSelfServiceLoginFlowWithWebAuthnMethodBody).GetProperty("AdditionalProperties") == null)
                {
                    newClientSubmitSelfServiceLoginFlowBody = new ClientSubmitSelfServiceLoginFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceLoginFlowWithWebAuthnMethodBody>(jsonString, ClientSubmitSelfServiceLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newClientSubmitSelfServiceLoginFlowBody = new ClientSubmitSelfServiceLoginFlowBody(JsonConvert.DeserializeObject<ClientSubmitSelfServiceLoginFlowWithWebAuthnMethodBody>(jsonString, ClientSubmitSelfServiceLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientSubmitSelfServiceLoginFlowWithWebAuthnMethodBody");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientSubmitSelfServiceLoginFlowWithWebAuthnMethodBody: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newClientSubmitSelfServiceLoginFlowBody;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientSubmitSelfServiceLoginFlowBody);
        }

        /// <summary>
        /// Returns true if ClientSubmitSelfServiceLoginFlowBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientSubmitSelfServiceLoginFlowBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientSubmitSelfServiceLoginFlowBody input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for ClientSubmitSelfServiceLoginFlowBody
    /// </summary>
    public class ClientSubmitSelfServiceLoginFlowBodyJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ClientSubmitSelfServiceLoginFlowBody).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return ClientSubmitSelfServiceLoginFlowBody.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
