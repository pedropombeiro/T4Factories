T4Factories
===========
T4 Factories uses T4toolbox to automatically generate the source code for [factory implementations](http://en.wikipedia.org/wiki/Factory_method_pattern) and even contracts (if they don't exist already), based on a concrete class and a base interface.

It allows easier use of the factory pattern for easier unit testing and refactoring.

Given a class like the following `Foo<T>` class:

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

We can decorate `Foo<T>` with the `[GenerateT4Factory]` attribute to let T4Factories know that we want it to generate a factory from the class. By running the T4 Generator, we get the `IFooFactory` interface and `FooFactory` implementation for free:

    /// <summary>
    /// The contract for the factory generating <see cref="T4Factories.Testbed.Contracts.IFoo{T}" /> instances.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("T4Factories", "0.1")]
    public partial interface IFooFactory<T>
    {
        #region Factory Methods
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Foo{T}"/> class. 
        /// The object creation timestamp defaults to <see cref="DateTime.Now"/>.
        /// </summary>
        /// <param name="bar">
        /// The service responsible for ...
        /// </param>
        T4Factories.Testbed.Contracts.IFoo<T> Create(T bar);
        
        #endregion
    }

----------

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

----------
If the base interface for the class we're decorating happens to be named differently (maybe you have a `Dog` class derived from an `IPet` interface), T4Factories can still handle that scenario if you add the type of the interface as an argument to the decorator attribute, like this: `[GenerateT4Factory(typeof(IPet))]`. This will generate an `IPetFactory` interface which returns instances of `Dog`.

----------
# Advanced Use #
## Dependency Injection ##

T4Factories plays well with classes which receive a mix of arguments which are injected by an IoC container and by the factory method. In this case, you start by defining the factory interface with the arguments which will be passed by the factory user. Any arguments which are taken by the constructor but not passed in the factory method will get injected in the factory constructor:

**TODO**