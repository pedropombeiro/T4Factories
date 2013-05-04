using System;
using T4Factories.Contracts;

namespace T4Factories.Models
{
    [GenerateT4FactoryWithContract]
    public class Foo : IFoo
    {
        private readonly IBar bar;
        private readonly DateTime dateTime;

        /// <summary>
        /// Initializes a new instance of the <see cref="Foo"/> class. The object creation timestamp defaults to <see cref="DateTime.Now"/>.
        /// </summary>
        /// <param name="bar">
        /// The service responsible for ...
        /// </param>
        public Foo(IBar bar)
            : this(bar, DateTime.Now)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Foo"/> class.
        /// </summary>
        /// <param name="bar">
        /// The service responsible for ...
        /// </param>
        /// <param name="dateTime">
        /// The object creation timestamp.
        /// </param>
        private Foo(IBar bar, DateTime dateTime)
        {
            this.bar = bar;
            this.dateTime = dateTime;
        }
    }
}
