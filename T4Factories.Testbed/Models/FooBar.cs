namespace T4Factories.Testbed.Models
{
    using T4Factories.Testbed.Contracts;

    [GenerateT4Factory]
    public class FooBar : IFooBar
    {
        public int A { get; set; }

        public int B { get; set; }

        public FooBar(int a, [InjectedInT4Factory]int b)
        {
            this.A = a;
            this.B = b;
        }
    }
}