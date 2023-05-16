
namespace RcSpeedStatistics
{
    public class ModelInFile : ModelBase
    {
        public event SpeedAddedDelegate SpeedAdded;

        private const string fileName = "_Speed.txt";
        private string fullFileName;

        public ModelInFile(string modelName, string modelType)
            : base(modelName, modelType)
        {
            fullFileName = $"{modelName}{fileName}";
        }

        public override void AddSpeedValue(float speedValue)
        {
            if (speedValue >= 10 && speedValue <= 70)
            {
                using (var writer = File.AppendText(fullFileName))
                {
                    writer.WriteLine(speedValue);
                }
                if (SpeedAdded != null)
                {
                    SpeedAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid speed value");
            }
        }

        private List<float> ReadSpeeds()
        {
            var speeds = new List<float>();
            if (File.Exists(fullFileName))
            {
                using (var reader = File.OpenText(fullFileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var value = float.Parse(line);
                        speeds.Add(value);
                        line = reader.ReadLine();
                    }
                }
            }
            return speeds;
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach (var speed in ReadSpeeds())
            {
                statistics.AddSpeedValue(speed);
            }
            return statistics;
        }
        public override void ShowSpeedList()
        {
            Console.WriteLine($"You will see data for {ModelName}, {ModelType}");
            Console.WriteLine("Model speed list :");
            foreach (var speed in ReadSpeeds())
            {
                Console.Write(speed + " ");
            }
            Console.WriteLine();
        }
    }
}
