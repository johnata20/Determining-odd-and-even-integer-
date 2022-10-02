int inp;

Console.Write("Enter an integer : ");
inp = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (inp > 0 && inp % 2 == 0)
    Console.WriteLine("The input is a positive even number.");

if (inp > 0 && inp % 2 != 0)
    Console.WriteLine("The input is a positive odd number.");

if (inp < 0 && inp % 2 == 0)
    Console.WriteLine("The input is a negative even number.");

if (inp < 0 && inp % 2 != 0)
    Console.WriteLine("The input is a negative odd number.");

if (inp == 0)
    Console.WriteLine("The input is zero.");

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

