namespace T4Factories.Testbed.Models
{
    using T4Factories.Testbed.Contracts;

    [GenerateT4Factory]
    public class ParameterlessClass : IParameterlessClass
    {
        public bool IsBusy { get; set; }
    }
}