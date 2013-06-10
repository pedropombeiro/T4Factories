// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CsvFileParser.cs" company="Developer In The Flow">
//   © 2012-2013 Pedro Pombeiro
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace T4Factories.Testbed.Models
{
    using T4Factories.Testbed.Contracts;

    [GenerateT4Factory(typeof(IFileParser))]
    public class CsvFileParser : IFileParser
    {
        #region Fields

        private readonly string delimiter;

        private readonly IFileSystem fileSystem;

        #endregion

        #region Constructors and Destructors

        public CsvFileParser(IFileSystem fileSystem, 
                             string delimiter)
        {
            this.fileSystem = fileSystem;
            this.delimiter = delimiter;
        }

        #endregion

        #region Public Methods and Operators

        public string[] Parse(string filePath)
        {
            object file = this.fileSystem.GetFile(filePath);
            return new string[0];
        }

        #endregion
    }
}