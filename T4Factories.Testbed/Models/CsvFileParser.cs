// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CsvFileParser.cs" company="Developer In The Flow">
//   © 2012-2013 Pedro Pombeiro
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace T4Factories.Testbed.Models
{
    using System.IO;

    using T4Factories.Testbed.Contracts;

    [GenerateT4Factory(typeof(IFileParser))]
    public class CsvFileParser : IFileParser
    {
        #region Fields

        private readonly IFileSystem fileSystem;

        private readonly string delimiter;

        #endregion

        #region Constructors and Destructors

        public CsvFileParser(IFileSystem fileSystem, string delimiter)
        {
            this.fileSystem = fileSystem;
            this.delimiter = delimiter;
        }

        #endregion

        public string[] Parse(string filePath)
        {
            File file = this.fileSystem.GetFile(filePath);
        }
    }
}