namespace Assignment_5
{
    internal class Program
    {
        #region Q1
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        #endregion


        #region Q2
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        #endregion


        #region Q4
        enum Colors
        {
            Red,
            Green,
            Blue
        }
        #endregion




        static void Main()
        {


            #region Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            string[] days = Enum.GetNames(typeof(WeekDays));

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }


            #endregion


            #region Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");

            string Month = Console.ReadLine();

            bool isValid = Enum.TryParse(Month, true, out Season season);

            if (isValid)
            {

                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                }
            }

            #endregion

            
            #region Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            Console.Write("Enter a color name: ");
            string Color = Console.ReadLine();

            bool isPrimaryColor = Enum.TryParse(Color, true, out Colors color);

            if (isPrimaryColor)
            {
                Console.WriteLine($"{Color} is a primary color.");
            }
            else
            {
                Console.WriteLine($"{Color} is NOT a primary color.");
            }

            #endregion
        }
    }
}
