using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopDemo1
{
    [Flags]
    enum Permission :byte
    {
        Delete = 1, // 00000001
        Execute = 2, // 00000010
        Read = 4, // 00000100
        Write = 8, // 00001000
        Select = 16, // 00010000

    }
}
