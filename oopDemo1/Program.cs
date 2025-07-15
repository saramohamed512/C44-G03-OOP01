using Common;
using System;
using System.Diagnostics.Metrics;
namespace oopDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ClassLibarary
            Product p1 = new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 99999,
                Description = "A high-performance laptop for gaming and work.",
                Count = 10

            };
            Console.WriteLine(p1);
            #endregion
            #region AccessModifier
            TypeA typeA = new TypeA();
            //typeA.x= 10; //  inaccessible due to its protection level
            // typeA.y = 20; //  inaccessible due to its protection level
            typeA.z = 30;
            #endregion
            #region User Defined Types
            #region class
            //What You Can Write Inside ?
            // 1. Attributes (Fields) => Member Variables
            // 2. Functions(CTOR, Setter Getter, Method)
            // 3. Properties(Full, Automatic, Indexer)
            // 4. Events

            //Access Modifier Allowed Inside ? 
            //1. All Access Modifiers Allowed
            //2. Private is Default

            //Default Access Modifier ?
            //Internal

            #endregion

            #region struct
            //What You Can Write Inside ?
            // 1. Attributes (Fields) => Member Variables
            // 2. Functions(CTOR, Setter Getter, Method)
            // 3. Properties(Full, Automatic, Indexer)
            // 4. Events

            //Access Modifier Allowed Inside ? 
            //Private is Default , internal , public 

            //Default Access Modifier ?
            //Internal
            #endregion

            #region interface
            //What You Can Write Inside ?
            //1.Signature For Property
            //2.Signature For Method
            //3.Default Implemented Method

            //Access Modifier Allowed Inside ? 
            //public is Default

            //Default Access Modifier ?
            //Internal
            #endregion

            #region enum
            //What You Can Write Inside ? 
            //Set of Names Constants[Labels]

            //Access Modifier Allowed Inside ?
            //No Access Modifier Allowed Inside Enum 

            //Default Access Modifier ?
            //Internal
            #region example01
            MyPerson person = new MyPerson();
            person.Id = 1;
            person.Name = "John Doe";
            person.Gender = Gender.Male;
            #endregion
            #region example02
            Grades grade= new Grades();
            grade= Grades.A;
            grade =(Grades)70;
            Console.WriteLine(grade);
            if (grade == Grades.A || grade == Grades.B)
                Console.WriteLine("Bravo");
            else
                Console.WriteLine("You need to study more");

            #endregion

            #region example03
            User user1 = new User();
            user1.Id = 1;
            user1.Permission = (Permission)2;
            //Console.WriteLine(user1.Permission);

            User user2 = new User();
            user2.Id = 2;
            user2.Permission = (Permission)3;
            user2.Permission = user2.Permission ^Permission.Read; //add Read Permission using XOR
            user2.Permission ^= Permission.Read; //delete Read Permission using XOR

            Console.WriteLine(user2.Permission);

            //Check if user2 has Execute Permission or not => & operator
            if ((user2.Permission & Permission.Execute) == Permission.Execute)
            {
                Console.WriteLine("User has Execute Permission");
            }
            else
            {
                Console.WriteLine("User does not have Execute Permission");
            }
            bool hasWritePermission = user2.Permission.HasFlag(Permission.Write);
            if (hasWritePermission)
            {
                Console.WriteLine("User has Write Permission");
            }
            else
            {
                Console.WriteLine("User does not have Write Permission");
            }
            user2.Permission |= Permission.Execute; //add Execute Permission using OR

            #endregion
            #endregion
            #endregion
        }
    }
}
