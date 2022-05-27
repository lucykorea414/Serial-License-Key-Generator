using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKGL;

namespace SerialKey_test_preview
{
    internal class Generate
    {
        internal string generate_serialKey(string password, int day)
        {
            SKGL.Generate gen = new SKGL.Generate();
            gen.secretPhase = password;
            return gen.doKey(day);
        }
    }
}
