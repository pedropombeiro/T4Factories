namespace T4Factories.Testbed.Models
{
    [GenerateT4FactoryWithContract]
    public class ParameterlessClass : IParameterlessClass
    {
        public bool IsBusy { get; set; }
    }
}