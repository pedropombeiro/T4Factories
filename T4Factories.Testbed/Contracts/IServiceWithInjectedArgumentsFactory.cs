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

        IService Create(int value1, string value2);

        #endregion
    }
}