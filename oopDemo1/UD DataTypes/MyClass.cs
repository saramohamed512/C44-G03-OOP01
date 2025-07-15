using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopDemo1.UD_DataTypes
{
    internal class MyClass
    {
        //1.Attribute
        public int Attribute;

        //2.Function
        public void Fun01() {
            Console.WriteLine(Attribute);
        } 

        //3.Property
        public int MyProperty { get; set; }

        //4.Event
    }
}
