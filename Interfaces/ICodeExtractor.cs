using Microsoft.CodeAnalysis;

namespace TestGenAPI.Interfaces;

public interface ICodeExtractor
{
    Task<String> ExtractCode(string code);
}
