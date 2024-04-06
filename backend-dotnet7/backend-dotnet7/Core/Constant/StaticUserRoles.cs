﻿namespace backend_dotnet7.Core.Constant
{
    //this class will be used to avoid typing Errors
    public static class StaticUserRoles
    {

        public const string OWNER = "OWNER";
        public const string ADMIN = "ADMIN";

        public const string MANAGER = "MANAGER";

        public const string USER = "USER";


        public const string OwnerAdmin = "OWNER,ADMIN";
        public const string OwnerAdminManager = "OWNER,ADMIN,MANAGER";
        public const string OwnerAdminManagerUser = "OWNER,ADMIN,MANAGER,User";



    }
}
