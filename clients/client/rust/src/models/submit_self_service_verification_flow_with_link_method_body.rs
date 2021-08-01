/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.17
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct SubmitSelfServiceVerificationFlowWithLinkMethodBody {
    /// Sending the anti-csrf token is only required for browser login flows.
    #[serde(rename = "csrf_token", skip_serializing_if = "Option::is_none")]
    pub csrf_token: Option<String>,
    /// Email to Verify  Needs to be set when initiating the flow. If the email is a registered verification email, a verification link will be sent. If the email is not known, a email with details on what happened will be sent instead.  format: email
    #[serde(rename = "email")]
    pub email: String,
    /// Method supports `link` only right now.
    #[serde(rename = "method")]
    pub method: Method,
}

impl SubmitSelfServiceVerificationFlowWithLinkMethodBody {
    pub fn new(email: String, method: Method) -> SubmitSelfServiceVerificationFlowWithLinkMethodBody {
        SubmitSelfServiceVerificationFlowWithLinkMethodBody {
            csrf_token: None,
            email,
            method,
        }
    }
}

/// Method supports `link` only right now.
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum Method {
    #[serde(rename = "link")]
    Link,
}

