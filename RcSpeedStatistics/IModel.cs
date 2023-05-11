using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RcSpeedStatistics
{
    internal interface IModel
    {
        string ModelName { get; }
        string ModelType { get; }

        void AddSpeedValue(float speedValue);
        void AddSpeedValue(string speedValue);
        void AddSpeedValue(char speedValue);
        Statistics GetStatistics();


    }
}
