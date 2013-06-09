// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Foo.cs" company="Developer In The Flow">
//   © 2012-2013 Pedro Pombeiro
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace T4Factories.Testbed.Models
{
    using System;

    using T4Factories.Testbed.Contracts;

    [GenerateT4Factory]
    public class Foo<T> : IFoo<T>
    {
        #region Fields

        private readonly T bar;

        private readonly DateTime dateTime;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Foo{T}"/> class.
        /// The object creation timestamp defaults to <see cref="DateTime.Now"/>.
        /// </summary>
        /// <param name="bar">
        /// The service responsible for ...
        /// </param>
        public Foo(T bar)
            : this(bar, DateTime.Now)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Foo{T}"/> class.
        /// </summary>
        /// <param name="bar">
        /// The service responsible for ...
        /// </param>
        /// <param name="dateTime">
        /// The object creation timestamp.
        /// </param>
        private Foo(T bar, 
                    DateTime dateTime)
        {
            this.bar = bar;
            this.dateTime = dateTime;
        }

        #endregion
    }
}