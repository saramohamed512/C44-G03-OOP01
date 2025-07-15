using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB
    {
       public TypeB() { 
            TypeA typeA = new TypeA();
            //typeA.x= 10; //  inaccessible due to its protection level
            typeA.y = 20;
            typeA.z = 30; 
        }
    }
}
