namespace T4Factories.Models
{
    using System;
    using T4Factories.Contracts;

	[System.CodeDom.Compiler.GeneratedCode("T4Factories", "0.1")]
    public class FooFactory : T4Factories.Contracts.IFooFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Foo"/> class. The object creation timestamp defaults to <see cref="DateTime.Now"/>.
        /// </summary>
        /// <param name="bar">
        /// The service responsible for ...
        /// </param>
        public T4Factories.Contracts.IFoo Create(T4Factories.Contracts.IBar bar)
        {
        	return new T4Factories.Models.Foo(bar);
        }
	}
}
