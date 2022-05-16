using System;

namespace WelcomeToCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Miles();
            AllTheErrors();
        }

        public static void AllTheErrors()
        {
            int num = 13;
            int denom = 1;
            int result;
            int[] numbers = { 22, 33, 44 };

            try
            {
                result = num / denom;
                result = numbers[5];
                Console.WriteLine(result);
            }
            catch( DivideByZeroException e )
            {
                Console.WriteLine("You divided by zero!");
            }
            catch(Exception e)
            {
                Console.WriteLine("Index out of range!");
            }
            finally
            {
                Console.WriteLine("You are done!");
            }
        }

        public static void Miles()
        {
            int milesDriven, gallonsOfGas, mpg;

            try
            {
                Console.WriteLine("Enter the miles driven");
                milesDriven = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter how many gallons of gas you used?");
                gallonsOfGas = Convert.ToInt32(Console.ReadLine());

                mpg = milesDriven / gallonsOfGas;

                Console.WriteLine($"You drove {milesDriven} and used {gallonsOfGas} gallons of gas. Your MPG is {mpg}!");
            }
            catch( Exception e )
            {
                mpg = 0;
                Console.WriteLine("Incorrect input value");
                Miles();
            }
        }
    }
}
