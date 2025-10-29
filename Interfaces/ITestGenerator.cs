using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;

namespace TestGenAPI;

public interface ITestGenerator
{
    void GenTests(byte[] file);
}   
