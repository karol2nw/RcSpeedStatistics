
namespace RcSpeedStatistics.Tests
{
    public class ModelInMemoryStatisticTest
    {

        [Test]
        public void SumTest()
        {
            var model = new ModelInMemory("model", "testowy");
            model.AddSpeedValue(43);
            model.AddSpeedValue("36");
            model.AddSpeedValue('f');

            var result = model.GetStatistics();

            Assert.AreEqual(99, result.sum);
        }

        [Test]
        public void MaxValueTest()
        {
            var model = new ModelInMemory("model", "testowy");
            model.AddSpeedValue(43);
            model.AddSpeedValue("36");
            model.AddSpeedValue('f');

            var result = model.GetStatistics();

            Assert.AreEqual(43, result.MaxSpeedValue);
        }

        [Test]
        public void MinValueTest()
        {
            var model = new ModelInMemory("model", "testowy");
            model.AddSpeedValue(43);
            model.AddSpeedValue("36");
            model.AddSpeedValue('f');

            var result = model.GetStatistics();

            Assert.AreEqual(20, result.MinSpeedValue);
        }

        [Test]
        public void AverageTest()
        {
            var model = new ModelInMemory("model", "testowy");
            model.AddSpeedValue(43);
            model.AddSpeedValue("36");
            model.AddSpeedValue('f');

            var result = model.GetStatistics();

            Assert.AreEqual(33, result.AverageSpeedValue);
        }

        [Test]
        public void SpeedCategoryTest()
        {
            var model = new ModelInMemory("model", "testowy");
            model.AddSpeedValue(43);
            model.AddSpeedValue("36");
            model.AddSpeedValue('f');

            var result = model.GetStatistics();

            Assert.AreEqual("Third speed category", result.ModelSpeedCategory);
        }
    }
}