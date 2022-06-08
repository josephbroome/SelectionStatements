// See https://aka.ms/new-console-template for more information
class program
{

    static void Main(String[] args)
    {
       

        var favoriteNumber = 200;

        var userGuess = int.Parse(Console.ReadLine());

        if (userGuess < favoriteNumber)
        {
            Console.WriteLine("too low");
        }

        else if (userGuess > favoriteNumber)
        {
            Console.WriteLine("too high");
        }

        else 
        {
            Console.WriteLine("Thats correct!!");
        }
    }

}