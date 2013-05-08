namespace T4Factories.Models
{
    using System;
    using T4Factories.Testbed.Contracts;

    [global::System.CodeDom.Compiler.GeneratedCode("T4Factories", "0.1")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public class FooFactory<T> : T4Factories.Testbed.Contracts.IFooFactory<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Foo{T}"/> class. The object creation timestamp defaults to <see cref="DateTime.Now"/>.
        /// </summary>
        /// <param name="bar">
        /// The service responsible for ...
        /// </param>
        public T4Factories.Testbed.Contracts.IFoo<T> Create(T bar)
        {
            return new T4Factories.Models.Foo<T>(bar);
        }
    }
}
