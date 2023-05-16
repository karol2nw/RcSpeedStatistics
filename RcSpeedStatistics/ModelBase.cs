
namespace RcSpeedStatistics
{
    public abstract class ModelBase : IModel
    {
        public delegate void SpeedAddedDelegate(object sender, EventArgs args);
        public event SpeedAddedDelegate SpeedAdded;
        public string ModelName { get; private set; }
        public string ModelType { get; private set; }
        public ModelBase(string modelName, string modelType)
        {
            this.ModelName = modelName;
            this.ModelType = modelType;
        }

        public abstract void AddSpeedValue(float speedValue);
        public void AddSpeedValue(string speedValue)
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
        public void AddSpeedValue(char speedValue)
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
        public abstract Statistics GetStatistics();
        public abstract void ShowSpeedList();
    }
}
