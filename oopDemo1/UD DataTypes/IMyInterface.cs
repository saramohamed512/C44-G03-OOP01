using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopDemo1.UD_DataTypes
{
    internal interface IMyInterface
    {
        //1.Signature For Property
        public int MyProperty { get; set; }
        //2.Signature For Method
        void Print();
        void Print01()
        {
            Console.WriteLine("Hello World From Interface");
        }

    }
}
