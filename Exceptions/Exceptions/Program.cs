using System;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Pick a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dividing the two...");

            int num3 = num1 / num2;
            Console.WriteLine(num1 + " divided by" + num2 + " equals " + num3);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
        
        
    }
}

