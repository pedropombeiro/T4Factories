// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICsvFileParserFactory.cs" company="Developer In The Flow">
//   © 2012-2013 Pedro Pombeiro
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace T4Factories.Testbed.Contracts
{
    public interface ICsvFileParserFactory
    {
        #region Public Methods and Operators

        IFileParser Create(string delimiter);

        #endregion
    }
}