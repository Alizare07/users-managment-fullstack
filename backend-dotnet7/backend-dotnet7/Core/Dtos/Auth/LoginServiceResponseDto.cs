namespace backend_dotnet7.Core.Dtos.Auth
{
    public class LoginServiceResponseDto
    {
        public string NewToken { get; set; }

        //this would be returned to frontend

        public UserInfoResult UserInfo { get; set; }
    }
}
