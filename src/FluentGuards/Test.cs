using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentGuards
{
    public class Test
    {
        public Test()
        {
            string s = "1";
            s.Must().NotBeNullOrWhiteSpace(nameof(s));
        }
    }
}
