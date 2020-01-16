# coding: utf-8

"""
    Ory Kratos

    Welcome to the ORY Kratos HTTP API documentation!  # noqa: E501

    The version of the OpenAPI document: v0.0.0-alpha.1
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import unittest

import ory_kratos_client
from ory_kratos_client.api.public_api import PublicApi  # noqa: E501
from ory_kratos_client.rest import ApiException


class TestPublicApi(unittest.TestCase):
    """PublicApi unit test stubs"""

    def setUp(self):
        self.api = ory_kratos_client.api.public_api.PublicApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_complete_profile_management_flow(self):
        """Test case for complete_profile_management_flow

        Complete Profile Management Flow  # noqa: E501
        """
        pass

    def test_get_login_request(self):
        """Test case for get_login_request

        Get Login Request  # noqa: E501
        """
        pass

    def test_get_profile_management_request(self):
        """Test case for get_profile_management_request

        Get Profile Management Request (via cookie)  # noqa: E501
        """
        pass

    def test_get_registration_request(self):
        """Test case for get_registration_request

        Get Registration Request  # noqa: E501
        """
        pass

    def test_initialize_login_flow(self):
        """Test case for initialize_login_flow

        Initialize a Login Flow  # noqa: E501
        """
        pass

    def test_initialize_profile_management_flow(self):
        """Test case for initialize_profile_management_flow

        Initialize Profile Management Flow  # noqa: E501
        """
        pass

    def test_initialize_registration_flow(self):
        """Test case for initialize_registration_flow

        Initialize a Registration Flow  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()