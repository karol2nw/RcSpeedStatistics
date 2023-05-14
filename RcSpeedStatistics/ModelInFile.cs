

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
            fullFileName =$"{modelName}{fileName}";
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

        public override void AddSpeedValue(string speedValue)
        {
            if (float.TryParse(speedValue, out float result))
            {
                this.AddSpeedValue(result);
            }
            else if (char.TryParse(speedValue, out char letter))
            {
                this.AddSpeedValue(letter);
            }
        }

        public override void AddSpeedValue(char speedValue)
        {
            switch (speedValue)
            {
                case 'A':
                case 'a':
                    this.AddSpeedValue(70);
                    break;
                case 'B':
                case 'b':
                    this.AddSpeedValue(60);
                    break;
                case 'C':
                case 'c':
                    this.AddSpeedValue(50);
                    break;
                case 'D':
                case 'd':
                    this.AddSpeedValue(40);
                    break;
                case 'E':
                case 'e':
                    this.AddSpeedValue(30);
                    break;
                case 'F':
                case 'f':
                    this.AddSpeedValue(20);
                    break;
                case 'G':
                case 'g':
                    this.AddSpeedValue(10);
                    break;
                case 'Q':
                case 'q':
                    break;
                default:
                    throw new Exception("Invalid letter");
            }
        }        

       private List<float> ReadSpeeds()                                
       {
            var speeds = new List<float>();
            if(File.Exists(fullFileName))
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
            foreach(var speed in ReadSpeeds())
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
