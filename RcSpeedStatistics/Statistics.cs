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



    }
}
