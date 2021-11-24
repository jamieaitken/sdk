/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * API version: v0.0.1-alpha.29
 * Contact: support@ory.sh
 */

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"time"
)

// ProjectRevision struct for ProjectRevision
type ProjectRevision struct {
	// The Project API URL  The URL where the Project's APIs are available.
	ApiUrl string `json:"api_url"`
	// Your Application URL  The URL where your application is available. Your users will be redirected to this URL when they successfully complete a login, logout, verification, recovery, or registration flow.  More fine-grained redirection patterns are available for the individual flows.
	ApplicationUrl string `json:"application_url"`
	// The Project's Revision Creation Date
	CreatedAt time.Time `json:"created_at"`
	// Default Identity Schema URL  This represents your Ory Kratos Default Identity Schema. It is your identity's default schema. This allows setting custom fields such as \"address\", specifying whether you want to log in using email or a username, and more. For more information on this topic, please check out the identity documentation.  The value of this field can be either any \"https://\" URL - for example a file hosted at GitHub, or a `preset://`-prefixed string. Available profiles are:  profile://email profile://username
	DefaultIdentitySchemaUrl string `json:"default_identity_schema_url"`
	// Self-Service Error UI URL  Sets the UI URL for the error UI. If left empty, this will use Ory's hosted pages.
	ErrorUiUrl *string `json:"error_ui_url,omitempty"`
	Hosts []string `json:"hosts"`
	Id string `json:"id"`
	// The Project's Kratos Config Version
	KratosConfigVersion *string `json:"kratos_config_version,omitempty"`
	KratosCustomSchemaId *NullUUID `json:"kratos_custom_schema_id,omitempty"`
	// Self-Service Login UI URL  Sets the UI URL for the login UI. If left empty, this will use Ory's hosted pages.
	LoginUiUrl *string `json:"login_ui_url,omitempty"`
	LookupSecret *ProjectLookupSecretConfig `json:"lookup_secret,omitempty"`
	// The project's name.
	Name string `json:"name"`
	OidcProviders []ProjectOidcConfig `json:"oidc_providers,omitempty"`
	Password *ProjectPasswordConfig `json:"password,omitempty"`
	ProjectId string `json:"project_id"`
	Recovery *ProjectRecoveryConfig `json:"recovery,omitempty"`
	// Self-Service Login UI URL  Sets the UI URL for the recovery UI. If left empty, this will use Ory's hosted pages.
	RecoveryUiUrl *string `json:"recovery_ui_url,omitempty"`
	RedirectionConfig *RedirectionConfig `json:"redirection_config,omitempty"`
	// Self-Service Login UI URL  Sets the UI URL for the registration UI. If left empty, this will use Ory's hosted pages.
	RegistrationUiUrl *string `json:"registration_ui_url,omitempty"`
	// Issue Session after Sign Up  If set to true, users will receive a session after they successfully signed up. Enabling this option allows account enumeration during registration flows. Read more: https://www.ory.sh/kratos/docs/self-service/flows/user-registration#successful-registration
	SessionAfterSignUp bool `json:"session_after_sign_up"`
	// Enable Soft 2FA for Login Sessions
	SessionSoft2fa *bool `json:"session_soft_2fa,omitempty"`
	// Duration in Seconds of how long a Session is Privileged  Defines how long a session is considered privileged in seconds. If the session's authenticated_at is older than the value specified here, the user needs to re-authenticate to perform certain actions (e.g. password change).
	SettingsPrivilegedSessionMaxAgeSeconds *int64 `json:"settings_privileged_session_max_age_seconds,omitempty"`
	// Enable Soft 2FA for Self-Service Settings Flows
	SettingsSoft2fa *bool `json:"settings_soft_2fa,omitempty"`
	// Self-Service Settings UI URL  Sets the UI URL for the settings UI. If left empty, this will use Ory's hosted pages.
	SettingsUiUrl *string `json:"settings_ui_url,omitempty"`
	Totp *ProjectTotpConfig `json:"totp,omitempty"`
	// Last Time Project's Revision was Updated
	UpdatedAt time.Time `json:"updated_at"`
	Verification *ProjectVerificationConfig `json:"verification,omitempty"`
	// Self-Service Login UI URL  Sets the UI URL for the verification UI. If left empty, this will use Ory's hosted pages.
	VerificationUiUrl *string `json:"verification_ui_url,omitempty"`
	Webauthn *ProjectWebAuthnConfig `json:"webauthn,omitempty"`
}

// NewProjectRevision instantiates a new ProjectRevision object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewProjectRevision(apiUrl string, applicationUrl string, createdAt time.Time, defaultIdentitySchemaUrl string, hosts []string, id string, name string, projectId string, sessionAfterSignUp bool, updatedAt time.Time) *ProjectRevision {
	this := ProjectRevision{}
	this.ApiUrl = apiUrl
	this.ApplicationUrl = applicationUrl
	this.CreatedAt = createdAt
	this.DefaultIdentitySchemaUrl = defaultIdentitySchemaUrl
	this.Hosts = hosts
	this.Id = id
	this.Name = name
	this.ProjectId = projectId
	this.SessionAfterSignUp = sessionAfterSignUp
	this.UpdatedAt = updatedAt
	return &this
}

// NewProjectRevisionWithDefaults instantiates a new ProjectRevision object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewProjectRevisionWithDefaults() *ProjectRevision {
	this := ProjectRevision{}
	return &this
}

// GetApiUrl returns the ApiUrl field value
func (o *ProjectRevision) GetApiUrl() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.ApiUrl
}

// GetApiUrlOk returns a tuple with the ApiUrl field value
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetApiUrlOk() (*string, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.ApiUrl, true
}

// SetApiUrl sets field value
func (o *ProjectRevision) SetApiUrl(v string) {
	o.ApiUrl = v
}

// GetApplicationUrl returns the ApplicationUrl field value
func (o *ProjectRevision) GetApplicationUrl() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.ApplicationUrl
}

// GetApplicationUrlOk returns a tuple with the ApplicationUrl field value
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetApplicationUrlOk() (*string, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.ApplicationUrl, true
}

// SetApplicationUrl sets field value
func (o *ProjectRevision) SetApplicationUrl(v string) {
	o.ApplicationUrl = v
}

// GetCreatedAt returns the CreatedAt field value
func (o *ProjectRevision) GetCreatedAt() time.Time {
	if o == nil {
		var ret time.Time
		return ret
	}

	return o.CreatedAt
}

// GetCreatedAtOk returns a tuple with the CreatedAt field value
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetCreatedAtOk() (*time.Time, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.CreatedAt, true
}

// SetCreatedAt sets field value
func (o *ProjectRevision) SetCreatedAt(v time.Time) {
	o.CreatedAt = v
}

// GetDefaultIdentitySchemaUrl returns the DefaultIdentitySchemaUrl field value
func (o *ProjectRevision) GetDefaultIdentitySchemaUrl() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.DefaultIdentitySchemaUrl
}

// GetDefaultIdentitySchemaUrlOk returns a tuple with the DefaultIdentitySchemaUrl field value
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetDefaultIdentitySchemaUrlOk() (*string, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.DefaultIdentitySchemaUrl, true
}

// SetDefaultIdentitySchemaUrl sets field value
func (o *ProjectRevision) SetDefaultIdentitySchemaUrl(v string) {
	o.DefaultIdentitySchemaUrl = v
}

// GetErrorUiUrl returns the ErrorUiUrl field value if set, zero value otherwise.
func (o *ProjectRevision) GetErrorUiUrl() string {
	if o == nil || o.ErrorUiUrl == nil {
		var ret string
		return ret
	}
	return *o.ErrorUiUrl
}

// GetErrorUiUrlOk returns a tuple with the ErrorUiUrl field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetErrorUiUrlOk() (*string, bool) {
	if o == nil || o.ErrorUiUrl == nil {
		return nil, false
	}
	return o.ErrorUiUrl, true
}

// HasErrorUiUrl returns a boolean if a field has been set.
func (o *ProjectRevision) HasErrorUiUrl() bool {
	if o != nil && o.ErrorUiUrl != nil {
		return true
	}

	return false
}

// SetErrorUiUrl gets a reference to the given string and assigns it to the ErrorUiUrl field.
func (o *ProjectRevision) SetErrorUiUrl(v string) {
	o.ErrorUiUrl = &v
}

// GetHosts returns the Hosts field value
func (o *ProjectRevision) GetHosts() []string {
	if o == nil {
		var ret []string
		return ret
	}

	return o.Hosts
}

// GetHostsOk returns a tuple with the Hosts field value
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetHostsOk() ([]string, bool) {
	if o == nil  {
		return nil, false
	}
	return o.Hosts, true
}

// SetHosts sets field value
func (o *ProjectRevision) SetHosts(v []string) {
	o.Hosts = v
}

// GetId returns the Id field value
func (o *ProjectRevision) GetId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Id
}

// GetIdOk returns a tuple with the Id field value
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetIdOk() (*string, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.Id, true
}

// SetId sets field value
func (o *ProjectRevision) SetId(v string) {
	o.Id = v
}

// GetKratosConfigVersion returns the KratosConfigVersion field value if set, zero value otherwise.
func (o *ProjectRevision) GetKratosConfigVersion() string {
	if o == nil || o.KratosConfigVersion == nil {
		var ret string
		return ret
	}
	return *o.KratosConfigVersion
}

// GetKratosConfigVersionOk returns a tuple with the KratosConfigVersion field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetKratosConfigVersionOk() (*string, bool) {
	if o == nil || o.KratosConfigVersion == nil {
		return nil, false
	}
	return o.KratosConfigVersion, true
}

// HasKratosConfigVersion returns a boolean if a field has been set.
func (o *ProjectRevision) HasKratosConfigVersion() bool {
	if o != nil && o.KratosConfigVersion != nil {
		return true
	}

	return false
}

// SetKratosConfigVersion gets a reference to the given string and assigns it to the KratosConfigVersion field.
func (o *ProjectRevision) SetKratosConfigVersion(v string) {
	o.KratosConfigVersion = &v
}

// GetKratosCustomSchemaId returns the KratosCustomSchemaId field value if set, zero value otherwise.
func (o *ProjectRevision) GetKratosCustomSchemaId() NullUUID {
	if o == nil || o.KratosCustomSchemaId == nil {
		var ret NullUUID
		return ret
	}
	return *o.KratosCustomSchemaId
}

// GetKratosCustomSchemaIdOk returns a tuple with the KratosCustomSchemaId field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetKratosCustomSchemaIdOk() (*NullUUID, bool) {
	if o == nil || o.KratosCustomSchemaId == nil {
		return nil, false
	}
	return o.KratosCustomSchemaId, true
}

// HasKratosCustomSchemaId returns a boolean if a field has been set.
func (o *ProjectRevision) HasKratosCustomSchemaId() bool {
	if o != nil && o.KratosCustomSchemaId != nil {
		return true
	}

	return false
}

// SetKratosCustomSchemaId gets a reference to the given NullUUID and assigns it to the KratosCustomSchemaId field.
func (o *ProjectRevision) SetKratosCustomSchemaId(v NullUUID) {
	o.KratosCustomSchemaId = &v
}

// GetLoginUiUrl returns the LoginUiUrl field value if set, zero value otherwise.
func (o *ProjectRevision) GetLoginUiUrl() string {
	if o == nil || o.LoginUiUrl == nil {
		var ret string
		return ret
	}
	return *o.LoginUiUrl
}

// GetLoginUiUrlOk returns a tuple with the LoginUiUrl field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetLoginUiUrlOk() (*string, bool) {
	if o == nil || o.LoginUiUrl == nil {
		return nil, false
	}
	return o.LoginUiUrl, true
}

// HasLoginUiUrl returns a boolean if a field has been set.
func (o *ProjectRevision) HasLoginUiUrl() bool {
	if o != nil && o.LoginUiUrl != nil {
		return true
	}

	return false
}

// SetLoginUiUrl gets a reference to the given string and assigns it to the LoginUiUrl field.
func (o *ProjectRevision) SetLoginUiUrl(v string) {
	o.LoginUiUrl = &v
}

// GetLookupSecret returns the LookupSecret field value if set, zero value otherwise.
func (o *ProjectRevision) GetLookupSecret() ProjectLookupSecretConfig {
	if o == nil || o.LookupSecret == nil {
		var ret ProjectLookupSecretConfig
		return ret
	}
	return *o.LookupSecret
}

// GetLookupSecretOk returns a tuple with the LookupSecret field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetLookupSecretOk() (*ProjectLookupSecretConfig, bool) {
	if o == nil || o.LookupSecret == nil {
		return nil, false
	}
	return o.LookupSecret, true
}

// HasLookupSecret returns a boolean if a field has been set.
func (o *ProjectRevision) HasLookupSecret() bool {
	if o != nil && o.LookupSecret != nil {
		return true
	}

	return false
}

// SetLookupSecret gets a reference to the given ProjectLookupSecretConfig and assigns it to the LookupSecret field.
func (o *ProjectRevision) SetLookupSecret(v ProjectLookupSecretConfig) {
	o.LookupSecret = &v
}

// GetName returns the Name field value
func (o *ProjectRevision) GetName() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Name
}

// GetNameOk returns a tuple with the Name field value
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetNameOk() (*string, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.Name, true
}

// SetName sets field value
func (o *ProjectRevision) SetName(v string) {
	o.Name = v
}

// GetOidcProviders returns the OidcProviders field value if set, zero value otherwise.
func (o *ProjectRevision) GetOidcProviders() []ProjectOidcConfig {
	if o == nil || o.OidcProviders == nil {
		var ret []ProjectOidcConfig
		return ret
	}
	return o.OidcProviders
}

// GetOidcProvidersOk returns a tuple with the OidcProviders field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetOidcProvidersOk() ([]ProjectOidcConfig, bool) {
	if o == nil || o.OidcProviders == nil {
		return nil, false
	}
	return o.OidcProviders, true
}

// HasOidcProviders returns a boolean if a field has been set.
func (o *ProjectRevision) HasOidcProviders() bool {
	if o != nil && o.OidcProviders != nil {
		return true
	}

	return false
}

// SetOidcProviders gets a reference to the given []ProjectOidcConfig and assigns it to the OidcProviders field.
func (o *ProjectRevision) SetOidcProviders(v []ProjectOidcConfig) {
	o.OidcProviders = v
}

// GetPassword returns the Password field value if set, zero value otherwise.
func (o *ProjectRevision) GetPassword() ProjectPasswordConfig {
	if o == nil || o.Password == nil {
		var ret ProjectPasswordConfig
		return ret
	}
	return *o.Password
}

// GetPasswordOk returns a tuple with the Password field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetPasswordOk() (*ProjectPasswordConfig, bool) {
	if o == nil || o.Password == nil {
		return nil, false
	}
	return o.Password, true
}

// HasPassword returns a boolean if a field has been set.
func (o *ProjectRevision) HasPassword() bool {
	if o != nil && o.Password != nil {
		return true
	}

	return false
}

// SetPassword gets a reference to the given ProjectPasswordConfig and assigns it to the Password field.
func (o *ProjectRevision) SetPassword(v ProjectPasswordConfig) {
	o.Password = &v
}

// GetProjectId returns the ProjectId field value
func (o *ProjectRevision) GetProjectId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.ProjectId
}

// GetProjectIdOk returns a tuple with the ProjectId field value
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetProjectIdOk() (*string, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.ProjectId, true
}

// SetProjectId sets field value
func (o *ProjectRevision) SetProjectId(v string) {
	o.ProjectId = v
}

// GetRecovery returns the Recovery field value if set, zero value otherwise.
func (o *ProjectRevision) GetRecovery() ProjectRecoveryConfig {
	if o == nil || o.Recovery == nil {
		var ret ProjectRecoveryConfig
		return ret
	}
	return *o.Recovery
}

// GetRecoveryOk returns a tuple with the Recovery field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetRecoveryOk() (*ProjectRecoveryConfig, bool) {
	if o == nil || o.Recovery == nil {
		return nil, false
	}
	return o.Recovery, true
}

// HasRecovery returns a boolean if a field has been set.
func (o *ProjectRevision) HasRecovery() bool {
	if o != nil && o.Recovery != nil {
		return true
	}

	return false
}

// SetRecovery gets a reference to the given ProjectRecoveryConfig and assigns it to the Recovery field.
func (o *ProjectRevision) SetRecovery(v ProjectRecoveryConfig) {
	o.Recovery = &v
}

// GetRecoveryUiUrl returns the RecoveryUiUrl field value if set, zero value otherwise.
func (o *ProjectRevision) GetRecoveryUiUrl() string {
	if o == nil || o.RecoveryUiUrl == nil {
		var ret string
		return ret
	}
	return *o.RecoveryUiUrl
}

// GetRecoveryUiUrlOk returns a tuple with the RecoveryUiUrl field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetRecoveryUiUrlOk() (*string, bool) {
	if o == nil || o.RecoveryUiUrl == nil {
		return nil, false
	}
	return o.RecoveryUiUrl, true
}

// HasRecoveryUiUrl returns a boolean if a field has been set.
func (o *ProjectRevision) HasRecoveryUiUrl() bool {
	if o != nil && o.RecoveryUiUrl != nil {
		return true
	}

	return false
}

// SetRecoveryUiUrl gets a reference to the given string and assigns it to the RecoveryUiUrl field.
func (o *ProjectRevision) SetRecoveryUiUrl(v string) {
	o.RecoveryUiUrl = &v
}

// GetRedirectionConfig returns the RedirectionConfig field value if set, zero value otherwise.
func (o *ProjectRevision) GetRedirectionConfig() RedirectionConfig {
	if o == nil || o.RedirectionConfig == nil {
		var ret RedirectionConfig
		return ret
	}
	return *o.RedirectionConfig
}

// GetRedirectionConfigOk returns a tuple with the RedirectionConfig field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetRedirectionConfigOk() (*RedirectionConfig, bool) {
	if o == nil || o.RedirectionConfig == nil {
		return nil, false
	}
	return o.RedirectionConfig, true
}

// HasRedirectionConfig returns a boolean if a field has been set.
func (o *ProjectRevision) HasRedirectionConfig() bool {
	if o != nil && o.RedirectionConfig != nil {
		return true
	}

	return false
}

// SetRedirectionConfig gets a reference to the given RedirectionConfig and assigns it to the RedirectionConfig field.
func (o *ProjectRevision) SetRedirectionConfig(v RedirectionConfig) {
	o.RedirectionConfig = &v
}

// GetRegistrationUiUrl returns the RegistrationUiUrl field value if set, zero value otherwise.
func (o *ProjectRevision) GetRegistrationUiUrl() string {
	if o == nil || o.RegistrationUiUrl == nil {
		var ret string
		return ret
	}
	return *o.RegistrationUiUrl
}

// GetRegistrationUiUrlOk returns a tuple with the RegistrationUiUrl field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetRegistrationUiUrlOk() (*string, bool) {
	if o == nil || o.RegistrationUiUrl == nil {
		return nil, false
	}
	return o.RegistrationUiUrl, true
}

// HasRegistrationUiUrl returns a boolean if a field has been set.
func (o *ProjectRevision) HasRegistrationUiUrl() bool {
	if o != nil && o.RegistrationUiUrl != nil {
		return true
	}

	return false
}

// SetRegistrationUiUrl gets a reference to the given string and assigns it to the RegistrationUiUrl field.
func (o *ProjectRevision) SetRegistrationUiUrl(v string) {
	o.RegistrationUiUrl = &v
}

// GetSessionAfterSignUp returns the SessionAfterSignUp field value
func (o *ProjectRevision) GetSessionAfterSignUp() bool {
	if o == nil {
		var ret bool
		return ret
	}

	return o.SessionAfterSignUp
}

// GetSessionAfterSignUpOk returns a tuple with the SessionAfterSignUp field value
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetSessionAfterSignUpOk() (*bool, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.SessionAfterSignUp, true
}

// SetSessionAfterSignUp sets field value
func (o *ProjectRevision) SetSessionAfterSignUp(v bool) {
	o.SessionAfterSignUp = v
}

// GetSessionSoft2fa returns the SessionSoft2fa field value if set, zero value otherwise.
func (o *ProjectRevision) GetSessionSoft2fa() bool {
	if o == nil || o.SessionSoft2fa == nil {
		var ret bool
		return ret
	}
	return *o.SessionSoft2fa
}

// GetSessionSoft2faOk returns a tuple with the SessionSoft2fa field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetSessionSoft2faOk() (*bool, bool) {
	if o == nil || o.SessionSoft2fa == nil {
		return nil, false
	}
	return o.SessionSoft2fa, true
}

// HasSessionSoft2fa returns a boolean if a field has been set.
func (o *ProjectRevision) HasSessionSoft2fa() bool {
	if o != nil && o.SessionSoft2fa != nil {
		return true
	}

	return false
}

// SetSessionSoft2fa gets a reference to the given bool and assigns it to the SessionSoft2fa field.
func (o *ProjectRevision) SetSessionSoft2fa(v bool) {
	o.SessionSoft2fa = &v
}

// GetSettingsPrivilegedSessionMaxAgeSeconds returns the SettingsPrivilegedSessionMaxAgeSeconds field value if set, zero value otherwise.
func (o *ProjectRevision) GetSettingsPrivilegedSessionMaxAgeSeconds() int64 {
	if o == nil || o.SettingsPrivilegedSessionMaxAgeSeconds == nil {
		var ret int64
		return ret
	}
	return *o.SettingsPrivilegedSessionMaxAgeSeconds
}

// GetSettingsPrivilegedSessionMaxAgeSecondsOk returns a tuple with the SettingsPrivilegedSessionMaxAgeSeconds field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetSettingsPrivilegedSessionMaxAgeSecondsOk() (*int64, bool) {
	if o == nil || o.SettingsPrivilegedSessionMaxAgeSeconds == nil {
		return nil, false
	}
	return o.SettingsPrivilegedSessionMaxAgeSeconds, true
}

// HasSettingsPrivilegedSessionMaxAgeSeconds returns a boolean if a field has been set.
func (o *ProjectRevision) HasSettingsPrivilegedSessionMaxAgeSeconds() bool {
	if o != nil && o.SettingsPrivilegedSessionMaxAgeSeconds != nil {
		return true
	}

	return false
}

// SetSettingsPrivilegedSessionMaxAgeSeconds gets a reference to the given int64 and assigns it to the SettingsPrivilegedSessionMaxAgeSeconds field.
func (o *ProjectRevision) SetSettingsPrivilegedSessionMaxAgeSeconds(v int64) {
	o.SettingsPrivilegedSessionMaxAgeSeconds = &v
}

// GetSettingsSoft2fa returns the SettingsSoft2fa field value if set, zero value otherwise.
func (o *ProjectRevision) GetSettingsSoft2fa() bool {
	if o == nil || o.SettingsSoft2fa == nil {
		var ret bool
		return ret
	}
	return *o.SettingsSoft2fa
}

// GetSettingsSoft2faOk returns a tuple with the SettingsSoft2fa field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetSettingsSoft2faOk() (*bool, bool) {
	if o == nil || o.SettingsSoft2fa == nil {
		return nil, false
	}
	return o.SettingsSoft2fa, true
}

// HasSettingsSoft2fa returns a boolean if a field has been set.
func (o *ProjectRevision) HasSettingsSoft2fa() bool {
	if o != nil && o.SettingsSoft2fa != nil {
		return true
	}

	return false
}

// SetSettingsSoft2fa gets a reference to the given bool and assigns it to the SettingsSoft2fa field.
func (o *ProjectRevision) SetSettingsSoft2fa(v bool) {
	o.SettingsSoft2fa = &v
}

// GetSettingsUiUrl returns the SettingsUiUrl field value if set, zero value otherwise.
func (o *ProjectRevision) GetSettingsUiUrl() string {
	if o == nil || o.SettingsUiUrl == nil {
		var ret string
		return ret
	}
	return *o.SettingsUiUrl
}

// GetSettingsUiUrlOk returns a tuple with the SettingsUiUrl field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetSettingsUiUrlOk() (*string, bool) {
	if o == nil || o.SettingsUiUrl == nil {
		return nil, false
	}
	return o.SettingsUiUrl, true
}

// HasSettingsUiUrl returns a boolean if a field has been set.
func (o *ProjectRevision) HasSettingsUiUrl() bool {
	if o != nil && o.SettingsUiUrl != nil {
		return true
	}

	return false
}

// SetSettingsUiUrl gets a reference to the given string and assigns it to the SettingsUiUrl field.
func (o *ProjectRevision) SetSettingsUiUrl(v string) {
	o.SettingsUiUrl = &v
}

// GetTotp returns the Totp field value if set, zero value otherwise.
func (o *ProjectRevision) GetTotp() ProjectTotpConfig {
	if o == nil || o.Totp == nil {
		var ret ProjectTotpConfig
		return ret
	}
	return *o.Totp
}

// GetTotpOk returns a tuple with the Totp field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetTotpOk() (*ProjectTotpConfig, bool) {
	if o == nil || o.Totp == nil {
		return nil, false
	}
	return o.Totp, true
}

// HasTotp returns a boolean if a field has been set.
func (o *ProjectRevision) HasTotp() bool {
	if o != nil && o.Totp != nil {
		return true
	}

	return false
}

// SetTotp gets a reference to the given ProjectTotpConfig and assigns it to the Totp field.
func (o *ProjectRevision) SetTotp(v ProjectTotpConfig) {
	o.Totp = &v
}

// GetUpdatedAt returns the UpdatedAt field value
func (o *ProjectRevision) GetUpdatedAt() time.Time {
	if o == nil {
		var ret time.Time
		return ret
	}

	return o.UpdatedAt
}

// GetUpdatedAtOk returns a tuple with the UpdatedAt field value
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetUpdatedAtOk() (*time.Time, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.UpdatedAt, true
}

// SetUpdatedAt sets field value
func (o *ProjectRevision) SetUpdatedAt(v time.Time) {
	o.UpdatedAt = v
}

// GetVerification returns the Verification field value if set, zero value otherwise.
func (o *ProjectRevision) GetVerification() ProjectVerificationConfig {
	if o == nil || o.Verification == nil {
		var ret ProjectVerificationConfig
		return ret
	}
	return *o.Verification
}

// GetVerificationOk returns a tuple with the Verification field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetVerificationOk() (*ProjectVerificationConfig, bool) {
	if o == nil || o.Verification == nil {
		return nil, false
	}
	return o.Verification, true
}

// HasVerification returns a boolean if a field has been set.
func (o *ProjectRevision) HasVerification() bool {
	if o != nil && o.Verification != nil {
		return true
	}

	return false
}

// SetVerification gets a reference to the given ProjectVerificationConfig and assigns it to the Verification field.
func (o *ProjectRevision) SetVerification(v ProjectVerificationConfig) {
	o.Verification = &v
}

// GetVerificationUiUrl returns the VerificationUiUrl field value if set, zero value otherwise.
func (o *ProjectRevision) GetVerificationUiUrl() string {
	if o == nil || o.VerificationUiUrl == nil {
		var ret string
		return ret
	}
	return *o.VerificationUiUrl
}

// GetVerificationUiUrlOk returns a tuple with the VerificationUiUrl field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetVerificationUiUrlOk() (*string, bool) {
	if o == nil || o.VerificationUiUrl == nil {
		return nil, false
	}
	return o.VerificationUiUrl, true
}

// HasVerificationUiUrl returns a boolean if a field has been set.
func (o *ProjectRevision) HasVerificationUiUrl() bool {
	if o != nil && o.VerificationUiUrl != nil {
		return true
	}

	return false
}

// SetVerificationUiUrl gets a reference to the given string and assigns it to the VerificationUiUrl field.
func (o *ProjectRevision) SetVerificationUiUrl(v string) {
	o.VerificationUiUrl = &v
}

// GetWebauthn returns the Webauthn field value if set, zero value otherwise.
func (o *ProjectRevision) GetWebauthn() ProjectWebAuthnConfig {
	if o == nil || o.Webauthn == nil {
		var ret ProjectWebAuthnConfig
		return ret
	}
	return *o.Webauthn
}

// GetWebauthnOk returns a tuple with the Webauthn field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ProjectRevision) GetWebauthnOk() (*ProjectWebAuthnConfig, bool) {
	if o == nil || o.Webauthn == nil {
		return nil, false
	}
	return o.Webauthn, true
}

// HasWebauthn returns a boolean if a field has been set.
func (o *ProjectRevision) HasWebauthn() bool {
	if o != nil && o.Webauthn != nil {
		return true
	}

	return false
}

// SetWebauthn gets a reference to the given ProjectWebAuthnConfig and assigns it to the Webauthn field.
func (o *ProjectRevision) SetWebauthn(v ProjectWebAuthnConfig) {
	o.Webauthn = &v
}

func (o ProjectRevision) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if true {
		toSerialize["api_url"] = o.ApiUrl
	}
	if true {
		toSerialize["application_url"] = o.ApplicationUrl
	}
	if true {
		toSerialize["created_at"] = o.CreatedAt
	}
	if true {
		toSerialize["default_identity_schema_url"] = o.DefaultIdentitySchemaUrl
	}
	if o.ErrorUiUrl != nil {
		toSerialize["error_ui_url"] = o.ErrorUiUrl
	}
	if true {
		toSerialize["hosts"] = o.Hosts
	}
	if true {
		toSerialize["id"] = o.Id
	}
	if o.KratosConfigVersion != nil {
		toSerialize["kratos_config_version"] = o.KratosConfigVersion
	}
	if o.KratosCustomSchemaId != nil {
		toSerialize["kratos_custom_schema_id"] = o.KratosCustomSchemaId
	}
	if o.LoginUiUrl != nil {
		toSerialize["login_ui_url"] = o.LoginUiUrl
	}
	if o.LookupSecret != nil {
		toSerialize["lookup_secret"] = o.LookupSecret
	}
	if true {
		toSerialize["name"] = o.Name
	}
	if o.OidcProviders != nil {
		toSerialize["oidc_providers"] = o.OidcProviders
	}
	if o.Password != nil {
		toSerialize["password"] = o.Password
	}
	if true {
		toSerialize["project_id"] = o.ProjectId
	}
	if o.Recovery != nil {
		toSerialize["recovery"] = o.Recovery
	}
	if o.RecoveryUiUrl != nil {
		toSerialize["recovery_ui_url"] = o.RecoveryUiUrl
	}
	if o.RedirectionConfig != nil {
		toSerialize["redirection_config"] = o.RedirectionConfig
	}
	if o.RegistrationUiUrl != nil {
		toSerialize["registration_ui_url"] = o.RegistrationUiUrl
	}
	if true {
		toSerialize["session_after_sign_up"] = o.SessionAfterSignUp
	}
	if o.SessionSoft2fa != nil {
		toSerialize["session_soft_2fa"] = o.SessionSoft2fa
	}
	if o.SettingsPrivilegedSessionMaxAgeSeconds != nil {
		toSerialize["settings_privileged_session_max_age_seconds"] = o.SettingsPrivilegedSessionMaxAgeSeconds
	}
	if o.SettingsSoft2fa != nil {
		toSerialize["settings_soft_2fa"] = o.SettingsSoft2fa
	}
	if o.SettingsUiUrl != nil {
		toSerialize["settings_ui_url"] = o.SettingsUiUrl
	}
	if o.Totp != nil {
		toSerialize["totp"] = o.Totp
	}
	if true {
		toSerialize["updated_at"] = o.UpdatedAt
	}
	if o.Verification != nil {
		toSerialize["verification"] = o.Verification
	}
	if o.VerificationUiUrl != nil {
		toSerialize["verification_ui_url"] = o.VerificationUiUrl
	}
	if o.Webauthn != nil {
		toSerialize["webauthn"] = o.Webauthn
	}
	return json.Marshal(toSerialize)
}

type NullableProjectRevision struct {
	value *ProjectRevision
	isSet bool
}

func (v NullableProjectRevision) Get() *ProjectRevision {
	return v.value
}

func (v *NullableProjectRevision) Set(val *ProjectRevision) {
	v.value = val
	v.isSet = true
}

func (v NullableProjectRevision) IsSet() bool {
	return v.isSet
}

func (v *NullableProjectRevision) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableProjectRevision(val *ProjectRevision) *NullableProjectRevision {
	return &NullableProjectRevision{value: val, isSet: true}
}

func (v NullableProjectRevision) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableProjectRevision) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


