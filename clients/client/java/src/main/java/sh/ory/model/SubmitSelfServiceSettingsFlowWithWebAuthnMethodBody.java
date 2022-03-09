/*
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.119
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-03-09T11:03:50.782367219Z[Etc/UTC]")
public class SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody {
  public static final String SERIALIZED_NAME_CSRF_TOKEN = "csrf_token";
  @SerializedName(SERIALIZED_NAME_CSRF_TOKEN)
  private String csrfToken;

  public static final String SERIALIZED_NAME_METHOD = "method";
  @SerializedName(SERIALIZED_NAME_METHOD)
  private String method;

  public static final String SERIALIZED_NAME_WEBAUTHN_REGISTER = "webauthn_register";
  @SerializedName(SERIALIZED_NAME_WEBAUTHN_REGISTER)
  private String webauthnRegister;

  public static final String SERIALIZED_NAME_WEBAUTHN_REGISTER_DISPLAYNAME = "webauthn_register_displayname";
  @SerializedName(SERIALIZED_NAME_WEBAUTHN_REGISTER_DISPLAYNAME)
  private String webauthnRegisterDisplayname;

  public static final String SERIALIZED_NAME_WEBAUTHN_REMOVE = "webauthn_remove";
  @SerializedName(SERIALIZED_NAME_WEBAUTHN_REMOVE)
  private String webauthnRemove;

  public SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody() { 
  }

  public SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody csrfToken(String csrfToken) {
    
    this.csrfToken = csrfToken;
    return this;
  }

   /**
   * CSRFToken is the anti-CSRF token
   * @return csrfToken
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "CSRFToken is the anti-CSRF token")

  public String getCsrfToken() {
    return csrfToken;
  }


  public void setCsrfToken(String csrfToken) {
    this.csrfToken = csrfToken;
  }


  public SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody method(String method) {
    
    this.method = method;
    return this;
  }

   /**
   * Method  Should be set to \&quot;webauthn\&quot; when trying to add, update, or remove a webAuthn pairing.
   * @return method
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Method  Should be set to \"webauthn\" when trying to add, update, or remove a webAuthn pairing.")

  public String getMethod() {
    return method;
  }


  public void setMethod(String method) {
    this.method = method;
  }


  public SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody webauthnRegister(String webauthnRegister) {
    
    this.webauthnRegister = webauthnRegister;
    return this;
  }

   /**
   * Register a WebAuthn Security Key  It is expected that the JSON returned by the WebAuthn registration process is included here.
   * @return webauthnRegister
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Register a WebAuthn Security Key  It is expected that the JSON returned by the WebAuthn registration process is included here.")

  public String getWebauthnRegister() {
    return webauthnRegister;
  }


  public void setWebauthnRegister(String webauthnRegister) {
    this.webauthnRegister = webauthnRegister;
  }


  public SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody webauthnRegisterDisplayname(String webauthnRegisterDisplayname) {
    
    this.webauthnRegisterDisplayname = webauthnRegisterDisplayname;
    return this;
  }

   /**
   * Name of the WebAuthn Security Key to be Added  A human-readable name for the security key which will be added.
   * @return webauthnRegisterDisplayname
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Name of the WebAuthn Security Key to be Added  A human-readable name for the security key which will be added.")

  public String getWebauthnRegisterDisplayname() {
    return webauthnRegisterDisplayname;
  }


  public void setWebauthnRegisterDisplayname(String webauthnRegisterDisplayname) {
    this.webauthnRegisterDisplayname = webauthnRegisterDisplayname;
  }


  public SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody webauthnRemove(String webauthnRemove) {
    
    this.webauthnRemove = webauthnRemove;
    return this;
  }

   /**
   * Remove a WebAuthn Security Key  This must contain the ID of the WebAuthN connection.
   * @return webauthnRemove
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Remove a WebAuthn Security Key  This must contain the ID of the WebAuthN connection.")

  public String getWebauthnRemove() {
    return webauthnRemove;
  }


  public void setWebauthnRemove(String webauthnRemove) {
    this.webauthnRemove = webauthnRemove;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody submitSelfServiceSettingsFlowWithWebAuthnMethodBody = (SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody) o;
    return Objects.equals(this.csrfToken, submitSelfServiceSettingsFlowWithWebAuthnMethodBody.csrfToken) &&
        Objects.equals(this.method, submitSelfServiceSettingsFlowWithWebAuthnMethodBody.method) &&
        Objects.equals(this.webauthnRegister, submitSelfServiceSettingsFlowWithWebAuthnMethodBody.webauthnRegister) &&
        Objects.equals(this.webauthnRegisterDisplayname, submitSelfServiceSettingsFlowWithWebAuthnMethodBody.webauthnRegisterDisplayname) &&
        Objects.equals(this.webauthnRemove, submitSelfServiceSettingsFlowWithWebAuthnMethodBody.webauthnRemove);
  }

  @Override
  public int hashCode() {
    return Objects.hash(csrfToken, method, webauthnRegister, webauthnRegisterDisplayname, webauthnRemove);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody {\n");
    sb.append("    csrfToken: ").append(toIndentedString(csrfToken)).append("\n");
    sb.append("    method: ").append(toIndentedString(method)).append("\n");
    sb.append("    webauthnRegister: ").append(toIndentedString(webauthnRegister)).append("\n");
    sb.append("    webauthnRegisterDisplayname: ").append(toIndentedString(webauthnRegisterDisplayname)).append("\n");
    sb.append("    webauthnRemove: ").append(toIndentedString(webauthnRemove)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

