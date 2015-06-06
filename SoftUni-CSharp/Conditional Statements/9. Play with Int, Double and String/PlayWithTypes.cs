using System;

class PlayWithTypes
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:" +
                          "\r\n1 --> int" +
                          "\r\n2 --> double" +
                          "\r\n3 --> string");

        int choise = int.Parse(Console.ReadLine());

        switch (choise)
        {
            case 1: 
                {
                    Console.Write("Please enter a int: ");
                    int output = int.Parse(Console.ReadLine());
                    Console.WriteLine(++output);
                    break;
                }
            case 2:
                {
                    Console.Write("Please enter a double: ");
                    double output = double.Parse(Console.ReadLine());
                    Console.WriteLine(++output);
                    break;
                }
            case 3:
                {
                    Console.Write("Please enter a string: ");
                    string output = Console.ReadLine();
                    Console.WriteLine(output + "*");
                    break;
                }
            default:
                break;
        }
    }
}