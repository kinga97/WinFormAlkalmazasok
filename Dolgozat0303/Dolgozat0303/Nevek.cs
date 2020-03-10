using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat0303
{
    class Nevek
    {
        public string Tanulo { get; set; }
        public string Igazolt { get; set; }
        public string Igazolatlan { get; set; }

        public Nevek(string tan, string igaz, string igazlan)
        {
            this.Tanulo = tan;
            this.Igazolt = igaz;
            this.Igazolatlan = igazlan;
        }
    }
}
