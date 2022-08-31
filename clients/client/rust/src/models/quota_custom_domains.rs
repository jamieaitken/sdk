/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.25
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct QuotaCustomDomains {
    #[serde(rename = "available_domains", skip_serializing_if = "Option::is_none")]
    pub available_domains: Option<i64>,
    #[serde(rename = "can_use", skip_serializing_if = "Option::is_none")]
    pub can_use: Option<bool>,
    #[serde(rename = "used_domains", skip_serializing_if = "Option::is_none")]
    pub used_domains: Option<i64>,
}

impl Default for QuotaCustomDomains {
    fn default() -> Self {
        Self::new()
    }
}

impl QuotaCustomDomains {
    pub fn new() -> QuotaCustomDomains {
        QuotaCustomDomains {
                available_domains: None,
                can_use: None,
                used_domains: None,
        }
    }
}


