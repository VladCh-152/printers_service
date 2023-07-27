using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace PrintersBackend.Options
{
    public class AuthOptions
    {
        public const string ISSUER = "PrintersFrontend";
        public const string AUDIENCE = "PrintersBackend";
        const string KEY = "ProjectPrinters_key_for_encrypting";
        public const int LIFETIME = 1;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
