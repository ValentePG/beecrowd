using System; 

class URI {

    static void Main(string[] args) 
    { 
        
        string input = Console.ReadLine();
        int number = int.Parse(input);
        int[] values = {100, 50, 20, 10, 5, 2, 1};
        int[] notes = new int[values.Length];

        Console.WriteLine($"{number}");

        while (number > 0)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (number >= values[i])
                {
                    number -= values[i];
                    notes[i]++;
                    break;
                };
            };
            
            
        };


        for (int i = 0; i < values.Length; i++)
        {
            Console.WriteLine($"{notes[i]} nota(s) de R$ {values[i]},00");
        };
        
    }

};