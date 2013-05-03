namespace T4Factories.Models
{
	using T4Factories.Contracts;

	[System.CodeDom.Compiler.GeneratedCode("T4Factories", "0.1")]
    public class Class1Factory : IClass1Factory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Class1"/> class.
        /// </summary>
        /// <param name="param1">
        /// The param 1.
        /// </param>
        public IClass1 Create(int param1)
        {
        	return new Class1(param1);
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Class1"/> class.
        /// </summary>
        /// <param name="param1">
        /// The param 1.
        /// </param>
        /// <param name="now">
        /// The now.
        /// </param>
        public IClass1 Create(int param1, System.DateTime now)
        {
        	return new Class1(param1, now);
        }
	}
}
