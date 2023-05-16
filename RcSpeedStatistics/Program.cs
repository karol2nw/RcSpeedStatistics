using RcSpeedStatistics;

Console.WriteLine($"This is application for counting Airplanes model speed statistics ");
Console.WriteLine("===================================================================");
Console.WriteLine("You can add exact value or average value by letter A-G (70-10 kmph, every 10 kmph)");
Console.WriteLine("To quit data entry press : 'q'");
Console.WriteLine("If You quit data entry, You will show data statistics");
Console.WriteLine("========================================================");
Console.WriteLine("What do You want to do?");
Console.WriteLine("To run application in memory mode, press '1'");
Console.WriteLine("To run application with speeds value saved to text file, press '2'");
string input = Console.ReadLine();

if (input == "1")
{
    AddModelInMemory();
}
if (input == "2")
{
    AddModelInFile();
}

void SpeedAdded(object sedner, EventArgs args)
{
    Console.WriteLine("New speed value was added");
}

void AddModelInMemory()
{
    Console.WriteLine("input model Name");
    string modelName = Console.ReadLine();

    Console.WriteLine("input model type");
    string modelType = Console.ReadLine();

    var model = new ModelInMemory(modelName, modelType);
    model.SpeedAdded += SpeedAdded;

    AddSpeed(model);

    var statistics = new Statistics();
    statistics = model.GetStatistics();

    model.ShowSpeedList();
    statistics.ShowStatistics();

    Console.ReadKey();
}

void AddModelInFile()
{
    Console.WriteLine("input model Name");
    string modelName = Console.ReadLine();

    Console.WriteLine("input model type");
    string modelType = Console.ReadLine();

    var model = new ModelInFile(modelName, modelType);
    model.SpeedAdded += SpeedAdded;

    AddSpeed(model);

    var statistics = new Statistics();
    statistics = model.GetStatistics();

    model.ShowSpeedList();
    statistics.ShowStatistics();

    Console.ReadKey();
}

void AddSpeed(IModel model)
{
    while (true)
    {
        Console.WriteLine();
        Console.WriteLine("Input airplane model speed");

        input = Console.ReadLine();
        try
        {
            model.AddSpeedValue(input);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        if (input == "q")
        {
            break;
        }
    }
}


