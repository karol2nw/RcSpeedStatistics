
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
        void ShowSpeedList();


    }
}
