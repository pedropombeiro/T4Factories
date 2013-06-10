namespace T4Factories.Testbed.Models
{
    using System;
    using T4Factories.Testbed.Contracts;

    [global::System.CodeDom.Compiler.GeneratedCode("T4Factories", "0.1")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public partial class FooBarFactory : T4Factories.Testbed.Contracts.IFooBarFactory
    {
        /// <remarks>
        /// TODO: output documentation
        /// </remarks>
        System.Int32 b;
        
        /// <remarks>
        /// TODO: output documentation
        /// </remarks>
        public FooBarFactory([InjectedInT4Factory] System.Int32 b)
        {
                this.b = b;    
        }
        
        
        public T4Factories.Testbed.Contracts.IFooBar Create(System.Int32 a)
        {
            return new T4Factories.Testbed.Models.FooBar(a, this.b);
        }
    }
}
