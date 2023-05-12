

namespace RcSpeedStatistics
{
    public abstract class ModelBase : IModel
    {
        public  delegate void SpeedAddedDelegate (object sender, EventArgs args);
        public event SpeedAddedDelegate SpeedAdded;
        public string ModelName { get; private set; }
        public string ModelType { get; private set; }
        public ModelBase(string modelName, string modelType)
        {
            this.ModelName = modelName;
            this.ModelType = modelType;
        }

        public abstract void AddSpeedValue(float speedValue);
        public abstract void AddSpeedValue(string speedValue);       
        public abstract void AddSpeedValue(char speedValue);
        public abstract Statistics GetStatistics();
        public abstract void ShowSpeedList();
    }
}
