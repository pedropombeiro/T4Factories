using System;

namespace T4Factories
{
    public class GenerateT4FactoryWithContractAttribute : Attribute
    {
        public Type ContractType { get; private set; }

        public GenerateT4FactoryWithContractAttribute()
        {
        }

        public GenerateT4FactoryWithContractAttribute(Type contractType)
        {
            ContractType = contractType;
        }
    }
}