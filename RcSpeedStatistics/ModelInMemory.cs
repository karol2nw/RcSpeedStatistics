
namespace RcSpeedStatistics
{
    public class ModelInMemory : ModelBase
    {
        public event SpeedAddedDelegate SpeedAdded;

        public ModelInMemory(string modelName, string modelType)
            : base(modelName, modelType)
        {
        }

        List<float> speeds = new List<float>();

        public override void AddSpeedValue(float speedValue)
        {
            if (speedValue >= 10 && speedValue <= 70)
            {
                speeds.Add(speedValue);
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

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach (var speed in speeds)
            {
                statistics.AddSpeedValue(speed);
            }
            return statistics;
        }

        public override void ShowSpeedList()
        {
            Console.WriteLine($"You will see data for {ModelName}, {ModelType}");
            Console.WriteLine("Model speed list :");
            foreach (var speed in speeds)
            {
                Console.Write(speed + " ");
            }
            Console.WriteLine();
        }
    }
}
