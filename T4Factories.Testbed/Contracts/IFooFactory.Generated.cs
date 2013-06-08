namespace T4Factories.Testbed.Contracts
{
    using System;
    using T4Factories.Testbed.Models;

    [global::System.CodeDom.Compiler.GeneratedCode("T4Factories", "0.1")]
    public partial interface IFooFactory<T>
    {
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Foo{T}"/> class. The object creation timestamp defaults to <see cref="DateTime.Now"/>.
        /// </summary>
        /// <param name="bar">
        /// The service responsible for ...
        /// </param>
        T4Factories.Testbed.Contracts.IFoo<T> Create(T bar);
    }
}
