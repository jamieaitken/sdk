/**
 * ORY Keto
 * A cloud native access control server providing best-practice patterns (RBAC, ABAC, ACL, AWS IAM Policies, Kubernetes Roles, ...) via REST APIs.
 *
 * The version of the OpenAPI document: v0.0.0-alpha.37
 * Contact: hi@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


/**
* RemoveOryAccessControlPolicyRoleMembers remove ory access control policy role members
*/
export class RemoveOryAccessControlPolicyRoleMembers {
    /**
    * The ORY Access Control Policy flavor. Can be \"regex\", \"glob\", and \"exact\".  in: path
    */
    'flavor': string;
    /**
    * The ID of the ORY Access Control Policy Role.  in: path
    */
    'id': string;
    /**
    * The member to be removed.  in: path
    */
    'member': string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "flavor",
            "baseName": "flavor",
            "type": "string"
        },
        {
            "name": "id",
            "baseName": "id",
            "type": "string"
        },
        {
            "name": "member",
            "baseName": "member",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return RemoveOryAccessControlPolicyRoleMembers.attributeTypeMap;
    }
}
