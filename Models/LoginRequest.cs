namespace Authentication_Implement_DotNet.Models
{
    public class LoginRequest
    {
        public string UserId { get; set; }   // ✅ MUST match exactly
        public string Password { get; set; }
    }
}
