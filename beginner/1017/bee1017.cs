using System; 

class URI {

    static void Main(string[] args) 
    { 
        string input = Console.ReadLine();
        string input2 = Console.ReadLine();
        int spentTime = int.Parse(input);
        int averageSpeed = int.Parse(input2);

        double distance = spentTime * averageSpeed;

        double liters = distance / 12;

        Console.WriteLine($"{liters.ToString("F3")}");
    }


}