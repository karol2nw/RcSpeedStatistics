

namespace RcSpeedStatistics
{
    public abstract class ModelBase : IModel
    {
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

        public abstract void AddSpeedValue(decimal speedValue);

        public abstract Statistics GetStatistics();

    }
}
