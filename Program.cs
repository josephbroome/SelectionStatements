// See https://aka.ms/new-console-template for more information
class program
{

    static void Main(String[] args)
    {

        Console.WriteLine("What is your favorite subject?");

        var subject = Console.ReadLine();


      
        switch (subject)
        {
            case "History":
                Console.WriteLine("What a coincidence my favorite subject is History, to bad we are doomed to repeat it");
                break;
            case "Math":
                Console.WriteLine("Math is a very difficult subject, I dont like it even though I am a computer");
                break;
            case "Science":
                Console.WriteLine("Science is fun!, I like to preform Science experiments on Humans");
                break;
            case "Chemistry":
                Console.WriteLine("Chemistry! lets make a volcano!");
                break;
            case "Art":
                Console.WriteLine("I never understood Art, everything to me just looks like a bunch of ones and zeros");
                break;
            default: Console.WriteLine($"Thats neat, I have never taken that subject before, {subject} sounds interesting!");
                break;


        }





    }
}