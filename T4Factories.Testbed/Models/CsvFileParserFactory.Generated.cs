namespace T4Factories.Testbed.Models
{
    using System.IO;
    using T4Factories.Testbed.Contracts;
    
    /// <summary>
    /// The implementation for the factory generating <see cref="T4Factories.Testbed.Models.CsvFileParser" /> instances.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("T4Factories", "0.1")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public partial class CsvFileParserFactory : T4Factories.Testbed.Contracts.ICsvFileParserFactory
    {
        #region Fields
        
        private T4Factories.Testbed.Contracts.IFileSystem fileSystem;
        
        #endregion
        
        #region Constructors
        
        public CsvFileParserFactory(T4Factories.Testbed.Contracts.IFileSystem fileSystem)
        {
            this.fileSystem = fileSystem;
        }
        
        #endregion
        
        #region Public Factory Methods
        
        public T4Factories.Testbed.Contracts.IFileParser Create(System.String delimiter)
        {        
            return new T4Factories.Testbed.Models.CsvFileParser(
                this.fileSystem, 
                delimiter);
        }
        
        #endregion
    }
}
