namespace T4Factories.Contracts
{
	using T4Factories.Models;

	[System.CodeDom.Compiler.GeneratedCode("T4Factories", "0.1")]
	public interface IClass1Factory
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="Class1"/> class.
        /// </summary>
        /// <param name="param1">
        /// The param 1.
        /// </param>
        IClass1 Create(int param1);
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Class1"/> class.
        /// </summary>
        /// <param name="param1">
        /// The param 1.
        /// </param>
        /// <param name="now">
        /// The now.
        /// </param>
        IClass1 Create(int param1, System.DateTime now);
	}
}
