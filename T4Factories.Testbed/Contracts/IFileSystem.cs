// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IFileSystem.cs" company="Developer in the Flow">
// //   © 2013 Pedro Pombeiro. All rights reserved.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------
namespace T4Factories.Testbed.Contracts
{
    using System.IO;

    public interface IFileSystem
    {
        File GetFile(string filePath);
    }
}