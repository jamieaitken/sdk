# ory_client
Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed
with a valid Personal Access Token. Public APIs are mostly used in browsers.


This Dart package is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v0.2.0-alpha.48
- Build package: org.openapitools.codegen.languages.DartClientCodegen

## Requirements

Dart 2.12 or later

## Installation & Usage

### Github
If this Dart package is published to Github, add the following dependency to your pubspec.yaml
```
dependencies:
  ory_client:
    git: https://github.com/ory/sdk.git
```

### Local
To use the package in your local drive, add the following dependency to your pubspec.yaml
```
dependencies:
  ory_client:
    path: /path/to/ory_client
```

## Tests

TODO

## Getting Started

Please follow the [installation procedure](#installation--usage) and then run the following:

```dart
import 'package:ory_client/api.dart';


final api_instance = AdminApi();
final consentChallenge = consentChallenge_example; // String | 
final acceptConsentRequest = AcceptConsentRequest(); // AcceptConsentRequest | 

try {
    final result = api_instance.acceptConsentRequest(consentChallenge, acceptConsentRequest);
    print(result);
} catch (e) {
    print('Exception when calling AdminApi->acceptConsentRequest: $e\n');
}

```

## Documentation for API Endpoints

All URIs are relative to *https://playground.projects.oryapis.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AdminApi* | [**acceptConsentRequest**](doc//AdminApi.md#acceptconsentrequest) | **PUT** /oauth2/auth/requests/consent/accept | Accept a Consent Request
*AdminApi* | [**acceptLoginRequest**](doc//AdminApi.md#acceptloginrequest) | **PUT** /oauth2/auth/requests/login/accept | Accept a Login Request
*AdminApi* | [**acceptLogoutRequest**](doc//AdminApi.md#acceptlogoutrequest) | **PUT** /oauth2/auth/requests/logout/accept | Accept a Logout Request
*AdminApi* | [**createJsonWebKeySet**](doc//AdminApi.md#createjsonwebkeyset) | **POST** /keys/{set} | Generate a New JSON Web Key
*AdminApi* | [**createOAuth2Client**](doc//AdminApi.md#createoauth2client) | **POST** /clients | Create an OAuth 2.0 Client
*AdminApi* | [**deleteJsonWebKey**](doc//AdminApi.md#deletejsonwebkey) | **DELETE** /keys/{set}/{kid} | Delete a JSON Web Key
*AdminApi* | [**deleteJsonWebKeySet**](doc//AdminApi.md#deletejsonwebkeyset) | **DELETE** /keys/{set} | Delete a JSON Web Key Set
*AdminApi* | [**deleteOAuth2Client**](doc//AdminApi.md#deleteoauth2client) | **DELETE** /clients/{id} | Deletes an OAuth 2.0 Client
*AdminApi* | [**deleteOAuth2Token**](doc//AdminApi.md#deleteoauth2token) | **DELETE** /oauth2/tokens | Delete OAuth2 Access Tokens from a Client
*AdminApi* | [**deleteTrustedJwtGrantIssuer**](doc//AdminApi.md#deletetrustedjwtgrantissuer) | **DELETE** /trust/grants/jwt-bearer/issuers/{id} | Delete a Trusted OAuth2 JWT Bearer Grant Type Issuer
*AdminApi* | [**flushInactiveOAuth2Tokens**](doc//AdminApi.md#flushinactiveoauth2tokens) | **POST** /oauth2/flush | Flush Expired OAuth2 Access Tokens
*AdminApi* | [**getConsentRequest**](doc//AdminApi.md#getconsentrequest) | **GET** /oauth2/auth/requests/consent | Get Consent Request Information
*AdminApi* | [**getJsonWebKey**](doc//AdminApi.md#getjsonwebkey) | **GET** /keys/{set}/{kid} | Fetch a JSON Web Key
*AdminApi* | [**getJsonWebKeySet**](doc//AdminApi.md#getjsonwebkeyset) | **GET** /keys/{set} | Retrieve a JSON Web Key Set
*AdminApi* | [**getLoginRequest**](doc//AdminApi.md#getloginrequest) | **GET** /oauth2/auth/requests/login | Get a Login Request
*AdminApi* | [**getLogoutRequest**](doc//AdminApi.md#getlogoutrequest) | **GET** /oauth2/auth/requests/logout | Get a Logout Request
*AdminApi* | [**getOAuth2Client**](doc//AdminApi.md#getoauth2client) | **GET** /clients/{id} | Get an OAuth 2.0 Client
*AdminApi* | [**getTrustedJwtGrantIssuer**](doc//AdminApi.md#gettrustedjwtgrantissuer) | **GET** /trust/grants/jwt-bearer/issuers/{id} | Get a Trusted OAuth2 JWT Bearer Grant Type Issuer
*AdminApi* | [**introspectOAuth2Token**](doc//AdminApi.md#introspectoauth2token) | **POST** /oauth2/introspect | Introspect OAuth2 Tokens
*AdminApi* | [**listOAuth2Clients**](doc//AdminApi.md#listoauth2clients) | **GET** /clients | List OAuth 2.0 Clients
*AdminApi* | [**listSubjectConsentSessions**](doc//AdminApi.md#listsubjectconsentsessions) | **GET** /oauth2/auth/sessions/consent | Lists All Consent Sessions of a Subject
*AdminApi* | [**listTrustedJwtGrantIssuers**](doc//AdminApi.md#listtrustedjwtgrantissuers) | **GET** /trust/grants/jwt-bearer/issuers | List Trusted OAuth2 JWT Bearer Grant Type Issuers
*AdminApi* | [**patchOAuth2Client**](doc//AdminApi.md#patchoauth2client) | **PATCH** /clients/{id} | Patch an OAuth 2.0 Client
*AdminApi* | [**rejectConsentRequest**](doc//AdminApi.md#rejectconsentrequest) | **PUT** /oauth2/auth/requests/consent/reject | Reject a Consent Request
*AdminApi* | [**rejectLoginRequest**](doc//AdminApi.md#rejectloginrequest) | **PUT** /oauth2/auth/requests/login/reject | Reject a Login Request
*AdminApi* | [**rejectLogoutRequest**](doc//AdminApi.md#rejectlogoutrequest) | **PUT** /oauth2/auth/requests/logout/reject | Reject a Logout Request
*AdminApi* | [**revokeAuthenticationSession**](doc//AdminApi.md#revokeauthenticationsession) | **DELETE** /oauth2/auth/sessions/login | Invalidates All Login Sessions of a Certain User Invalidates a Subject's Authentication Session
*AdminApi* | [**revokeConsentSessions**](doc//AdminApi.md#revokeconsentsessions) | **DELETE** /oauth2/auth/sessions/consent | Revokes Consent Sessions of a Subject for a Specific OAuth 2.0 Client
*AdminApi* | [**trustJwtGrantIssuer**](doc//AdminApi.md#trustjwtgrantissuer) | **POST** /trust/grants/jwt-bearer/issuers | Trust an OAuth2 JWT Bearer Grant Type Issuer
*AdminApi* | [**updateJsonWebKey**](doc//AdminApi.md#updatejsonwebkey) | **PUT** /keys/{set}/{kid} | Update a JSON Web Key
*AdminApi* | [**updateJsonWebKeySet**](doc//AdminApi.md#updatejsonwebkeyset) | **PUT** /keys/{set} | Update a JSON Web Key Set
*AdminApi* | [**updateOAuth2Client**](doc//AdminApi.md#updateoauth2client) | **PUT** /clients/{id} | Update an OAuth 2.0 Client
*MetadataApi* | [**getVersion**](doc//MetadataApi.md#getversion) | **GET** /version | Return Running Software Version.
*MetadataApi* | [**isAlive**](doc//MetadataApi.md#isalive) | **GET** /health/alive | Check HTTP Server Status
*MetadataApi* | [**isReady**](doc//MetadataApi.md#isready) | **GET** /health/ready | Check HTTP Server and Database Status
*PublicApi* | [**disconnectUser**](doc//PublicApi.md#disconnectuser) | **GET** /oauth2/sessions/logout | OpenID Connect Front-Backchannel Enabled Logout
*PublicApi* | [**discoverOpenIDConfiguration**](doc//PublicApi.md#discoveropenidconfiguration) | **GET** /.well-known/openid-configuration | OpenID Connect Discovery
*PublicApi* | [**dynamicClientRegistrationCreateOAuth2Client**](doc//PublicApi.md#dynamicclientregistrationcreateoauth2client) | **POST** /connect/register | Register an OAuth 2.0 Client using the OpenID / OAuth2 Dynamic Client Registration Management Protocol
*PublicApi* | [**dynamicClientRegistrationDeleteOAuth2Client**](doc//PublicApi.md#dynamicclientregistrationdeleteoauth2client) | **DELETE** /connect/register/{id} | Deletes an OAuth 2.0 Client using the OpenID / OAuth2 Dynamic Client Registration Management Protocol
*PublicApi* | [**dynamicClientRegistrationGetOAuth2Client**](doc//PublicApi.md#dynamicclientregistrationgetoauth2client) | **GET** /connect/register/{id} | Get an OAuth 2.0 Client using the OpenID / OAuth2 Dynamic Client Registration Management Protocol
*PublicApi* | [**dynamicClientRegistrationUpdateOAuth2Client**](doc//PublicApi.md#dynamicclientregistrationupdateoauth2client) | **PUT** /connect/register/{id} | Update an OAuth 2.0 Client using the OpenID / OAuth2 Dynamic Client Registration Management Protocol
*PublicApi* | [**oauth2Token**](doc//PublicApi.md#oauth2token) | **POST** /oauth2/token | The OAuth 2.0 Token Endpoint
*PublicApi* | [**oauthAuth**](doc//PublicApi.md#oauthauth) | **GET** /oauth2/auth | The OAuth 2.0 Authorize Endpoint
*PublicApi* | [**revokeOAuth2Token**](doc//PublicApi.md#revokeoauth2token) | **POST** /oauth2/revoke | Revoke OAuth2 Tokens
*PublicApi* | [**userinfo**](doc//PublicApi.md#userinfo) | **GET** /userinfo | OpenID Connect Userinfo
*PublicApi* | [**wellKnown**](doc//PublicApi.md#wellknown) | **GET** /.well-known/jwks.json | JSON Web Keys Discovery
*ReadApi* | [**getCheck**](doc//ReadApi.md#getcheck) | **GET** /relation-tuples/check/openapi | # Check a relation tuple
*ReadApi* | [**getCheckMirrorStatus**](doc//ReadApi.md#getcheckmirrorstatus) | **GET** /relation-tuples/check | # Check a relation tuple
*ReadApi* | [**getExpand**](doc//ReadApi.md#getexpand) | **GET** /relation-tuples/expand | # Expand a Relation Tuple
*ReadApi* | [**getRelationTuples**](doc//ReadApi.md#getrelationtuples) | **GET** /relation-tuples | # Query relation tuples
*ReadApi* | [**postCheck**](doc//ReadApi.md#postcheck) | **POST** /relation-tuples/check/openapi | # Check a relation tuple
*ReadApi* | [**postCheckMirrorStatus**](doc//ReadApi.md#postcheckmirrorstatus) | **POST** /relation-tuples/check | # Check a relation tuple
*V0alpha2Api* | [**adminCreateIdentity**](doc//V0alpha2Api.md#admincreateidentity) | **POST** /admin/identities | Create an Identity
*V0alpha2Api* | [**adminCreateSelfServiceRecoveryLink**](doc//V0alpha2Api.md#admincreateselfservicerecoverylink) | **POST** /admin/recovery/link | Create a Recovery Link
*V0alpha2Api* | [**adminDeleteIdentity**](doc//V0alpha2Api.md#admindeleteidentity) | **DELETE** /admin/identities/{id} | Delete an Identity
*V0alpha2Api* | [**adminDeleteIdentitySessions**](doc//V0alpha2Api.md#admindeleteidentitysessions) | **DELETE** /admin/identities/{id}/sessions | Calling this endpoint irrecoverably and permanently deletes and invalidates all sessions that belong to the given Identity.
*V0alpha2Api* | [**adminExtendSession**](doc//V0alpha2Api.md#adminextendsession) | **PATCH** /admin/sessions/{id}/extend | Calling this endpoint extends the given session ID. If `session.earliest_possible_extend` is set it will only extend the session after the specified time has passed.
*V0alpha2Api* | [**adminGetIdentity**](doc//V0alpha2Api.md#admingetidentity) | **GET** /admin/identities/{id} | Get an Identity
*V0alpha2Api* | [**adminListIdentities**](doc//V0alpha2Api.md#adminlistidentities) | **GET** /admin/identities | List Identities
*V0alpha2Api* | [**adminListIdentitySessions**](doc//V0alpha2Api.md#adminlistidentitysessions) | **GET** /admin/identities/{id}/sessions | This endpoint returns all sessions that belong to the given Identity.
*V0alpha2Api* | [**adminPatchIdentity**](doc//V0alpha2Api.md#adminpatchidentity) | **PATCH** /admin/identities/{id} | Partially updates an Identity's field using [JSON Patch](https://jsonpatch.com/)
*V0alpha2Api* | [**adminUpdateIdentity**](doc//V0alpha2Api.md#adminupdateidentity) | **PUT** /admin/identities/{id} | Update an Identity
*V0alpha2Api* | [**createProject**](doc//V0alpha2Api.md#createproject) | **POST** /projects | # Create a Project
*V0alpha2Api* | [**createProjectApiKey**](doc//V0alpha2Api.md#createprojectapikey) | **POST** /projects/{project}/tokens | # Create API Token
*V0alpha2Api* | [**createSelfServiceLogoutFlowUrlForBrowsers**](doc//V0alpha2Api.md#createselfservicelogoutflowurlforbrowsers) | **GET** /self-service/logout/browser | Create a Logout URL for Browsers
*V0alpha2Api* | [**deleteProjectApiKey**](doc//V0alpha2Api.md#deleteprojectapikey) | **DELETE** /projects/{project}/tokens/{token_id} | # Delete API Token
*V0alpha2Api* | [**getIdentitySchema**](doc//V0alpha2Api.md#getidentityschema) | **GET** /schemas/{id} | 
*V0alpha2Api* | [**getProject**](doc//V0alpha2Api.md#getproject) | **GET** /projects/{project_id} | # Get a Project
*V0alpha2Api* | [**getProjectMembers**](doc//V0alpha2Api.md#getprojectmembers) | **GET** /projects/{project_id}/members | Get all members associated with this project.
*V0alpha2Api* | [**getSelfServiceError**](doc//V0alpha2Api.md#getselfserviceerror) | **GET** /self-service/errors | Get Self-Service Errors
*V0alpha2Api* | [**getSelfServiceLoginFlow**](doc//V0alpha2Api.md#getselfserviceloginflow) | **GET** /self-service/login/flows | Get Login Flow
*V0alpha2Api* | [**getSelfServiceRecoveryFlow**](doc//V0alpha2Api.md#getselfservicerecoveryflow) | **GET** /self-service/recovery/flows | Get Recovery Flow
*V0alpha2Api* | [**getSelfServiceRegistrationFlow**](doc//V0alpha2Api.md#getselfserviceregistrationflow) | **GET** /self-service/registration/flows | Get Registration Flow
*V0alpha2Api* | [**getSelfServiceSettingsFlow**](doc//V0alpha2Api.md#getselfservicesettingsflow) | **GET** /self-service/settings/flows | Get Settings Flow
*V0alpha2Api* | [**getSelfServiceVerificationFlow**](doc//V0alpha2Api.md#getselfserviceverificationflow) | **GET** /self-service/verification/flows | # Get Verification Flow
*V0alpha2Api* | [**getWebAuthnJavaScript**](doc//V0alpha2Api.md#getwebauthnjavascript) | **GET** /.well-known/ory/webauthn.js | Get WebAuthn JavaScript
*V0alpha2Api* | [**initializeSelfServiceLoginFlowForBrowsers**](doc//V0alpha2Api.md#initializeselfserviceloginflowforbrowsers) | **GET** /self-service/login/browser | Initialize Login Flow for Browsers
*V0alpha2Api* | [**initializeSelfServiceLoginFlowWithoutBrowser**](doc//V0alpha2Api.md#initializeselfserviceloginflowwithoutbrowser) | **GET** /self-service/login/api | Initialize Login Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initializeSelfServiceRecoveryFlowForBrowsers**](doc//V0alpha2Api.md#initializeselfservicerecoveryflowforbrowsers) | **GET** /self-service/recovery/browser | Initialize Recovery Flow for Browsers
*V0alpha2Api* | [**initializeSelfServiceRecoveryFlowWithoutBrowser**](doc//V0alpha2Api.md#initializeselfservicerecoveryflowwithoutbrowser) | **GET** /self-service/recovery/api | Initialize Recovery Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initializeSelfServiceRegistrationFlowForBrowsers**](doc//V0alpha2Api.md#initializeselfserviceregistrationflowforbrowsers) | **GET** /self-service/registration/browser | Initialize Registration Flow for Browsers
*V0alpha2Api* | [**initializeSelfServiceRegistrationFlowWithoutBrowser**](doc//V0alpha2Api.md#initializeselfserviceregistrationflowwithoutbrowser) | **GET** /self-service/registration/api | Initialize Registration Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initializeSelfServiceSettingsFlowForBrowsers**](doc//V0alpha2Api.md#initializeselfservicesettingsflowforbrowsers) | **GET** /self-service/settings/browser | Initialize Settings Flow for Browsers
*V0alpha2Api* | [**initializeSelfServiceSettingsFlowWithoutBrowser**](doc//V0alpha2Api.md#initializeselfservicesettingsflowwithoutbrowser) | **GET** /self-service/settings/api | Initialize Settings Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**initializeSelfServiceVerificationFlowForBrowsers**](doc//V0alpha2Api.md#initializeselfserviceverificationflowforbrowsers) | **GET** /self-service/verification/browser | Initialize Verification Flow for Browser Clients
*V0alpha2Api* | [**initializeSelfServiceVerificationFlowWithoutBrowser**](doc//V0alpha2Api.md#initializeselfserviceverificationflowwithoutbrowser) | **GET** /self-service/verification/api | Initialize Verification Flow for APIs, Services, Apps, ...
*V0alpha2Api* | [**listIdentitySchemas**](doc//V0alpha2Api.md#listidentityschemas) | **GET** /schemas | 
*V0alpha2Api* | [**listProjectApiKeys**](doc//V0alpha2Api.md#listprojectapikeys) | **GET** /projects/{project}/tokens | # List a Project's API Tokens
*V0alpha2Api* | [**listProjects**](doc//V0alpha2Api.md#listprojects) | **GET** /projects | # List All Projects
*V0alpha2Api* | [**listSessions**](doc//V0alpha2Api.md#listsessions) | **GET** /sessions | This endpoints returns all other active sessions that belong to the logged-in user. The current session can be retrieved by calling the `/sessions/whoami` endpoint.
*V0alpha2Api* | [**patchProject**](doc//V0alpha2Api.md#patchproject) | **PATCH** /projects/{project_id} | Patch an Ory Cloud Project Configuration`
*V0alpha2Api* | [**purgeProject**](doc//V0alpha2Api.md#purgeproject) | **DELETE** /projects/{project_id} | # Irrecoverably Purge a Project
*V0alpha2Api* | [**removeProjectMember**](doc//V0alpha2Api.md#removeprojectmember) | **DELETE** /projects/{project_id}/members/{member_id} | Remove a member associated with this project. This also sets their invite status to `REMOVED`.
*V0alpha2Api* | [**revokeSession**](doc//V0alpha2Api.md#revokesession) | **DELETE** /sessions/{id} | Calling this endpoint invalidates the specified session. The current session cannot be revoked. Session data are not deleted.
*V0alpha2Api* | [**revokeSessions**](doc//V0alpha2Api.md#revokesessions) | **DELETE** /sessions | Calling this endpoint invalidates all except the current session that belong to the logged-in user. Session data are not deleted.
*V0alpha2Api* | [**submitSelfServiceLoginFlow**](doc//V0alpha2Api.md#submitselfserviceloginflow) | **POST** /self-service/login | Submit a Login Flow
*V0alpha2Api* | [**submitSelfServiceLogoutFlow**](doc//V0alpha2Api.md#submitselfservicelogoutflow) | **GET** /self-service/logout | Complete Self-Service Logout
*V0alpha2Api* | [**submitSelfServiceLogoutFlowWithoutBrowser**](doc//V0alpha2Api.md#submitselfservicelogoutflowwithoutbrowser) | **DELETE** /self-service/logout/api | Perform Logout for APIs, Services, Apps, ...
*V0alpha2Api* | [**submitSelfServiceRecoveryFlow**](doc//V0alpha2Api.md#submitselfservicerecoveryflow) | **POST** /self-service/recovery | Complete Recovery Flow
*V0alpha2Api* | [**submitSelfServiceRegistrationFlow**](doc//V0alpha2Api.md#submitselfserviceregistrationflow) | **POST** /self-service/registration | Submit a Registration Flow
*V0alpha2Api* | [**submitSelfServiceSettingsFlow**](doc//V0alpha2Api.md#submitselfservicesettingsflow) | **POST** /self-service/settings | Complete Settings Flow
*V0alpha2Api* | [**submitSelfServiceVerificationFlow**](doc//V0alpha2Api.md#submitselfserviceverificationflow) | **POST** /self-service/verification | # Complete Verification Flow
*V0alpha2Api* | [**toSession**](doc//V0alpha2Api.md#tosession) | **GET** /sessions/whoami | Check Who the Current HTTP Session Belongs To
*V0alpha2Api* | [**updateProject**](doc//V0alpha2Api.md#updateproject) | **PUT** /projects/{project_id} | # Update an Ory Cloud Project Configuration
*WriteApi* | [**createRelationTuple**](doc//WriteApi.md#createrelationtuple) | **PUT** /admin/relation-tuples | # Create a Relation Tuple
*WriteApi* | [**deleteRelationTuples**](doc//WriteApi.md#deleterelationtuples) | **DELETE** /admin/relation-tuples | # Delete Relation Tuples
*WriteApi* | [**patchRelationTuples**](doc//WriteApi.md#patchrelationtuples) | **PATCH** /admin/relation-tuples | # Patch Multiple Relation Tuples


## Documentation For Models

 - [AcceptConsentRequest](doc//AcceptConsentRequest.md)
 - [AcceptLoginRequest](doc//AcceptLoginRequest.md)
 - [ActiveProject](doc//ActiveProject.md)
 - [AdminCreateIdentityBody](doc//AdminCreateIdentityBody.md)
 - [AdminCreateIdentityImportCredentialsOidc](doc//AdminCreateIdentityImportCredentialsOidc.md)
 - [AdminCreateIdentityImportCredentialsOidcConfig](doc//AdminCreateIdentityImportCredentialsOidcConfig.md)
 - [AdminCreateIdentityImportCredentialsOidcProvider](doc//AdminCreateIdentityImportCredentialsOidcProvider.md)
 - [AdminCreateIdentityImportCredentialsPassword](doc//AdminCreateIdentityImportCredentialsPassword.md)
 - [AdminCreateIdentityImportCredentialsPasswordConfig](doc//AdminCreateIdentityImportCredentialsPasswordConfig.md)
 - [AdminCreateSelfServiceRecoveryLinkBody](doc//AdminCreateSelfServiceRecoveryLinkBody.md)
 - [AdminIdentityImportCredentials](doc//AdminIdentityImportCredentials.md)
 - [AdminUpdateIdentityBody](doc//AdminUpdateIdentityBody.md)
 - [AuthenticatorAssuranceLevel](doc//AuthenticatorAssuranceLevel.md)
 - [CloudAccount](doc//CloudAccount.md)
 - [CnameSettings](doc//CnameSettings.md)
 - [CompletedRequest](doc//CompletedRequest.md)
 - [ConsentRequest](doc//ConsentRequest.md)
 - [ConsentRequestSession](doc//ConsentRequestSession.md)
 - [CreateCustomHostnameBody](doc//CreateCustomHostnameBody.md)
 - [CreateProjectApiKeyRequest](doc//CreateProjectApiKeyRequest.md)
 - [CreateProjectBody](doc//CreateProjectBody.md)
 - [CreateSubscriptionPayload](doc//CreateSubscriptionPayload.md)
 - [ErrorAuthenticatorAssuranceLevelNotSatisfied](doc//ErrorAuthenticatorAssuranceLevelNotSatisfied.md)
 - [ExpandTree](doc//ExpandTree.md)
 - [FlushInactiveOAuth2TokensRequest](doc//FlushInactiveOAuth2TokensRequest.md)
 - [FlushLoginConsentRequest](doc//FlushLoginConsentRequest.md)
 - [GenericError](doc//GenericError.md)
 - [GenericErrorContent](doc//GenericErrorContent.md)
 - [GetCheckResponse](doc//GetCheckResponse.md)
 - [GetManagedIdentitySchemaLocation](doc//GetManagedIdentitySchemaLocation.md)
 - [GetRelationTuplesResponse](doc//GetRelationTuplesResponse.md)
 - [GetVersion200Response](doc//GetVersion200Response.md)
 - [HealthNotReadyStatus](doc//HealthNotReadyStatus.md)
 - [HealthStatus](doc//HealthStatus.md)
 - [Identity](doc//Identity.md)
 - [IdentityCredentials](doc//IdentityCredentials.md)
 - [IdentityCredentialsOidc](doc//IdentityCredentialsOidc.md)
 - [IdentityCredentialsOidcProvider](doc//IdentityCredentialsOidcProvider.md)
 - [IdentityCredentialsPassword](doc//IdentityCredentialsPassword.md)
 - [IdentityCredentialsType](doc//IdentityCredentialsType.md)
 - [IdentitySchemaContainer](doc//IdentitySchemaContainer.md)
 - [IdentitySchemaPreset](doc//IdentitySchemaPreset.md)
 - [IdentityState](doc//IdentityState.md)
 - [InvitePayload](doc//InvitePayload.md)
 - [IsOwnerForProjectBySlug](doc//IsOwnerForProjectBySlug.md)
 - [IsOwnerForProjectBySlugPayload](doc//IsOwnerForProjectBySlugPayload.md)
 - [IsReady200Response](doc//IsReady200Response.md)
 - [IsReady503Response](doc//IsReady503Response.md)
 - [JSONWebKey](doc//JSONWebKey.md)
 - [JSONWebKeySet](doc//JSONWebKeySet.md)
 - [JsonError](doc//JsonError.md)
 - [JsonPatch](doc//JsonPatch.md)
 - [JsonWebKeySetGeneratorRequest](doc//JsonWebKeySetGeneratorRequest.md)
 - [KetoNamespace](doc//KetoNamespace.md)
 - [LoginRequest](doc//LoginRequest.md)
 - [LogoutRequest](doc//LogoutRequest.md)
 - [ManagedIdentitySchema](doc//ManagedIdentitySchema.md)
 - [ManagedIdentitySchemaValidationResult](doc//ManagedIdentitySchemaValidationResult.md)
 - [NeedsPrivilegedSessionError](doc//NeedsPrivilegedSessionError.md)
 - [NormalizedProject](doc//NormalizedProject.md)
 - [NormalizedProjectRevision](doc//NormalizedProjectRevision.md)
 - [NormalizedProjectRevisionHook](doc//NormalizedProjectRevisionHook.md)
 - [NormalizedProjectRevisionIdentitySchema](doc//NormalizedProjectRevisionIdentitySchema.md)
 - [NormalizedProjectRevisionThirdPartyProvider](doc//NormalizedProjectRevisionThirdPartyProvider.md)
 - [NullPlan](doc//NullPlan.md)
 - [OAuth2Client](doc//OAuth2Client.md)
 - [OAuth2TokenIntrospection](doc//OAuth2TokenIntrospection.md)
 - [Oauth2TokenResponse](doc//Oauth2TokenResponse.md)
 - [OauthTokenResponse](doc//OauthTokenResponse.md)
 - [OpenIDConnectContext](doc//OpenIDConnectContext.md)
 - [Pagination](doc//Pagination.md)
 - [PatchDelta](doc//PatchDelta.md)
 - [PatchDocument](doc//PatchDocument.md)
 - [PreviousConsentSession](doc//PreviousConsentSession.md)
 - [Project](doc//Project.md)
 - [ProjectApiKey](doc//ProjectApiKey.md)
 - [ProjectHost](doc//ProjectHost.md)
 - [ProjectInvite](doc//ProjectInvite.md)
 - [ProjectMetadata](doc//ProjectMetadata.md)
 - [ProjectServiceIdentity](doc//ProjectServiceIdentity.md)
 - [ProjectServiceOAuth2](doc//ProjectServiceOAuth2.md)
 - [ProjectServicePermission](doc//ProjectServicePermission.md)
 - [ProjectServices](doc//ProjectServices.md)
 - [ProvisionMockSubscriptionPayload](doc//ProvisionMockSubscriptionPayload.md)
 - [QuotaCustomDomains](doc//QuotaCustomDomains.md)
 - [QuotaProjectMemberSeats](doc//QuotaProjectMemberSeats.md)
 - [RecoveryAddress](doc//RecoveryAddress.md)
 - [RefreshTokenHookRequest](doc//RefreshTokenHookRequest.md)
 - [RefreshTokenHookResponse](doc//RefreshTokenHookResponse.md)
 - [RejectRequest](doc//RejectRequest.md)
 - [RelationQuery](doc//RelationQuery.md)
 - [RelationTuple](doc//RelationTuple.md)
 - [RequestWasHandledResponse](doc//RequestWasHandledResponse.md)
 - [RevokedSessions](doc//RevokedSessions.md)
 - [SchemaPatch](doc//SchemaPatch.md)
 - [SelfServiceBrowserLocationChangeRequiredError](doc//SelfServiceBrowserLocationChangeRequiredError.md)
 - [SelfServiceError](doc//SelfServiceError.md)
 - [SelfServiceFlowExpiredError](doc//SelfServiceFlowExpiredError.md)
 - [SelfServiceLoginFlow](doc//SelfServiceLoginFlow.md)
 - [SelfServiceLogoutUrl](doc//SelfServiceLogoutUrl.md)
 - [SelfServiceRecoveryFlow](doc//SelfServiceRecoveryFlow.md)
 - [SelfServiceRecoveryFlowState](doc//SelfServiceRecoveryFlowState.md)
 - [SelfServiceRecoveryLink](doc//SelfServiceRecoveryLink.md)
 - [SelfServiceRegistrationFlow](doc//SelfServiceRegistrationFlow.md)
 - [SelfServiceSettingsFlow](doc//SelfServiceSettingsFlow.md)
 - [SelfServiceSettingsFlowState](doc//SelfServiceSettingsFlowState.md)
 - [SelfServiceVerificationFlow](doc//SelfServiceVerificationFlow.md)
 - [SelfServiceVerificationFlowState](doc//SelfServiceVerificationFlowState.md)
 - [Session](doc//Session.md)
 - [SessionAuthenticationMethod](doc//SessionAuthenticationMethod.md)
 - [SessionDevice](doc//SessionDevice.md)
 - [SettingsProfileFormConfig](doc//SettingsProfileFormConfig.md)
 - [StripeCustomerResponse](doc//StripeCustomerResponse.md)
 - [SubjectSet](doc//SubjectSet.md)
 - [SubmitSelfServiceFlowWithWebAuthnRegistrationMethod](doc//SubmitSelfServiceFlowWithWebAuthnRegistrationMethod.md)
 - [SubmitSelfServiceLoginFlowBody](doc//SubmitSelfServiceLoginFlowBody.md)
 - [SubmitSelfServiceLoginFlowWithLookupSecretMethodBody](doc//SubmitSelfServiceLoginFlowWithLookupSecretMethodBody.md)
 - [SubmitSelfServiceLoginFlowWithOidcMethodBody](doc//SubmitSelfServiceLoginFlowWithOidcMethodBody.md)
 - [SubmitSelfServiceLoginFlowWithPasswordMethodBody](doc//SubmitSelfServiceLoginFlowWithPasswordMethodBody.md)
 - [SubmitSelfServiceLoginFlowWithTotpMethodBody](doc//SubmitSelfServiceLoginFlowWithTotpMethodBody.md)
 - [SubmitSelfServiceLoginFlowWithWebAuthnMethodBody](doc//SubmitSelfServiceLoginFlowWithWebAuthnMethodBody.md)
 - [SubmitSelfServiceLogoutFlowWithoutBrowserBody](doc//SubmitSelfServiceLogoutFlowWithoutBrowserBody.md)
 - [SubmitSelfServiceRecoveryFlowBody](doc//SubmitSelfServiceRecoveryFlowBody.md)
 - [SubmitSelfServiceRecoveryFlowWithLinkMethodBody](doc//SubmitSelfServiceRecoveryFlowWithLinkMethodBody.md)
 - [SubmitSelfServiceRegistrationFlowBody](doc//SubmitSelfServiceRegistrationFlowBody.md)
 - [SubmitSelfServiceRegistrationFlowWithOidcMethodBody](doc//SubmitSelfServiceRegistrationFlowWithOidcMethodBody.md)
 - [SubmitSelfServiceRegistrationFlowWithPasswordMethodBody](doc//SubmitSelfServiceRegistrationFlowWithPasswordMethodBody.md)
 - [SubmitSelfServiceRegistrationFlowWithWebAuthnMethodBody](doc//SubmitSelfServiceRegistrationFlowWithWebAuthnMethodBody.md)
 - [SubmitSelfServiceSettingsFlowBody](doc//SubmitSelfServiceSettingsFlowBody.md)
 - [SubmitSelfServiceSettingsFlowWithLookupMethodBody](doc//SubmitSelfServiceSettingsFlowWithLookupMethodBody.md)
 - [SubmitSelfServiceSettingsFlowWithOidcMethodBody](doc//SubmitSelfServiceSettingsFlowWithOidcMethodBody.md)
 - [SubmitSelfServiceSettingsFlowWithPasswordMethodBody](doc//SubmitSelfServiceSettingsFlowWithPasswordMethodBody.md)
 - [SubmitSelfServiceSettingsFlowWithProfileMethodBody](doc//SubmitSelfServiceSettingsFlowWithProfileMethodBody.md)
 - [SubmitSelfServiceSettingsFlowWithTotpMethodBody](doc//SubmitSelfServiceSettingsFlowWithTotpMethodBody.md)
 - [SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody](doc//SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody.md)
 - [SubmitSelfServiceVerificationFlowBody](doc//SubmitSelfServiceVerificationFlowBody.md)
 - [SubmitSelfServiceVerificationFlowWithLinkMethodBody](doc//SubmitSelfServiceVerificationFlowWithLinkMethodBody.md)
 - [Subscription](doc//Subscription.md)
 - [SuccessfulProjectUpdate](doc//SuccessfulProjectUpdate.md)
 - [SuccessfulSelfServiceLoginWithoutBrowser](doc//SuccessfulSelfServiceLoginWithoutBrowser.md)
 - [SuccessfulSelfServiceRegistrationWithoutBrowser](doc//SuccessfulSelfServiceRegistrationWithoutBrowser.md)
 - [TokenPagination](doc//TokenPagination.md)
 - [TokenPaginationHeaders](doc//TokenPaginationHeaders.md)
 - [TrustJwtGrantIssuerBody](doc//TrustJwtGrantIssuerBody.md)
 - [TrustedJsonWebKey](doc//TrustedJsonWebKey.md)
 - [TrustedJwtGrantIssuer](doc//TrustedJwtGrantIssuer.md)
 - [UiContainer](doc//UiContainer.md)
 - [UiNode](doc//UiNode.md)
 - [UiNodeAnchorAttributes](doc//UiNodeAnchorAttributes.md)
 - [UiNodeAttributes](doc//UiNodeAttributes.md)
 - [UiNodeImageAttributes](doc//UiNodeImageAttributes.md)
 - [UiNodeInputAttributes](doc//UiNodeInputAttributes.md)
 - [UiNodeMeta](doc//UiNodeMeta.md)
 - [UiNodeScriptAttributes](doc//UiNodeScriptAttributes.md)
 - [UiNodeTextAttributes](doc//UiNodeTextAttributes.md)
 - [UiText](doc//UiText.md)
 - [UpdateCustomHostnameBody](doc//UpdateCustomHostnameBody.md)
 - [UpdateProject](doc//UpdateProject.md)
 - [UpdateSubscriptionPayload](doc//UpdateSubscriptionPayload.md)
 - [UserinfoResponse](doc//UserinfoResponse.md)
 - [VerifiableIdentityAddress](doc//VerifiableIdentityAddress.md)
 - [Version](doc//Version.md)
 - [Warning](doc//Warning.md)
 - [WellKnown](doc//WellKnown.md)


## Documentation For Authorization


## basic

- **Type**: HTTP Basic authentication

## oauth2

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: https://hydra.demo.ory.sh/oauth2/auth
- **Scopes**: 
 - **offline**: A scope required when requesting refresh tokens (alias for `offline_access`)
 - **offline_access**: A scope required when requesting refresh tokens
 - **openid**: Request an OpenID Connect ID Token

## oryAccessToken

- **Type**: HTTP Bearer authentication


## Author

support@ory.sh

