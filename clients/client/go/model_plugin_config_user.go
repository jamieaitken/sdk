/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * API version: v0.0.1-alpha.17
 * Contact: support@ory.sh
 */

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// PluginConfigUser PluginConfigUser plugin config user
type PluginConfigUser struct {
	// g ID
	GID *int32 `json:"GID,omitempty"`
	// UID
	UID *int32 `json:"UID,omitempty"`
}

// NewPluginConfigUser instantiates a new PluginConfigUser object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewPluginConfigUser() *PluginConfigUser {
	this := PluginConfigUser{}
	return &this
}

// NewPluginConfigUserWithDefaults instantiates a new PluginConfigUser object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewPluginConfigUserWithDefaults() *PluginConfigUser {
	this := PluginConfigUser{}
	return &this
}

// GetGID returns the GID field value if set, zero value otherwise.
func (o *PluginConfigUser) GetGID() int32 {
	if o == nil || o.GID == nil {
		var ret int32
		return ret
	}
	return *o.GID
}

// GetGIDOk returns a tuple with the GID field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *PluginConfigUser) GetGIDOk() (*int32, bool) {
	if o == nil || o.GID == nil {
		return nil, false
	}
	return o.GID, true
}

// HasGID returns a boolean if a field has been set.
func (o *PluginConfigUser) HasGID() bool {
	if o != nil && o.GID != nil {
		return true
	}

	return false
}

// SetGID gets a reference to the given int32 and assigns it to the GID field.
func (o *PluginConfigUser) SetGID(v int32) {
	o.GID = &v
}

// GetUID returns the UID field value if set, zero value otherwise.
func (o *PluginConfigUser) GetUID() int32 {
	if o == nil || o.UID == nil {
		var ret int32
		return ret
	}
	return *o.UID
}

// GetUIDOk returns a tuple with the UID field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *PluginConfigUser) GetUIDOk() (*int32, bool) {
	if o == nil || o.UID == nil {
		return nil, false
	}
	return o.UID, true
}

// HasUID returns a boolean if a field has been set.
func (o *PluginConfigUser) HasUID() bool {
	if o != nil && o.UID != nil {
		return true
	}

	return false
}

// SetUID gets a reference to the given int32 and assigns it to the UID field.
func (o *PluginConfigUser) SetUID(v int32) {
	o.UID = &v
}

func (o PluginConfigUser) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.GID != nil {
		toSerialize["GID"] = o.GID
	}
	if o.UID != nil {
		toSerialize["UID"] = o.UID
	}
	return json.Marshal(toSerialize)
}

type NullablePluginConfigUser struct {
	value *PluginConfigUser
	isSet bool
}

func (v NullablePluginConfigUser) Get() *PluginConfigUser {
	return v.value
}

func (v *NullablePluginConfigUser) Set(val *PluginConfigUser) {
	v.value = val
	v.isSet = true
}

func (v NullablePluginConfigUser) IsSet() bool {
	return v.isSet
}

func (v *NullablePluginConfigUser) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullablePluginConfigUser(val *PluginConfigUser) *NullablePluginConfigUser {
	return &NullablePluginConfigUser{value: val, isSet: true}
}

func (v NullablePluginConfigUser) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullablePluginConfigUser) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


