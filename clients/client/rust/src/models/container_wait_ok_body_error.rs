/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.17
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

/// ContainerWaitOkBodyError : ContainerWaitOKBodyError container waiting error, if any



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct ContainerWaitOkBodyError {
    /// Details of an error
    #[serde(rename = "Message", skip_serializing_if = "Option::is_none")]
    pub message: Option<String>,
}

impl ContainerWaitOkBodyError {
    /// ContainerWaitOKBodyError container waiting error, if any
    pub fn new() -> ContainerWaitOkBodyError {
        ContainerWaitOkBodyError {
            message: None,
        }
    }
}


