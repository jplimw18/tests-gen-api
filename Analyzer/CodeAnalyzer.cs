using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using TestGenAPI.Interfaces;

namespace TestGenAPI;

public class CodeAnalyzer : ICodeExtractor
{
    public async Task<string> ExtractCode(byte[] file)
    {
        throw new NotImplementedException();
    }
}