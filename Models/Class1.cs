using System;
using T4Factories.Contracts;

namespace T4Factories.Models
{
    public class Class1 : IClass1
    {
        private readonly int _param1;
        private readonly DateTime _now;

        /// <summary>
        /// Initializes a new instance of the <see cref="Class1"/> class.
        /// </summary>
        /// <param name="param1">
        /// The param 1.
        /// </param>
        public Class1(int param1)
        {
            _param1 = param1;
            _now = DateTime.Now;
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
        public Class1(int param1, DateTime now)
        {
            _param1 = param1;
            _now = now;
        }
    }
}
