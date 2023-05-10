

namespace RcSpeedStatistics
{
    public class ModelInFile : ModelBase
    {
        public ModelInFile(string modelName, string modelType)
            : base(modelName, modelType)
        {
        }
  


        public override void AddSpeedValue(float speedValue)
        {




        }

        public override void AddSpeedValue(string speedValue)
        {
            throw new NotImplementedException();
        }

        public override void AddSpeedValue(char speedValue)
        {
            throw new NotImplementedException();
        }

        public override void AddSpeedValue(decimal speedValue)
        {
            throw new NotImplementedException();
        }

       
        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }

    }
}
