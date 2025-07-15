using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopDemo1.UD_DataTypes
{
    internal class ClassInterface : IMyInterface
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Print()
        {
            Console.WriteLine("Hello World");
        }
    }
}
