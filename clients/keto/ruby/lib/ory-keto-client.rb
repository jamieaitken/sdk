=begin
#ORY Keto

#A cloud native access control server providing best-practice patterns (RBAC, ABAC, ACL, AWS IAM Policies, Kubernetes Roles, ...) via REST APIs.

The version of the OpenAPI document: v0.0.0-alpha.37
Contact: hi@ory.sh
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.2.2

=end

# Common files
require 'ory-keto-client/api_client'
require 'ory-keto-client/api_error'
require 'ory-keto-client/version'
require 'ory-keto-client/configuration'

# Models
require 'ory-keto-client/models/add_ory_access_control_policy_role_members'
require 'ory-keto-client/models/add_ory_access_control_policy_role_members_body'
require 'ory-keto-client/models/add_ory_access_control_policy_role_members_internal_server_error'
require 'ory-keto-client/models/add_ory_access_control_policy_role_members_internal_server_error_body'
require 'ory-keto-client/models/add_ory_access_control_policy_role_members_ok'
require 'ory-keto-client/models/authorization_result'
require 'ory-keto-client/models/delete_ory_access_control_policy'
require 'ory-keto-client/models/delete_ory_access_control_policy_internal_server_error'
require 'ory-keto-client/models/delete_ory_access_control_policy_internal_server_error_body'
require 'ory-keto-client/models/delete_ory_access_control_policy_role'
require 'ory-keto-client/models/delete_ory_access_control_policy_role_internal_server_error'
require 'ory-keto-client/models/delete_ory_access_control_policy_role_internal_server_error_body'
require 'ory-keto-client/models/do_ory_access_control_policies_allow'
require 'ory-keto-client/models/do_ory_access_control_policies_allow_forbidden'
require 'ory-keto-client/models/do_ory_access_control_policies_allow_internal_server_error'
require 'ory-keto-client/models/do_ory_access_control_policies_allow_internal_server_error_body'
require 'ory-keto-client/models/do_ory_access_control_policies_allow_ok'
require 'ory-keto-client/models/get_ory_access_control_policy'
require 'ory-keto-client/models/get_ory_access_control_policy_internal_server_error'
require 'ory-keto-client/models/get_ory_access_control_policy_internal_server_error_body'
require 'ory-keto-client/models/get_ory_access_control_policy_not_found'
require 'ory-keto-client/models/get_ory_access_control_policy_not_found_body'
require 'ory-keto-client/models/get_ory_access_control_policy_ok'
require 'ory-keto-client/models/get_ory_access_control_policy_role'
require 'ory-keto-client/models/get_ory_access_control_policy_role_internal_server_error'
require 'ory-keto-client/models/get_ory_access_control_policy_role_internal_server_error_body'
require 'ory-keto-client/models/get_ory_access_control_policy_role_not_found'
require 'ory-keto-client/models/get_ory_access_control_policy_role_not_found_body'
require 'ory-keto-client/models/get_ory_access_control_policy_role_ok'
require 'ory-keto-client/models/health_not_ready_status'
require 'ory-keto-client/models/health_status'
require 'ory-keto-client/models/inline_response500'
require 'ory-keto-client/models/input'
require 'ory-keto-client/models/is_instance_alive_internal_server_error'
require 'ory-keto-client/models/is_instance_alive_internal_server_error_body'
require 'ory-keto-client/models/is_instance_alive_ok'
require 'ory-keto-client/models/list_ory_access_control_policies'
require 'ory-keto-client/models/list_ory_access_control_policies_internal_server_error'
require 'ory-keto-client/models/list_ory_access_control_policies_internal_server_error_body'
require 'ory-keto-client/models/list_ory_access_control_policies_ok'
require 'ory-keto-client/models/list_ory_access_control_policy_roles'
require 'ory-keto-client/models/list_ory_access_control_policy_roles_internal_server_error'
require 'ory-keto-client/models/list_ory_access_control_policy_roles_internal_server_error_body'
require 'ory-keto-client/models/list_ory_access_control_policy_roles_ok'
require 'ory-keto-client/models/ory_access_control_policies'
require 'ory-keto-client/models/ory_access_control_policy'
require 'ory-keto-client/models/ory_access_control_policy_allowed_input'
require 'ory-keto-client/models/ory_access_control_policy_role'
require 'ory-keto-client/models/ory_access_control_policy_roles'
require 'ory-keto-client/models/policy'
require 'ory-keto-client/models/remove_ory_access_control_policy_role_members'
require 'ory-keto-client/models/remove_ory_access_control_policy_role_members_internal_server_error'
require 'ory-keto-client/models/remove_ory_access_control_policy_role_members_internal_server_error_body'
require 'ory-keto-client/models/role'
require 'ory-keto-client/models/swagger_health_status'
require 'ory-keto-client/models/swagger_not_ready_status'
require 'ory-keto-client/models/swagger_version'
require 'ory-keto-client/models/upsert_ory_access_control_policy'
require 'ory-keto-client/models/upsert_ory_access_control_policy_internal_server_error'
require 'ory-keto-client/models/upsert_ory_access_control_policy_internal_server_error_body'
require 'ory-keto-client/models/upsert_ory_access_control_policy_ok'
require 'ory-keto-client/models/upsert_ory_access_control_policy_role'
require 'ory-keto-client/models/upsert_ory_access_control_policy_role_internal_server_error'
require 'ory-keto-client/models/upsert_ory_access_control_policy_role_internal_server_error_body'
require 'ory-keto-client/models/upsert_ory_access_control_policy_role_ok'
require 'ory-keto-client/models/version'

# APIs
require 'ory-keto-client/api/engines_api'
require 'ory-keto-client/api/health_api'
require 'ory-keto-client/api/version_api'

module OryHydraClient
  class << self
    # Customize default settings for the SDK using block.
    #   OryHydraClient.configure do |config|
    #     config.username = "xxx"
    #     config.password = "xxx"
    #   end
    # If no block given, return the default Configuration object.
    def configure
      if block_given?
        yield(Configuration.default)
      else
        Configuration.default
      end
    end
  end
end