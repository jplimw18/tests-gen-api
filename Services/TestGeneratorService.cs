using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using TestGenAPI.Interfaces;

namespace TestGenAPI;

public class TestGeneratorService : ITestGenerator
{
    private readonly ICodeExtractor _analysis;
    private readonly IAiProvider _provider;


    public TestGeneratorService(ICodeExtractor analysis, IAiProvider provider)
    {
        _analysis = analysis;
        _provider = provider;
    }
    
    public async void GenTests(byte[] file)
    {
        string codeContext = await _analysis.ExtractCode(file);

        throw new NotImplementedException();  
    }
}
