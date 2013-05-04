namespace T4Factories.Models
{
    using System;
    using T4Factories.Contracts;
	using T4Factories.Models;

	[System.CodeDom.Compiler.GeneratedCode("T4Factories", "0.1")]
    public class FooFactory : IFooFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Foo"/> class. The object creation timestamp defaults to <see cref="DateTime.Now"/>.
        /// </summary>
        /// <param name="bar">
        /// The service responsible for ...
        /// </param>
        public IFoo Create(T4Factories.Contracts.IBar bar)
        {
        	return new Foo(bar);
        }
	}
}
