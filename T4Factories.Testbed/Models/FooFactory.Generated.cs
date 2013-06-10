namespace T4Factories.Testbed.Models
{
    using System;
    using T4Factories.Testbed.Contracts;
    
    /// <summary>
    /// The implementation for the factory generating <see cref="T4Factories.Testbed.Models.Foo{T}" /> instances.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("T4Factories", "0.1")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public partial class FooFactory<T> : T4Factories.Testbed.Contracts.IFooFactory<T>
    {
        #region Public Factory Methods
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Foo{T}"/> class.
        /// The object creation timestamp defaults to <see cref="DateTime.Now"/>.
        /// </summary>
        /// <param name="bar">
        /// The service responsible for ...
        /// </param>
        public T4Factories.Testbed.Contracts.IFoo<T> Create(T bar)
        {
            return new T4Factories.Testbed.Models.Foo<T>(bar);
        }
        
        #endregion
    }
}
