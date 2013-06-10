// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FooBar.cs" company="Developer In The Flow">
//   © 2012-2013 Pedro Pombeiro
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace T4Factories.Testbed.Models
{
    using T4Factories.Testbed.Contracts;

    [GenerateT4Factory]
    public class FooBar : IFooBar
    {
        #region Constructors and Destructors

        public FooBar(
            int a, 
            [InjectedInT4Factory] int b)
        {
            this.A = a;
            this.B = b;
        }

        #endregion

        #region Public Properties

        public int A { get; set; }

        public int B { get; set; }

        #endregion
    }
}