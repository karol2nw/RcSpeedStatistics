using RcSpeedStatistics;

Console.WriteLine($"Program służacy do wyliczania statystyk lotów modeli RC ");
Console.WriteLine("========================================================");
Console.WriteLine("Aby zakończyć działanie programu, wciśnij 'q'");
var model = new ModelInMemory("Extra300","Acro");
string input;



while (true)
{
    Console.WriteLine("Wprowadź prędkość modelu");
    input = Console.ReadLine();
    model.AddSpeedValue(input);
   
   
    if (input == "q")
    {
        break;
    }
   
}

model.ShowSpeedlist();
