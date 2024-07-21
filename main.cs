using System;

class Program
{
    public static void Main()
    {
        Console.Write("Enter wind speed in mph: ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());
        if (windSpeed >= 74)
        {
            string category = "";

            if (windSpeed >= 157)
            {
                category = "five";
            }
            else if (windSpeed >= 130)
            {
                category = "four";
            }
            else if (windSpeed >= 111)
            {
                category = "three";
            }
            else if (windSpeed >= 96)
            {
                category = "two";
            }
            else
            {
                category = "one";
            }
            Console.WriteLine("This is a category " + category + " hurricane");
        }
        else
        {
            Console.WriteLine("This is not a hurricane.");
        }
    }
}