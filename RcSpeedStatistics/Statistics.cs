using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RcSpeedStatistics
{
    public class Statistics
    {
        public float MaxSpeedValue { get; private set; }
        public float MinSpeedValue { get; private set; }
        public float AverageSpeedValue
        {
            get
            {
                return sum / count;
            }
        }
        public string ModelSpeedCategory
        {
            get
            {
                switch (this.AverageSpeedValue)
                {
                    case var average when average >= 60:
                        return "First speed category";
                    case var average when average >= 40:
                        return "Second speed category";
                    case var average when average >= 20:
                        return "Third speed category";
                    default :
                        return "Fourth speed category";                    
                }
            }
        }                      
        private float sum;
        private int count;

        public Statistics()
        {
            MaxSpeedValue = float.MinValue;
            MinSpeedValue = float.MaxValue;
            sum = 0;
            count = 0;
        }

        public void AddSpeedValue(float speed)
        {
            sum += speed;
            count++;
            MaxSpeedValue = Math.Max(MaxSpeedValue, speed);
            MinSpeedValue = Math.Min(MinSpeedValue, speed);

        }
        public void ShowStatistics()
        {
            Console.WriteLine("Model speed statistics :");
            Console.WriteLine($"Min speed value : {MinSpeedValue}");
            Console.WriteLine($"Max speed value : {MaxSpeedValue} ");
            Console.WriteLine($"Average speed Value : {AverageSpeedValue}");
            Console.WriteLine($"Model category : {ModelSpeedCategory}");
        }
    
    
    }
}
