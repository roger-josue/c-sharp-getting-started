using c_sharp_getting_started;

internal class Program
{
    private static void Main(string[] args)
    {
        //Sedan s = new Sedan(60);
        //// Call SpeedUp() here
        //Console.WriteLine(s.Describe());

        //Truck t = new Truck(45, 500);
        //// Call SpeedUp() here
        //Console.WriteLine(t.Describe());

        //Bicycle b = new Bicycle(10);
        //// Call SpeedUp() here
        //Console.WriteLine(b.Describe());

        //Cipher.Encrypt();

        QuizApp.RunQuiz();
    }

    // static void Madlib()
    // {
    //     // Give the Mad Lib a title:
    //     string title = "That\'s odd";

    //     Console.WriteLine(title);
    //     // Define user input and variables:
    //     Console.WriteLine("Hi, sit tight, Mad Libs game starting now!");
    //     Console.WriteLine("Give me a name for the character and hit enter:");
    //     string name = Console.ReadLine();
    //     Console.WriteLine("Now, I want you to give me 3 different adjectives and hit enter every time you input each of them:");
    //     string firstAdjective = Console.ReadLine();
    //     string secondAdjective = Console.ReadLine();
    //     string thirdAdjective = Console.ReadLine();
    //     Console.WriteLine("What about a verb? Input one and hit enter:");
    //     string verb = Console.ReadLine();
    //     Console.WriteLine("Now, I want you to give me 2 different nouns and hit enter every time you input each of them:");
    //     string firstNoun = Console.ReadLine();
    //     string secondNoun = Console.ReadLine();
    //     Console.WriteLine("An animal:");
    //     string animal = Console.ReadLine();
    //     Console.WriteLine("A food:");
    //     string food = Console.ReadLine();
    //     Console.WriteLine("A fruit:");
    //     string fruit = Console.ReadLine();
    //     Console.WriteLine("A superhero:");

    //     string superhero = Console.ReadLine();
    //     Console.WriteLine("A country:");
    //     string country = Console.ReadLine();
    //     Console.WriteLine("A dessert:");
    //     string dessert = Console.ReadLine();
    //     Console.WriteLine("A year:");
    //     string year = Console.ReadLine();
    //     // The template for the story:

    //     string story = $"This morning {name} woke up feeling {firstAdjective}. 'It is going to be a {secondAdjective} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {thirdAdjective}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {secondNoun}s ruled the world.";
    // }

    static void Moneymaker()
    {
        Console.WriteLine("Welcome to Money Maker!");
        Console.WriteLine("Please, enter the amount of money you want to convert and hit enter:");
        double amountToConvert = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{amountToConvert} is equal to...");
        int goldCoin = 10;
        int silverCoin = 5;
        double goldCoins = Math.Floor(amountToConvert / goldCoin);
        double remainder = amountToConvert % goldCoin;
        double silverCoins = Math.Floor(remainder / silverCoin);
        remainder = remainder % silverCoin;
        Console.WriteLine($@"Gold coins: {goldCoins}
Silver coins: {silverCoins}
Bronze coins: {remainder}");
    }
}