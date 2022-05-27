using SKGL;

namespace SerialKey_test_preview
{
    internal class Validate
    {
        SKGL.Validate val = new SKGL.Validate();

        internal Validate(string password, string serialKey)
        {
            val.secretPhase = password;
            val.Key = serialKey;
        }

        internal string val_creation()
        {
            return val.CreationDate.ToString();
        }

        internal string val_expiration()
        {
            return val.ExpireDate.ToString();
        }

        internal bool val_isValid()
        {
            return val.IsValid;
        }

        internal bool val_isExpired()
        {
            return val.IsExpired;
        }

        internal string val_daysleft()
        {
            return val.DaysLeft.ToString();
        }
    }
}
