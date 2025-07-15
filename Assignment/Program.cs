namespace Assignment
{
    internal class Program
    {
        #region Problem 1:
        static void PrintWeekDays()
        {
            Console.WriteLine("Days of the week:");
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            Console.WriteLine();
        }
        #endregion
        #region Problem 2:


        static void DisplaySeasonMonths()
        {
            Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out Season season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("December to February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season name.");
            }
            Console.WriteLine();
        }
        #endregion

        #region Problem 3:
   

        static void WorkWithPermissions()
        {
            Console.WriteLine("Permission Management:");
            Permissions userPermissions = Permissions.None;

            // Add permissions
            userPermissions |= Permissions.Read;
            userPermissions |= Permissions.Write;

            Console.WriteLine($"Current permissions: {userPermissions}");

            // Check for a permission
            if (userPermissions.HasFlag(Permissions.Read))
            {
                Console.WriteLine("Read permission exists.");
            }

            // Remove a permission
            userPermissions ^= Permissions.Write;
            Console.WriteLine($"After removing Write: {userPermissions}");

            // Check if Execute permission exists
            if (!userPermissions.HasFlag(Permissions.Execute))
            {
                Console.WriteLine("Execute permission does not exist.");
            }
            Console.WriteLine();
        }
        #endregion
        #region Problem 4 :
   

        static void CheckPrimaryColor()
        {
            Console.WriteLine("Enter a color to check if it's primary (Red, Green, Blue):");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out Colors color))
            {
               
                    Console.WriteLine($"{color} is a primary color.");
               
            }
            else
            {
                Console.WriteLine("Is not a primary color.");
            }
            Console.WriteLine();
        }
        #endregion

        static void Main(string[] args)
        {

            //PrintWeekDays();
            //DisplaySeasonMonths();
            //WorkWithPermissions();
            CheckPrimaryColor();


        }
    }
}
