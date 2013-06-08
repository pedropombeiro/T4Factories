// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IServiceWithInjectedArgumentsFactory.cs" company="Developer In The Flow">
//   © 2012-2013 Pedro Pombeiro
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace T4Factories.Testbed.Contracts
{
    public interface IServiceWithInjectedArgumentsFactory
    {
        #region Public Methods and Operators

        /// <summary>
        /// Creates a service instance with two parameters.
        /// </summary>
        /// <param name="value1">
        /// The first value.
        /// </param>
        /// <param name="value2">
        /// The second value.
        /// </param>
        /// <returns>
        /// A new <see cref="IService"/> instance.
        /// </returns>
        IService Create(
            int value1, 
            string value2);

        #endregion
    }
}