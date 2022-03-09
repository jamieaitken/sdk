/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.119
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct AdminCreateIdentityImportCredentialsOidcProvider {
    /// The OpenID Connect provider to link the subject to. Usually something like `google` or `github`.
    #[serde(rename = "provider")]
    pub provider: String,
    /// The subject (`sub`) of the OpenID Connect connection. Usually the `sub` field of the ID Token.
    #[serde(rename = "subject")]
    pub subject: String,
}

impl AdminCreateIdentityImportCredentialsOidcProvider {
    pub fn new(provider: String, subject: String) -> AdminCreateIdentityImportCredentialsOidcProvider {
        AdminCreateIdentityImportCredentialsOidcProvider {
            provider,
            subject,
        }
    }
}


