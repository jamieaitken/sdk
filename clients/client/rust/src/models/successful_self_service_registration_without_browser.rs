/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.25
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

/// SuccessfulSelfServiceRegistrationWithoutBrowser : The Response for Registration Flows via API



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct SuccessfulSelfServiceRegistrationWithoutBrowser {
    #[serde(rename = "identity")]
    pub identity: Box<crate::models::Identity>,
    #[serde(rename = "session", skip_serializing_if = "Option::is_none")]
    pub session: Option<Box<crate::models::Session>>,
    /// The Session Token  This field is only set when the session hook is configured as a post-registration hook.  A session token is equivalent to a session cookie, but it can be sent in the HTTP Authorization Header:  Authorization: bearer ${session-token}  The session token is only issued for API flows, not for Browser flows!
    #[serde(rename = "session_token", skip_serializing_if = "Option::is_none")]
    pub session_token: Option<String>,
}


impl SuccessfulSelfServiceRegistrationWithoutBrowser {
    /// The Response for Registration Flows via API
    pub fn new(identity: crate::models::Identity) -> SuccessfulSelfServiceRegistrationWithoutBrowser {
        SuccessfulSelfServiceRegistrationWithoutBrowser {
                identity: Box::new(identity),
                session: None,
                session_token: None,
        }
    }
}


