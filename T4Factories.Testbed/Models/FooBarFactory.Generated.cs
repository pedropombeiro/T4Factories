namespace T4Factories.Testbed.Models
{
    using T4Factories.Testbed.Contracts;
    
    /// <summary>
    /// The implementation for the factory generating <see cref="T4Factories.Testbed.Models.FooBar" /> instances.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("T4Factories", "0.1")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public partial class FooBarFactory : T4Factories.Testbed.Contracts.IFooBarFactory
    {
        #region Fields
        
        private System.Int32 b;
        
        #endregion
        
        #region Constructors
        
        public FooBarFactory([InjectedInT4Factory] System.Int32 b)
        {
            this.b = b;
        }
        
        #endregion
        
        #region Public Factory Methods
        
        public T4Factories.Testbed.Contracts.IFooBar Create(System.Int32 a)
        {
            return new T4Factories.Testbed.Models.FooBar(
                a, 
                this.b);
        }
        
        #endregion
    }
}
