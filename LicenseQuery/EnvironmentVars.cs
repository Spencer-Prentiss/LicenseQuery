namespace LicenseQuery
{
    public static class EnvironmentVars
    {
        public const string DOMAIN_EMAIL = "domain_name.com";
        public const string DOMAIN_CONTROLLER = "enter.valid.domain.controller.com";
        public const string DOMAIN_USERS_OU_ROOT = "LDAP://" + DOMAIN_CONTROLLER + "/OU=User Accounts,DC=Valid,DC=Domain,DC=Account,DC=com";
    }
}
