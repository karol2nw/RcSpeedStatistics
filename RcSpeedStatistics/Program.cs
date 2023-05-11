using RcSpeedStatistics;
using System.Reflection;
using System.Runtime.CompilerServices;

Console.WriteLine($"This is application for counting Airplanes model speed statistics ");
Console.WriteLine("========================================================");
Console.WriteLine("You can add exact value or average value by letter A-G (70-10 kmph, every 10 kmph)");
Console.WriteLine("To quit data entry press : 'q'");
Console.WriteLine("If You quit data entry, You will show data statistics");
Console.WriteLine("========================================================");
Console.WriteLine("What do You want to do?");
Console.WriteLine("To run application with memory statistics, press '1'");
Console.WriteLine("To run application with speeds value saved to text file, press '2'");
//var model = new ModelInMemory("Extra300","Acro");
string input;
input = Console.ReadLine();

if( input == "1")
{
    AddModelInMemory();
}
if( input == "2")
{
    AddModelInFile();
}

//model.SpeedAdded += SpeedAdded;
void SpeedAdded(object sedner, EventArgs args)
{
    Console.WriteLine("New speed value was added");
}



 ModelInMemory AddModelInMemory()
 {
    Console.WriteLine("input model Name");
    string modelName = Console.ReadLine();
    Console.WriteLine("input model type");
    string modelType = Console.ReadLine();
    var  model = new ModelInMemory(modelName, modelType);

    return model;
 }

ModelInFile AddModelInFile()
{
    Console.WriteLine("input model Name");
    string modelName = Console.ReadLine();
    Console.WriteLine("input model type");
    string modelType = Console.ReadLine();
    var model = new ModelInFile(modelName, modelType);

    return model;
}

while (true)
{
    Console.WriteLine("Input airplane model speed ");
    input = Console.ReadLine();
    //model.AddSpeedValue(input);


    if (input == "q")
    {
        break;
    }

}