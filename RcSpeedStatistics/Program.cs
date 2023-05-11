using RcSpeedStatistics;

Console.WriteLine($"This is application for counting Airplanes model speed statistics ");
Console.WriteLine("========================================================");
Console.WriteLine("You can add exact value or average value by letter A-G (70-10 kmph, every 10 kmph)");
Console.WriteLine("To quit data entry press : 'q'");
Console.WriteLine("If You quit data entry, You will show data statistics");

var model = new ModelInMemory("Extra300","Acro");
string input;

model.SpeedAdded += SpeedAdded;
void SpeedAdded(object sedner, EventArgs args)
{
    Console.WriteLine("New speed value was added");
}

while (true)
{
    Console.WriteLine("Input airplane model speed ");
    input = Console.ReadLine();
    model.AddSpeedValue(input);
   
   
    if (input == "q")
    {
        break;
    }
   
}

model.ShowSpeedlist();
