
using System.Collections.Specialized;

namespace RcSpeedStatistics
{
    public class ModelInMemory : ModelBase
    {
        public event SpeedAddedDelegate SpeedAdded;
       
        public ModelInMemory(string modelName, string modelType)
            : base (modelName, modelType)
        {            
        }

        List<float> speeds = new List<float>();

        public override void AddSpeedValue(float speedValue)
        {
            if (speedValue >= 10 && speedValue <=70) 
            {
                speeds.Add(speedValue);
                if(SpeedAdded != null)
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
            if (float.TryParse(speedValue, out float value))
            {
                this.AddSpeedValue(value);
            }
            else if (char.TryParse(speedValue, out char letter))
            {
                this.AddSpeedValue(letter);
            }
            else 
            {
                throw new Exception("Invalid string Value");
            }                                                  
        }

        public override void AddSpeedValue(char speedValue)
        {
            switch(speedValue)
            {
                case 'A':
                case 'a':
                    speeds.Add(70);
                    break;
                case 'B':
                case 'b':
                    speeds.Add(60);
                    break;
                case 'C':
                case 'c':
                    speeds.Add(50);
                    break;
                case 'D':
                case 'd':
                    speeds.Add(40);
                    break;
                case 'E':
                case 'e':
                    speeds.Add(30);
                    break;
                case 'F':
                case 'f':
                    speeds.Add(20);
                    break;
                case 'G':
                case 'g':
                    speeds.Add(10);
                    break;
                case 'Q':
                case 'q':
                    break;
                default:
                    throw new Exception("Invalid letter");
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
