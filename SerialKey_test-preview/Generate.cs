using SKGL;

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
    }
}
