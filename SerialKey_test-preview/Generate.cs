using SKGL;
using System.Text;
using System.Security.Cryptography;

namespace SerialKey_test_preview
{
    internal class Generate
    {
        SKGL.Generate gen = new SKGL.Generate();
        internal string generate_serialKey(string password, int day)
        {
            gen.secretPhase = password;
            return gen.doKey(day);
        }

        internal string generate_password(string ID, string password)
        {
            byte[] m = new ASCIIEncoding().GetBytes(ID);
            byte[] k = new ASCIIEncoding().GetBytes(password);

            HMACSHA1 h = new HMACSHA1(k);

            byte[] result = h.ComputeHash(m);

            return Convert.ToBase64String(result);
        }
    }
}
