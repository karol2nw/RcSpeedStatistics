using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RcSpeedStatistics.Tests
{
    public class ModelInFileStatisticTest
    {
        
        [Test]
        public void ModelInFileStatisticComplexTest()
        {
            var model = new ModelInFile("model", "test");
            model.AddSpeedValue(43);
            model.AddSpeedValue("36");
            model.AddSpeedValue('f');
            
            var result = model.GetStatistics();

            Assert.AreEqual(43, result.MaxSpeedValue);
            Assert.AreEqual(20, result.MinSpeedValue);
            Assert.AreEqual(33, result.AverageSpeedValue);
            Assert.AreEqual("Third speed category", result.ModelSpeedCategory);
        }


    }
}
