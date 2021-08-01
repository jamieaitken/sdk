/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.17
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

/// PluginMount : PluginMount plugin mount



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct PluginMount {
    /// description
    #[serde(rename = "Description")]
    pub description: String,
    /// destination
    #[serde(rename = "Destination")]
    pub destination: String,
    /// name
    #[serde(rename = "Name")]
    pub name: String,
    /// options
    #[serde(rename = "Options")]
    pub options: Vec<String>,
    /// settable
    #[serde(rename = "Settable")]
    pub settable: Vec<String>,
    /// source
    #[serde(rename = "Source")]
    pub source: String,
    /// type
    #[serde(rename = "Type")]
    pub _type: String,
}

impl PluginMount {
    /// PluginMount plugin mount
    pub fn new(description: String, destination: String, name: String, options: Vec<String>, settable: Vec<String>, source: String, _type: String) -> PluginMount {
        PluginMount {
            description,
            destination,
            name,
            options,
            settable,
            source,
            _type,
        }
    }
}


