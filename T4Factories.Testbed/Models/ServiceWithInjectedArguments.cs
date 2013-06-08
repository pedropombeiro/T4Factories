// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceWithInjectedArguments.cs" company="Developer In The Flow">
//   © 2012-2013 Pedro Pombeiro
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace T4Factories.Testbed.Models
{
    using T4Factories.Testbed.Contracts;

    /// <summary>
    /// Demonstrates a service with injected arguments which do not appear in the factory method.
    /// </summary>
    [T4Factories.GenerateT4Factory(typeof(IService))]
    public class ServiceWithInjectedArguments : IService
    {
        #region Fields

        /// <summary>
        /// The injected service.
        /// </summary>
        private readonly IFoo<int> foo;

        /// <summary>
        /// The first factory parameter.
        /// </summary>
        private readonly int value1;

        /// <summary>
        /// The second factory parameter.
        /// </summary>
        private string value2;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceWithInjectedArguments" /> class.
        /// </summary>
        /// <param name="value1">The first factory parameter.</param>
        public ServiceWithInjectedArguments(int value1)
        {
            this.value1 = value1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceWithInjectedArguments" /> class.
        /// </summary>
        /// <param name="foo">The injected service.</param>
        /// <param name="value1">The first factory parameter.</param>
        /// <param name="value2">The second factory parameter.</param>
        public ServiceWithInjectedArguments(
            IFoo<int> foo, 
            int value1, 
            string value2)
        {
            this.foo = foo;
            this.value1 = value1;
            this.value2 = value2;
        }

        #endregion
    }
}