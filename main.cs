using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter the wind speed in mph: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int windspeed))
                {
                string category = GetProgram(windspeed);
                Console.WriteLine(category);
                }
                else
                {
                Console.WriteLine("Invalid input. Enter a valid number for wind speed.");
                }
            static string GetProgram(int windspeed)
            {
                if (windspeed >= 157)
                {
                return "Category Five Hurricane";
                }
              else if (windspeed >= 130)
                {
                return "Category Four Hurricane";
                }
              else if (windspeed >= 111)
                {
                return "Category Three Hurricane";
                }
              else if (windspeed >= 96)
                {
                return "Category Two Hurricane";
                }
              else if (windspeed >= 74)
                {
                return "Category One Hurricane";
                }
                else
                {
                return "Not a Hurricane";
                }
            }
  }
}
        
