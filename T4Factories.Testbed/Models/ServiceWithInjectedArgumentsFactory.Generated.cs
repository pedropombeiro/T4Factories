namespace T4Factories.Testbed.Models
{
    using T4Factories.Testbed.Contracts;
    
    /// <summary>
    /// The implementation for the factory generating <see cref="T4Factories.Testbed.Models.ServiceWithInjectedArguments" /> instances.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("T4Factories", "0.1")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public partial class ServiceWithInjectedArgumentsFactory : T4Factories.Testbed.Contracts.IServiceWithInjectedArgumentsFactory
    {
        #region Fields
        
        private T4Factories.Testbed.Contracts.IFoo<System.Int32> foo;
        
        #endregion
        
        #region Constructors
        
        public ServiceWithInjectedArgumentsFactory(T4Factories.Testbed.Contracts.IFoo<System.Int32> foo)
        {
            this.foo = foo;
        }
        
        #endregion
        
        #region Public Factory Methods
        
        public T4Factories.Testbed.Contracts.IService Create(System.Int32 value1)
        {
            return new T4Factories.Testbed.Models.ServiceWithInjectedArguments(value1);
        }
        
        public T4Factories.Testbed.Contracts.IService Create(
            System.Int32 value1, 
            System.String value2)
        {
            return new T4Factories.Testbed.Models.ServiceWithInjectedArguments(
                this.foo, 
                value1, 
                value2);
        }
        
        #endregion
    }
}
