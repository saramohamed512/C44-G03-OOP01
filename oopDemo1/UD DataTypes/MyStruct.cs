using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopDemo1.UD_DataTypes
{
    internal struct MyStruct
    {
        //1.Attribute
        private int Attribute;

        //2.Function
        internal void Fun01()
        {
            Console.WriteLine(Attribute);
        }

        //3.Property
        public int MyProperty { get; set; }

        //4.Event
    }
}
